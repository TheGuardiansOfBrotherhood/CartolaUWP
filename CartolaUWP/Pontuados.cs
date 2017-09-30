using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    [DataContract]
    class Pontuados
    {
        public Pontuados()
        {
        }

        [DataMember(Name = "rodada")]
        public int Rodada { get; set; }

        [DataMember(Name = "total_atletas")]
        public int TotalAtletas { get; set; }
    }
}
