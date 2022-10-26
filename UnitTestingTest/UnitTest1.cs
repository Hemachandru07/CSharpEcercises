using NUnit.Framework;
using UnitTesting;
using Moq;

namespace UnitTestingTest
{
    public class Tests
    {
        public IEmployee<Employee> Iobj;
        public Mock<IEmployee<Employee>> mockobj;
        [SetUp]
        public void SetUp()
        {
            Iobj = new Employee();
            mockobj = new Mock<IEmployee<Employee>>();
        }

        [Test]
        public void TestAdd()
        {
            int actualresult = Iobj.add(10, 20);
            int expectedresult = 200;
            Assert.That(actualresult, Is.EqualTo(expectedresult));
        }

        [Test]
        public void TestName()
        {
            string actualresult = Iobj.message("Ram");
            string expectedresult = "HelloRam";
            Assert.That(expectedresult, Is.EqualTo(actualresult));
        }

        [Test]
        public void TestCheckSalPositive()
        {
            mockobj.Setup(x => x.add(40, 40)).Returns(80);
            bool actualresult = Iobj.checksal(40);
            bool expectedresult = true;
            Assert.That(actualresult, Is.EqualTo(expectedresult));
        }

        [Test]
        public void TestCheckSalNegative()
        {
            mockobj.Setup(x => x.add(40, 50)).Returns(80);
            bool actualresult = Iobj.checksal(20);
            bool expectedresult = false;
            Assert.That(actualresult, Is.EqualTo(expectedresult));
        }
    }
}