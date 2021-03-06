using DockerWorkflow.Lib;
using Xunit;

namespace DockerWorkflow.LibTest
{
    public class HelloServiceTest
    {
        private readonly IHelloService _helloService;

        public HelloServiceTest()
        {
            _helloService = new HelloService("test user 1");
        }

        [Fact]
        public void UserNameTest()
        {
            string userName = _helloService.UserName;
            Assert.Equal("test user 1", userName);
        }

        [Fact]
        public void GetHelloMessageTest()
        {
            string helloMessage = _helloService.GetHelloMessage();
            Assert.Equal("hello test user 1", helloMessage);
        }
    }
}
