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
namespace Specflow_Test_Project1.Features
{
    using TechTalk.SpecFlow;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("CompareTheMeerkat", Description = "In order to ensure I order the correct cuddly toy\nAs a customer\nI want to be able" +
        " to compare meerkats", SourceFile = "Features\\CompareTheMeerkat.feature", SourceLine = 0)]
    public partial class CompareTheMeerkatFeature
    {

        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "CompareTheMeerkat.feature"
#line hidden

        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CompareTheMeerkat", "In order to ensure I order the correct cuddly toy\nAs a customer\nI want to be able" +
                    " to compare meerkats", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }

        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }

        public virtual void TestInitialize()
        {
        }

        [TechTalk.SpecRun.ScenarioCleanup()]
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

        [TechTalk.SpecRun.ScenarioAttribute("Navigate to Compare Meerkats page", new string[] {
                "mytag"}, SourceLine = 6)]
        public virtual void NavigateToCompareMeerkatsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to Compare Meerkats page", new string[] {
                        "mytag"});
#line 7
            this.ScenarioSetup(scenarioInfo);
#line 8
            testRunner.Given("I visit the comparethemeerkat site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
            testRunner.When("I select the Compare Meerkats menu link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
            testRunner.Then("I am taken to the Compare Meerkats page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
