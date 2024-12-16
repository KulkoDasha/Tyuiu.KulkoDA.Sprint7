using System.Data;
using System.Web;
using System.Windows.Forms;
using Tyuiu.KulkoDA.Project.V7.Lib;
namespace Tyuiu.KulkoDA.Project.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonHelp_KDA_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void buttonOpen_KDA_Click(object sender, EventArgs e)
        {
            
            openFileDialog_KDA.ShowDialog();
            openFilePath = openFileDialog_KDA.FileName;
            int col = 8;
            int row = ds.RowCount(openFilePath);
            dataGridView_KDA.RowCount = row;
            dataGridView_KDA.ColumnCount = col;
            string[,] mass = new string[row,col];
            mass = ds.StringMass(openFilePath);
            int c = 0;
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col ; j++)
                {
                    dataGridView_KDA.Rows[i].Cells[j].Value = mass[i,j];
                }
            }
        }

        private void buttonPerson_KDA_Click(object sender, EventArgs e)
        {
            FormPerson form = new FormPerson();
            form.ShowDialog();
        }

        private void buttonChart_KDA_Click(object sender, EventArgs e)
        {
            FormChart form = new FormChart();
            form.ShowDialog();
        }
    }
}
