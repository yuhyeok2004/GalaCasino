using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnit
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
}
