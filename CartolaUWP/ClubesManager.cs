using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartolaUWP
{
    class ClubesManager
    {
        public ClubesManager()
        {
            Clubes = new List<Clube>();
            SearchKey = "";
            Times = new List<Time>();
        }

        public List<Clube> Clubes { get; set; }

        public String SearchKey { get; set; }

        public List<Time> Times { get; set; }
    }
}
