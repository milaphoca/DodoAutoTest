﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UnitTestProject1
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Отправка анкеты")]
    public partial class ОтправкаАнкетыFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "rabotavdodo1.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("ru-RU"), "Отправка анкеты", "\tДля того чтобы работать в Додо\r\n\tКак пользователь\r\n\tЯ хочу заполнить анкету", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Успешная отправка анкеты")]
        [NUnit.Framework.CategoryAttribute("позитивный")]
        public virtual void УспешнаяОтправкаАнкеты()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Успешная отправка анкеты", new string[] {
                        "позитивный"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("я нахожусь на главной странице", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Допустим ");
#line 9
 testRunner.When("я нажимаю кнопку Хочу работать с вами", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line 10
 testRunner.Then("Браузер перенаправляет на страницу с анкетой", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line 11
 testRunner.Given("я выбираю город \'Сыктывкар\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Допустим ");
#line 12
 testRunner.And("я выбираю пиццерию", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 13
 testRunner.And("я выбираю кем хочу работать", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 14
 testRunner.And("я указываю фамилию \'Иванов\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 15
 testRunner.And("я указываю имя \'Иван\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 16
 testRunner.And("я указываю дату рождения \'5\' \'Январь\' \'1990\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 17
 testRunner.And("я указываю адрес проживания \'г. Сыктывкар, ул. Пермская, д. 8\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 18
 testRunner.And("я указываю телефон \'89033333333\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 19
 testRunner.And("я выбираю когда мне удобно работать", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 20
 testRunner.And("я указываю есть ли у меня медкнижка", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 21
 testRunner.And("я указываю если ли у меня дети", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 22
 testRunner.And("я указываю курю ли я", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 23
 testRunner.And("я выбираю как узнала о Додо \'Газета\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 24
 testRunner.And("я указываю опыт работы \'5 лет\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 25
 testRunner.And("я указываю увлечения \'Баскетбол\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 26
 testRunner.When("я нажимаю кнопку Отправить анкету", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line 27
 testRunner.Then("Браузер перенаправляет на страницу Спасибо", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Неуспешная отправка анкеты")]
        [NUnit.Framework.CategoryAttribute("негативный")]
        public virtual void НеуспешнаяОтправкаАнкеты()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Неуспешная отправка анкеты", new string[] {
                        "негативный"});
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
 testRunner.Given("я нахожусь на главной странице", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Допустим ");
#line 32
 testRunner.When("я нажимаю кнопку Хочу работать с вами", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line 33
 testRunner.Then("Браузер перенаправляет на страницу с анкетой", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line 34
 testRunner.Given("я выбираю город \'Сыктывкар\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Допустим ");
#line 35
 testRunner.And("я выбираю пиццерию", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 36
 testRunner.And("я выбираю кем хочу работать", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 37
 testRunner.And("я указываю фамилию \'Иванов\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 38
 testRunner.And("я указываю имя \'Иван\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 39
 testRunner.And("я указываю дату рождения \'5\' \'Январь\' \'1990\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 40
 testRunner.And("я указываю адрес проживания \'г. Сыктывкар, ул. Пермская, д. 8\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 42
 testRunner.And("я выбираю когда мне удобно работать", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 43
 testRunner.And("я указываю есть ли у меня медкнижка", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 44
 testRunner.And("я указываю если ли у меня дети", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 45
 testRunner.And("я указываю курю ли я", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 46
 testRunner.And("я выбираю как узнала о Додо \'Газета\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 47
 testRunner.And("я указываю опыт работы \'5 лет\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 48
 testRunner.And("я указываю увлечения \'Баскетбол\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 49
 testRunner.When("я указываю телефон \'8\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line 50
 testRunner.Then("кнопка неактивна", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion