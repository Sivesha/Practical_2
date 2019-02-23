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

          string result4= p.Prefix("my name is");
          Assert.AreEqual("10,3:my name is",result4);

          string result5= p.Prefix("see sharp..?!");
          Assert.AreEqual("14,2:see sharp..?!",result5);

          string result6= p.Prefix(" hi ..Hello");
          Assert.AreEqual("11,2: hi ..Hello",result6);
        
        }
        // public void Test2()
        // {
        //    Program p=new Program();
        //   string result= p.Prefix("");
        //   Assert.AreEqual("0,0:",result);
        
        // }
        // public void Test3()
        // {
        //    Program p=new Program();
        //   string result= p.Prefix("what ... did you say??");
        //   Assert.AreEqual("27,5:what ... did you say??",result);
        
        // }
    }
}