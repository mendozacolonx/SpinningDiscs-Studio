using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        //common behaviors of discs: spin, store data, laser write, laser read
        //common information: name, capacity, contents, disc type

        //properties
        public string Name;
        public double Capacity;
        public List<String> Contents { get; set; } = new List<String>();
        public string discType { get; set; }

        //step four storage ex
        public double storageUsed { get; set; }
        public double availableStorage { get; set; }


        public BaseDisc(string Name, double Capacity, List<string> Contents, string discType)
        {
            this.Name = Name;
            this.Capacity = Capacity;
            this.Contents = Contents;
            this.discType = discType;

            //step four storage ex
            this.storageUsed = 0;
            this.availableStorage = Capacity - storageUsed;
    }


        //methods
        public void laserWriteData( double fileSize)
        {
            //first need to validate for storage size
            //will need to include property on other discs for file size.
            if(this.availableStorage < fileSize)
            {
                Console.WriteLine("Your data file is too big to laser. Make some room in your storage for new information. \n");
            }
            else
            {
                storageUsed += fileSize;
                availableStorage -= fileSize;
                this.Contents.Add("1");
                Console.WriteLine(
                    "The data has been added. \n" +
                    "Your remaining available storage is: " + availableStorage + " GB. \n"
                    );
            }
        } 

        //hmmm not sure how i would actually do this when called
        public String laserReadData()
        {
            string information = "";
            foreach( String s in Contents )
            {
                //removed becuase i need to format for return
                //Console.WriteLine( s + "\n");

                //adding += instead of = fixed problem of only returning last item.
                information +="\n\t\t" + s;
            }
            //Console.WriteLine(information);

            //error because not returning anything

            return information;
        }

        //"not all code paths return a value."
        //need to make void, bc i dont want to return anything, just print info report.
        //changed back to sting and put inside a variable because when printing to soncsole "cannot convert void to bool"
        public string readDiscReport()
        {
          string report =
                "Disc Report: \n" +
                "\t Disc Name: " + this.Name + "\n" +
                "\t Contents: " + laserReadData() + "\n" +
                "\t Capacity: " + this.Capacity + "\n" +
                "\t Disc Type: " + this.discType +
                "\nEnd of Report\n"
                ;
            return report;
        }

    }
}
