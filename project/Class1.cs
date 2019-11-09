using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    public class Class1
    {
        public struct Student
        {
            public string firstName;
            public string lastName;
            public string id;
            public string course;
            public string specialization;
            public string score;
            public string status;



            public void InfoStud()
            {
                Console.Write("Имя студента:");
                firstName = Console.ReadLine();
                Console.Write("Фамилия студента:");
                lastName = Console.ReadLine();
                Console.Write("ID студента:");
                id = Console.ReadLine();
                Console.Write("На каком курсе учится студент:");
                course = Console.ReadLine();
                Console.Write("Специализация студента:");
                specialization = Console.ReadLine();
                Console.Write("Введите средний балл студента:");
                int score = Convert.ToInt32(Console.ReadLine());
                if (score < 70 && score > 50)
                {
                    status = "У этого студента нет стипендии, но и нет лето.";
                }
                else if (score > 70 && score < 100)
                {
                    status = "У этого студента есть стипендия, все хорошо";
                }
                else if (score < 50 && score > 25)
                {
                    status = "Этот студент остается на пересдачу.";
                }
                else if (score < 25)
                {
                    status = "Этот студент остается на лето, без пересдачи.";
                }

            }
        }
    }
}
