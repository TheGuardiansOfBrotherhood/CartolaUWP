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
        private ClubesManager ClubesManagerTest;

        public ClubesParticipantes()
        {
            this.InitializeComponent();
            ClubesManagerTest = new ClubesManager();
            //this.DataContext = ClubesManagerTest;
            LoadClubes();
        }

        public void LoadClubes()
        {
            string url = "https://api.cartolafc.globo.com/clubes";
            Uri uri = new Uri(url, UriKind.Absolute);

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
                    ClubesManagerTest.Clubes.Clear();

                    PropertyInfo[] properties = typeof(Clubes).GetProperties();
                    foreach (PropertyInfo property in properties)
                    {
                        if (property.PropertyType == typeof(Clube))
                        {
                            ClubesManagerTest.Clubes.Add((Clube)property.GetValue(data));
                        }
                    }

                    this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    {
                        this.DataContext = ClubesManagerTest;
                    }).AsTask().Wait();
                }
            },
            request);
        }

        private void SearchTeams(object sender, RoutedEventArgs e)
        {
            string url = "https://api.cartolafc.globo.com/times?q=" + ClubesManagerTest.SearchKey;
            Uri uri = new Uri(url, UriKind.Absolute);

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
                    ClubesManagerTest.Times = (List<Time>)serializer.ReadObject(stream);

                    this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    {
                        this.DataContext = ClubesManagerTest;
                    }).AsTask().Wait();
                }
            },
            request);
        }
    }
}
