using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilderPrototypeLib.Prototypes
{
    public class FiletOFish : IBurger
    {
        public Image img;
        public string name;

        public FiletOFish(Image img, string name)
        {
            this.img = img;
            this.name = name;
        }

        public IBurger Clone()
        {
            return new FiletOFish(img, name);
        }
    }
}
