using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;


class PrimerPoint
{
    //private const string Url = "https://testing.todorvachev.com";
    private const string Url = "https://testing.todorvachev.com/name/";

    static void Main()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(Url);
        Thread.Sleep(2000);
        IWebElement paginaSelecto = driver.FindElement(By.Id("menu-item-106"));
        paginaSelecto.Click();
        Thread.Sleep(3000);
        driver.FindElement(By.CssSelector("#main-content > article.mh-loop-item.mh-clearfix.post-111.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-selectors > div > header > h3 > a")).Click();
        //driver.FindElement(By.CssSelector(".post-111 .attachment-mh-magazine-lite-medium")).Click();
        Thread.Sleep(3000);
        /*
        Actions action = new Actions(driver);
        action.DragAndDropToOffset(driver.FindElement(By.XPath("put an element path which **is in the screen now**, such as a label")), 0, -250);
        action.Build().Perform();
        */
        IWebElement espacioName = driver.FindElement(By.Name("myName"));
        espacioName.SendKeys("Prueba");
        Thread.Sleep(3000);
        INavigation navigation = driver.Navigate();
        navigation.Refresh();
        //se va a devolver en la pagina 
        navigation.Back();
        navigation.Forward();
        driver.Close();
    }
}