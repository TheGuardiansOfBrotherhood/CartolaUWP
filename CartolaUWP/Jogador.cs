using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    class Jogador
    {
        public Jogador() { }

        public Jogador(string Nome, string Escudo, string Posicao, string Clube)
        {
            this.Nome = Nome;
            this.Clube = Clube;
            this.Escudo = Escudo;
            this.Posicao = Posicao;
        }
        public string Nome { get; set; }
        public string Escudo { get; set; }
        public string Posicao { get; set; }
        public string Clube { get; set; }
       
    }

    

}
