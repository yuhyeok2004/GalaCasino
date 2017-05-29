using AventStack.ExtentReports;
using NUnit;
using NUnit.Framework;

namespace GalaCasino
{
    [TestFixture]
    public class Program
    {

        public ExtentReports extent;
        public ExtentTest reporter;

        static void Main(string[] args)
        {
        }

        [OneTimeSetUp]
        public void StartReport()
        {
            AssistFunctions assistFunc = new AssistFunctions();

            extent = new ExtentReports();
            assistFunc.Extent(extent);

            ExcelLib.PopulateInCollection(@"C:\Users\Tzahi.Ben\Documents\Visual Studio 2015\Projects\GalaCasino\GalaCasino\Data.xlsx");
        }

        [SetUp]
        public void Initialize()
        {
        }

        [TearDown]
        public void CleanUp()
        {
        }
        
        [OneTimeTearDown]
        public void EndReport()
        {
            AssistFunctions assistFunc = new AssistFunctions();
            extent.Flush();
            assistFunc.killProcess("ChromeDriver");
        }
    }
}
