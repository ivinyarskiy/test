using NUnit.Framework;

namespace Revers_Test
{
    public class Tests
    {
      
        [Test]
        public void ReverserMethod_Test()
        {
            var Revers = new Revers();
            Revers.Reverser("q1w2e3r4");
            Assert.AreEqual("r1e2w3q4", Revers.Reverser("q1w2e3r4"));
        }
    }
}