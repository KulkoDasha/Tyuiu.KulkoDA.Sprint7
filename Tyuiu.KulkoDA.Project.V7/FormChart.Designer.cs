namespace Tyuiu.KulkoDA.Project.V7
{
    partial class FormChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChart));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chart_KDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxInChart_KDA = new GroupBox();
            textBoxY_KDA = new TextBox();
            textBoxX_KDA = new TextBox();
            buttonDoneChart_KDA = new Button();
            textBoxYIn_KDA = new TextBox();
            textBoxXIn_KDA = new TextBox();
            buttonOpen_KDA = new Button();
            ((System.ComponentModel.ISupportInitialize)chart_KDA).BeginInit();
            groupBoxInChart_KDA.SuspendLayout();
            SuspendLayout();
            // 
            // chart_KDA
            // 
            chart_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chart_KDA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_KDA.Legends.Add(legend1);
            chart_KDA.Location = new Point(201, 26);
            chart_KDA.Name = "chart_KDA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_KDA.Series.Add(series1);
            chart_KDA.Size = new Size(506, 344);
            chart_KDA.TabIndex = 0;
            // 
            // groupBoxInChart_KDA
            // 
            groupBoxInChart_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxInChart_KDA.Controls.Add(textBoxY_KDA);
            groupBoxInChart_KDA.Controls.Add(textBoxX_KDA);
            groupBoxInChart_KDA.Controls.Add(buttonDoneChart_KDA);
            groupBoxInChart_KDA.Controls.Add(textBoxYIn_KDA);
            groupBoxInChart_KDA.Controls.Add(textBoxXIn_KDA);
            groupBoxInChart_KDA.Location = new Point(12, 71);
            groupBoxInChart_KDA.Name = "groupBoxInChart_KDA";
            groupBoxInChart_KDA.Size = new Size(174, 288);
            groupBoxInChart_KDA.TabIndex = 1;
            groupBoxInChart_KDA.TabStop = false;
            groupBoxInChart_KDA.Text = "Ввод данных:";
            // 
            // textBoxY_KDA
            // 
            textBoxY_KDA.Location = new Point(6, 95);
            textBoxY_KDA.Name = "textBoxY_KDA";
            textBoxY_KDA.ReadOnly = true;
            textBoxY_KDA.Size = new Size(126, 23);
            textBoxY_KDA.TabIndex = 6;
            textBoxY_KDA.Text = "Введите имя столбца\r\n\r\n";
            // 
            // textBoxX_KDA
            // 
            textBoxX_KDA.Location = new Point(6, 22);
            textBoxX_KDA.Name = "textBoxX_KDA";
            textBoxX_KDA.ReadOnly = true;
            textBoxX_KDA.Size = new Size(126, 23);
            textBoxX_KDA.TabIndex = 5;
            textBoxX_KDA.Text = "Введите имя столбца\r\n\r\n";
            // 
            // buttonDoneChart_KDA
            // 
            buttonDoneChart_KDA.Location = new Point(6, 167);
            buttonDoneChart_KDA.Name = "buttonDoneChart_KDA";
            buttonDoneChart_KDA.Size = new Size(87, 42);
            buttonDoneChart_KDA.TabIndex = 4;
            buttonDoneChart_KDA.Text = "Выполнить";
            buttonDoneChart_KDA.UseVisualStyleBackColor = true;
            buttonDoneChart_KDA.Click += buttonDoneChart_KDA_Click;
            // 
            // textBoxYIn_KDA
            // 
            textBoxYIn_KDA.Location = new Point(6, 124);
            textBoxYIn_KDA.Name = "textBoxYIn_KDA";
            textBoxYIn_KDA.Size = new Size(100, 23);
            textBoxYIn_KDA.TabIndex = 3;
            // 
            // textBoxXIn_KDA
            // 
            textBoxXIn_KDA.Location = new Point(6, 51);
            textBoxXIn_KDA.Name = "textBoxXIn_KDA";
            textBoxXIn_KDA.Size = new Size(100, 23);
            textBoxXIn_KDA.TabIndex = 2;
            // 
            // buttonOpen_KDA
            // 
            buttonOpen_KDA.Image = (Image)resources.GetObject("buttonOpen_KDA.Image");
            buttonOpen_KDA.Location = new Point(12, 12);
            buttonOpen_KDA.Name = "buttonOpen_KDA";
            buttonOpen_KDA.Size = new Size(66, 53);
            buttonOpen_KDA.TabIndex = 4;
            buttonOpen_KDA.UseVisualStyleBackColor = true;
            // 
            // FormChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 371);
            Controls.Add(buttonOpen_KDA);
            Controls.Add(groupBoxInChart_KDA);
            Controls.Add(chart_KDA);
            Name = "FormChart";
            Text = "График";
            ((System.ComponentModel.ISupportInitialize)chart_KDA).EndInit();
            groupBoxInChart_KDA.ResumeLayout(false);
            groupBoxInChart_KDA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_KDA;
        private GroupBox groupBoxInChart_KDA;
        private TextBox textBoxYIn_KDA;
        private TextBox textBoxXIn_KDA;
        private Button buttonDoneChart_KDA;
        private TextBox textBoxX_KDA;
        private TextBox textBoxY_KDA;
        private Button buttonOpen_KDA;
    }
}