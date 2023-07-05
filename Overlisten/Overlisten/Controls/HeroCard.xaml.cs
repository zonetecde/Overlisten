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
    public partial class HeroCard : UserControl
    {
        public HeroCard(Hero hero)
        {
            this.InitializeComponent();
            Hero = hero;

            // Load l'image
            var bitmapImage = new BitmapImage();
            bitmapImage.UriSource = new Uri($"{Config.Server}assets/{OverlistenGlob.FormatHeroName(hero.Name).Replace(':', '_').ToLower()}.png"); ;
            Image_heroImg.Source = bitmapImage;

            TextBlock_heroName.Text = OverlistenGlob.FormatHeroName(hero.Name);
        }

        public HeroCard(Npc npc)
        {
            this.InitializeComponent();

            Npc = npc;

            // Load l'image
            var bitmapImage = new BitmapImage();
            bitmapImage.UriSource = new Uri($"{Config.Server}assets/{OverlistenGlob.FormatHeroName(npc.Name).Replace(':','_').ToLower()}.png"); ;
            Image_heroImg.Source = bitmapImage;

            TextBlock_heroName.Text = OverlistenGlob.FormatHeroName(npc.Name);
        }

        public Hero Hero { get; }
        public Npc Npc { get; }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            if(Hero != null)
            {
                if(Hero.Categories.Any())
                {
                    Category helloCat = Hero.Categories.FirstOrDefault(x => x.Name == "Hello");

                    Audio.PlayAudio(helloCat.Sounds[MainPage.Random.Next(0, helloCat.Sounds.Count)].Path);
                }
            }
        }
    }
}
