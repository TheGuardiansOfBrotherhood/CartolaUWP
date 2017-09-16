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

        public Atleta(long AtletaId, string Nome, string Apelido, string Foto, int PrecoEditorial, long RodadaId, long ClubeId,
            long PosicaoId, long StatusId, double PontosNum, double PrecoNum, double VariacaoNum, double MediaNum, int JogosNum,
            object Scout)
        {
            this.AtletaId = AtletaId;
            this.Nome = Nome;
            this.Apelido = Apelido;
            this.Foto = Foto;
            this.PrecoEditorial = PrecoEditorial;
            this.RodadaId = RodadaId;
            this.ClubeId = ClubeId;
            this.PosicaoId = PosicaoId;
            this.StatusId = StatusId;
            this.PontosNum = PontosNum;
            this.PrecoNum = PrecoNum;
            this.VariacaoNum = VariacaoNum;
            this.MediaNum = MediaNum;
            this.JogosNum = JogosNum;
            this.Scout = Scout;
        }

        [DataMember(Name = "atleta_id")]
        public long AtletaId { get; set; }

        [DataMember(Name = "nome")]
        public string Nome { get; set; }

        [DataMember(Name = "apelido")]
        public string Apelido { get; set; }

        [DataMember(Name = "foto")]
        public string Foto { get; set; }

        [DataMember(Name = "preco_editorial")]
        public int PrecoEditorial { get; set; }

        [DataMember(Name = "rodada_id")]
        public long RodadaId { get; set; }

        [DataMember(Name = "clube_id")]
        public long ClubeId { get; set; }

        [DataMember(Name = "posicao_id")]
        public long PosicaoId { get; set; }

        [DataMember(Name = "status_id")]
        public long StatusId { get; set; }

        [DataMember(Name = "pontos_num")]
        public double PontosNum { get; set; }

        [DataMember(Name = "preco_num")]
        public double PrecoNum { get; set; }

        [DataMember(Name = "variacao_num")]
        public double VariacaoNum { get; set; }

        [DataMember(Name = "media_num")]
        public double MediaNum { get; set; }

        [DataMember(Name = "jogos_num")]
        public int JogosNum { get; set; }

        [DataMember(Name = "scout")]
        public object Scout { get; set; }
    }
}
