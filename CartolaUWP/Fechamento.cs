using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    [DataContract]
    class Fechamento
    {
        public Fechamento()
        {
        }

        public Fechamento(int Dia, int Mes, int Ano, int Hora, int Minuto, long Timestamp)
        {
            this.Dia = Dia;
            this.Mes = Mes;
            this.Ano = Ano;
            this.Hora = Hora;
            this.Minuto = Minuto;
            this.Timestamp = Timestamp;
        }

        [DataMember(Name = "dia")]
        public int Dia { get; set; }

        [DataMember(Name = "mes")]
        public int Mes { get; set; }

        [DataMember(Name = "ano")]
        public int Ano { get; set; }

        [DataMember(Name = "hora")]
        public int Hora { get; set; }

        [DataMember(Name = "minuto")]
        public int Minuto { get; set; }

        [DataMember(Name = "timestamp")]
        public long Timestamp { get; set; }
    }
}
