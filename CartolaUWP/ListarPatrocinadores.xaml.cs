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
    public sealed partial class ListarPatrocinadores : Page
    {
        private const String URL_PATROCINADORES = "https://api.cartolafc.globo.com/patrocinadores";

        public ListarPatrocinadores()
        {
            this.InitializeComponent();
            this.LoadPatrocinadores();
        }

        private void LoadPatrocinadores()
        {
            Uri uri = new Uri(URL_PATROCINADORES, UriKind.Absolute);

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
                    var serializer = new DataContractJsonSerializer(typeof(Patrocinadores));
                    var data = (Patrocinadores)serializer.ReadObject(stream);
                    List<Patrocinador> Patrocinadores = new List<Patrocinador>();

                    PropertyInfo[] properties = typeof(Patrocinadores).GetProperties();
                    foreach (PropertyInfo property in properties)
                    {
                        if (property.PropertyType == typeof(Patrocinador))
                        {
                            Patrocinadores.Add((Patrocinador) property.GetValue(data));
                        }
                    }

                    this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    {
                        this.DataContext = Patrocinadores;
                    }).AsTask().Wait();
                }
            },
            request);
        }
    }
}
