using AsmitaEnterprises.Services;
using Xunit;

namespace AsmitaEnterprises.Tests;

public class WhatsAppServiceTests
{
    private readonly WhatsAppService _waService = new();

    [Fact]
    public void GetFreeDemoUrl_ReturnsEncodedWhatsAppLinkWithCorrectNumber()
    {
        var url = _waService.GetFreeDemoUrl("en");

        Assert.StartsWith("https://wa.me/919834555868?text=", url);
        Assert.Contains("Hello%20Asmita%20Enterprises", url);
        Assert.Contains("free%20water%20filter%20demo", url);
    }

    [Fact]
    public void GetProductEnquiryUrl_IncludesProductNameAndLanguage()
    {
        var url = _waService.GetProductEnquiryUrl("RO Water Purifier", "en");

        Assert.StartsWith("https://wa.me/919834555868?text=", url);
        Assert.Contains("RO%20Water%20Purifier", url);
    }

    [Fact]
    public void GetServiceEnquiryUrl_IncludesServiceName()
    {
        var url = _waService.GetServiceEnquiryUrl("Installation", "en");

        Assert.StartsWith("https://wa.me/919834555868?text=", url);
        Assert.Contains("Installation", url);
    }
}
