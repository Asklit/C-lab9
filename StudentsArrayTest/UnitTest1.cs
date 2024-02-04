using lab9;
namespace StudentArrayTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Проверка корректности создания объекта класса
        /// </summary>
        [Fact]
        public void Test1()
        {
            StudentsArray sa = new(5, ["Pasha", "Masha", "Polina", "Timofey", "Dasha"], [18, 20, 21, 22, 19], [5, 6, 7, 10, 10]);
            Assert.Equal("Polina", sa[2].Name);
            Assert.Equal(21, sa[2].Age);
            Assert.Equal(7, sa[2].Gpa);
        }

        /// <summary>
        /// Проверка корректности копирования объекта
        /// </summary>
        [Fact]
        public void Test2()
        {
            StudentsArray sa1 = new(4);
            StudentsArray sa2 = new(sa1);
            Assert.Equal(sa1[2].Name, sa2[2].Name);
            Assert.Equal(sa1[2].Age, sa2[2].Age);
            Assert.Equal(sa1[2].Gpa, sa2[2].Gpa);
        }
    }
}