using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextovaHra
{
    public class Bod
    {
        Lokace lokace = new Lokace();

        public int X { get; set; }
        public int Y { get; set; }
        public Bod(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return lokace.herniProstredi[X, Y].ToString();
        }
        public void ZmenaSouradnic(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
