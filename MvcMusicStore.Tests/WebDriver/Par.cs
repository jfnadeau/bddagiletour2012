using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
