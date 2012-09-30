using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace MvcMusicStore.Tests.Pages
{
    public class CommandePage : LoadableComponent<CommandePage>
    {
        private readonly IWebDriver _webDriver;

        public CommandePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            PageFactory.InitElements(_webDriver, this);
        }

        public bool EstCommandeCompletee()
        {
            return _webDriver.Title == "La commande est complétée.";
        }

        protected override void ExecuteLoad()
        {
            _webDriver.Navigate().GoToUrl("http://bddagiletour.azurewebsites.net/Checkout/AddressAndPayment");
        }

        protected override bool EvaluateLoadedStatus()
        {
            return _webDriver.Title == "Adresse et paiement";
        }
    }
}
