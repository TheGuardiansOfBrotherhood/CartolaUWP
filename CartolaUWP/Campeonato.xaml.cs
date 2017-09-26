using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization.Json;
using Windows.UI.Xaml.Controls;

namespace CartolaUWP
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class Campeonato : Page
    {
        public Campeonato()
        {
            this.InitializeComponent();

            this.Load();
        }

        private void Load()
        {
            Uri uri = new Uri("https://api.cartolafc.globo.com/rodadas", UriKind.Absolute);
            var request = (HttpWebRequest) WebRequest.Create(uri);
            request.Method = "GET";
            request.Accept = "application/json";
            request.BeginGetResponse((result) =>
            {
                var req = (HttpWebRequest)result.AsyncState;
                var response = req.EndGetResponse(result);
                var stream = response.GetResponseStream();
                if (stream != null)
                {
                    var serializer = new DataContractJsonSerializer(typeof(List<Rodada>));

                    var results = (List<Rodada>) serializer.ReadObject(stream);
                    if (results != null)
                    {
                        this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                        {
                            if (results != null)
                            {

                            }
                        }).AsTask().Wait();
                    }
                }
            },
            request);
        }
    }
}
