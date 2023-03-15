using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace PasswordGenerator.Pages;

public class Index_Tests : PasswordGeneratorWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
