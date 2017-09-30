using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    [DataContract]
    class Partidas
    {
        public Partidas()
        {
        }

        [DataMember(Name = "partidas")]
        public List<Partida> PartidaList { get; set; }
    }
}
