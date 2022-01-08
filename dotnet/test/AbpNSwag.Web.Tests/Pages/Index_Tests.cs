using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AbpNSwag.Pages
{
    public class Index_Tests : AbpNSwagWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
