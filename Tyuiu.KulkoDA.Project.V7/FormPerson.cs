using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KulkoDA.Project.V7.Lib;
namespace Tyuiu.KulkoDA.Project.V7
{
    public partial class FormPerson : Form
    {
        public FormPerson()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonFind_KDA_Click(object sender, EventArgs e)
        {
            int col = 8;
            int row = ds.RowCount(openFilePath);
            string[,] mass = new string[row, col];
            mass = ds.StringMass(openFilePath, row, col);
            string str = textBoxName_KDA.Text;
            int k = 1;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j <= 0; j++)
                {
                    if (mass[i, j] == str)
                    {
                        textBoxEntranceIn_KDA.Text = mass[i, k];
                        k++;
                        textBoxNumIn_KDA.Text = mass[i, k];
                        k++;
                        textBoxSquareIn_KDA.Text = mass[i, k];
                        k++;
                        textBoxRoomIn_KDA.Text = mass[i, k];
                        k++;
                        textBoxPetIn_KDA.Text= mass[i, k];
                        k++;
                        textBoxRentIn_KDA.Text = mass[i, k];
                        k++;
                        textBoxPersonIn_KDA.Text = mass[i, k];
                    }
                }
            }
        }

        private void buttonOpen_KDA_Click(object sender, EventArgs e)
        {
            openFileDialog_KDA.ShowDialog();
            openFilePath = openFileDialog_KDA.FileName;
            buttonFind_KDA.Enabled = true;
        }
    }
}
