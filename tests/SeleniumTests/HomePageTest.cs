using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EShopOnWebTest {
   static void Main(string[] args) {
      IWebDriver driver = new ChromeDriver();
      
      // Navigate to the EShopOnWeb homepage
      driver.Navigate().GoToUrl("https://localhost:5001");
      
      // Click the "Store" link
      IWebElement storeLink = driver.FindElement(By.LinkText("Store"));
      storeLink.Click();
      
      // Assert that the resulting page contains the text "Welcome to EShopOnWeb"
      IWebElement welcomeMessage = driver.FindElement(By.XPath("//h1[contains(text(), 'Welcome to EShopOnWeb')]"));
      if (welcomeMessage == null) {
         throw new Exception("Could not find welcome message on Store page");
      }
      
      // Close the browser window
      driver.Quit();
   }
}