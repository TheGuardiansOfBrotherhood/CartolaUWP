using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    [DataContract]
    class MitoRodada
    {
        public MitoRodada()
        {
        }

        public MitoRodada(long TimeId, long ClubeId, long EsquemaId, long CadunId, long FacebookId, string FotoPerfil,
            string Nome, string NomeCartola, string Slug, int TipoEscudo, string CorFundoEscudo, string CorBordaEscudo,
            string CorPrimariaEstampaEscudo, string CorSecundariaEstampaEscudo, string UrlEscudoSvg, string UrlEscudoPng,
            string UrlCamisaSvg, string UrlCamisaPng, string UrlEscudoPlaceholderPng, string UrlCamisaPlaceholderPng,
            int TipoEstampaEscudo, int TipoAdorno, int TipoCamisa, int TipoEstampaCamisa, string CorCamisa,
            string CorPrimariaEstampaCamisa, string CorSecundariaEstampaCamisa, long RodadaTimeId, bool Assinante,
            bool CadastroCompleto, long Patrocinador1Id, long Patrocinador2Id, int TemporadaInicial, bool Simplificado)
        {
            this.TimeId = TimeId;
            this.ClubeId = ClubeId;
            this.EsquemaId = EsquemaId;
            this.CadunId = CadunId;
            this.FacebookId = FacebookId;
            this.FotoPerfil = FotoPerfil;
            this.Nome = Nome;
            this.NomeCartola = NomeCartola;
            this.Slug = Slug;
            this.TipoEscudo = TipoEscudo;
            this.CorFundoEscudo = CorFundoEscudo;
            this.CorBordaEscudo = CorBordaEscudo;
            this.CorPrimariaEstampaEscudo = CorPrimariaEstampaEscudo;
            this.CorSecundariaEstampaEscudo = CorSecundariaEstampaEscudo;
            this.UrlEscudoSvg = UrlEscudoSvg;
            this.UrlEscudoPng = UrlEscudoPng;
            this.UrlCamisaSvg = UrlCamisaSvg;
            this.UrlCamisaPng = UrlCamisaPng;
            this.UrlEscudoPlaceholderPng = UrlEscudoPlaceholderPng;
            this.UrlCamisaPlaceholderPng = UrlCamisaPlaceholderPng;
            this.TipoEstampaEscudo = TipoEstampaEscudo;
            this.TipoAdorno = TipoAdorno;
            this.TipoCamisa = TipoCamisa;
            this.TipoEstampaCamisa = TipoEstampaCamisa;
            this.CorCamisa = CorCamisa;
            this.CorPrimariaEstampaCamisa = CorPrimariaEstampaCamisa;
            this.CorSecundariaEstampaCamisa = CorSecundariaEstampaCamisa;
            this.RodadaTimeId = RodadaTimeId;
            this.Assinante = Assinante;
            this.CadastroCompleto = CadastroCompleto;
            this.Patrocinador1Id = Patrocinador1Id;
            this.Patrocinador2Id = Patrocinador2Id;
            this.TemporadaInicial = TemporadaInicial;
            this.Simplificado = Simplificado;
        }

        [DataMember(Name = "time_id")]
        public long TimeId { get; set; }

        [DataMember(Name = "clube_id")]
        public long ClubeId { get; set; }

        [DataMember(Name = "esquema_id")]
        public long EsquemaId { get; set; }

        [DataMember(Name = "cadun_id")]
        public long CadunId { get; set; }

        [DataMember(Name = "facebook_id")]
        public long FacebookId { get; set; }

        [DataMember(Name = "foto_perfil")]
        public string FotoPerfil { get; set; }

        [DataMember(Name = "nome")]
        public string Nome { get; set; }

        [DataMember(Name = "nome_cartola")]
        public string NomeCartola { get; set; }

        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        [DataMember(Name = "tipo_escudo")]
        public int TipoEscudo { get; set; }

        [DataMember(Name = "cor_fundo_escudo")]
        public string CorFundoEscudo { get; set; }

        [DataMember(Name = "cor_borda_escudo")]
        public string CorBordaEscudo { get; set; }

        [DataMember(Name = "cor_primaria_estampa_escudo")]
        public string CorPrimariaEstampaEscudo { get; set; }

        [DataMember(Name = "cor_secundaria_estampa_escudo")]
        public string CorSecundariaEstampaEscudo { get; set; }

        [DataMember(Name = "url_escudo_svg")]
        public string UrlEscudoSvg { get; set; }

        [DataMember(Name = "url_escudo_png")]
        public string UrlEscudoPng { get; set; }

        [DataMember(Name = "url_camisa_svg")]
        public string UrlCamisaSvg { get; set; }

        [DataMember(Name = "url_camisa_png")]
        public string UrlCamisaPng { get; set; }

        [DataMember(Name = "url_escudo_placeholder_png")]
        public string UrlEscudoPlaceholderPng { get; set; }

        [DataMember(Name = "url_camisa_placeholder_png")]
        public string UrlCamisaPlaceholderPng { get; set; }

        [DataMember(Name = "tipo_estampa_escudo")]
        public int TipoEstampaEscudo { get; set; }

        [DataMember(Name = "tipo_adorno")]
        public int TipoAdorno { get; set; }

        [DataMember(Name = "tipo_camisa")]
        public int TipoCamisa { get; set; }

        [DataMember(Name = "tipo_estampa_camisa")]
        public int TipoEstampaCamisa { get; set; }

        [DataMember(Name = "cor_camisa")]
        public string CorCamisa { get; set; }

        [DataMember(Name = "cor_primaria_estampa_camisa")]
        public string CorPrimariaEstampaCamisa { get; set; }

        [DataMember(Name = "cor_secundaria_estampa_camisa")]
        public string CorSecundariaEstampaCamisa { get; set; }

        [DataMember(Name = "rodada_time_id")]
        public long RodadaTimeId { get; set; }

        [DataMember(Name = "assinante")]
        public bool Assinante { get; set; }

        [DataMember(Name = "cadastro_completo")]
        public bool CadastroCompleto { get; set; }

        [DataMember(Name = "patrocinador1_id")]
        public long Patrocinador1Id { get; set; }

        [DataMember(Name = "patrocinador2_id")]
        public long Patrocinador2Id { get; set; }

        [DataMember(Name = "temporada_inicial")]
        public int TemporadaInicial { get; set; }

        [DataMember(Name = "simplificado")]
        public bool Simplificado { get; set; }
    }
}
