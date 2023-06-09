﻿using OpenQA.Selenium;
using ManualTestingProjectPLUS.code.factoryBrowser;

namespace ManualTestingProjectPLUS.code.Session
{
    public class Session
    {   
        // atributo del mismo tipo
        private static Session instance = null;
        private IWebDriver browser;
        // constrcutor privado
        private Session() 
        {
            browser = FactoryBrowser.Make("chrome").Create();
        }


        // metodo estatico publico para su accesso global
        public static Session Instance() 
        {
            if (instance == null) 
            { 
                instance = new Session();
            }

            return instance;
        }

        public void CloseBrowser() {
            instance = null;
            browser.Quit();
        }


        public IWebDriver GetBrowser()
        {
            return browser;
        }

    }
}
