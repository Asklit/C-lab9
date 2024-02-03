using System;
namespace lab9
{
    internal class Program
    {
        static void Main()
        {
            TestStudent();

            //TestArray();
        }

        static void TestStudent()
        {
            Student masha = new Student("Masha", 18, 8);
            Student sasha = new Student("Sasha", 21, 6);
            Student kirill = new Student("Kirill", 20, 3);
            Student noname = new Student();
            Student sonya = new Student(masha);

            masha.GetInfo();
            sasha.GetInfo();
            kirill.GetInfo();
            noname.GetInfo();
            sonya.GetInfo();

            Console.WriteLine("-------------------");
            Console.WriteLine("Сравнение студентов (class metods):");
            masha.Compare(sasha);
            sasha.Compare(kirill);
            masha.Compare(sonya);

            Console.WriteLine("-------------------");
            Console.WriteLine("Сравнение студентов (static metods):");
            Student.CompareStudents(sonya, kirill);
            Student.CompareStudents(sasha, masha);
            Student.CompareStudents(noname, sonya);

            Console.WriteLine("-------------------");
            Console.WriteLine($"Общее количество студентов: {Student.GetCountStudents()}");

            masha.Name = "mAsHa";
            masha.GetInfo();
            masha = ~masha;
            masha++;
            masha.GetInfo();

            Student daniil = masha % "daniil";
            daniil.GetInfo();
            daniil -= 5;
            daniil.GetInfo();
            daniil -= 5;
            daniil.GetInfo();
            daniil -= -10;
            daniil.GetInfo();

            daniil.GetInfo();
            bool checkResults1 = daniil;
            Console.WriteLine($"Оценки студента {daniil.Gpa} положительные? - {checkResults1}");
            bool checkResults2 = masha;
            Console.WriteLine($"Оценки студента {masha.Gpa} положительные? - {checkResults2}");
            bool checkResults3 = kirill;
            Console.WriteLine($"Оценки студента {kirill.Gpa} положительные? - {checkResults3}");
            Console.WriteLine($"Курс обучения {daniil.Name} - {(int)daniil}");
            Console.WriteLine($"Курс обучения {masha.Name} - {(int)masha}");
            Console.WriteLine($"Курс обучения {kirill.Name} - {(int)kirill}");
        }

        static void TestArray()
        {
            StudentsArray sa = new(10);
            Console.WriteLine("10 рандомных студентов:");
            sa.GetInfo();
            Console.WriteLine($"Количество студентов: {sa.Length}");

            StudentsArray sa2 = new(5, ["Pasha", "Masha", "Polina", "Timofey", "Dasha"], [18, 20, 21, 22, 19], [5, 6, 7, 10, 10]);
            Console.WriteLine("5 существующих студентов:");
            sa2.GetInfo();
            Console.WriteLine($"Количество студентов: {sa2.Length}");

            StudentsArray sa3 = new(sa2);
            try
            {
                sa3[1] = sa3[2];
            }
            catch
            {
                Console.WriteLine("Error: IndexOutOfRange");
            }
            Console.WriteLine("Студенты первой группы:");
            sa2.GetInfo();
            Console.WriteLine("Студенты второй группы:");
            sa3.GetInfo();
            try
            {
                Console.WriteLine(sa2[100]);

            }
            catch
            {
                Console.WriteLine("Error: IndexOutOfRange");
            }
            try
            {
                Console.WriteLine(sa2[-1]);

            }
            catch
            {
                Console.WriteLine("Error: IndexOutOfRange");
            }
            FindStudent(sa2).GetInfo();

        }

        static Student FindStudent(StudentsArray sa)
        {
            Student s = new();
            for (int i = 0; i < sa.Length; i++)
            {
                if (sa[i].Gpa > 8 && s.Age < sa[i].Age)
                {
                    s = sa[i];
                }
            };
            return s;
        }
    }
}