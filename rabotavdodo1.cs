using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1
{
    [Binding]
    public class ОтправкаАнкетыSteps
    {
        private IWebDriver driver;
        string url = "http://rabotavdodo.ru/";
        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
        }

        [Given(@"я нахожусь на главной странице")]
        public void ДопустимЯНахожусьНаГлавнойСтранице()
        {
            driver.Navigate().GoToUrl(url);

        }

        [Given(@"я выбираю город '(.*)'")]
        public void ДопустимЯВыбираюГород(String g0)
        {
            IWebElement selectElem = driver.FindElement(By.XPath("/ html / body / div / form / div / div[3] / div / div[2] / select"));
            SelectElement select = new SelectElement(selectElem);
            select.SelectByText(g0);
        }

        [Given(@"я выбираю пиццерию")]
        public void ДопустимЯВыбираюПиццерию()
        {
            System.Threading.Thread.Sleep(1000);
            IWebElement el = driver.FindElement(By.Id("unit_3"));
            new Actions(driver).MoveToElement(el).Click().Perform();
        }

        [Given(@"я выбираю кем хочу работать")]
        public void ДопустимЯВыбираюКемХочуРаботать()
        {
            System.Threading.Thread.Sleep(1000);
            IWebElement el = driver.FindElement(By.Id("position_2"));
            new Actions(driver).MoveToElement(el).Click().Perform();
            el = driver.FindElement(By.Id("position_3"));
            new Actions(driver).MoveToElement(el).Click().Perform();

        }

        [Given(@"я указываю фамилию '(.*)'")]
        public void ДопустимЯУказываюФамилию(String f0)
        {
            IWebElement el = driver.FindElement(By.Id("name_01"));
            new Actions(driver).MoveToElement(el).Click().SendKeys(f0).Perform();

        }

        [Given(@"я указываю имя '(.*)'")]
        public void ДопустимЯУказываюИмя(String i0)
        {
            IWebElement el = driver.FindElement(By.Id("name_02"));
            new Actions(driver).MoveToElement(el).Click().SendKeys(i0).Perform();
        }

        [Given(@"я указываю дату рождения '(.*)' '(.*)' '(.*)'")]
        public void ДопустимЯУказываюДатуРождения(String d0, String d1, String d2)
        {
            IWebElement selectElem = driver.FindElement(By.Id("birthday_day"));
            SelectElement select = new SelectElement(selectElem);
            select.SelectByText(d0);
            selectElem = driver.FindElement(By.Id("birthday_month"));
            select = new SelectElement(selectElem);
            select.SelectByText(d1);
            selectElem = driver.FindElement(By.Id("birthday_year"));
            select = new SelectElement(selectElem);
            select.SelectByText(d2);
        }

        [Given(@"я указываю адрес проживания '(.*)'")]
        public void ДопустимЯУказываюАдресПроживания(String a0)
        {
            IWebElement el = driver.FindElement(By.Id("address"));
            new Actions(driver).MoveToElement(el).Click().SendKeys(a0).Perform();
        }

        [Given(@"я указываю телефон '(.*)'")]
        [When(@"я указываю телефон '(.*)'")]
        public void ДопустимЯУказываюТелефон(String p0)
        {
            IWebElement el = driver.FindElement(By.Id("phonenumber"));
            new Actions(driver).MoveToElement(el).Click().SendKeys(p0).Perform();
        }


        [Given(@"я выбираю когда мне удобно работать")]
        public void ДопустимЯВыбираюКогдаМнеУдобноРаботать()
        {
            IWebElement el = driver.FindElement(By.Id("worktime_04"));
            new Actions(driver).MoveToElement(el).Click().Perform();
        }

        [Given(@"я указываю есть ли у меня медкнижка")]
        public void ДопустимЯУказываюЕстьЛиУМеняМедкнижка()
        {
            IWebElement el = driver.FindElement(By.Id("med"));
            new Actions(driver).MoveToElement(el).Click().Perform();
        }

        [Given(@"я указываю если ли у меня дети")]
        public void ДопустимЯУказываюЕслиЛиУМеняДети()
        {
            IWebElement el = driver.FindElement(By.Id("kids"));
            new Actions(driver).MoveToElement(el).Click().Perform();
        }

        [Given(@"я указываю курю ли я")]
        public void ДопустимЯУказываюКурюЛиЯ()
        {
            IWebElement el = driver.FindElement(By.Id("smoking"));
            new Actions(driver).MoveToElement(el).Click().Perform();
        }

        [Given(@"я выбираю как узнала о Додо '(.*)'")]
        public void ДопустимЯВыбираюКакУзналаОДодо(String u0)
        {
            IWebElement selectElem = driver.FindElement(By.Id("applicantSource"));
            SelectElement select = new SelectElement(selectElem);
            select.SelectByText(u0);
        }

        [Given(@"я указываю опыт работы '(.*)'")]
        public void ДопустимЯУказываюОпытРаботы(String o0)
        {
            IWebElement el = driver.FindElement(By.Id("workExperience"));
            new Actions(driver).MoveToElement(el).Click().SendKeys(o0).Perform();
        }

        [Given(@"я указываю увлечения '(.*)'")]
        public void ДопустимЯУказываюУвлечения(String uv0)
        {
            IWebElement el = driver.FindElement(By.Id("hobby"));
            new Actions(driver).MoveToElement(el).Click().SendKeys(uv0).Perform();
        }

        [When(@"я нажимаю кнопку Хочу работать с вами")]
        public void ЕслиЯНажимаюКнопкуХочуРаботатьСВами()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/button")).Click();
        }

        [When(@"я нажимаю кнопку Отправить анкету")]
        public void ЕслиЯНажимаюКнопкуОтправитьАнкету()
        {
            driver.FindElement(By.Id("send")).Click();
        }

        [Then(@"Браузер перенаправляет на страницу с анкетой")]
        public void ТоБраузерПеренаправляетНаСтраницуСАнкетой()
        {
            if (driver.Url != "http://rabotavdodo.ru/Applicants/Form") Assert.Fail("Неверный адрес");
        }

        [Then(@"Браузер перенаправляет на страницу Спасибо")]
        public void ТоБраузерПеренаправляетНаСтраницуСпасибо()
        {
            if (driver.Url != "http://rabotavdodo.ru/Applicants/Thanks") Assert.Fail("Неверный адрес последней страницы");
            if (driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/h1")).Text != "Спасибо!") Assert.Fail("Нет спасибо");
        }
        [Then(@"кнопка неактивна")]
        public void ТоКнопкаНеактивна()
        {
            IWebElement el = driver.FindElement(By.TagName("body"));
            new Actions(driver).MoveToElement(el).Click().Perform();
            if (driver.FindElement(By.Id("send")).GetAttribute("disabled") != "true") Assert.Fail("Кнопка отправки активна");
        }
        [AfterScenario]
        public void Cleanup()
        {
            driver.Close();
        }
    }
}
