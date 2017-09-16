using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    [DataContract]
    class Escudo
    {

        [DataMember(Name = "id")]
        public long Id { get; set; }
    }
}
