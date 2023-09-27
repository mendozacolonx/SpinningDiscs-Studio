using Microsoft.VisualBasic;
using SpinningDiscs;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

// TODO: Declare and initialize a CD and a DVD object.

List<String> dvd1List = new List<String> { "act I", "act II", "act III" };
DVD myDvd = new DVD(
    "Rapuzenl",
    //this list needs to be declared before the object can be decalred. cannot be decalred within the object
    dvd1List,
    "DVD",
    10
    ) ;

List<String> cd1List = new List<String> { "track 1", "track 2", "track 3" };
CD myCd = new CD(
    "Midnights",
    cd1List,
    "CD",
    .6
    );

List<String> vinyl1List = new List<String> { "track 1", "track 2", "track 3" };
VinylDisc myVinylDisc = new VinylDisc(
    "Midnights",
    vinyl1List,
    "Vinyl",
    .04
    );

List<String> floppy1List = new List<String> { "a", "2", "!" };
FloppyDsic myFloppyDisc = new FloppyDsic(
    "Midnights",
    floppy1List,
    "Floppy",
    .001
    );
// TODO: Call each CD and DVD method to verify that they work as expected.

myCd.SpinDisc();
//Console.WriteLine(myCd.laserReadData());
myCd.laserWriteData(2);
//Console.WriteLine(myCd.readDiscReport());
myCd.displayReadData();

Console.WriteLine("-----------------------------------");

myDvd.SpinDisc();
//Console.WriteLine(myDvd.laserReadData());
myDvd.laserWriteData(2);
//Console.WriteLine(myDvd.readDiscReport());
myDvd.displayReadData();

Console.WriteLine("-----------------------------------");

myVinylDisc.SpinDisc();
//Console.WriteLine(myVinylDisc.laserReadData());
myVinylDisc.laserWriteData(.01);
//Console.WriteLine(myVinylDisc.readDiscReport());
myVinylDisc.displayReadData();

Console.WriteLine("-----------------------------------");

myFloppyDisc.SpinDisc();
//Console.WriteLine(myFloppyDisc.laserReadData());
myFloppyDisc.laserWriteData(001);
//Console.WriteLine(myFloppyDisc.readDiscReport());
myFloppyDisc.displayReadData();

Console.WriteLine("-----------------------------------");
