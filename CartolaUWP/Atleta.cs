using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    [DataContract]
    class Atleta
    {
        public Atleta()
        {
        }

        public Atleta(int AtletaId, string Nome, string Apelido, string Foto, int PrecoEditorial)
        {
            this.AtletaId = AtletaId;
            this.Nome = Nome;
            this.Apelido = Apelido;
            this.Foto = Foto;
            this.PrecoEditorial = PrecoEditorial;
        }

        [DataMember(Name = "atleta_id")]
        public int AtletaId { get; set; }

        [DataMember(Name = "nome")]
        public string Nome { get; set; }

        [DataMember(Name = "apelido")]
        public string Apelido { get; set; }

        [DataMember(Name = "foto")]
        public string Foto { get; set; }

        [DataMember(Name = "preco_editorial")]
        public int PrecoEditorial { get; set; }
    }
}
