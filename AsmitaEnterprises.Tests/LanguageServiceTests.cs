using AsmitaEnterprises.Services;
using Xunit;

namespace AsmitaEnterprises.Tests;

public class LanguageServiceTests
{
    private readonly LanguageService _langService = new();

    [Fact]
    public void DefaultLanguage_IsEnglish()
    {
        Assert.Equal("en", _langService.CurrentLanguage);
        Assert.Equal("Home", _langService.GetText("Nav_Home"));
    }

    [Fact]
    public void SetLanguage_ToMarathi_UpdatesTextAndTriggersEvent()
    {
        bool eventFired = false;
        _langService.OnLanguageChanged += () => eventFired = true;

        _langService.SetLanguage("mr");

        Assert.Equal("mr", _langService.CurrentLanguage);
        Assert.True(eventFired);
        Assert.Equal("मुख्य पृष्ठ", _langService.GetText("Nav_Home"));
    }

    [Fact]
    public void SetLanguage_ToHindi_UpdatesText()
    {
        _langService.SetLanguage("hi");

        Assert.Equal("hi", _langService.CurrentLanguage);
        Assert.Equal("होम", _langService.GetText("Nav_Home"));
    }
}
