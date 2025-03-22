using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;

namespace WinFormsZimneeZ
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxFormulas.Items.Add("Равноускоренное движение");
            comboBoxFormulas.Items.Add("Другая формула");
            comboBoxFormulas.SelectedIndex = 0; // Установим первый элемент по умолчанию
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем значения из текстовых полей
                double v0 = Convert.ToDouble(txtV0.Text);
                double t = Convert.ToDouble(txtT.Text);
                double a = Convert.ToDouble(txtA.Text);

                // Выбираем нужную формулу
                PhysicalFormula formula;
                if (comboBoxFormulas.SelectedItem.ToString() == "Равноускоренное движение")
                {
                    formula = new UniformlyAcceleratedMotion();
                }
                else
                {
                    // Добавить другие формулы, когда они будут
                    MessageBox.Show("Формула не реализована");
                    return;
                }

                // Подготавливаем параметры
                var parameters = new Dictionary<string, double>
                {
                    { "v0", v0 },
                    { "t", t },
                    { "a", a }
                };

                // Выполняем расчет
                double result = formula.Calculate(parameters);
                lblResult.Text = "Результат: " + result.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
    
}
