using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDexx
{
    public class Unown : Pokemon
    {
        public Unown() 
        {
            this.Type = PokemonType.psychic;
            this.Height = 0.5;
            this.Weight = 5.0;
            this.HP = 48;
            this.Attack = 72;
            this.Defense = 48;
            this.SpecialAttack = 72;
            this.SpecialDefense = 48;
            this.Speed = 48;
            this.Total = 336;
            this.Name = "Unown";
            this.image = Resource1.ResourceManager.GetObject("Unown") as byte[] ?? Array.Empty<byte>();
        }
    }
}
