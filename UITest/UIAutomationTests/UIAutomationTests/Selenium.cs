using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutomationTests
{
    public class Selenium
    {
        IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [Test]
        public void Add_Country_Test()
        {
            var URL = "http://localhost:8080/";

            _driver.Manage().Window.Maximize();

            _driver.Navigate().GoToUrl(URL);

            Assert.IsNotNull(_driver);

            System.Threading.Thread.Sleep(1500);

            var botonAgregarPais = _driver.FindElement(By.CssSelector("a[href='/pais'] button"));
            botonAgregarPais.Click();

            System.Threading.Thread.Sleep(1500);

            var nombre = _driver.FindElement(By.Id("name"));
            nombre.SendKeys("Uruguay");

            System.Threading.Thread.Sleep(1500);

            var continente = _driver.FindElement(By.Id("continente"));
            var continenteSeleccion = continente.FindElements(By.TagName("option"));
            continenteSeleccion[4].Click();

            System.Threading.Thread.Sleep(1500);

            var idiomaInput = _driver.FindElement(By.Id("idioma"));
            idiomaInput.SendKeys("Español");

            System.Threading.Thread.Sleep(2000);

            var botonGuardar = _driver.FindElement(By.CssSelector("button.btn.btn-success"));
            botonGuardar.Click();
        }
    }
}
