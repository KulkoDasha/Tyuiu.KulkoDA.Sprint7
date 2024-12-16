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
            textBoxHeadLine_KDA = new TextBox();
            buttonOpen_KDA = new Button();
            buttonHelp_KDA = new Button();
            dataGridView_KDA = new DataGridView();
            textBoxApartment_KDA = new TextBox();
            textBoxPeople_KDA = new TextBox();
            textBoxPeopleIn_KDA = new TextBox();
            textBoxApartmentIn_KDA = new TextBox();
            textBoxDebtIn_KDA = new TextBox();
            textBoxDebt_KDA = new TextBox();
            buttonChart_KDA = new Button();
            buttonPerson_KDA = new Button();
            openFileDialog_KDA = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            groupBox_KDA = new GroupBox();
            buttonCount_KDA = new Button();
            Surname = new DataGridViewTextBoxColumn();
            Num_Entrance = new DataGridViewTextBoxColumn();
            Num_Apartment = new DataGridViewTextBoxColumn();
            Square = new DataGridViewTextBoxColumn();
            Room_Count = new DataGridViewTextBoxColumn();
            Pet = new DataGridViewTextBoxColumn();
            Debt = new DataGridViewTextBoxColumn();
            People_Count = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView_KDA).BeginInit();
            groupBox_KDA.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxHeadLine_KDA
            // 
            textBoxHeadLine_KDA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxHeadLine_KDA.BackColor = SystemColors.MenuBar;
            textBoxHeadLine_KDA.BorderStyle = BorderStyle.None;
            textBoxHeadLine_KDA.Font = new Font("Segoe UI", 13F);
            textBoxHeadLine_KDA.Location = new Point(281, 66);
            textBoxHeadLine_KDA.Multiline = true;
            textBoxHeadLine_KDA.Name = "textBoxHeadLine_KDA";
            textBoxHeadLine_KDA.ReadOnly = true;
            textBoxHeadLine_KDA.Size = new Size(215, 23);
            textBoxHeadLine_KDA.TabIndex = 0;
            textBoxHeadLine_KDA.Text = "Общие сведения о доме:\r\n";
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
            dataGridView_KDA.RowHeadersVisible = false;
            dataGridView_KDA.Size = new Size(731, 232);
            dataGridView_KDA.TabIndex = 3;
            // 
            // textBoxApartment_KDA
            // 
            textBoxApartment_KDA.Location = new Point(18, 16);
            textBoxApartment_KDA.Multiline = true;
            textBoxApartment_KDA.Name = "textBoxApartment_KDA";
            textBoxApartment_KDA.ReadOnly = true;
            textBoxApartment_KDA.Size = new Size(100, 60);
            textBoxApartment_KDA.TabIndex = 4;
            textBoxApartment_KDA.Text = "Общее кол.во залесенных квартир";
            // 
            // textBoxPeople_KDA
            // 
            textBoxPeople_KDA.Location = new Point(141, 16);
            textBoxPeople_KDA.Multiline = true;
            textBoxPeople_KDA.Name = "textBoxPeople_KDA";
            textBoxPeople_KDA.ReadOnly = true;
            textBoxPeople_KDA.Size = new Size(100, 60);
            textBoxPeople_KDA.TabIndex = 5;
            textBoxPeople_KDA.Text = "Общее кол.во людей";
            // 
            // textBoxPeopleIn_KDA
            // 
            textBoxPeopleIn_KDA.Location = new Point(141, 82);
            textBoxPeopleIn_KDA.Name = "textBoxPeopleIn_KDA";
            textBoxPeopleIn_KDA.Size = new Size(100, 23);
            textBoxPeopleIn_KDA.TabIndex = 6;
            // 
            // textBoxApartmentIn_KDA
            // 
            textBoxApartmentIn_KDA.Location = new Point(18, 82);
            textBoxApartmentIn_KDA.Name = "textBoxApartmentIn_KDA";
            textBoxApartmentIn_KDA.Size = new Size(100, 23);
            textBoxApartmentIn_KDA.TabIndex = 7;
            // 
            // textBoxDebtIn_KDA
            // 
            textBoxDebtIn_KDA.Location = new Point(269, 82);
            textBoxDebtIn_KDA.Name = "textBoxDebtIn_KDA";
            textBoxDebtIn_KDA.Size = new Size(107, 23);
            textBoxDebtIn_KDA.TabIndex = 8;
            // 
            // textBoxDebt_KDA
            // 
            textBoxDebt_KDA.BackColor = SystemColors.MenuBar;
            textBoxDebt_KDA.Location = new Point(269, 16);
            textBoxDebt_KDA.Multiline = true;
            textBoxDebt_KDA.Name = "textBoxDebt_KDA";
            textBoxDebt_KDA.ReadOnly = true;
            textBoxDebt_KDA.Size = new Size(107, 60);
            textBoxDebt_KDA.TabIndex = 9;
            textBoxDebt_KDA.Text = "Общая сумма задолженностей";
            // 
            // buttonChart_KDA
            // 
            buttonChart_KDA.Image = (Image)resources.GetObject("buttonChart_KDA.Image");
            buttonChart_KDA.Location = new Point(100, 12);
            buttonChart_KDA.Name = "buttonChart_KDA";
            buttonChart_KDA.Size = new Size(66, 53);
            buttonChart_KDA.TabIndex = 10;
            buttonChart_KDA.UseVisualStyleBackColor = true;
            buttonChart_KDA.Click += buttonChart_KDA_Click;
            // 
            // buttonPerson_KDA
            // 
            buttonPerson_KDA.Image = (Image)resources.GetObject("buttonPerson_KDA.Image");
            buttonPerson_KDA.Location = new Point(187, 12);
            buttonPerson_KDA.Name = "buttonPerson_KDA";
            buttonPerson_KDA.Size = new Size(66, 53);
            buttonPerson_KDA.TabIndex = 11;
            buttonPerson_KDA.UseVisualStyleBackColor = true;
            buttonPerson_KDA.Click += buttonPerson_KDA_Click;
            // 
            // openFileDialog_KDA
            // 
            openFileDialog_KDA.FileName = "openFileDialog1";
            // 
            // groupBox_KDA
            // 
            groupBox_KDA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox_KDA.Controls.Add(textBoxDebt_KDA);
            groupBox_KDA.Controls.Add(textBoxDebtIn_KDA);
            groupBox_KDA.Controls.Add(textBoxApartmentIn_KDA);
            groupBox_KDA.Controls.Add(textBoxPeople_KDA);
            groupBox_KDA.Controls.Add(textBoxApartment_KDA);
            groupBox_KDA.Controls.Add(textBoxPeopleIn_KDA);
            groupBox_KDA.Location = new Point(12, 333);
            groupBox_KDA.Name = "groupBox_KDA";
            groupBox_KDA.Size = new Size(392, 120);
            groupBox_KDA.TabIndex = 12;
            groupBox_KDA.TabStop = false;
            groupBox_KDA.Text = "Общие сведения:";
            // 
            // buttonCount_KDA
            // 
            buttonCount_KDA.Enabled = false;
            buttonCount_KDA.Location = new Point(421, 396);
            buttonCount_KDA.Name = "buttonCount_KDA";
            buttonCount_KDA.Size = new Size(91, 42);
            buttonCount_KDA.TabIndex = 10;
            buttonCount_KDA.Text = "Расчитать";
            buttonCount_KDA.UseVisualStyleBackColor = true;
            buttonCount_KDA.Click += buttonCount_KDA_Click;
            // 
            // Surname
            // 
            Surname.HeaderText = "Фамилия";
            Surname.Name = "Surname";
            // 
            // Num_Entrance
            // 
            Num_Entrance.HeaderText = "Номер подъезда";
            Num_Entrance.Name = "Num_Entrance";
            Num_Entrance.Width = 75;
            // 
            // Num_Apartment
            // 
            Num_Apartment.HeaderText = "Номер кв";
            Num_Apartment.Name = "Num_Apartment";
            Num_Apartment.Width = 50;
            // 
            // Square
            // 
            Square.HeaderText = "Площадь";
            Square.Name = "Square";
            Square.Width = 75;
            // 
            // Room_Count
            // 
            Room_Count.HeaderText = "Кол.во комнат";
            Room_Count.Name = "Room_Count";
            // 
            // Pet
            // 
            Pet.HeaderText = "Животные";
            Pet.Name = "Pet";
            Pet.Width = 75;
            // 
            // Debt
            // 
            Debt.HeaderText = "Задолженность";
            Debt.Name = "Debt";
            // 
            // People_Count
            // 
            People_Count.HeaderText = "Кол.во человек";
            People_Count.Name = "People_Count";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 455);
            Controls.Add(buttonCount_KDA);
            Controls.Add(buttonPerson_KDA);
            Controls.Add(buttonChart_KDA);
            Controls.Add(dataGridView_KDA);
            Controls.Add(buttonHelp_KDA);
            Controls.Add(buttonOpen_KDA);
            Controls.Add(textBoxHeadLine_KDA);
            Controls.Add(groupBox_KDA);
            Name = "FormMain";
            Text = "Главное Меню";
            ((System.ComponentModel.ISupportInitialize)dataGridView_KDA).EndInit();
            groupBox_KDA.ResumeLayout(false);
            groupBox_KDA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHeadLine_KDA;
        private Button buttonOpen_KDA;
        private Button buttonHelp_KDA;
        private DataGridView dataGridView_KDA;
        private TextBox textBoxApartment_KDA;
        private TextBox textBoxPeople_KDA;
        private TextBox textBoxPeopleIn_KDA;
        private TextBox textBoxApartmentIn_KDA;
        private TextBox textBoxDebtIn_KDA;
        private TextBox textBoxDebt_KDA;
        private Button buttonChart_KDA;
        private Button buttonPerson_KDA;
        private OpenFileDialog openFileDialog_KDA;
        private ToolTip toolTip1;
        private GroupBox groupBox_KDA;
        private Button buttonCount_KDA;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Num_Entrance;
        private DataGridViewTextBoxColumn Num_Apartment;
        private DataGridViewTextBoxColumn Square;
        private DataGridViewTextBoxColumn Room_Count;
        private DataGridViewTextBoxColumn Pet;
        private DataGridViewTextBoxColumn Debt;
        private DataGridViewTextBoxColumn People_Count;
    }
}
