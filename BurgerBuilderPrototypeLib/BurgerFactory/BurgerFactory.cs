using BurgerBuilderPrototypeLib.Prototypes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilderPrototypeLib.BurgerFactory
{
     public class BurgerFactory
     {
        public static Hamburger MakeHamburger(string path)
        {
            return new Hamburger(new Bitmap(path), "Hamburger");
        }

        public static McChicken MakeMcChicken(string path)
        {
            return new McChicken(new Bitmap(path), "McChicken");
        }

        public static FiletOFish MakeFiletOFish(string path)
        {
            return new FiletOFish(new Bitmap(path), "FiletOFish");
        }
    }
}
