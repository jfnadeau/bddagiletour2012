using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace MvcMusicStore.Tests.Pages
{
    public class PanierPage : LoadableComponent<PanierPage>
    {
        private readonly IWebDriver _webDriver;

        public PanierPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            PageFactory.InitElements(_webDriver, this);
        }

        protected override void ExecuteLoad()
        {
            _webDriver.Navigate().GoToUrl("http://bddagiletour.azurewebsites.net/ShoppingCart");
        }

        protected override bool EvaluateLoadedStatus()
        {
            return _webDriver.Title == "Panier";
        }
    }
}
