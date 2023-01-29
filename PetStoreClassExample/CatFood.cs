using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreClassExample
{
    public class CatFood : Product
    {
        public double WeightPounds;
        public bool KittenFood;

        public string HowMuchFood()
        {
            return WeightPounds + "lbs of food";
        }
    }
}
