using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    [DataContract]
    class Atletas
    {
        public Atletas()
        {
        }

        [DataMember(Name = "atletas")]
        public List<Atleta> AtletaList { get; set; }
    }
}
