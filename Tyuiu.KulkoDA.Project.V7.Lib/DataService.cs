namespace Tyuiu.KulkoDA.Project.V7.Lib
{
    public class DataService
    {
        public int RowCount(string path)
        {
            int row = 0;
            using(StreamReader sr = new StreamReader(path))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    row++;
                }
            }
            return row;
        }
        
    }
}
