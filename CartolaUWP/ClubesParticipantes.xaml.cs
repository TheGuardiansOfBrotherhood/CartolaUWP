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

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace CartolaUWP
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class ClubesParticipantes : Page
    {
        private const string URL_CLUBES = "https://api.cartolafc.globo.com/clubes";
        private const string URL_TIMES = "https://api.cartolafc.globo.com/times?q=";
        private const string URL_DESTAQUES = "https://api.cartolafc.globo.com/pos-rodada/destaques";

        public ClubesParticipantes()
        {
            this.InitializeComponent();
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
                    List<Clube> Clubes = new List<Clube>();

                    PropertyInfo[] properties = typeof(Clubes).GetProperties();
                    foreach (PropertyInfo property in properties)
                    {
                        if (property.PropertyType == typeof(Clube))
                        {
                            Clubes.Add((Clube)property.GetValue(data));
                        }
                    }

                    this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    {
                        this.DataContext = Clubes;
                        LoadingIndicator.Visibility = Visibility.Collapsed;
                    }).AsTask().Wait();
                }
            },
            request);
        }

        private void SearchTeams(object sender, RoutedEventArgs e)
        {
            LoadingIndicator.Visibility = Visibility.Visible;
            Uri uri = new Uri(URL_TIMES + SearchKey.Text, UriKind.Absolute);

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
                    var serializer = new DataContractJsonSerializer(typeof(List<Time>));
                    List<Time> Times = (List<Time>)serializer.ReadObject(stream);

                    this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    {
                        this.DataContext = Times;
                        LoadingIndicator.Visibility = Visibility.Collapsed;
                    }).AsTask().Wait();
                }
            },
            request);
        }

        private void LoadDestaques()
        {
            LoadingIndicator.Visibility = Visibility.Visible;
            Uri uri = new Uri(URL_DESTAQUES, UriKind.Absolute);

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
                    var serializer = new DataContractJsonSerializer(typeof(PosRodadaDestaque));
                    PosRodadaDestaque PosRodadaDestaque = (PosRodadaDestaque) serializer.ReadObject(stream);

                    this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    {
                        this.DataContext = PosRodadaDestaque;
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

            if (item.Name == "clubes")
            {
                this.LoadClubes();
            }
            else if (item.Name == "times")
            {
                this.DataContext = null;
            }
            else if (item.Name == "destaque")
            {
                this.LoadDestaques();
            }
        }
    }
}
