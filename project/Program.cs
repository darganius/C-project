using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static project.Class1;


namespace ConsoleApp4
{

    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Новая папка (2)\\output.txt";

            int count;
            do
            {
                Console.Write("Сколько студентов хотите ввести в систему?:");
            }
            while (!int.TryParse(Console.ReadLine(), out count) || count < 1);
            var student = new Student[count];

            for (int i = 0; i < count; i++)
            {
                int k;
                do
                {
                    Console.WriteLine("1-Ввести данные о {0}, студенте", i + 1);
                    Console.WriteLine("2-Выйти");
                }
                while (!int.TryParse(Console.ReadLine(), out k));
                {
                    switch (k)
                    {
                        case 1: student[i].InfoStud(); break;
                        case 2: return;
                    }
                }
            }

            for (int i = 0; i < count; i++)
            {
                List<string> studlist = new List<string>();
                for (int x = 0; x < 1; x++)
                {
                    studlist.Add(student[i].firstName);
                    studlist.Add(student[i].lastName);
                    studlist.Add(student[i].id);
                    studlist.Add(student[i].course);
                    studlist.Add(student[i].specialization);
                    studlist.Add(student[i].score);
                    studlist.Add(student[i].status);

                }
                Console.WriteLine("[{0}]", string.Join("  ", studlist));
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                string rezult = "";
                foreach (var s in studlist)
                    rezult += s + " ";
                File.AppendAllText(path, rezult + Environment.NewLine);
            }
            Console.ReadKey();
        }
    }
}