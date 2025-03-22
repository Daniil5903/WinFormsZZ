using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class UniformlyAcceleratedMotion : PhysicalFormula
    {
        public UniformlyAcceleratedMotion()
            : base("Равноускоренное движение", "s = v0 * t + (1/2) * a * t^2",
                   new Dictionary<string, string> { { "s", "м" }, { "v0", "м/с" }, { "t", "с" }, { "a", "м/с²" } })
        { }

        public override double Calculate(Dictionary<string, double> parameters)
        {
            double v0 = parameters["v0"];
            double t = parameters["t"];
            double a = parameters["a"];
            return v0 * t + 0.5 * a * t * t;
        }
    }
}
