using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace Pokemonapi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btnallpokemon_Click(object sender, RoutedEventArgs e)
        {
            string url = @"https://pokeapi.co/api/v2/pokemon?offset=0&limit=964";
            //https://pokeapi.co/api/v2/pokemon?offset=0&limit=964
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(@"https://pokeapi.co/api/v2/pokemon?offset=0&limit=964").Result;
                if(response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var stuff = JsonConvert.DeserializeObject<Results>(content);
                    lstnames.Items.Clear();
                    foreach (var result in stuff.results)
                    {
                        lstnames.Items.Add(result.name);
                    }
                }
            }
        }

        private void BtnAbility_Click(object sender, RoutedEventArgs e)
        {
            string url = @"https://pokeapi.co/api/v2/ability?offset=0&limit=293";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                   
                }
            }
        }
    }
}
