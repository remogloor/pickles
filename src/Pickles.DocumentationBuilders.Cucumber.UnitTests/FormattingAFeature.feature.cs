﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.7.0.0
//      SpecFlow Generator Version:3.7.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PicklesDoc.Pickles.DocumentationBuilders.Cucumber.UnitTests
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.7.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Formatting A Feature")]
    public partial class FormattingAFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "FormattingAFeature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "Formatting A Feature", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A simple feature")]
        [NUnit.Framework.CategoryAttribute("cucumber")]
        public virtual void ASimpleFeature()
        {
            string[] tagsOfScenario = new string[] {
                    "cucumber"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A simple feature", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
    testRunner.Given("I have this feature description", @"Feature: Clearing Screen
    In order to restart a new set of calculations
    As a math idiot
    I want to be able to clear the screen

@workflow @slow
Scenario: Clear the screen
    Clear the screen by pressing C
    Given I have entered 50 into the calculator
    And I have entered 70 into the calculator
    When I press C
    Then the screen should be empty", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 21
    testRunner.When("I generate the documentation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
    testRunner.Then("the JSON file should contain", "[\r\n  {\r\n    \"id\": \"clearing-screen\",\r\n    \"keyword\": \"Feature\",\r\n    \"name\": \"Cle" +
                        "aring Screen\",\r\n    \"description\": \"In order to restart a new set of calculation" +
                        "s\\r\\nAs a math idiot\\r\\nI want to be able to clear the screen\",\r\n    \"tags\": []," +
                        "\r\n    \"line\": 1,\r\n    \"elements\": [\r\n      {\r\n        \"id\": \"clearing-screen;cle" +
                        "ar-the-screen\",\r\n        \"keyword\": \"Scenario\",\r\n        \"name\": \"Clear the scre" +
                        "en\",\r\n        \"description\": \"Clear the screen by pressing C\",\r\n        \"line\": " +
                        "7,\r\n        \"type\": \"scenario\",\r\n        \"tags\": [\r\n          {\r\n            \"na" +
                        "me\": \"@workflow\"\r\n          },\r\n          {\r\n            \"name\": \"@slow\"\r\n      " +
                        "    }\r\n        ],\r\n        \"steps\": [\r\n          {\r\n            \"keyword\": \"Give" +
                        "n\",\r\n            \"name\": \"I have entered 50 into the calculator\",\r\n            \"" +
                        "line\": 9,\r\n            \"hidden\": false,\r\n            \"result\": {\r\n              " +
                        "\"status\": \"Undefined\",\r\n              \"duration\": 1\r\n            }\r\n          }," +
                        "\r\n          {\r\n            \"keyword\": \"And\",\r\n            \"name\": \"I have entere" +
                        "d 70 into the calculator\",\r\n            \"line\": 10,\r\n            \"hidden\": false" +
                        ",\r\n            \"result\": {\r\n              \"status\": \"Undefined\",\r\n              " +
                        "\"duration\": 1\r\n            }\r\n          },\r\n          {\r\n            \"keyword\": " +
                        "\"When\",\r\n            \"name\": \"I press C\",\r\n            \"line\": 11,\r\n            " +
                        "\"hidden\": false,\r\n            \"result\": {\r\n              \"status\": \"Undefined\",\r" +
                        "\n              \"duration\": 1\r\n            }\r\n          },\r\n          {\r\n        " +
                        "    \"keyword\": \"Then\",\r\n            \"name\": \"the screen should be empty\",\r\n     " +
                        "       \"line\": 12,\r\n            \"hidden\": false,\r\n            \"result\": {\r\n     " +
                        "         \"status\": \"Undefined\",\r\n              \"duration\": 1\r\n            }\r\n   " +
                        "       }", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A feature with a table")]
        [NUnit.Framework.CategoryAttribute("cucumber")]
        public virtual void AFeatureWithATable()
        {
            string[] tagsOfScenario = new string[] {
                    "cucumber"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A feature with a table", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 92
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 94
    testRunner.Given("I have this feature description", @"Feature: Interactive DHTML View
    In order to increase stakeholder engagement with pickled specs
    As a SpecFlow evangelist
    I want to adjust the level of detail in the DHTML view to suit my audience
    So that I do not overwhelm them.

Scenario: Scenario with large data table
    Given a feature with a large table of data:
        | heading    | page # |
        | Chapter 1  | 1      |
        | Chapter 2  | 5      |
        | Chapter 3  | 10     |
        | Chapter 4  | 15     |
        | Chapter 5  | 20     |
        | Chapter 6  | 25     |
        | Chapter 7  | 30     |
        | Chapter 8  | 35     |
        | Chapter 9  | 40     |
        | Chapter 10 | 45     |
        | Chapter 11 | 50     |
        | Chapter 12 | 55     |
        | Chapter 13 | 60     |
        | Chapter 14 | 65     |
        | Chapter 15 | 70     |
        | Chapter 16 | 75     |
        | Chapter 17 | 80     |
        | Chapter 18 | 85     |
        | Chapter 19 | 90     |
        | Chapter 20 | 95     |
        | Chapter 21 | 100    |
        | Chapter 22 | 105    |
    When I click on the table heading
    Then the table body should collapse", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 130
    testRunner.When("I generate the documentation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 131
    testRunner.Then("the JSON file should contain", "[\r\n  {\r\n    \"id\": \"interactive-dhtml-view\",\r\n    \"keyword\": \"Feature\",\r\n    \"name" +
                        "\": \"Interactive DHTML View\",\r\n    \"description\": \"In order to increase stakehold" +
                        "er engagement with pickled specs\\r\\nAs a SpecFlow evangelist\\r\\nI want to adjust" +
                        " the level of detail in the DHTML view to suit my audience\\r\\nSo that I do not o" +
                        "verwhelm them.\",\r\n    \"tags\": [],\r\n    \"line\": 1,\r\n    \"elements\": [\r\n      {\r\n " +
                        "       \"id\": \"interactive-dhtml-view;scenario-with-large-data-table\",\r\n        \"" +
                        "keyword\": \"Scenario\",\r\n        \"name\": \"Scenario with large data table\",\r\n      " +
                        "  \"description\": \"\",\r\n        \"line\": 7,\r\n        \"type\": \"scenario\",\r\n        \"" +
                        "tags\": [],\r\n        \"steps\": [\r\n          {\r\n            \"keyword\": \"Given\",\r\n  " +
                        "          \"name\": \"a feature with a large table of data:\",\r\n            \"line\": " +
                        "8,\r\n            \"hidden\": false,\r\n            \"result\": {\r\n              \"status" +
                        "\": \"Undefined\",\r\n              \"duration\": 1\r\n            }\r\n          },\r\n     " +
                        "     {\r\n            \"keyword\": \"When\",\r\n            \"name\": \"I click on the tabl" +
                        "e heading\",\r\n            \"line\": 32,\r\n            \"hidden\": false,\r\n            " +
                        "\"result\": {\r\n              \"status\": \"Undefined\",\r\n              \"duration\": 1\r\n" +
                        "            }\r\n          },\r\n          {\r\n            \"keyword\": \"Then\",\r\n      " +
                        "      \"name\": \"the table body should collapse\",\r\n            \"line\": 33,\r\n      " +
                        "      \"hidden\": false,\r\n            \"result\": {\r\n              \"status\": \"Undefi" +
                        "ned\",\r\n              \"duration\": 1\r\n            }\r\n          }", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
