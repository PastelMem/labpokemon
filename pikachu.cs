using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labpokemon
{
    public class pikachu : pokemon
    {
        public pikachu()
        {
            name = "pikachu";
            id = 1;
            level= 1;
            type = PokemonType.Electr;
        }
    }
}
