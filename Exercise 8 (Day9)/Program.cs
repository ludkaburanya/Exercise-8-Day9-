using System.Xml.Serialization;

namespace z1
{
    class Program
    {
        struct STUDENT
        {
            public string name, surname;
            public int[] score;
            public int group;
            public STUDENT(string n, string r, int g, int[] s)
            {
                score = s;
                name = n;
                surname = r;
                group = g;
            }
            public int getFinalScore() 
            {
                return (score[0] + score[1] + score[2] + score[3] + score[4]) / 5;
            }
        }
        class demo
        {
            static void Main()
            {
                string s;
                string[] c;
                int[] d = new int[5];
                bool morefour = false;
                STUDENT[] stud1 = new STUDENT[2];
                for (int i = 0; i < stud1.Length; i++)
                {
                    Console.Write("Введите фамилию: ");
                    stud1[i].name = Console.ReadLine();
                    Console.Write("Введите инициалы: ");
                    stud1[i].surname = Console.ReadLine();
                    Console.Write("Введите номер группы: ");
                    stud1[i].group = Int32.Parse(Console.ReadLine());
                    Console.Write("Введите 5 оценок: ");
                    s = Console.ReadLine();
                    stud1[i].score = new int[5];
                    c = s.Split(null);
                    for (int j = 0; j < 5; j++) stud1[i].score[j] = Int32.Parse(c[j]);
                    Console.WriteLine();
                }
          
                for (int i = 0; i < stud1.Length; i++)
                {
                    int sum = (stud1[i].score[0] + stud1[i].score[1] + stud1[i].score[2] + stud1[i].score[3] + stud1[i].score[4]) / 5;

                    Console.WriteLine("\nВывод среднего балла студента:");
     
                    Console.WriteLine($"{stud1[i].name} {stud1[i].surname}\n"  +  sum);
                }

                Console.WriteLine("\nСтуденты со средним баллом больше 4-х: ");
                foreach (STUDENT st in stud1)
                {
                    if (st.getFinalScore() >= 4)
                    {
                        Console.WriteLine($"Студент: {st.name} {st.surname}");
                        morefour = true;
                    }
                }
                if (!morefour) Console.WriteLine("Студентов со средним баллом больше 4-х нету.");

                for (int i = 0; i < stud1.Length-1; i++)
                {
                        if (stud1[i].group > stud1[i + 1].group)
                        {
                            Console.WriteLine("\nСписок по возрастанию группы:");
                            Console.WriteLine($"Студент {stud1[i+1].name} {stud1[i+1].surname} из группы {stud1[i+1].group}");
                            Console.WriteLine($"Студент {stud1[i].name} {stud1[i].surname} из группы {stud1[i].group}");
                        }
                        else 
                        {
                            Console.WriteLine($"Студент {stud1[i ].name} {stud1[i].surname} из группы {stud1[i].group}");
                            Console.WriteLine($"Студент {stud1[i+1].name} {stud1[i+1].surname} из группы {stud1[i+1].group}");
                        }
                    
                }            
                
            }
        }
    }
}