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
        
        public string[,] StringMass(string path)
        {
            string[,] mass = new string[2,8];
            int j = 0;
            String line = String.Empty;
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                String[] parts_of_line = line.Split(';');
                for (int i = 0; i < parts_of_line.Length; i++)
                {
                    parts_of_line[i] = parts_of_line[i].Trim();
                    mass[j, i] = parts_of_line[i].Trim();
                }
                j++;
            }
            return mass;
        }


    }
}
