using Overlisten.Extension;
using OverlistenClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace Overlisten.Controls
{
    public partial class SoundControl : UserControl
    {
        public Sound Sound { get; }

        public SoundControl(Sound sound)
        {
            this.InitializeComponent();

            TextBlock_subtitle.Text = sound.Subtitle;
            Sound = sound;
        }

        private void Image_play_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainPage._MainPage.mediaElement.Source = new Uri(Config.Server + Sound.Path);
            MainPage._MainPage.mediaElement.Play();
        }        
        private void Image_pause_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainPage._MainPage.mediaElement.Pause();
        }        
        private void Image_download_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Audio.DownloadAudio(Sound.Path, String.Join(string.Empty, Sound.Subtitle.Take(20)) + ".ogg");
        }

    }
}
