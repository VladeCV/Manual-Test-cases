﻿namespace ManualTestingProjectPLUS.code.factoryBrowser
{
    public class FactoryBrowser
    {

        public static IBrowser Make(String type)
        {
            IBrowser browser;

            switch (type)
            {
                case "chrome":
                    browser = new Chrome();
                    break;
                case "firefox":
                    browser = new Firefox();
                    break;
                case "edge":
                    browser = new Edgge();
                    break;
                case "grid":
                    browser = new Grid();
                    break;
                default:
                    browser = new Chrome();
                    break;
            }
            return browser;
        }


    }
}
