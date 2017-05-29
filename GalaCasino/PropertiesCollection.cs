using OpenQA.Selenium;

namespace GalaCasino
{
    class PropertiesCollection
    {
        public static IWebDriver driver { get; set; }
    }

    enum PropertyType
    {
        Id,
        Name,
        ClassName
    }

    enum BrowserType
    {
        Chrome,
        Firefox,
        IE
    }
}
