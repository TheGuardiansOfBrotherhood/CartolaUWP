using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    [DataContract]
    class MercadoDestaque
    {
        public MercadoDestaque()
        {
        }

        public MercadoDestaque(Atleta Atleta, int Escalacoes, string Clube, string EscudoClube, string Posicao)
        {
            this.Atleta = Atleta;
            this.Escalacoes = Escalacoes;
            this.Clube = Clube;
            this.EscudoClube = EscudoClube;
            this.Posicao = Posicao;
        }

        [DataMember(Name = "Atleta")]
        public Atleta Atleta { get; set; }

        [DataMember(Name = "escalacoes")]
        public int Escalacoes { get; set; }

        [DataMember(Name = "clube")]
        public string Clube { get; set; }

        [DataMember(Name = "escudo_clube")]
        public string EscudoClube { get; set; }

        [DataMember(Name = "posicao")]
        public string Posicao { get; set; }
    }
}
