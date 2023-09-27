using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinningDiscs
{
    public class FloppyDsic : BaseDisc
    {
        public string discType = "Vinyl";
        public double minSpinRate = 300;
        public double maxSpinRate = 360;

        //cd stores in mb (700mb = 0.7gb), dvd stores in gb (17gb), vinyl stores 440mb = .44gb, floppy commonly used 2.8 mb = .0028
        public double Capacity = .0028;

        public FloppyDsic(string Name, List<string> Contents, string discType, double Capacity) : base(Name, Capacity, Contents, discType)
        {

        }

        public void SpinDisc()
        {
            Console.WriteLine("A Floppy disc has a spin rate of " + minSpinRate + " - " + maxSpinRate + " rpm. \n");
        }

        public void displayReadData()
        {
            Console.WriteLine(readDiscReport());
            Console.WriteLine("Here is a list of the data on this Floppy Disc: " + laserReadData());
        }
    }
}

