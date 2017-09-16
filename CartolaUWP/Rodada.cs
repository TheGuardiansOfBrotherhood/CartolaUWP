using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    [DataContract]
    class Rodada
    {
        public Rodada()
        {
        }

        public Rodada(long RodadaId, string Inicio, string Fim)
        {
            this.RodadaId = RodadaId;
            this.Inicio = Inicio;
            this.Fim = Fim;
        }

        [DataMember(Name = "rodada_id")]
        public long RodadaId { get; set; }

        [DataMember(Name = "inicio")]
        public string Inicio { get; set; }

        [DataMember(Name = "fim")]
        public string Fim { get; set; }
    }
}
