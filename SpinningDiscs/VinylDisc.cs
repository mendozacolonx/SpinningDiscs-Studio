using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinningDiscs
{
    public class VinylDisc : BaseDisc 
    { 
        public string discType = "Vinyl";
        public double minSpinRate = 33;
        public double maxSpinRate = 78;

        //cd stores in mb (700mb = 0.7gb), dvd stores in gb (17gb), vinyl stores 440mb = .44gb
        public double Capacity = .44;

        public VinylDisc(string Name, List<string> Contents, string discType, double Capacity) : base(Name, Capacity, Contents, discType)
        {

        }

        public void SpinDisc()
        {
            Console.WriteLine("A Vinyl disc has a spin rate of " + minSpinRate + " - " + maxSpinRate + " rpm. \n");
        }

        public void displayReadData()
        {
            Console.WriteLine(readDiscReport());
            Console.WriteLine("Here is a list of the tracks on this Vinyl Disc: " + laserReadData());
        }
    }
}
