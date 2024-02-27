using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Saucedemo_UI.src.core
{
    internal class DriverManager
    {

        private static IWebDriver? driver;

        public static IWebDriver GetWebDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver(GetGeneratedDriverPath());
            }
            driver.Manage().Window.Maximize();
            return driver;
        }

        public static void QuitDriver()
        {
            if (driver != null)
            {
                driver.Dispose();
                driver = null;
            }
        }


        private static string GetGeneratedDriverPath()
        {
            string driverPath = "";
            string hostPath = Configs.DRIVER_PATH;
            if (hostPath != null)
            {
                driverPath = hostPath;
            }
            else
            {
                string path = Environment.CurrentDirectory;
               
                string baseDir = path.Split("bin")[0];

                Console.WriteLine(baseDir);
                driverPath = baseDir + "src\\resources\\drivers\\chromedriver.exe";
                Console.WriteLine(driverPath);
            }

            return driverPath;
        }

    }
}
