using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
           Program p=new Program();
          string result= p.Prefix("hello");
          Assert.AreEqual("5,1:hello",result);
          string result2= p.Prefix("");
          Assert.AreEqual("0,0:",result2);
          string result3= p.Prefix("what ... did you say??");
          Assert.AreEqual("22,5:what ... did you say??",result3);
        
        }
        
    }
}