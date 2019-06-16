using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionInterfaces
{
    class Television : IElectronicDevice
    {
        public int Volume { get; set; }
        public void Off()
        {
            Console.WriteLine("The tv is off");
        }

        public void On()
        {
            Console.WriteLine("The tv is onn");
        }

        public void VolumeDown()
        {
            if (Volume != 0) Volume--;
            Console.WriteLine("The tv volume is at " + Volume);
           
        }

        public void VolumeUp()
        {
            if (Volume != 100) Volume++;
            Console.WriteLine("The tv volume is at " + Volume);
        }
    }
}
