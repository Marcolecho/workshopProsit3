using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib;

namespace workshopProsit3
{
    internal class Model
    {
        public string ConvertToUpper(string lowerString)
        {
            PartageFunction pt = new PartageFunction();
            return pt.ToUpperFunction(lowerString);
        }
    }
}
