using MvcMusicStore.Tests.Pages;
using MvcMusicStore.Tests.WebDriver;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MvcMusicStore.Tests.Etapes
{
    [Binding]
    public class WebEtapes
    {
        private readonly IWebDriver _webDriver;

        public WebEtapes(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [Given]
        public void Soit_que_je_suis_un_client_authentifié()
        {
            AuthentificationPage p = new AuthentificationPage(_webDriver).Load();
            p.Usager = "admin";
            p.MotDePasse = "qwerty123";

            p.Soumettre();
        }

        [When]
        public void Quand_je_clique_sur_lien_LIBELLE(string libelle)
        {
            _webDriver.FindElement(By.PartialLinkText(libelle)).Click();
        }

        [When]
        public void Quand_que_je_saisi_les_informations_suivantes(Table table)
        {
            foreach(TableRow rangee in table.Rows)
            {
                IWebElement champ = _webDriver.FindElement(Par.Libelle(rangee["Champ"]));
                champ.SendKeys(rangee["Valeur"]);
            }
        }

        [When]
        public void Quand_que_je_soumet_le_formulaire()
        {
            IWebElement s = _webDriver.FindElement(By.TagName("form"));
            s.Submit();
        }
    }
}
