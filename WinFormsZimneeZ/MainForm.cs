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
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
            comboBoxFormulas.Items.Add("Равноускоренное движение");
            comboBoxFormulas.Items.Add("Другая формула");
            comboBoxFormulas.SelectedIndex = 0; // Установим первый элемент по умолчанию
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Основная категория
            TreeNode molecularNode = new TreeNode("Молекулярно-кинетическое движение");

            // Подкатегория для Молекулярно-кинетического движения
            TreeNode mechanicalNode = new TreeNode("Механическое движение");

            // Подкатегория для Механического движения
            TreeNode uniformAccelerationNode = new TreeNode("Равноускоренное движение");

            // Добавляем основные категории в TreeView
            treeViewFormulas.Nodes.Add(molecularNode);

            // Добавляем подкатегории в механическое движение
            molecularNode.Nodes.Add(mechanicalNode);

            // 
            mechanicalNode.Nodes.Add(uniformAccelerationNode);

            // Разворачиваем дерево
            treeViewFormulas.ExpandAll();
        }

        private void treeViewFormulas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Очищаем поле перед обновлением
            lblFormula.Text = "";

            // Определяем, какая формула выбрана
            switch (e.Node.Text)
            {
                case "Равноускоренное движение":
                    lblFormula.Text = "s = v₀ * t + (1/2) * a * t²";
                    break;
                case "Другая формула":
                    lblFormula.Text = "Формула для другой категории";
                    break;
                default:
                    lblFormula.Text = "Выберите формулу для отображения";
                    break;
            }
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
