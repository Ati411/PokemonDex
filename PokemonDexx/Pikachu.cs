using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDexx
{
    public class Pikachu : Pokemon
    {
        public Pikachu()
        {
            this.Type = PokemonType.electric;
            this.Height = 0.4;
            this.Weight = 6.0;
            this.HP = 35;
            this.Attack = 55;
            this.Defense = 40;
            this.SpecialAttack = 50;
            this.SpecialDefense = 50;
            this.Speed = 90;
            this.Total = 320;
            this.Name = "Pikachu";
            this.image = Resource1.ResourceManager.GetObject("Pikachu") as byte[] ?? Array.Empty<byte>();
        }
    }
}
