using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace MvcMusicStore.Tests.Pages
{
    public class AuthentificationPage : LoadableComponent<AuthentificationPage>
    {
        private readonly IWebDriver _webDriver;

        [FindsBy(Using = "UserName")]
        private readonly IWebElement _userName = null;
        [FindsBy(Using = "Password")]
        private readonly IWebElement _password = null;
        [FindsBy(How = How.TagName, Using = "input")]
        private readonly IWebElement _submit = null;

        public string Usager
        {
            set
            {
                _userName.SendKeys(value);
            }
        }

        public string MotDePasse
        {
            set
            {
                _password.SendKeys(value);
            }
        }

        public AuthentificationPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            PageFactory.InitElements(_webDriver, this);
        }

        public void Soumettre()
        {
            _submit.Submit();
        }

        protected override void ExecuteLoad()
        {
            _webDriver.Navigate().GoToUrl("http://bddagiletour.azurewebsites.net/Account/LogOn");
        }

        protected override bool EvaluateLoadedStatus()
        {
            return _webDriver.Title == "Se connecter";
        }
    }
}
