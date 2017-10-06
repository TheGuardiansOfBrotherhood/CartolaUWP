using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    [DataContract]
    class Time
    {
        public Time()
        {
        }

        public Time(long TimeId, string Nome, string NomeCartola, string Slug, long FacebookId, string UrlEscudoPng,
            string UrlEscudoSvg, string UrlEscudoPlaceholderPng, string FotoPerfil, bool Assinante)
        {
            this.TimeId = TimeId;
            this.Nome = Nome;
            this.NomeCartola = NomeCartola;
            this.Slug = Slug;
            this.FacebookId = FacebookId;
            this.UrlEscudoPng = UrlEscudoPng;
            this.UrlEscudoSvg = UrlEscudoSvg;
            this.UrlEscudoPlaceholderPng = UrlEscudoPlaceholderPng;
            this.FotoPerfil = FotoPerfil;
            this.Assinante = Assinante;
        }

        [DataMember(Name = "time_id")]
        public long TimeId { get; set; }

        [DataMember(Name = "nome")]
        public string Nome { get; set; }

        [DataMember(Name = "nome_cartola")]
        public string NomeCartola { get; set; }

        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        [DataMember(Name = "facebook_id")]
        public long? FacebookId { get; set; }

        [DataMember(Name = "url_escudo_png")]
        public string UrlEscudoPng { get; set; }

        [DataMember(Name = "url_escudo_svg")]
        public string UrlEscudoSvg { get; set; }

        [DataMember(Name = "url_escudo_placeholder_png")]
        public string UrlEscudoPlaceholderPng { get; set; }

        [DataMember(Name = "foto_perfil")]
        public string FotoPerfil { get; set; }

        [DataMember(Name = "assinante")]
        public bool Assinante { get; set; }
    }
}
