namespace Tyuiu.KulkoDA.Project.V7
{
    partial class FormPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerson));
            textBoxName_KDA = new TextBox();
            groupBoxName_KDA = new GroupBox();
            buttonFind_KDA = new Button();
            buttonOpen_KDA = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            groupBoxDannye_KDA = new GroupBox();
            groupBoxName_KDA.SuspendLayout();
            groupBoxDannye_KDA.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxName_KDA
            // 
            textBoxName_KDA.Location = new Point(6, 22);
            textBoxName_KDA.Name = "textBoxName_KDA";
            textBoxName_KDA.Size = new Size(240, 23);
            textBoxName_KDA.TabIndex = 0;
            // 
            // groupBoxName_KDA
            // 
            groupBoxName_KDA.Controls.Add(textBoxName_KDA);
            groupBoxName_KDA.Location = new Point(12, 81);
            groupBoxName_KDA.Name = "groupBoxName_KDA";
            groupBoxName_KDA.Size = new Size(257, 59);
            groupBoxName_KDA.TabIndex = 1;
            groupBoxName_KDA.TabStop = false;
            groupBoxName_KDA.Text = "Введите фамилию:";
            // 
            // buttonFind_KDA
            // 
            buttonFind_KDA.Enabled = false;
            buttonFind_KDA.Location = new Point(289, 89);
            buttonFind_KDA.Name = "buttonFind_KDA";
            buttonFind_KDA.Size = new Size(69, 49);
            buttonFind_KDA.TabIndex = 2;
            buttonFind_KDA.Text = "Найти";
            buttonFind_KDA.UseVisualStyleBackColor = true;
            buttonFind_KDA.Click += buttonFind_KDA_Click;
            // 
            // buttonOpen_KDA
            // 
            buttonOpen_KDA.Image = (Image)resources.GetObject("buttonOpen_KDA.Image");
            buttonOpen_KDA.Location = new Point(12, 12);
            buttonOpen_KDA.Name = "buttonOpen_KDA";
            buttonOpen_KDA.Size = new Size(66, 53);
            buttonOpen_KDA.TabIndex = 3;
            buttonOpen_KDA.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(414, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(137, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(137, 48);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 99);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(277, 99);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(277, 48);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 10;
            // 
            // groupBoxDannye_KDA
            // 
            groupBoxDannye_KDA.Controls.Add(textBox7);
            groupBoxDannye_KDA.Controls.Add(textBox1);
            groupBoxDannye_KDA.Controls.Add(textBox4);
            groupBoxDannye_KDA.Controls.Add(textBox5);
            groupBoxDannye_KDA.Controls.Add(textBox6);
            groupBoxDannye_KDA.Controls.Add(textBox2);
            groupBoxDannye_KDA.Controls.Add(textBox3);
            groupBoxDannye_KDA.Location = new Point(12, 154);
            groupBoxDannye_KDA.Name = "groupBoxDannye_KDA";
            groupBoxDannye_KDA.Size = new Size(555, 160);
            groupBoxDannye_KDA.TabIndex = 11;
            groupBoxDannye_KDA.TabStop = false;
            groupBoxDannye_KDA.Text = "Данные";
            // 
            // FormPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 332);
            Controls.Add(buttonOpen_KDA);
            Controls.Add(buttonFind_KDA);
            Controls.Add(groupBoxName_KDA);
            Controls.Add(groupBoxDannye_KDA);
            Name = "FormPerson";
            Text = "Личные сведения";
            groupBoxName_KDA.ResumeLayout(false);
            groupBoxName_KDA.PerformLayout();
            groupBoxDannye_KDA.ResumeLayout(false);
            groupBoxDannye_KDA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxName_KDA;
        private GroupBox groupBoxName_KDA;
        private Button buttonFind_KDA;
        private Button buttonOpen_KDA;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private GroupBox groupBoxDannye_KDA;
    }
}