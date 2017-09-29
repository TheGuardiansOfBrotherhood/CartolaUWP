using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization.Json;
using Windows.UI.Xaml.Controls;

namespace CartolaUWP
{
    public sealed partial class Campeonato : Page
    {

        const string URL_RODADAS = "https://api.cartolafc.globo.com/rodadas";
        const string URL_PARTIDAS = "https://api.cartolafc.globo.com/partidas";

        public Campeonato()
        {
            this.InitializeComponent();
        }

        public void LoadCampeonatos()
        {
            Uri uri = new Uri(URL_RODADAS, UriKind.Absolute);

            var request = (HttpWebRequest) WebRequest.Create(uri);
            request.Method = "GET";
            request.Accept = "application/json";
            request.Headers[HttpRequestHeader.UserAgent] = ".NET Framework Test Client";
            request.BeginGetResponse((result) =>
            {
                var req = (HttpWebRequest)result.AsyncState;
                var response = req.EndGetResponse(result);
                var stream = response.GetResponseStream();
                if (stream != null)
                {
                    var serializer = new DataContractJsonSerializer(typeof(List<Rodada>));
                    var Rodadas = (List<Rodada>) serializer.ReadObject(stream);

                    this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    {
                        this.DataContext = Rodadas;
                    }).AsTask().Wait();
                }
            },
            request);
        }

        private void LoadPartidas()
        {
            Uri uri = new Uri(URL_PARTIDAS, UriKind.Absolute);

            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "GET";
            request.Accept = "application/json";
            request.Headers[HttpRequestHeader.UserAgent] = ".NET Framework Test Client";
            request.BeginGetResponse((result) =>
            {
                var req = (HttpWebRequest)result.AsyncState;
                var response = req.EndGetResponse(result);
                var stream = response.GetResponseStream();
                if (stream != null)
                {
                    var serializer = new DataContractJsonSerializer(typeof(List<Partida>));
                    var Partidas = (List<Partida>)serializer.ReadObject(stream);

                    this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    {
                        this.DataContext = Partidas;
                    }).AsTask().Wait();
                }
            },
            request);
        }

        private void Pivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var pivot = sender as Pivot;
            var item = pivot.SelectedItem as PivotItem;

            if (item.Name == "campeonato")
            {
                this.LoadCampeonatos();
            } else if (item.Name == "partidas")
            {
                this.LoadPartidas();
            }
        }
    }
}
