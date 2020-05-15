namespace imit14
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.FirstMethodBtn = new System.Windows.Forms.Button();
            this.SecondMethodBtn = new System.Windows.Forms.Button();
            this.ThirdMethodBtn = new System.Windows.Forms.Button();
            this.Mean = new System.Windows.Forms.NumericUpDown();
            this.Var = new System.Windows.Forms.NumericUpDown();
            this.NumExp = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StatPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AverageLbl = new System.Windows.Forms.Label();
            this.VarianceLbl = new System.Windows.Forms.Label();
            this.Chi1Lbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Mean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Var)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.StatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstMethodBtn
            // 
            this.FirstMethodBtn.Location = new System.Drawing.Point(16, 157);
            this.FirstMethodBtn.Name = "FirstMethodBtn";
            this.FirstMethodBtn.Size = new System.Drawing.Size(75, 23);
            this.FirstMethodBtn.TabIndex = 0;
            this.FirstMethodBtn.Text = "Method1";
            this.FirstMethodBtn.UseVisualStyleBackColor = true;
            this.FirstMethodBtn.Click += new System.EventHandler(this.FirstMethodBtn_Click);
            // 
            // SecondMethodBtn
            // 
            this.SecondMethodBtn.Location = new System.Drawing.Point(16, 212);
            this.SecondMethodBtn.Name = "SecondMethodBtn";
            this.SecondMethodBtn.Size = new System.Drawing.Size(75, 23);
            this.SecondMethodBtn.TabIndex = 1;
            this.SecondMethodBtn.Text = "Method2";
            this.SecondMethodBtn.UseVisualStyleBackColor = true;
            this.SecondMethodBtn.Click += new System.EventHandler(this.SecondMethodBtn_Click);
            // 
            // ThirdMethodBtn
            // 
            this.ThirdMethodBtn.Location = new System.Drawing.Point(16, 261);
            this.ThirdMethodBtn.Name = "ThirdMethodBtn";
            this.ThirdMethodBtn.Size = new System.Drawing.Size(75, 23);
            this.ThirdMethodBtn.TabIndex = 2;
            this.ThirdMethodBtn.Text = "Method3";
            this.ThirdMethodBtn.UseVisualStyleBackColor = true;
            this.ThirdMethodBtn.Click += new System.EventHandler(this.ThirdMethodBtn_Click);
            // 
            // Mean
            // 
            this.Mean.Location = new System.Drawing.Point(90, 12);
            this.Mean.Name = "Mean";
            this.Mean.Size = new System.Drawing.Size(85, 20);
            this.Mean.TabIndex = 3;
            // 
            // Var
            // 
            this.Var.Location = new System.Drawing.Point(90, 47);
            this.Var.Name = "Var";
            this.Var.Size = new System.Drawing.Size(85, 20);
            this.Var.TabIndex = 4;
            // 
            // NumExp
            // 
            this.NumExp.Location = new System.Drawing.Point(112, 95);
            this.NumExp.Name = "NumExp";
            this.NumExp.Size = new System.Drawing.Size(79, 20);
            this.NumExp.TabIndex = 5;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(197, 12);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(601, 354);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Average";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Variance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number of exp-s/";
            // 
            // StatPanel
            // 
            this.StatPanel.Controls.Add(this.label8);
            this.StatPanel.Controls.Add(this.label6);
            this.StatPanel.Controls.Add(this.AverageLbl);
            this.StatPanel.Controls.Add(this.VarianceLbl);
            this.StatPanel.Controls.Add(this.Chi1Lbl);
            this.StatPanel.Controls.Add(this.label14);
            this.StatPanel.Location = new System.Drawing.Point(197, 404);
            this.StatPanel.Name = "StatPanel";
            this.StatPanel.Size = new System.Drawing.Size(601, 151);
            this.StatPanel.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Variance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Average: ";
            // 
            // AverageLbl
            // 
            this.AverageLbl.AutoSize = true;
            this.AverageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AverageLbl.Location = new System.Drawing.Point(85, 12);
            this.AverageLbl.Name = "AverageLbl";
            this.AverageLbl.Size = new System.Drawing.Size(18, 20);
            this.AverageLbl.TabIndex = 14;
            this.AverageLbl.Text = "0";
            // 
            // VarianceLbl
            // 
            this.VarianceLbl.AutoSize = true;
            this.VarianceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VarianceLbl.Location = new System.Drawing.Point(85, 62);
            this.VarianceLbl.Name = "VarianceLbl";
            this.VarianceLbl.Size = new System.Drawing.Size(18, 20);
            this.VarianceLbl.TabIndex = 16;
            this.VarianceLbl.Text = "0";
            // 
            // Chi1Lbl
            // 
            this.Chi1Lbl.AutoSize = true;
            this.Chi1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chi1Lbl.Location = new System.Drawing.Point(142, 117);
            this.Chi1Lbl.Name = "Chi1Lbl";
            this.Chi1Lbl.Size = new System.Drawing.Size(18, 20);
            this.Chi1Lbl.TabIndex = 22;
            this.Chi1Lbl.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(15, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "Chi-Squared:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 583);
            this.Controls.Add(this.StatPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.NumExp);
            this.Controls.Add(this.Var);
            this.Controls.Add(this.Mean);
            this.Controls.Add(this.ThirdMethodBtn);
            this.Controls.Add(this.SecondMethodBtn);
            this.Controls.Add(this.FirstMethodBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Mean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Var)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.StatPanel.ResumeLayout(false);
            this.StatPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FirstMethodBtn;
        private System.Windows.Forms.Button SecondMethodBtn;
        private System.Windows.Forms.Button ThirdMethodBtn;
        private System.Windows.Forms.NumericUpDown Mean;
        private System.Windows.Forms.NumericUpDown Var;
        private System.Windows.Forms.NumericUpDown NumExp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel StatPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AverageLbl;
        private System.Windows.Forms.Label VarianceLbl;
        private System.Windows.Forms.Label Chi1Lbl;
        private System.Windows.Forms.Label label14;
    }
}

