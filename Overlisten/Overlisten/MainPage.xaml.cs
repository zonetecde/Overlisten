using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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

        private void NavigateToCharacterPage(object character)
        {
            TextBlock_characterPageTitle.Text = "Overlistening to ";

            StackPanel_Categories.Children.Clear();
            StackPanel_Conversations.Children.Clear();
            StackPanel_Sounds.Children.Clear();

            Animation.ShowAnimation(Grid_CharacterPage);

            if (character is Hero)
            {
                CharacterCard_Character.SetHero((Hero)character);
                TextBlock_characterPageTitle.Text += OverlistenGlob.FormatHeroName(((Hero)character).Name);

                Grid_Hero.Visibility = Visibility.Visible;
                Grid_Npc.Visibility = Visibility.Collapsed;

                StackPanel_Categories.Visibility = Visibility.Visible;
                StackPanel_Conversations.Visibility = Visibility.Visible;

                // Affiche les catégories
                foreach (Category cat in ((Hero)character).Categories)
                {
                    CategoryControl categoryControl = new CategoryControl(cat);
                    StackPanel_Categories.Children.Add(categoryControl);               
                }

                StackPanel_HeaderCategories.Visibility = StackPanel_Categories.Children.Any() ?
                    Visibility.Visible : Visibility.Collapsed;

                // Affiche les convs
                foreach (Conversation conv in ((Hero)character).Conversations)
                {
                    CategoryControl categoryControl = new CategoryControl(conv);
                    StackPanel_Conversations.Children.Add(categoryControl);
                }

                StackPanel_Conversations.Visibility = StackPanel_Conversations.Children.Any() ?
                    Visibility.Visible : Visibility.Collapsed;
            }
            else
            {
                Grid_Hero.Visibility = Visibility.Collapsed;
                Grid_Npc.Visibility = Visibility.Visible;

                CharacterCard_Character.SetNpc((Npc)character);
                TextBlock_characterPageTitle.Text += ((Npc)character).Name;

                // Affiche les sons du NPC
                foreach (Sound sound in ((Npc)character).Sounds)
                {
                    SoundControl conversationControl = new SoundControl(sound);
                    StackPanel_Sounds.Children.Add(conversationControl);
                }
            }
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
    }
}
