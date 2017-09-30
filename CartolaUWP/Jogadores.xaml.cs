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

    public sealed partial class Jogadores : Page
    {
        private const string URL_DESTAQUES = "http://api.cartolafc.globo.com/mercado/destaques";
        private const string URL_ATLETAS = "https://api.cartolafc.globo.com/atletas/mercado";

        private List<MercadoDestaque> MercadoDestaqueList = new List<MercadoDestaque>();
        private List<Atleta> Atletas = new List<Atleta>();

        public Jogadores()
        {
            this.InitializeComponent();
            LoadAtleta();
        }

        public void LoadAtleta()
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
                    var serializer = new DataContractJsonSerializer(typeof(List<MercadoDestaque>));
                    var data = (List<MercadoDestaque>)serializer.ReadObject(stream);
                   
                    this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    {
                        this.DataContext = data;
                        LoadingIndicator.Visibility = Visibility.Collapsed;
                    }).AsTask().Wait();
                }
            },
            request);
        }

        public void LoadAllAtleta()
        {
            LoadingIndicator.Visibility = Visibility.Visible;
            Uri uri = new Uri(URL_ATLETAS, UriKind.Absolute);

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
                    Atletas data = (Atletas)serializer.ReadObject(stream);
                                      
                    this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    {
                        this.Atletas = data.AtletaList;
                        this.DataContext = data.AtletaList;
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

            if (item.Name == "Escalacoes")
            {
                this.LoadAtleta();
            }
            else if (item.Name == "TodosAtletas")
            {
                this.LoadAllAtleta();
            }
        }

        private void SearchJogadores(object sender, RoutedEventArgs e)
        {
            LoadingIndicator.Visibility = Visibility.Visible;
            var Search = SearchKey.Text;

            if (Search != null && this.Atletas != null)
            {
                List<Atleta> SearchList = this.Atletas.FindAll(Atleta =>
                {
                    return Atleta.Nome.ToLower().Contains(Search.ToLower());
                });
                this.DataContext = SearchList;
            }
            LoadingIndicator.Visibility = Visibility.Collapsed;
        }
    }
}
