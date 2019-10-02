using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemonapi
{
    class Pokespecs
    {
        public int height { get; set; }
        public int weight { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return $"{name} is {height} cm tall and weighs {weight} lbs";
        }
    }
}
