using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    [DataContract]
    class Partida
    {
        public Partida()
        {
        }

        public Partida(long PartidaId, long ClubeCasaId, int ClubeCasaPosicao, long ClubeVisitanteId,
            string[] AproveitamentoMandante, string[] AproveitamentoVisitante, int ClubeVisitantePosicao,
            string PartidaData, string Local, bool Valida, string PlacarOficialMandante, string PlacarOficialVisitante,
            string UrlConfronto, string UrlTransmissao)
        {
            this.PartidaId = PartidaId;
            this.ClubeCasaId = ClubeCasaId;
            this.ClubeCasaPosicao = ClubeCasaPosicao;
            this.ClubeVisitanteId = ClubeVisitanteId;
            this.AproveitamentoMandante = AproveitamentoMandante;
            this.AproveitamentoVisitante = AproveitamentoVisitante;
            this.ClubeVisitantePosicao = ClubeVisitantePosicao;
            this.PartidaData = PartidaData;
            this.Local = Local;
            this.Valida = Valida;
            this.PlacarOficialMandante = PlacarOficialMandante;
            this.PlacarOficialVisitante = PlacarOficialVisitante;
            this.UrlConfronto = UrlConfronto;
            this.UrlTransmissao = UrlTransmissao;
        }

        [DataMember(Name = "partida_id")]
        public long PartidaId { get; set; }

        public Clube ClubeCasa { get; set; }

        [DataMember(Name = "clube_casa_id")]
        public long ClubeCasaId { get; set; }

        [DataMember(Name = "clube_casa_posicao")]
        public int ClubeCasaPosicao { get; set; }

        public Clube ClubeVisitante { get; set; }

        [DataMember(Name = "clube_visitante_id")]
        public long ClubeVisitanteId { get; set; }

        [DataMember(Name = "aproveitamento_mandante")]
        public string[] AproveitamentoMandante { get; set; }

        [DataMember(Name = "aproveitamento_visitante")]
        public string[] AproveitamentoVisitante { get; set; }

        [DataMember(Name = "clube_visitante_posicao")]
        public int ClubeVisitantePosicao { get; set; }

        [DataMember(Name = "partida_data")]
        public string PartidaData { get; set; }

        [DataMember(Name = "local")]
        public string Local { get; set; }

        [DataMember(Name = "valida")]
        public bool Valida { get; set; }

        [DataMember(Name = "placar_oficial_mandante")]
        public string PlacarOficialMandante { get; set; }

        [DataMember(Name = "placar_oficial_visitante")]
        public string PlacarOficialVisitante { get; set; }

        [DataMember(Name = "url_confronto")]
        public string UrlConfronto { get; set; }

        [DataMember(Name = "url_transmissao")]
        public string UrlTransmissao { get; set; }
    }
}
