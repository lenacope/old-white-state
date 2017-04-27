using NUnit.Framework;
using CESUIDriver;

namespace CESUITests
{
    [TestFixture]
    public class settingsTests
    {
        private AppOpener _appOpener;
        private SettingsModalWindow settingsModal;

        [SetUp]
        public void SetUp()
        {
            _appOpener = new AppOpener();
            MainWindow mainWindow = _appOpener.GETMainWindow();
            mainWindow.openSettings(mainWindow.VisibleMainWindow);

            settingsModal = new SettingsModalWindow(mainWindow.VisibleMainWindow);
        }


        [Test]
        public void chartFontsSetCorrectly()
        {
            settingsModal.openTab("Chart");

            ChartTab chartTab = new ChartTab(settingsModal.Tab);

            Assert.That(chartTab.AxisTitleFont, Is.EqualTo("Arial, 14 pt, Bold"));
            Assert.That(chartTab.AxisSubtitleFont, Is.EqualTo("Arial, 9 pt, Normal"));
            Assert.That(chartTab.TickFont, Is.EqualTo("Arial, 8 pt, Normal"));
         }

        [Test]
        public void multipleDatasheetsEnabled()
        {
            settingsModal.openTab("Datasheet");
            
            DatasheetTab datasheetTab = new DatasheetTab(settingsModal.Tab);
            
            Assert.True(datasheetTab.AreMultipleDatasheetsAllowed());
        }

        [Test]
        public void checkAppLanguage()
        {
            settingsModal.openTab("Language");

            LanguageTab languageTab = new LanguageTab(settingsModal.Tab);

            Assert.That(languageTab.AppLanguage, Is.EqualTo("English"));
        }

      
        [TearDown]
        public void tearDownTests()
        {
            _appOpener.Application.Kill();

        }
        
    }

}
