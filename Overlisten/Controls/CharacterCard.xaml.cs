using OpenSilver;
using Overlisten.Extension;
using OverlistenClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Xml.Linq;

namespace Overlisten.Controls
{
    public partial class CharacterCard : UserControl
    {
        public object Character { get; set; }
        public Action<object> NavigateToCharacterPage { get; }

        public CharacterCard(object character, Action<object> NavigateToCharacterPage)
        {
            this.InitializeComponent();

            if(character is Hero)
                SetHero((Hero)character);
            else
                SetNpc((Npc)character);

            Character = character;
            this.NavigateToCharacterPage = NavigateToCharacterPage;
        }

        internal void SetHero(Hero character)
        {
            // Load l'image
            var bitmapImage = new BitmapImage();
            bitmapImage.UriSource = new Uri($"{Config.Server}assets/{OverlistenGlob.FormatHeroName(character.Name).Replace(':', '_').ToLower()}.png"); ;
            Image_heroImg.Source = bitmapImage;

            TextBlock_heroName.Text = OverlistenGlob.FormatHeroName(character.Name);
        }

        internal void SetNpc(Npc character)
        {
            // Load l'image
            var bitmapImage = new BitmapImage();
            bitmapImage.UriSource = new Uri($"{Config.Server}assets/{OverlistenGlob.FormatHeroName(character.Name).Replace(':', '_').ToLower()}.png"); ;
            Image_heroImg.Source = bitmapImage;

            TextBlock_heroName.Text = OverlistenGlob.FormatHeroName(character.Name);
        }

        public CharacterCard()
        {
            this.InitializeComponent();
        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            if(Character is Hero)
            {
                if(((Hero)Character).Categories.Any())
                {
                    Category helloCat = ((Hero)Character).Categories.FirstOrDefault(x => x.Name == "Hello");

                    Audio.PlayAudio(helloCat.Sounds[MainPage.Random.Next(0, helloCat.Sounds.Count)].Path);
                }
            }
        }

        /// <summary>
        /// Ouvre la carte du héros
        /// </summary>
        private void UserControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            NavigateToCharacterPage(Character);
        }
    }
}
