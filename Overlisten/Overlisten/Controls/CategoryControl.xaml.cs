using Overlisten.Extension;
using OverlistenClassLibrary;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Overlisten.Controls
{
    public partial class CategoryControl : UserControl
    {
        public CategoryControl(object cat)
        {
            this.InitializeComponent();

            Cat = cat;

            // Ajoute le nom de la catégorie
          
            if (Cat is Category)
                TextBlock_CategoryName.Text = OverlistenGlob.FormatHeroName(StringExt.AddSpacesBeforeCaps(((Category)Cat).Name));
            else
                TextBlock_CategoryName.Text = OverlistenGlob.FormatHeroName(String.Join(", ", ((Conversation)Cat).Dialogues.ConvertAll(x => x.HeroTalking).Distinct())).Replace('_', ':');

            
        }

        public object Cat { get; }

        private void Image_ToggleSounds_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel_sounds.Visibility = StackPanel_sounds.Visibility == Visibility.Visible ?
                Visibility.Collapsed : Visibility.Visible;

            (sender as Image).Source = StackPanel_sounds.Visibility == Visibility.Visible
                ? MainPage._MainPage.Img_dropDownOpen.Source : MainPage._MainPage.Img_dropDownClosed.Source;


            // Ajoute les sons
            if (!StackPanel_sounds.Children.Any())
            {
                if (Cat is Category)
                {
                    var _cat = (Category)Cat;

                    foreach (Sound sound in _cat.Sounds)
                    {
                        StackPanel_sounds.Children.Add(new SoundControl(sound));
                    }
                }
                else
                {
                    var conv = (Conversation)Cat;


                    foreach (Dialogue dialogue in conv.Dialogues)
                    {
                        StackPanel stackPanel = new StackPanel();
                        stackPanel.Orientation = Orientation.Horizontal;

                        Image img = new Image();
                        var bitmapImage = new BitmapImage();
                        bitmapImage.UriSource = new Uri($"{Config.Server}assets/{OverlistenGlob.FormatHeroName(dialogue.HeroTalking).Replace(':', '_').ToLower()}.png"); ;
                        img.Source = bitmapImage;
                        img.Width = 50;
                        img.Height = 50;

                        SoundControl soundControl = new SoundControl(dialogue.Sound);
                        stackPanel.Children.Add(img);
                        stackPanel.Children.Add(soundControl);

                        StackPanel_sounds.Children.Add(stackPanel);
                    }
                }
            }
        }
    }
}
