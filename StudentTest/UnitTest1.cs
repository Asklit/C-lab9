using lab9;
namespace UnitTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Сравнение разных способов создания объектов
        /// </summary>
        [Fact]
        public void Test1()
        {
            // setters
            Student masha = new Student("", 5, 12);
            Student sasha = new Student();
            Assert.Equal(masha, sasha);
        }

        /// <summary>
        /// Сравнение копирования студента
        /// </summary>
        [Fact]
        public void Test2()
        {
            Student kirill = new Student("Kirill", 18, 6);
            Student polina = new Student(kirill);
            Assert.Equal(kirill, polina);
        }

        /// <summary>
        /// Проверка корректности преобразования имени студента
        /// </summary>
        [Fact]
        public void Test3()
        {
            Student masha = new Student("mAsHa", 18, 6);
            masha = ~masha;
            Assert.Equal("Masha", masha.Name);
        }

        /// <summary>
        /// Проверка корректности увеличения возраста студента
        /// </summary>
        [Fact]
        public void Test4()
        {
            Student masha = new Student("mAsHa", 18, 6);
            masha = masha++;
            Assert.Equal(19, masha.Age);
        }

        /// <summary>
        /// Проверка создания нового студента с новым именем
        /// </summary>
        [Fact]
        public void Test5()
        {
            Student masha = new Student("mAsHa", 18, 6);
            Student timofey = masha % "Timofey";
            Assert.Equal("Timofey", timofey.Name);
            Assert.Equal(masha.Age, timofey.Age);
            Assert.Equal(masha.Gpa, timofey.Gpa);
        }
        
        /// <summary>
        /// Проверка корректности изменения GPA
        /// </summary>
        [Fact]
        public void Test6()
        {
            Student masha = new Student("mAsHa", 18, 6);
            masha -= 10;
            Assert.Equal(0, masha.Gpa);
            masha -= -10.2;
            Assert.Equal(10, masha.Gpa);
            masha -= 3.2;
            Assert.Equal(6.8, masha.Gpa);
        }

        /// <summary>
        /// Проверка корректности вычисления курса студента и проверки его положительных оценок
        /// </summary>
        [Fact]
        public void Test7()
        {
            Student masha = new Student("mAsHa", 18, 6);
            bool kirill = masha;
            Assert.False(kirill);
            int stage = (int) masha;
            Assert.Equal(1, stage);
        }
    }
}