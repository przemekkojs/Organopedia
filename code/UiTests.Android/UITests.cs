using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;

namespace UiTests.Android;

public class UITests
{
    private static WindowsDriver? driver;

    public static WindowsDriver App => driver ?? throw new NullReferenceException("AppiumDriver is null");

    [OneTimeSetUp]
    public void RunBeforeAnyTests()
    {
        AppiumServerHelper.StartAppiumLocalServer();

        var windowsOptions = new AppiumOptions
        {
            AutomationName = "windows",
            PlatformName = "Windows",
            App = "C:\\Programming\\Organopedia\\code\\Organopedia3\\bin\\Debug\\net9.0-windows10.0.19041.0\\win10-x64\\Organopedia3.exe",
        };

        driver = new WindowsDriver(windowsOptions);
    }

    [OneTimeTearDown]
    public void RunAfterAnyTests()
    {
        driver?.Quit();

        AppiumServerHelper.DisposeAppiumLocalServer();
    }

    [Test]
    public void AppLaunches()
    {
        var searchBar = FindUIElement("MainSearchBar");
        Assert.That(searchBar, Is.Not.Null);
    }

    [Test]
    public void SearchBarMainTest()
    {
        var searchBar = FindUIElement("MainSearchBar");

        searchBar.Clear();
        searchBar.SendKeys("Piszczałki");
        searchBar.SendKeys(Keys.Enter);
        
        try
        {
            var tile = FindUIElement("Piszczałki");
            Assert.That(tile, Is.Not.Null);
        }
        catch(Exception ex)
        {
            Assert.Fail(ex.Message);
        }
    }

    [Test]
    public void DetailsScreenAvailable()
    {
        var tile = FindUIElement("Piszczałki");
        tile.Click();

        Thread.Sleep(1000);

        var searchBar = FindUIElement("SearchBar");
        Assert.That(searchBar, Is.Not.Null);
    }

    [Test]
    public void SubDetailScreenAvailable()
    {
        var tile = FindUIElement("Piszczałki");
        tile.Click();

        Thread.Sleep(1000);

        var subTile = FindUIElement("Labialne drewniane");
        subTile.Click();

        Thread.Sleep(1000);

        Assert.Pass(); // Tutaj można, bo w sumie weszliśmy do ekranu
    }
    
    //[Test]
    // To ogólnie nie działa, bo jest problem z szukaniem takich elementów jak VerticalStackLayout czy ScrollView
    public void MainSearchBarTests()
    {
        var searchBar = FindUIElement("MainSearchBar");
        var container = FindUIElement("TilesContainerMain");

        searchBar.Clear();
        searchBar.SendKeys("Piszczałki");
        searchBar.SendKeys(Keys.Enter);
        
        var children = container.FindElements(By.XPath(".//*"));

        Assert.Equals(1, children.Count);
    }

    private AppiumElement FindUIElement(string id)
    {
        if (App is WindowsDriver)
        {
            return App.FindElement(MobileBy.AccessibilityId(id));
        }

        return App.FindElement(MobileBy.Id(id));
    }
}
