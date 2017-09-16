using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    [DataContract]
    class MercadoStatus
    {
        public MercadoStatus()
        {
        }

        public MercadoStatus(int RodadaAtual, int StatusMercado, int EsquemaDefaultId, int CartoletaInicial,
            int MaxLigasFree, int MaxLigasPro, int MaxLigasMatamataFree, int MaxLigasMatamataPro,
            int MaxLigasPatrocinadasFree, int MaxLigasPatrocinadasProNum, bool GameOver, int Temporada, bool Reativar,
            int TimesEscalados, Fechamento Fechamento, bool MercadoPosRodada, string Aviso, string AvisoUrl)
        {
            this.RodadaAtual = RodadaAtual;
            this.StatusMercado = StatusMercado;
            this.EsquemaDefaultId = EsquemaDefaultId;
            this.CartoletaInicial = CartoletaInicial;
            this.MaxLigasFree = MaxLigasFree;
            this.MaxLigasPro = MaxLigasPro;
            this.MaxLigasMatamataFree = MaxLigasMatamataFree;
            this.MaxLigasMatamataPro = MaxLigasMatamataPro;
            this.MaxLigasPatrocinadasFree = MaxLigasPatrocinadasFree;
            this.MaxLigasPatrocinadasProNum = MaxLigasPatrocinadasProNum;
            this.GameOver = GameOver;
            this.Temporada = Temporada;
            this.Reativar = Reativar;
            this.TimesEscalados = TimesEscalados;
            this.Fechamento = Fechamento;
            this.MercadoPosRodada = MercadoPosRodada;
            this.Aviso = Aviso;
            this.AvisoUrl = AvisoUrl;
        }

        [DataMember(Name = "rodada_atual")]
        public int RodadaAtual { get; set; }

        [DataMember(Name = "status_mercado")]
        public int StatusMercado { get; set; }

        [DataMember(Name = "esquema_default_id")]
        public int EsquemaDefaultId { get; set; }

        [DataMember(Name = "cartoleta_inicial")]
        public int CartoletaInicial { get; set; }

        [DataMember(Name = "max_ligas_free")]
        public int MaxLigasFree { get; set; }

        [DataMember(Name = "max_ligas_pro")]
        public int MaxLigasPro { get; set; }

        [DataMember(Name = "max_ligas_matamata_free")]
        public int MaxLigasMatamataFree { get; set; }

        [DataMember(Name = "max_ligas_matamata_pro")]
        public int MaxLigasMatamataPro { get; set; }

        [DataMember(Name = "max_ligas_patrocinadas_free")]
        public int MaxLigasPatrocinadasFree { get; set; }

        [DataMember(Name = "max_ligas_patrocinadas_pro_num")]
        public int MaxLigasPatrocinadasProNum { get; set; }

        [DataMember(Name = "game_over")]
        public bool GameOver { get; set; }

        [DataMember(Name = "temporada")]
        public int Temporada { get; set; }

        [DataMember(Name = "reativar")]
        public bool Reativar { get; set; }

        [DataMember(Name = "times_escalados")]
        public int TimesEscalados { get; set; }

        [DataMember(Name = "fechamento")]
        public Fechamento Fechamento { get; set; }

        [DataMember(Name = "mercado_pos_rodada")]
        public bool MercadoPosRodada { get; set; }

        [DataMember(Name = "aviso")]
        public string Aviso { get; set; }

        [DataMember(Name = "aviso_url")]
        public string AvisoUrl { get; set; }
    }
}
