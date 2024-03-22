using NUnit.Framework;
using lab4_main;

namespace lab4
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            Aspirant aspirant = new Aspirant("Петро", 25, "Київський політехнічний інститут", "Дослідження в галузі штучного інтелекту");
            Assert.AreEqual(aspirant.Age, 25);
            Assert.AreEqual(aspirant.Name, "Петро");
            Assert.AreEqual(aspirant.University, "Київський політехнічний інститут");
            Assert.AreEqual(aspirant.ResearchTopic, "Дослідження в галузі штучного інтелекту");
        }
    }
}
