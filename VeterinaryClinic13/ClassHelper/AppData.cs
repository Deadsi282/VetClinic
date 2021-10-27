using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryClinic13.ClassHelper
{
    class AppData
    {
        public static EF.Entities context { get; } = new EF.Entities();
    }
}
