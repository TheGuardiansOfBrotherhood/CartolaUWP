using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    [DataContract]
    class Escudos
    {
        private string sessentaPorSessenta;
        private string quarentaECincoPorQuarentaECinco;
        private string trintaPorTrinta;

        public Escudos()
        {
        }

        public Escudos(string SessentaPorSessenta, string QuarentaECincoPorQuarentaECinco, string TrintaPorTrinta)
        {
            this.SessentaPorSessenta = SessentaPorSessenta;
            this.QuarentaECincoPorQuarentaECinco = QuarentaECincoPorQuarentaECinco;
            this.TrintaPorTrinta = TrintaPorTrinta;
        }

        [DataMember(Name = "60x60")]
        public string SessentaPorSessenta {
            get
            {
                return this.sessentaPorSessenta.Equals("") ?
                    "https://s3.glbimg.com/v1/AUTH_58d78b787ec34892b5aaa0c7a146155f/placeholder/escudo.png" :
                    this.sessentaPorSessenta;
            }
            set
            {
                this.sessentaPorSessenta = value;
            }
        }

        [DataMember(Name = "45x45")]
        public string QuarentaECincoPorQuarentaECinco {
            get
            {
                return this.quarentaECincoPorQuarentaECinco.Equals("") ?
                    "https://s3.glbimg.com/v1/AUTH_58d78b787ec34892b5aaa0c7a146155f/placeholder/escudo.png" :
                    this.quarentaECincoPorQuarentaECinco;
            }
            set
            {
                this.quarentaECincoPorQuarentaECinco = value;
            }
        }

        [DataMember(Name = "30x30")]
        public string TrintaPorTrinta {
            get
            {
                return this.trintaPorTrinta.Equals("") ?
                    "https://s3.glbimg.com/v1/AUTH_58d78b787ec34892b5aaa0c7a146155f/placeholder/escudo.png" :
                    this.trintaPorTrinta;
            }
            set
            {
                this.trintaPorTrinta = value;
            }
        }
    }
}
