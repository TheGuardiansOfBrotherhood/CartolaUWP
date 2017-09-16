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
        public string SessentaPorSessenta { get; set; }

        [DataMember(Name = "45x45")]
        public string QuarentaECincoPorQuarentaECinco { get; set; }

        [DataMember(Name = "30x30")]
        public string TrintaPorTrinta { get; set; }
    }
}
