using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;

namespace MvcMusicStore.Tests.Etapes
{
    [Binding]
    public class WebDriverSupport
    {
        private readonly IObjectContainer _objectContainer;

        public WebDriverSupport(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void InitialiserWebDriver()
        {
            InternetExplorerDriver webDriver = new InternetExplorerDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(webDriver);
        }

        [AfterScenario]
        public void TerminerWebDriver()
        {
            _objectContainer.Resolve<IWebDriver>().Quit();
        }
    }
}
