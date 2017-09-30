using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class Jogadores : Page
    {
        List<MercadoDestaque> MercadoDestaqueList = new List<MercadoDestaque>();
      
        public Jogadores()
        {
            
            this.InitializeComponent();
            LoadAtleta();
        }

        public void LoadAtleta()
        {
            string url = "http://api.cartolafc.globo.com/mercado/destaques";
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
                    var serializer = new DataContractJsonSerializer(typeof(List<MercadoDestaque>));
                    var data = (List<MercadoDestaque>)serializer.ReadObject(stream);
                   
                    this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    {
                        this.DataContext = data;
                    }).AsTask().Wait();
                }
            },
            request);
        }

        public void LoadAllAtleta()
        {
            string url = "https://api.cartolafc.globo.com/atletas/mercado";
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
                    var serializer = new DataContractJsonSerializer(typeof(Atletas));
                    var data = (Atletas)serializer.ReadObject(stream);
                                      
                    this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    {
                        this.DataContext = data.AtletaList;
                    }).AsTask().Wait();
                }
            },
            request);
        }


        private void Pivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var pivot = sender as Pivot;
            var item = pivot.SelectedItem as PivotItem;

            if (item.Name == "Escalacoes")
            {
                this.DataContext = null;
                this.LoadAtleta();
            }
            else if (item.Name == "TodosAtletas")
            {
                this.DataContext = null;
                this.LoadAllAtleta();
            }
            
        }
    }
}
