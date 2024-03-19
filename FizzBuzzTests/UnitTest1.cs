using fizzbuzz;
namespace TestProject2
{
    public class Tests
    {
        private List<Tuple<int, string>> _fb { get; set; }
        private List<Tuple<int, string>> _fbEven { get; set; }

        [SetUp]
        public void Setup()
        {
            _fb = new List<Tuple<int, string>>()
            {
                Tuple.Create<int, string>(3, "Micah"),
                Tuple.Create<int, string>(5, "Bright"),
            };

            _fbEven = new List<Tuple<int, string>>()
            {
                Tuple.Create<int, string>(2, "Even"),
            };
        }

        [Test]
        public void TestBasic()
        {

            var fboutput = FizzBuzzClass.FizzBuzz(10, _fb);
            string scmp = "12Micah4BrightMicah78MicahBright";
            string scmp2 = "";
            foreach(string s in fboutput)
            {
                scmp2 += s;
            }
            Console.WriteLine(scmp);
            Console.WriteLine(scmp2);
            Assert.IsTrue(scmp.Equals(scmp2));
        }

        [Test]
        public void TestMax()
        {
            var itm = FizzBuzzClass.GetFizzBuzzItem(int.MaxValue, _fb);
            Assert.IsTrue(itm == int.MaxValue.ToString());
        }

        [Test]
        public void TestEven()
        {
            Assert.IsTrue(FizzBuzzClass.GetFizzBuzzItem(2, _fbEven)=="Even");
            Assert.IsTrue(FizzBuzzClass.GetFizzBuzzItem(4, _fbEven)=="Even");
            Assert.IsFalse(FizzBuzzClass.GetFizzBuzzItem(25, _fbEven)=="Even");
        }

        [Test]
        public void TestOdd()
        {
            Assert.IsTrue(FizzBuzzClass.GetFizzBuzzItem(3, _fbEven) == "3");
            Assert.IsTrue(FizzBuzzClass.GetFizzBuzzItem(5, _fbEven) == "5");
        }

    }
}