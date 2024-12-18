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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerson));
            textBoxName_KDA = new TextBox();
            groupBoxName_KDA = new GroupBox();
            buttonFind_KDA = new Button();
            buttonOpen_KDA = new Button();
            textBoxEntranceIn_KDA = new TextBox();
            textBoxRoomIn_KDA = new TextBox();
            textBoxRentIn_KDA = new TextBox();
            textBoxNumIn_KDA = new TextBox();
            textBoxPetIn_KDA = new TextBox();
            textBoxPersonIn_KDA = new TextBox();
            textBoxSquareIn_KDA = new TextBox();
            groupBoxDannye_KDA = new GroupBox();
            textBoxPerson_KDA = new TextBox();
            textBoxRent_KDA = new TextBox();
            textBoxPet_KDA = new TextBox();
            textBoxRoom_KDA = new TextBox();
            textBoxSquare_KDA = new TextBox();
            textBoxNum_KDA = new TextBox();
            textBoxEntrance_KDA = new TextBox();
            openFileDialog_KDA = new OpenFileDialog();
            toolTip = new ToolTip(components);
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
            toolTip.SetToolTip(buttonFind_KDA, "Введите фамилю нужного человека на английском\r\n");
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
            toolTip.SetToolTip(buttonOpen_KDA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpen_KDA.UseVisualStyleBackColor = true;
            buttonOpen_KDA.Click += buttonOpen_KDA_Click;
            // 
            // textBoxEntranceIn_KDA
            // 
            textBoxEntranceIn_KDA.Location = new Point(6, 48);
            textBoxEntranceIn_KDA.Name = "textBoxEntranceIn_KDA";
            textBoxEntranceIn_KDA.Size = new Size(100, 23);
            textBoxEntranceIn_KDA.TabIndex = 4;
            // 
            // textBoxRoomIn_KDA
            // 
            textBoxRoomIn_KDA.Location = new Point(414, 48);
            textBoxRoomIn_KDA.Name = "textBoxRoomIn_KDA";
            textBoxRoomIn_KDA.Size = new Size(100, 23);
            textBoxRoomIn_KDA.TabIndex = 5;
            // 
            // textBoxRentIn_KDA
            // 
            textBoxRentIn_KDA.Location = new Point(137, 99);
            textBoxRentIn_KDA.Name = "textBoxRentIn_KDA";
            textBoxRentIn_KDA.Size = new Size(100, 23);
            textBoxRentIn_KDA.TabIndex = 6;
            // 
            // textBoxNumIn_KDA
            // 
            textBoxNumIn_KDA.Location = new Point(137, 48);
            textBoxNumIn_KDA.Name = "textBoxNumIn_KDA";
            textBoxNumIn_KDA.Size = new Size(100, 23);
            textBoxNumIn_KDA.TabIndex = 7;
            // 
            // textBoxPetIn_KDA
            // 
            textBoxPetIn_KDA.Location = new Point(6, 99);
            textBoxPetIn_KDA.Name = "textBoxPetIn_KDA";
            textBoxPetIn_KDA.Size = new Size(100, 23);
            textBoxPetIn_KDA.TabIndex = 8;
            // 
            // textBoxPersonIn_KDA
            // 
            textBoxPersonIn_KDA.Location = new Point(277, 99);
            textBoxPersonIn_KDA.Name = "textBoxPersonIn_KDA";
            textBoxPersonIn_KDA.Size = new Size(100, 23);
            textBoxPersonIn_KDA.TabIndex = 9;
            // 
            // textBoxSquareIn_KDA
            // 
            textBoxSquareIn_KDA.Location = new Point(277, 48);
            textBoxSquareIn_KDA.Name = "textBoxSquareIn_KDA";
            textBoxSquareIn_KDA.Size = new Size(100, 23);
            textBoxSquareIn_KDA.TabIndex = 10;
            // 
            // groupBoxDannye_KDA
            // 
            groupBoxDannye_KDA.Controls.Add(textBoxPerson_KDA);
            groupBoxDannye_KDA.Controls.Add(textBoxRent_KDA);
            groupBoxDannye_KDA.Controls.Add(textBoxPet_KDA);
            groupBoxDannye_KDA.Controls.Add(textBoxRoom_KDA);
            groupBoxDannye_KDA.Controls.Add(textBoxSquare_KDA);
            groupBoxDannye_KDA.Controls.Add(textBoxNum_KDA);
            groupBoxDannye_KDA.Controls.Add(textBoxEntrance_KDA);
            groupBoxDannye_KDA.Controls.Add(textBoxSquareIn_KDA);
            groupBoxDannye_KDA.Controls.Add(textBoxEntranceIn_KDA);
            groupBoxDannye_KDA.Controls.Add(textBoxNumIn_KDA);
            groupBoxDannye_KDA.Controls.Add(textBoxPetIn_KDA);
            groupBoxDannye_KDA.Controls.Add(textBoxPersonIn_KDA);
            groupBoxDannye_KDA.Controls.Add(textBoxRoomIn_KDA);
            groupBoxDannye_KDA.Controls.Add(textBoxRentIn_KDA);
            groupBoxDannye_KDA.Location = new Point(12, 154);
            groupBoxDannye_KDA.Name = "groupBoxDannye_KDA";
            groupBoxDannye_KDA.Size = new Size(555, 160);
            groupBoxDannye_KDA.TabIndex = 11;
            groupBoxDannye_KDA.TabStop = false;
            groupBoxDannye_KDA.Text = "Данные";
            // 
            // textBoxPerson_KDA
            // 
            textBoxPerson_KDA.BackColor = SystemColors.MenuBar;
            textBoxPerson_KDA.BorderStyle = BorderStyle.None;
            textBoxPerson_KDA.Location = new Point(277, 77);
            textBoxPerson_KDA.Name = "textBoxPerson_KDA";
            textBoxPerson_KDA.ReadOnly = true;
            textBoxPerson_KDA.Size = new Size(122, 16);
            textBoxPerson_KDA.TabIndex = 17;
            textBoxPerson_KDA.Text = "Количество человек:";
            // 
            // textBoxRent_KDA
            // 
            textBoxRent_KDA.BackColor = SystemColors.MenuBar;
            textBoxRent_KDA.BorderStyle = BorderStyle.None;
            textBoxRent_KDA.Location = new Point(137, 77);
            textBoxRent_KDA.Name = "textBoxRent_KDA";
            textBoxRent_KDA.ReadOnly = true;
            textBoxRent_KDA.Size = new Size(100, 16);
            textBoxRent_KDA.TabIndex = 16;
            textBoxRent_KDA.Text = "Задолженность:";
            // 
            // textBoxPet_KDA
            // 
            textBoxPet_KDA.BackColor = SystemColors.MenuBar;
            textBoxPet_KDA.BorderStyle = BorderStyle.None;
            textBoxPet_KDA.Location = new Point(6, 77);
            textBoxPet_KDA.Name = "textBoxPet_KDA";
            textBoxPet_KDA.ReadOnly = true;
            textBoxPet_KDA.Size = new Size(125, 16);
            textBoxPet_KDA.TabIndex = 15;
            textBoxPet_KDA.Text = "Наличие животных:";
            // 
            // textBoxRoom_KDA
            // 
            textBoxRoom_KDA.BackColor = SystemColors.MenuBar;
            textBoxRoom_KDA.BorderStyle = BorderStyle.None;
            textBoxRoom_KDA.Location = new Point(414, 22);
            textBoxRoom_KDA.Name = "textBoxRoom_KDA";
            textBoxRoom_KDA.ReadOnly = true;
            textBoxRoom_KDA.Size = new Size(118, 16);
            textBoxRoom_KDA.TabIndex = 14;
            textBoxRoom_KDA.Text = "Количество комнат:";
            // 
            // textBoxSquare_KDA
            // 
            textBoxSquare_KDA.BackColor = SystemColors.MenuBar;
            textBoxSquare_KDA.BorderStyle = BorderStyle.None;
            textBoxSquare_KDA.Location = new Point(277, 22);
            textBoxSquare_KDA.Name = "textBoxSquare_KDA";
            textBoxSquare_KDA.ReadOnly = true;
            textBoxSquare_KDA.Size = new Size(100, 16);
            textBoxSquare_KDA.TabIndex = 13;
            textBoxSquare_KDA.Text = "Общая площадь:";
            // 
            // textBoxNum_KDA
            // 
            textBoxNum_KDA.BackColor = SystemColors.MenuBar;
            textBoxNum_KDA.BorderStyle = BorderStyle.None;
            textBoxNum_KDA.Location = new Point(137, 22);
            textBoxNum_KDA.Name = "textBoxNum_KDA";
            textBoxNum_KDA.ReadOnly = true;
            textBoxNum_KDA.Size = new Size(100, 16);
            textBoxNum_KDA.TabIndex = 12;
            textBoxNum_KDA.Text = "Номер квартиры:";
            // 
            // textBoxEntrance_KDA
            // 
            textBoxEntrance_KDA.BackColor = SystemColors.MenuBar;
            textBoxEntrance_KDA.BorderStyle = BorderStyle.None;
            textBoxEntrance_KDA.Location = new Point(6, 22);
            textBoxEntrance_KDA.Name = "textBoxEntrance_KDA";
            textBoxEntrance_KDA.ReadOnly = true;
            textBoxEntrance_KDA.Size = new Size(100, 16);
            textBoxEntrance_KDA.TabIndex = 11;
            textBoxEntrance_KDA.Text = "Номер подъезда:";
            // 
            // openFileDialog_KDA
            // 
            openFileDialog_KDA.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 328);
            Controls.Add(buttonOpen_KDA);
            Controls.Add(buttonFind_KDA);
            Controls.Add(groupBoxName_KDA);
            Controls.Add(groupBoxDannye_KDA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
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
        private TextBox textBoxEntranceIn_KDA;
        private TextBox textBoxRoomIn_KDA;
        private TextBox textBoxRentIn_KDA;
        private TextBox textBoxNumIn_KDA;
        private TextBox textBoxPetIn_KDA;
        private TextBox textBoxPersonIn_KDA;
        private TextBox textBoxSquareIn_KDA;
        private GroupBox groupBoxDannye_KDA;
        private TextBox textBoxEntrance_KDA;
        private TextBox textBoxPerson_KDA;
        private TextBox textBoxRent_KDA;
        private TextBox textBoxPet_KDA;
        private TextBox textBoxRoom_KDA;
        private TextBox textBoxSquare_KDA;
        private TextBox textBoxNum_KDA;
        private OpenFileDialog openFileDialog_KDA;
        private ToolTip toolTip;
    }
}