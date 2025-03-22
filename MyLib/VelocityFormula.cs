using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class VelocityFormula : PhysicalFormula
    {
        public VelocityFormula()
            : base("Скорость при равноускоренном движении", "v = v0 + a * t",
                   new Dictionary<string, string> { { "v", "м/с" }, { "v0", "м/с" }, { "t", "с" }, { "a", "м/с²" } })
        { }

        public override double Calculate(Dictionary<string, double> parameters)
        {
            double v0 = parameters["v0"];
            double t = parameters["t"];
            double a = parameters["a"];
            return v0 + a * t;
        }
    }

}
