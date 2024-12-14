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
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    dataGridView_KDA.Rows[i].Cells[j].Value =0;
                }

            }
        }
    }
}
