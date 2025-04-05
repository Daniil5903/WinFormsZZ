namespace WinFormsZimneeZ
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeViewFormulas = new System.Windows.Forms.TreeView();
            this.lblFormula = new System.Windows.Forms.Label();
            this.lblV0 = new System.Windows.Forms.Label();
            this.txtV0 = new System.Windows.Forms.TextBox();
            this.lblT = new System.Windows.Forms.Label();
            this.txtT = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewFormulas
            // 
            this.treeViewFormulas.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewFormulas.Location = new System.Drawing.Point(0, 0);
            this.treeViewFormulas.Name = "treeViewFormulas";
            this.treeViewFormulas.Size = new System.Drawing.Size(366, 199);
            this.treeViewFormulas.TabIndex = 9;
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Location = new System.Drawing.Point(394, 3);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(61, 13);
            this.lblFormula.TabIndex = 10;
            this.lblFormula.Text = "Формула: ";
            this.lblFormula.Visible = false;
            // 
            // lblV0
            // 
            this.lblV0.AutoSize = true;
            this.lblV0.Location = new System.Drawing.Point(394, 50);
            this.lblV0.Name = "lblV0";
            this.lblV0.Size = new System.Drawing.Size(140, 13);
            this.lblV0.TabIndex = 11;
            this.lblV0.Text = "Начальная скорость (м/с)";
            this.lblV0.Visible = false;
            // 
            // txtV0
            // 
            this.txtV0.Location = new System.Drawing.Point(397, 84);
            this.txtV0.Name = "txtV0";
            this.txtV0.Size = new System.Drawing.Size(137, 20);
            this.txtV0.TabIndex = 12;
            this.txtV0.Visible = false;
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(559, 50);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(55, 13);
            this.lblT.TabIndex = 13;
            this.lblT.Text = "Время (с)";
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(562, 84);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(100, 20);
            this.txtT.TabIndex = 14;
            this.txtT.Visible = false;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(686, 50);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(94, 13);
            this.lblA.TabIndex = 15;
            this.lblA.Text = "Ускорение (м/с²)";
            this.lblA.Visible = false;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(689, 84);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 16;
            this.txtA.Visible = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(397, 146);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(559, 146);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(65, 13);
            this.lblResult.TabIndex = 18;
            this.lblResult.Text = "Результат: ";
            this.lblResult.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 199);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.txtV0);
            this.Controls.Add(this.lblV0);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.treeViewFormulas);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeViewFormulas;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label lblV0;
        private System.Windows.Forms.TextBox txtV0;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}

