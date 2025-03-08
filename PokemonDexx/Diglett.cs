using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDexx
{
    public class Diglett : Pokemon
    {
        public Diglett() 
        {
            this.Type = PokemonType.ground;
            this.Height = 2.1;
            this.Weight = 0.2;
            this.HP = 10;
            this.Attack = 55;
            this.Defense = 25;
            this.SpecialAttack = 35;
            this.SpecialDefense = 45;
            this.Speed = 95;
            this.Total = 265;
            this.Name = "Diglett";
            this.image = Resource1.ResourceManager.GetObject("Diglett") as byte[] ?? Array.Empty<byte>();
        }

    }
}
