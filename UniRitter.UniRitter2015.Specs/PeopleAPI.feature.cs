﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UniRitter.UniRitter2015.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("People API")]
    public partial class PeopleAPIFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PeopleAPI.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "People API", "In order to know who places posts and comments on my blog\r\nAs a blog owner\r\nI wan" +
                    "t to have an API that allows my apps to manage user information", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "id",
                        "firstName",
                        "lastName",
                        "email",
                        "url"});
            table1.AddRow(new string[] {
                        "8d0d477f-1378-4fc1-bb47-29eb3ea959e1",
                        "John",
                        "Doe",
                        "john@email.com",
                        "http://john.doe.com"});
            table1.AddRow(new string[] {
                        "58b024e9-57dc-49e4-8fc9-2d4d82bf1670",
                        "Jane",
                        "Doe",
                        "jane@email.com",
                        "http://jane.doe.com"});
            table1.AddRow(new string[] {
                        "1a5fd0be-d654-40ff-8190-ca59e3b52e76",
                        "Jack",
                        "Doe",
                        "jack@email.com",
                        "http://jack.doe.com"});
#line 7
 testRunner.Given("an API populated with the following people", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get all people entries")]
        [NUnit.Framework.CategoryAttribute("integrated")]
        public virtual void GetAllPeopleEntries()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get all people entries", new string[] {
                        "integrated"});
#line 15
 this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 16
 testRunner.Given("the populated API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
 testRunner.When("I GET from the /people API endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("I get a list containing the populated resources", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get a specific person entry")]
        [NUnit.Framework.CategoryAttribute("integrated")]
        [NUnit.Framework.TestCaseAttribute("8d0d477f-1378-4fc1-bb47-29eb3ea959e1", null)]
        [NUnit.Framework.TestCaseAttribute("58b024e9-57dc-49e4-8fc9-2d4d82bf1670", null)]
        [NUnit.Framework.TestCaseAttribute("1a5fd0be-d654-40ff-8190-ca59e3b52e76", null)]
        public virtual void GetASpecificPersonEntry(string id, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "integrated"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get a specific person entry", @__tags);
#line 21
 this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 22
 testRunner.Given("the populated API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
 testRunner.When(string.Format("I GET from the /people/{0} API endpoint", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.Then("I receive a success (code 200) return message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.And("the data matches that id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add a person")]
        [NUnit.Framework.CategoryAttribute("integrated")]
        public virtual void AddAPerson()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add a person", new string[] {
                        "integrated"});
#line 33
 this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "firstName",
                        "lastName",
                        "email",
                        "url"});
            table2.AddRow(new string[] {
                        "Josh",
                        "Doe",
                        "josh@email.com",
                        "http://josh.doe.com"});
#line 34
 testRunner.Given("a person resource as described below:", ((string)(null)), table2, "Given ");
#line 37
 testRunner.When("I post it to the /people API endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then("I receive a success (code 200) return message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
 testRunner.And("I receive the posted resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("the posted resource now has an ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("I can fetch it from the API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Invalid person data on insertion")]
        [NUnit.Framework.CategoryAttribute("integrated")]
        [NUnit.Framework.TestCaseAttribute("missing firstName", "{\"LastName\":\"de Tal\",\"Email\":\"fulano@email.com\",\"Url\":\"http://fulano.com.br\"}", ".*firstName.*", null)]
        [NUnit.Framework.TestCaseAttribute("invalid email", "{\"LastName\":\"de Tal\",\"FirstName\":\"fulano\", \"Email\":\"fulano\",\"Url\":\"http://fulano." +
            "com.br\"}", ".*email.*", null)]
        public virtual void InvalidPersonDataOnInsertion(string @case, string data, string messageRegex, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "integrated"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Invalid person data on insertion", @__tags);
#line 44
 this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 45
 testRunner.Given(string.Format("a {0} resource", @case), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
 testRunner.When(string.Format("I post the following data to the /people API endpoint: {0}", data), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then("I receive an error (code 400) return message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
 testRunner.And(string.Format("I receive a message that conforms {0}", messageRegex), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
