using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDexx
{
    public class Luvdisc : Pokemon
    {
        public Luvdisc() 
        {
            this.Type = PokemonType.water;
            this.Height = 0.6;
            this.Weight = 8.7;
            this.HP = 43;
            this.Attack = 30;
            this.Defense = 55;
            this.SpecialAttack = 40;
            this.SpecialDefense = 65;
            this.Speed = 97;
            this.Total = 330;
            this.Name = "Luvdisc";
            this.image = Resource1.ResourceManager.GetObject("Luvdisc") as byte[] ?? Array.Empty<byte>();
        }
    }
}
