using Xunit;

namespace CiCdTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod,Fact]
        public void TestMethod1()
        {

        }
        [Fact]
        public void Just_For_Run_Sample_Test()
        {
            // Arrange
            var myvar = "test";

            //Act
            bool result = (myvar == "test");

            //Assert 
            Xunit.Assert.True(result);
        }
    }
}