namespace Tyuiu.KulkoDA.Project.V7
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBox1 = new TextBox();
            buttonOpen_KDA = new Button();
            buttonHelp_KDA = new Button();
            dataGridView_KDA = new DataGridView();
            Surname = new DataGridViewTextBoxColumn();
            Num_Entrance = new DataGridViewTextBoxColumn();
            Num_Apartment = new DataGridViewTextBoxColumn();
            Square = new DataGridViewTextBoxColumn();
            Room_Count = new DataGridViewTextBoxColumn();
            Pet = new DataGridViewTextBoxColumn();
            Debt = new DataGridViewTextBoxColumn();
            People_Count = new DataGridViewTextBoxColumn();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            openFileDialog_KDA = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView_KDA).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(300, 66);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(215, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Общие сведения о доме:\r\n";
            // 
            // buttonOpen_KDA
            // 
            buttonOpen_KDA.Image = (Image)resources.GetObject("buttonOpen_KDA.Image");
            buttonOpen_KDA.Location = new Point(12, 12);
            buttonOpen_KDA.Name = "buttonOpen_KDA";
            buttonOpen_KDA.Size = new Size(66, 53);
            buttonOpen_KDA.TabIndex = 1;
            buttonOpen_KDA.UseVisualStyleBackColor = true;
            buttonOpen_KDA.Click += buttonOpen_KDA_Click;
            // 
            // buttonHelp_KDA
            // 
            buttonHelp_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KDA.Image = (Image)resources.GetObject("buttonHelp_KDA.Image");
            buttonHelp_KDA.Location = new Point(677, 12);
            buttonHelp_KDA.Name = "buttonHelp_KDA";
            buttonHelp_KDA.Size = new Size(66, 53);
            buttonHelp_KDA.TabIndex = 2;
            buttonHelp_KDA.UseVisualStyleBackColor = true;
            buttonHelp_KDA.Click += buttonHelp_KDA_Click;
            // 
            // dataGridView_KDA
            // 
            dataGridView_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_KDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_KDA.Columns.AddRange(new DataGridViewColumn[] { Surname, Num_Entrance, Num_Apartment, Square, Room_Count, Pet, Debt, People_Count });
            dataGridView_KDA.Location = new Point(12, 95);
            dataGridView_KDA.Name = "dataGridView_KDA";
            dataGridView_KDA.Size = new Size(731, 232);
            dataGridView_KDA.TabIndex = 3;
            // 
            // Surname
            // 
            Surname.HeaderText = "Фамилия";
            Surname.Name = "Surname";
            Surname.ReadOnly = true;
            // 
            // Num_Entrance
            // 
            Num_Entrance.HeaderText = "Номер подъезда";
            Num_Entrance.Name = "Num_Entrance";
            Num_Entrance.ReadOnly = true;
            Num_Entrance.Width = 75;
            // 
            // Num_Apartment
            // 
            Num_Apartment.HeaderText = "Номер кв";
            Num_Apartment.Name = "Num_Apartment";
            Num_Apartment.ReadOnly = true;
            Num_Apartment.Width = 50;
            // 
            // Square
            // 
            Square.HeaderText = "Площадь";
            Square.Name = "Square";
            Square.ReadOnly = true;
            Square.Width = 75;
            // 
            // Room_Count
            // 
            Room_Count.HeaderText = "Кол.во комнат";
            Room_Count.Name = "Room_Count";
            Room_Count.ReadOnly = true;
            // 
            // Pet
            // 
            Pet.HeaderText = "Животные";
            Pet.Name = "Pet";
            Pet.ReadOnly = true;
            Pet.Width = 75;
            // 
            // Debt
            // 
            Debt.HeaderText = "Задолженность";
            Debt.Name = "Debt";
            Debt.ReadOnly = true;
            // 
            // People_Count
            // 
            People_Count.HeaderText = "Кол.во человек";
            People_Count.Name = "People_Count";
            People_Count.ReadOnly = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 349);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 60);
            textBox2.TabIndex = 4;
            textBox2.Text = "Общее кол.во залесенных квартир";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(139, 349);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 60);
            textBox3.TabIndex = 5;
            textBox3.Text = "Общее кол.во людей";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(139, 415);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 415);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(263, 415);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(107, 23);
            textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(263, 349);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(107, 60);
            textBox7.TabIndex = 9;
            textBox7.Text = "Общая сумма задолженностей";
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(100, 12);
            button3.Name = "button3";
            button3.Size = new Size(66, 53);
            button3.TabIndex = 10;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(187, 12);
            button4.Name = "button4";
            button4.Size = new Size(66, 53);
            button4.TabIndex = 11;
            button4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog_KDA
            // 
            openFileDialog_KDA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 455);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(dataGridView_KDA);
            Controls.Add(buttonHelp_KDA);
            Controls.Add(buttonOpen_KDA);
            Controls.Add(textBox1);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView_KDA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonOpen_KDA;
        private Button buttonHelp_KDA;
        private DataGridView dataGridView_KDA;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Num_Entrance;
        private DataGridViewTextBoxColumn Num_Apartment;
        private DataGridViewTextBoxColumn Square;
        private DataGridViewTextBoxColumn Room_Count;
        private DataGridViewTextBoxColumn Pet;
        private DataGridViewTextBoxColumn Debt;
        private DataGridViewTextBoxColumn People_Count;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button3;
        private Button button4;
        private OpenFileDialog openFileDialog_KDA;
        private ToolTip toolTip1;
    }
}
