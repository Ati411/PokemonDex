using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDexx
{
    public class Swirlix : Pokemon
    {
        public Swirlix() 
        {
            this.Type = PokemonType.fairy;
            this.Height = 0.4;
            this.Weight = 3.5;
            this.HP = 62;
            this.Attack = 48;
            this.Defense = 66;
            this.SpecialAttack = 59;
            this.SpecialDefense = 57;
            this.Speed = 49;
            this.Total = 341;
            this.Name = "Swirlix";
            this.image = Resource1.ResourceManager.GetObject("Swirlix") as byte[] ?? Array.Empty<byte>();
        }
    }
}
