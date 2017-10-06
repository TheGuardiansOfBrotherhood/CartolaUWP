using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace CartolaUWP
{
    public sealed partial class Campeonato : Page
    {
        private const string URL_RODADAS = "https://api.cartolafc.globo.com/rodadas";
        private const string URL_CLUBES = "https://api.cartolafc.globo.com/clubes";
        private const string URL_PARTIDAS = "https://api.cartolafc.globo.com/partidas";

        List<Clube> ClubeList = new List<Clube>();

        public Campeonato()
        {
            this.InitializeComponent();
        }

        public void LoadRodadas()
        {
            LoadingIndicator.Visibility = Visibility.Visible;
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
                    List<Rodada> Rodadas = (List<Rodada>) serializer.ReadObject(stream);

                    this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    {
                        this.DataContext = Rodadas;
                        LoadingIndicator.Visibility = Visibility.Collapsed;
                    }).AsTask().Wait();
                }
            },
            request);
        }

        public void LoadClubes()
        {
            LoadingIndicator.Visibility = Visibility.Visible;
            Uri uri = new Uri(URL_CLUBES, UriKind.Absolute);

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
                    var serializer = new DataContractJsonSerializer(typeof(Clubes));
                    var data = (Clubes)serializer.ReadObject(stream);
                    ClubeList.Clear();

                    PropertyInfo[] properties = typeof(Clubes).GetProperties();
                    foreach (PropertyInfo property in properties)
                    {
                        if (property.PropertyType == typeof(Clube))
                        {
                            ClubeList.Add((Clube)property.GetValue(data));
                        }
                    }

                    LoadPartidas();
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
                    var serializer = new DataContractJsonSerializer(typeof(Partidas));
                    Partidas Partidas = (Partidas)serializer.ReadObject(stream);

                    Partidas.PartidaList.ForEach(partida => {
                        partida.ClubeCasa = ClubeList.FirstOrDefault(clube => clube.Id == partida.ClubeCasaId);
                        partida.ClubeVisitante = ClubeList.FirstOrDefault(clube => clube.Id == partida.ClubeVisitanteId);
                    });

                    this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    {
                        this.DataContext = Partidas.PartidaList;
                        LoadingIndicator.Visibility = Visibility.Collapsed;
                    }).AsTask().Wait();
                }
            },
            request);
        }

        private void Pivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.DataContext = null;
            var pivot = sender as Pivot;
            var item = pivot.SelectedItem as PivotItem;

            if (item.Name == "rodadas")
            {
                this.LoadRodadas();
            }
            else if (item.Name == "partidas")
            {
                this.LoadClubes();
            }
        }
    }
}
