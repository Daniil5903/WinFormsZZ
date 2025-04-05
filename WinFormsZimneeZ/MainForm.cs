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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Структура дерева
            TreeNode molecularNode = new TreeNode("Молекулярно-кинетическое движение");
            TreeNode mechanicalNode = new TreeNode("Механическое движение");
            TreeNode uniformlyAcceleratedNode = new TreeNode("Равноускоренное движение");

            // Вложенные узлы
            treeViewFormulas.Nodes.Add(molecularNode);
            molecularNode.Nodes.Add(mechanicalNode);
            mechanicalNode.Nodes.Add(uniformlyAcceleratedNode);

            treeViewFormulas.ExpandAll();

            // Прячем элементы справа
            SetCalculationControlsVisible(false);

            // Подключаем двойной клик
            treeViewFormulas.NodeMouseDoubleClick += treeViewFormulas_NodeMouseDoubleClick;
        }

        private void treeViewFormulas_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "Равноускоренное движение")
            {
                lblFormula.Text = "s = v₀ * t + (1/2) * a * t²";
                SetCalculationControlsVisible(true);
            }
            else
            {
                SetCalculationControlsVisible(false);
                lblFormula.Text = "Формула ещё не реализована.";
            }

            lblResult.Text = "";
        }

        private void SetCalculationControlsVisible(bool visible)
        {
            lblFormula.Visible = visible;
            txtV0.Visible = visible;
            txtT.Visible = visible;
            txtA.Visible = visible;
            lblV0.Visible = visible;
            lblT.Visible = visible;
            lblA.Visible = visible;
            btnCalculate.Visible = visible;
            lblResult.Visible = visible;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double v0 = Convert.ToDouble(txtV0.Text);
                double t = Convert.ToDouble(txtT.Text);
                double a = Convert.ToDouble(txtA.Text);

                var formula = new UniformlyAcceleratedMotion();
                var parameters = new Dictionary<string, double>
                {
                    { "v0", v0 },
                    { "t", t },
                    { "a", a }
                };

                MessageBox.Show("Начало расчёта"); // Временно для проверки
                double result = formula.Calculate(parameters);
                MessageBox.Show("Результат: " + result.ToString("F2") + " м", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
    
}
