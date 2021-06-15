using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Personal.SeleniumWebDriver
{
    public class TestMethods
    {
        const string homeUrl = "https://ultimateqa.com/automation";
        const string aboutUrl = "https://ultimateqa.com/about/";
        const string homeTitle = "Automation Practice - Ultimate QA";

        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {

                driver.Navigate().GoToUrl(homeUrl);

                Helpers.Pause();

                Assert.Equal(homeTitle, driver.Title);
                Assert.Equal(homeUrl, driver.Url);
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void ReloadHomePage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(homeUrl);

                Helpers.Pause();

                driver.Navigate().Refresh();

                Assert.Equal(homeTitle, driver.Title);
                Assert.Equal(homeUrl, driver.Url);
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void ReloadHomePageOnBack()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(homeUrl);
                Helpers.Pause();

                driver.Navigate().GoToUrl(aboutUrl);
                Helpers.Pause();

                driver.Navigate().Back();
                Helpers.Pause();

                Assert.Equal(homeTitle, driver.Title);
                Assert.Equal(homeUrl, driver.Url);
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void ReloadHomePageOnForward()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(aboutUrl);
                Helpers.Pause();

                driver.Navigate().GoToUrl(homeUrl);
                Helpers.Pause();
                
                driver.Navigate().Back();
                Helpers.Pause();

                driver.Navigate().Forward();
                Helpers.Pause();

                Assert.Equal(homeTitle, driver.Title);
                Assert.Equal(homeUrl, driver.Url);
            }
        }
    }
}