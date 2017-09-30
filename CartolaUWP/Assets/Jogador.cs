using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP.Assets
{
    class Jogador
    {
        public Jogador(){}

        public Jogador(string Nome, string Clube, string Posisao, string FotoClube)
        {
            this.Nome = Nome;
            this.Clube = Clube;
            this.Posicao = Posicao;
            this.FotoClube = FotoClube;
        }
        
        public string Nome { get; set; }

        public string Clube { get; set; }

        public string Posicao { get; set; }

        public string FotoClube { get; set; }

    }
}
