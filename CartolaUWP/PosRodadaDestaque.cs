using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    [DataContract]
    class PosRodadaDestaque
    {
        public PosRodadaDestaque()
        {
        }

        public PosRodadaDestaque(double MediaCartoletas, double MediaPontos, MitoRodada MitoRodada)
        {
            this.MediaCartoletas = MediaCartoletas;
            this.MediaPontos = MediaPontos;
            this.MitoRodada = MitoRodada;
        }

        [DataMember(Name = "media_cartoletas")]
        public double MediaCartoletas { get; set; }

        [DataMember(Name = "media_pontos")]
        public double MediaPontos { get; set; }

        [DataMember(Name = "mito_rodada")]
        public MitoRodada MitoRodada { get; set; }
    }
}
