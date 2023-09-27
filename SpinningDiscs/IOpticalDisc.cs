using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinningDiscs
{
    internal interface IOpticalDisc
    {
        //not sure if these behaviors are all supposed to say void or what
        void SpinDisc();
        void laserReadData();

        //not sure if these belong in here...
        void laserWriteData();
        void readDiscReport();
    }
}
