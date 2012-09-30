using OpenQA.Selenium;

namespace MvcMusicStore.Tests.WebDriver
{
    public class Par
    {
        public static By Libelle(string libelle)
        {
            string xpath = "id(//label[text() = \"" + libelle + "\"]/@for)";
            return By.XPath(xpath);
        }
    }
}
