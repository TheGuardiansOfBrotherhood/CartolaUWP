using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    [DataContract]
    public class Patrocinador
    {
        public Patrocinador()
        {
        }

        public Patrocinador(long LigaEditorialId, long LigaId, int ServicoCadun, string CorNomeLiga, string TipoRanking,
            string UrlLink, string UrlEditoriaGe, int PosicaoInicial, string AutorizacaoPromocao, string ImgBackground,
            string ImgMarcaPatrocinador, string ImgMarcaPatrocinadorPng, string Nome, bool Optin, string UrlTermoUso)
        {
            this.LigaEditorialId = LigaEditorialId;
            this.LigaId = LigaId;
            this.ServicoCadun = ServicoCadun;
            this.CorNomeLiga = CorNomeLiga;
            this.TipoRanking = TipoRanking;
            this.UrlLink = UrlLink;
            this.UrlEditoriaGe = UrlEditoriaGe;
            this.PosicaoInicial = PosicaoInicial;
            this.AutorizacaoPromocao = AutorizacaoPromocao;
            this.ImgBackground = ImgBackground;
            this.ImgMarcaPatrocinador = ImgMarcaPatrocinador;
            this.ImgMarcaPatrocinadorPng = ImgMarcaPatrocinadorPng;
            this.Nome = Nome;
            this.Optin = Optin;
            this.UrlTermoUso = UrlTermoUso;
        }

        [DataMember(Name = "liga_editorial_id")]
        public long LigaEditorialId { get; set; }

        [DataMember(Name = "liga_id")]
        public long LigaId { get; set; }

        [DataMember(Name = "servico_cadun")]
        public int ServicoCadun { get; set; }

        [DataMember(Name = "cor_nome_liga")]
        public string CorNomeLiga { get; set; }

        [DataMember(Name = "tipo_ranking")]
        public string TipoRanking { get; set; }

        [DataMember(Name = "url_link")]
        public string UrlLink { get; set; }

        [DataMember(Name = "url_editoria_ge")]
        public string UrlEditoriaGe { get; set; }

        [DataMember(Name = "posicao_inicial")]
        public int PosicaoInicial { get; set; }

        [DataMember(Name = "autorizacao_promocao")]
        public string AutorizacaoPromocao { get; set; }

        [DataMember(Name = "img_background")]
        public string ImgBackground { get; set; }

        [DataMember(Name = "img_marca_patrocinador")]
        public string ImgMarcaPatrocinador { get; set; }

        [DataMember(Name = "img_marca_patrocinador_png")]
        public string ImgMarcaPatrocinadorPng { get; set; }

        [DataMember(Name = "nome")]
        public string Nome { get; set; }

        [DataMember(Name = "optin")]
        public bool Optin { get; set; }

        [DataMember(Name = "url_termo_uso")]
        public string UrlTermoUso { get; set; }
    }
}
