using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Xunit;

namespace AzFn.StarterKit.Test
{
    public class Function1Test
    {
        private readonly ILogger logger = NullLoggerFactory.Instance.CreateLogger("Null Logger");

        [Fact]
        public async void HttpTriggerWithParams()
        {
            var request = TestFactory.CreateHttpRequest("name", "Bill");
            var response = (OkObjectResult)await Hello.Run(request, logger);
            Assert.IsType<string>(response.Value);
            string rstr = response.Value as string;
            Assert.StartsWith("Hello, Bill.", rstr);
        }

        [Fact]
        public async void HttpTriggerWithoutParams()
        {
            var request = TestFactory.CreateHttpRequest("", "");
            var response = (OkObjectResult)await Hello.Run(request, logger);
            Assert.IsType<string>(response.Value);
            string rstr = response.Value as string;
            Assert.StartsWith("This HTTP triggered function executed successfully", rstr);
        }
    }
}
