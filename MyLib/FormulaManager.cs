    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class FormulaManager
    {
        private List<PhysicalFormula> formulas = new List<PhysicalFormula>();

        public void RegisterFormula(PhysicalFormula formula)
        {
            formulas.Add(formula);
        }

        public PhysicalFormula GetFormulaByName(string name)
        {
            return formulas.FirstOrDefault(f => f.Name == name);
        }
    }
}
