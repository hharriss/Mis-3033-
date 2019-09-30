using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemonapi
{
    class PokeAbility
    {
       public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<AbilResult> results { get; set; }

    }
    class AbilResult
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
