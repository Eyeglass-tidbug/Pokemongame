using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Game
{
    internal class deoxy : Pokemon
    {
        public deoxy()
        {
            Random random = new Random();
            this.name = "Deoxy";
            this.HP = random.Next(430, 525);
            this._image = Properties.Resources.deoxy;
            this.Attack = random.Next(202, 351);
            this.Defense = random.Next(121, 252);
        }
    }
}
