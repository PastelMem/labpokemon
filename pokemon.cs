using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labpokemon
{
    public class pokemon
    {
        protected int id;
        protected string name;
        protected Image pic;
        protected int level;
        protected PokemonType type;
        protected PokemonAbilities abilities;
        protected int hp;
        protected int att;
        protected int def;
        protected int sAtt;
        protected int sDef;
        protected int speed;

        public string Name()
        {
            return name;
        }
        public Image picture()
        {
            return pic;
        }
        public enum PokemonType
        {
            Grass, poison, Electr, fairy, normal, water, dragon, fire, flying, dark, ice,
        }
        public enum PokemonAbilities
        {
            Overgorw, ChlorophyII,Lightning, blaze, solarpower, SwordofRuin, Comatose, sapsipper, hugepower, thickfat, pressure, multitype
        }
    }
}
