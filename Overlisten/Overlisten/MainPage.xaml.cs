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
using Overlisten.Extension;
using OverlistenClassLibrary;

namespace Overlisten
{
    public partial class MainPage : Page
    {
        internal static Random Random { get; set; } = new Random();

        internal Data OverwatchData;

        public MainPage()
        {
            this.InitializeComponent();
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
                    Controls.HeroCard heroCard = new Controls.HeroCard(hero);
                    WrapPanel_Heros.Children.Add(heroCard);
                }
                foreach (var npc in OverwatchData.Npcs)
                {
                    Controls.HeroCard heroCard = new Controls.HeroCard(npc);
                    WrapPanel_Others.Children.Add(heroCard);
                }

                Animation.HideAnimation(Grid_Loading, Grid_main);
            }
        }
    }
}
