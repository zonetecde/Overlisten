using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Newtonsoft.Json;
using Overlisten.Controls;
using Overlisten.Extension;
using OverlistenClassLibrary;

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
                string json = await client.GetStringAsync(Config.Server + "data.json");
                OverwatchData = JsonConvert.DeserializeObject<Data>(json);

                // Ajoute la carte de tout les héros
                foreach(var hero in OverwatchData.Heroes)
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


        private async void NavigateToCharacterPage(object character)
        {
            this.Cursor = Cursors.Wait;

            TextBlock_characterPageTitle.Text = "Overlistening to ";

            StackPanel_Categories.Children.Clear();
            StackPanel_Conversations.Children.Clear();
            StackPanel_Sounds.Children.Clear();

            Animation.ShowAnimation(Grid_CharacterPage);

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
                    //await Task.Run(() =>
                    //{
                        CategoryControl categoryControl = new CategoryControl(cat);

                        //Dispatcher.InvokeAsync(() =>
                        //{
                            StackPanel_Categories.Children.Add(categoryControl);
                        //});
                    //});
                }

                StackPanel_HeaderCategories.Visibility = StackPanel_Categories.Children.Any() ?
                    Visibility.Visible : Visibility.Collapsed;

                // Affiche les convs
                foreach (Conversation conv in hero.Conversations)
                {
                    //await Task.Run(() =>
                    //{
                        CategoryControl categoryControl = new CategoryControl(conv);

                        //Dispatcher.InvokeAsync(() =>
                        //{
                            StackPanel_Conversations.Children.Add(categoryControl);
                        //});
                    //});
                }

                StackPanel_Conversations.Visibility = StackPanel_Conversations.Children.Any() ?
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
                foreach (Sound sound in npc.Sounds)
                {
                    //await Task.Run(() =>
                    //{
                        SoundControl conversationControl = new SoundControl(sound);

                        //Dispatcher.InvokeAsync(() =>
                        //{
                            StackPanel_Sounds.Children.Add(conversationControl);
                        //});
                    //});
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
            Animation.HideAnimation(Grid_CharacterPage, Grid_main);
        }

        private void TextBox_SearchCharacter_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(String.IsNullOrEmpty(((TextBox)sender).Text))
            {
                WrapPanel_Heros.Children.Where(x => x is CharacterCard)
                    .ToList().ForEach(x => x.Visibility = Visibility.Visible);   
                
                WrapPanel_Others.Children.Where(x => x is CharacterCard)
                    .ToList().ForEach(x => x.Visibility = Visibility.Visible);
                return;
            }

            WrapPanel_Heros.Children.Where(x => x is CharacterCard)             
                .ToList().ForEach(x => x.Visibility =  Visibility.Collapsed);
            WrapPanel_Others.Children.Where(x => x is CharacterCard)             
                .ToList().ForEach(x => x.Visibility =  Visibility.Collapsed);

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
            string searchTerm = StringExt.RemoveDiacritics(TextBox_SearchLine.Text.ToLower()).Trim();
            StackPanel_searchResult.Children.Clear();

            if (String.IsNullOrEmpty(searchTerm))
            {
                Image_CancelSearch.Visibility = Visibility.Collapsed;
                Grid_SearchResult.Visibility = Visibility.Collapsed;
                ScrollViewer_Characters.Visibility = Visibility.Visible;
                return;
            }

            Cursor = Cursors.Wait;
            Image_CancelSearch.Visibility = Visibility.Visible;

            var soundDictionary = new Dictionary<string, List<Sound>>();

            // Iterate through heroes' categories
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

            // Iterate through heroes' conversations
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

            // Iterate through NPCs
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
                foreach (var sound in soundDictionary)
                {
                    CategoryControl categoryControl = new CategoryControl(sound);

                    StackPanel_searchResult.Children.Add(categoryControl);
                }
            }
            else
            {
                StackPanel_searchResult.Children.Add(new TextBlock()
                {
                    FontSize= 26,
                    Text = $"No line found with '{searchTerm}'",
                    Foreground = (Brush)Colors.White,
                    Margin = new Thickness(0,75,0,0)

                });
            }

            Cursor = Cursors.Arrow;
        }

        private void TextBox_SearchLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Image_SearchLine_MouseLeftButtonDown(this, null);
        }

        private void Image_CancelSearch_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel_searchResult.Children.Clear();
            Grid_SearchResult.Visibility = Visibility.Collapsed;
            ScrollViewer_Characters.Visibility = Visibility.Visible;
            Image_CancelSearch.Visibility = Visibility.Collapsed;
        }
    }
}
