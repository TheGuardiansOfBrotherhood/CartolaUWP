using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    [DataContract]
    class Clube
    {
        public Clube()
        {
        }

        public Clube(long Id, string Nome, string Abreviacao, Escudos Escudos)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Abreviacao = Abreviacao;
            this.Escudos = Escudos;
        }

        [DataMember(Name = "id")]
        public long Id { get; set; }

        [DataMember(Name = "nome")]
        public string Nome { get; set; }

        [DataMember(Name = "abreviacao")]
        public string Abreviacao { get; set; }

        [DataMember(Name = "escudos")]
        public Escudos Escudos { get; set; }
    }
}
