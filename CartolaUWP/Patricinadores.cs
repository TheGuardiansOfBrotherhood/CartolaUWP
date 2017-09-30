using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    [DataContract]
    public class Patrocinadores
    {

        public Patrocinadores() {}

        [DataMember(Name = "62")]
        public Patrocinador Patrocinador62 { get; set; }

        [DataMember(Name = "63")]
        public Patrocinador Patrocinador63 { get; set; }

        [DataMember(Name = "64")]
        public Patrocinador Patrocinador64 { get; set; }

        [DataMember(Name = "65")]
        public Patrocinador Patrocinador65 { get; set; }

        [DataMember(Name = "66")]
        public Patrocinador Patrocinador66 { get; set; }

        [DataMember(Name = "67")]
        public Patrocinador Patrocinador67 { get; set; }

        [DataMember(Name = "68")]
        public Patrocinador Patrocinador68 { get; set; }
    }
}
