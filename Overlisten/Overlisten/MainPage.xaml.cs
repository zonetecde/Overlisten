using Newtonsoft.Json;
using Overlisten.Controls;
using Overlisten.Extension;
using OverlistenClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Overlisten
{
    public partial class MainPage : Page
    {
        internal static MainPage _MainPage;
        internal static Random Random { get; set; } = new Random();

        internal Data OverwatchData;

        public MainPage()
        {
            this.InitializeComponent();

            _MainPage = this;
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                string json = await client.GetStringAsync(Config.JsonData);
                OverwatchData = JsonConvert.DeserializeObject<Data>(json);

                // Ajoute la carte de tout les héros
                foreach (var hero in OverwatchData.Heroes)
                {
                    Controls.CharacterCard heroCard = new Controls.CharacterCard(hero, NavigateToCharacterPage);
                    WrapPanel_Heros.Children.Add(heroCard);
                }
                foreach (var npc in OverwatchData.Npcs)
                {
                    Controls.CharacterCard heroCard = new Controls.CharacterCard(npc, NavigateToCharacterPage);
                    WrapPanel_Others.Children.Add(heroCard);
                }

                Animation.HideAnimation(Grid_Loading, Grid_main);
            }
        }

        private void NavigateToCharacterPage(object character)
        {
            this.Cursor = Cursors.Wait;

            TextBlock_characterPageTitle.Text = "Overlistening to ";

            StackPanel_Categories.Children.Clear();
            StackPanel_Conversations.Children.Clear();
            StackPanel_Sounds.Children.Clear();

            Animation.HideAnimation(Grid_main, Grid_CharacterPage);

            if (character is Hero)
            {
                var hero = ((Hero)character);

                CharacterCard_Character.SetHero(hero);
                TextBlock_characterPageTitle.Text += OverlistenGlob.FormatHeroName(hero.Name);

                Grid_Hero.Visibility = Visibility.Visible;
                Grid_Npc.Visibility = Visibility.Collapsed;

                StackPanel_Categories.Visibility = Visibility.Visible;
                StackPanel_Conversations.Visibility = Visibility.Visible;

                // Affiche les catégories
                foreach (Category cat in hero.Categories)
                {

                    CategoryControl categoryControl = new CategoryControl(cat);

                    Dispatcher.InvokeAsync(() =>
                    {
                        StackPanel_Categories.Children.Add(categoryControl);
                    });
                }

                StackPanel_HeaderCategories.Visibility = hero.Categories.Any() ?
                    Visibility.Visible : Visibility.Collapsed;

                // Affiche les convs
                foreach (Conversation conv in hero.Conversations)
                {

                    CategoryControl categoryControl = new CategoryControl(conv);

                    Dispatcher.InvokeAsync(() =>
                    {
                        StackPanel_Conversations.Children.Add(categoryControl);
                    });
                }

                StackPanel_Conversations.Visibility = hero.Conversations.Any() ?
                    Visibility.Visible : Visibility.Collapsed;
            }
            else
            {
                Grid_Hero.Visibility = Visibility.Collapsed;
                Grid_Npc.Visibility = Visibility.Visible;

                Npc npc = ((Npc)character);

                CharacterCard_Character.SetNpc(npc);
                TextBlock_characterPageTitle.Text += npc.Name;

                // Affiche les sons du NPC
                Grid_CharacterPage.Tag = String.Join(",", npc.Sounds.ConvertAll(x => x.Path));

                foreach (Sound sound in npc.Sounds)
                {

                    SoundControl conversationControl = new SoundControl(sound);

                    Dispatcher.InvokeAsync(() =>
                    {
                        if (Grid_CharacterPage.Tag.ToString().Contains(sound.Path))
                            StackPanel_Sounds.Children.Add(conversationControl);
                    });
                }
            }

            this.Cursor = Cursors.Arrow;
        }

        private void Image_ToggleCategories_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel_Categories.Visibility = StackPanel_Categories.Visibility == Visibility.Visible ?
                Visibility.Collapsed : Visibility.Visible;

            (sender as Image).Source = StackPanel_Categories.Visibility == Visibility.Visible
                ? Img_dropDownOpen.Source : Img_dropDownClosed.Source;
        }

        private void Image_ToggleConversations_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel_Conversations.Visibility = StackPanel_Conversations.Visibility == Visibility.Visible ?
                Visibility.Collapsed : Visibility.Visible;

            (sender as Image).Source = StackPanel_Conversations.Visibility == Visibility.Visible
                ? Img_dropDownOpen.Source : Img_dropDownClosed.Source;
        }

        private void Image_PreviousPage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Grid_CharacterPage.Tag = string.Empty;
            Animation.HideAnimation(Grid_CharacterPage, Grid_main);
        }

        private void TextBox_SearchCharacter_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(((TextBox)sender).Text))
            {
                WrapPanel_Heros.Children.Where(x => x is CharacterCard)
                    .ToList().ForEach(x => x.Visibility = Visibility.Visible);

                WrapPanel_Others.Children.Where(x => x is CharacterCard)
                    .ToList().ForEach(x => x.Visibility = Visibility.Visible);
                return;
            }

            WrapPanel_Heros.Children.Where(x => x is CharacterCard)
                .ToList().ForEach(x => x.Visibility = Visibility.Collapsed);
            WrapPanel_Others.Children.Where(x => x is CharacterCard)
                .ToList().ForEach(x => x.Visibility = Visibility.Collapsed);

            string searchTerm = StringExt.RemoveDiacritics(TextBox_SearchCharacter.Text.ToLower()).Trim()
                .Replace(" ", "");

            WrapPanel_Heros.Children.Where(x => x is CharacterCard)
                .Where(x => StringExt.RemoveDiacritics(((CharacterCard)x).TextBlock_heroName.Text).ToLower().Replace(" ", "").Contains(searchTerm))
                .ToList().ForEach(x => x.Visibility = Visibility.Visible);

            WrapPanel_Others.Children.Where(x => x is CharacterCard)
                .Where(x => StringExt.RemoveDiacritics(((CharacterCard)x).TextBlock_heroName.Text).ToLower().Replace(" ", "").Contains(searchTerm))
                .ToList().ForEach(x => x.Visibility = Visibility.Visible);

        }

        private void Image_SearchLine_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel_searchCharacter.Visibility = Visibility.Collapsed;

            string searchTerm = StringExt.RemoveDiacritics(TextBox_SearchLine.Text.ToLower()).Trim();
            StackPanel_searchResult.Children.Clear();

            if (String.IsNullOrEmpty(searchTerm))
            {
                Image_CancelSearch_MouseLeftButtonDown(this, null);
                return;
            }

            Cursor = Cursors.Wait;
            Image_CancelSearch.Visibility = Visibility.Visible;

            var soundDictionary = new Dictionary<string, List<Sound>>();

            foreach (var hero in OverwatchData.Heroes)
            {
                foreach (var category in hero.Categories)
                {
                    foreach (var sound in category.Sounds)
                    {
                        if (sound.Subtitle.Contains(searchTerm))
                        {
                            if (!soundDictionary.ContainsKey(hero.Name))
                            {
                                soundDictionary[hero.Name] = new List<Sound>();
                            }

                            soundDictionary[hero.Name].Add(sound);
                        }
                    }
                }
            }

            foreach (var hero in OverwatchData.Heroes)
            {
                foreach (var conversation in hero.Conversations)
                {
                    foreach (var dialogue in conversation.Dialogues)
                    {
                        if (dialogue.Sound.Subtitle.Contains(searchTerm))
                        {
                            var heroTalking = dialogue.HeroTalking;

                            if (!soundDictionary.ContainsKey(heroTalking))
                            {
                                soundDictionary[heroTalking] = new List<Sound>();
                            }

                            soundDictionary[heroTalking].Add(dialogue.Sound);
                        }
                    }
                }
            }

            foreach (var npc in OverwatchData.Npcs)
            {
                foreach (var sound in npc.Sounds)
                {
                    if (sound.Subtitle.Contains(searchTerm))
                    {
                        if (!soundDictionary.ContainsKey(npc.Name))
                        {
                            soundDictionary[npc.Name] = new List<Sound>();
                        }

                        soundDictionary[npc.Name].Add(sound);
                    }
                }
            }

            Grid_SearchResult.Visibility = Visibility.Visible;
            ScrollViewer_Characters.Visibility = Visibility.Collapsed;

            if (soundDictionary.Any())
            {
                // Afin de pouvoir annuler la recherche dans le futur on met dans le .Tag les éléments à afficher
                StackPanel_searchResult.Tag = String.Join(" ", soundDictionary.ToList().ConvertAll(x => String.Join(" ", x.Value.ConvertAll(y => y.Path))));
                
                foreach (var sound in soundDictionary)
                {
                    CategoryControl categoryControl = new CategoryControl(sound);

                    Dispatcher.InvokeAsync(() =>
                    {
                        // Vérifie qu'on est toujours dans la recherche concernée
                        if (StackPanel_searchResult.Tag.ToString().Contains(sound.Value.First().Path))
                            StackPanel_searchResult.Children.Add(categoryControl);
                    });
                }
            }
            else
            {
                StackPanel_searchResult.Children.Add(new TextBlock()
                {
                    FontSize = 26,
                    Text = $"No line found with '{searchTerm}'",
                    Foreground = (Brush)Colors.White,
                    Margin = new Thickness(0, 75, 0, 0)

                });
            }

            Cursor = Cursors.Arrow;
        }

        /// <summary>
        /// Recherche une line
        /// </summary>
        private void TextBox_SearchLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Image_SearchLine_MouseLeftButtonDown(this, null);
        }

        /// <summary>
        /// Cancel la recherche actuelle
        /// </summary>
        private void Image_CancelSearch_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel_searchResult.Tag = string.Empty;
            StackPanel_searchResult.Children.Clear();
            Grid_SearchResult.Visibility = Visibility.Collapsed;
            ScrollViewer_Characters.Visibility = Visibility.Visible;
            Image_CancelSearch.Visibility = Visibility.Collapsed;
            StackPanel_searchCharacter.Visibility = Visibility.Visible;
        }
    }
}
