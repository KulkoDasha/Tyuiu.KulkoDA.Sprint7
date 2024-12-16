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
            string[,] mass = new string[row, col];
            mass = ds.StringMass(openFilePath, row, col);
            int c = 0;
            for (int i = 1; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dataGridView_KDA.Rows[c].Cells[j].Value = mass[i, j];
                }
                c++;
            }
            buttonCount_KDA.Enabled = true;
            buttonSave_KDA.Enabled = true;
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

        private void buttonCount_KDA_Click(object sender, EventArgs e)
        {
            int r = dataGridView_KDA.RowCount - 1;
            for (int i = 0; i < r; i++)
            {
                textBoxApartmentIn_KDA.Text = Convert.ToString(r);
            }
            int people = 0;
            for (int i = 0; i < r; i++)
            {
                people += Convert.ToInt32(dataGridView_KDA.Rows[i].Cells[7].Value);
            }
            textBoxPeopleIn_KDA.Text = Convert.ToString(people);
            int debt = 0;
            for (int i = 0; i < r; i++)
            {
                debt += Convert.ToInt32(dataGridView_KDA.Rows[i].Cells[6].Value);
            }
            textBoxDebtIn_KDA.Text = Convert.ToString(debt);
            
        }

        private void buttonSave_KDA_Click(object sender, EventArgs e)
        {
            saveFileDialog_KDA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_KDA.ShowDialog();
            string path = saveFileDialog_KDA.FileName;
            int rows = dataGridView_KDA.Rows.Count;
            int cols = dataGridView_KDA.Columns.Count;
            string str = "";
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    if(j!=cols-1)
                    {
                        str += dataGridView_KDA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridView_KDA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
            MessageBox.Show("Файл успешно сохранен!");
        }
    }
}
