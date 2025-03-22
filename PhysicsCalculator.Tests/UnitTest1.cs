using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLib;

namespace PhysicsCalculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UniformlyAcceleratedMotion_Calculate_CorrectResult()
        {
            // Arrange
            var formula = new UniformlyAcceleratedMotion();
            var parameters = new Dictionary<string, double>
            {
                { "v0", 5 },  // Начальная скорость (м/с)
                { "t", 10 },  // Время (с)
                { "a", 2 }    // Ускорение (м/с²)
            };
            double expected = 5 * 10 + 0.5 * 2 * 10 * 10; // 5 * 10 + 0.5 * 2 * 100 = 50 + 100 = 150 м

            // Act
            double actual = formula.Calculate(parameters);

            // Assert
            Assert.AreEqual(expected, actual, 0.001, "Расчет неверный для равноускоренного движения.");
        }

        [TestMethod]
        public void VelocityFormula_Calculate_CorrectResult()
        {
            // Arrange
            var formula = new VelocityFormula();
            var parameters = new Dictionary<string, double>
            {
                { "v0", 5 },  // Начальная скорость (м/с)
                { "t", 10 },  // Время (с)
                { "a", 2 }    // Ускорение (м/с²)
            };
            double expected = 5 + 2 * 10; // 5 + 20 = 25 м/с

            // Act
            double actual = formula.Calculate(parameters);

            // Assert
            Assert.AreEqual(expected, actual, 0.001, "Расчет неверный для скорости при равноускоренном движении.");
        }

        [TestMethod]
        public void FormulaManager_GetFormulaByName_ReturnsCorrectFormula()
        {
            // Arrange
            var formulaManager = new FormulaManager();
            var formula = new UniformlyAcceleratedMotion();
            formulaManager.RegisterFormula(formula);

            // Act
            var retrievedFormula = formulaManager.GetFormulaByName("Равноускоренное движение");

            // Assert
            Assert.IsNotNull(retrievedFormula, "Формула не найдена.");
            Assert.AreEqual(formula.Name, retrievedFormula.Name, "Названия формул не совпадают.");
        }
    }
}
