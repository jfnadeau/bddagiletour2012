using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcMusicStore.Tests.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MvcMusicStore.Tests.Etapes
{
    [Binding]
    public class CommandesEtapes
    {
        private readonly IWebDriver _webDriver;

        public CommandesEtapes(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [Given]
        public void Soit_que_je_suis_sur_la_page_du_panier_d_achat()
        {
            PanierPage p = new PanierPage(_webDriver).Load();
        }

        [Then]
        public void Alors_mon_paiment_est_complété_avec_succès()
        {
            CommandePage p = new CommandePage(_webDriver).Load();
            Assert.IsTrue(p.EstCommandeCompletee());
        }
    }
}
