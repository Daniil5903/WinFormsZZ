using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public abstract class PhysicalFormula
    {
        public string Name { get; }
        public string SymbolicRepresentation { get; }
        public Dictionary<string, string> Units { get; }

        protected PhysicalFormula(string name, string symbolicRepresentation, Dictionary<string, string> units)
        {
            Name = name;
            SymbolicRepresentation = symbolicRepresentation;
            Units = units;
        }

        public abstract double Calculate(Dictionary<string, double> parameters);
    }
}
