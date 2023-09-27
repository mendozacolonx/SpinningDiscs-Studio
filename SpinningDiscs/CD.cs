﻿using System;

namespace SpinningDiscs
{
    public class CD : BaseDisc
    {
        // TODO: Implement your custom interface.
        // see above, :BsseDisc

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 

        //https://everpresent.com/difference-between-cds-and-dvds/#:~:text=A%20CD%20can%20store%20up,or%206%2B%20hours%20of%20video.

        public string discType = "CD";

        // 1.2- 1.4 m/s cd, 3.49-3.84 m/s
        //public double scanningVelocity = 1.2; 
        //example uses rpm, not m/s
        public double minSpinRate = 200;
        public double maxSpinRate = 500;

        //cd stores in mb (700mb = 0.7gb), dvd stores in gb (17gb)
        public double Capacity = .7;

        public CD(string Name, List<string> Contents, string discType, double Capacity) : base(Name, Capacity, Contents, discType)
        {

        }

        public void SpinDisc()
        {
            Console.WriteLine("A CD has a spin rate of " + minSpinRate + " - " + maxSpinRate + " rpm. \n");
        }

        //seems wrong/roundabout. makeing a method that prints the return information from a different called method
        public void displayReadData()
        {
            Console.WriteLine(readDiscReport());
            Console.WriteLine("Here is a list of the audio tracks on this CD: " + laserReadData());
        }
    }
}

