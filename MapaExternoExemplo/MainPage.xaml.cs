using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.ExternalMaps;
using Xamarin.Forms;

namespace MapaExternoExemplo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void Handle_Clicked(object sender, EventArgs e)
        {
            // var success = await CrossExternalMaps.Current.NavigateTo("NESS Processos e Tecnologia", -23.6008793, -46.6950054);

            var success = await CrossExternalMaps.Current.NavigateTo("NESS Processos e Tecnologia",
             "Rua Doutor Geraldo Campos Moreira 240", "São Paulo", "São Paulo", "04533-085", "Brasil", "");

        }
    }
}
