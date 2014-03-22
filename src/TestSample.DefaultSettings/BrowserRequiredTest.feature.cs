﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18449
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TestSample.DefaultSettings
{
    using TechTalk.SpecFlow;
    using System.Configuration;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("BrowserRequiredTest")]
    [NUnit.Framework.CategoryAttribute("BrowserRequiredTestFeature")]
    [NUnit.Framework.CategoryAttribute("DefaultSettings")]
    [NUnit.Framework.Property("Config", "Default")]
    [NUnit.Framework.CategoryAttribute("FeatureTag")]
    [NUnit.Framework.CategoryAttribute("Config:Default")]
    public partial class BrowserRequiredTestFeature
    {
        
        private string Browser;
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        internal static object[] SingleBrowserTagChrome__chrome
        {
            get
            {
                int repeats = 1;
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> rows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                rows.Add(new NUnit.Framework.TestCaseData("chrome"));
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> repeatedRows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                System.Collections.Generic.List<NUnit.Framework.TestCaseData>.Enumerator repeatedEnumerator = rows.GetEnumerator();
                for (
                ; repeatedEnumerator.MoveNext(); 
                )
                {
                    NUnit.Framework.TestCaseData current = repeatedEnumerator.Current;
                    for (int i = 0; (i < repeats); i = (i + 1))
                    {
                        repeatedRows.Add(current);
                    }
                }
                return repeatedRows.ToArray();
            }
        }
        
        internal static object[] MultipleBrowserTags__firefox
        {
            get
            {
                int repeats = 1;
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> rows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                rows.Add(new NUnit.Framework.TestCaseData("firefox"));
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> repeatedRows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                System.Collections.Generic.List<NUnit.Framework.TestCaseData>.Enumerator repeatedEnumerator = rows.GetEnumerator();
                for (
                ; repeatedEnumerator.MoveNext(); 
                )
                {
                    NUnit.Framework.TestCaseData current = repeatedEnumerator.Current;
                    for (int i = 0; (i < repeats); i = (i + 1))
                    {
                        repeatedRows.Add(current);
                    }
                }
                return repeatedRows.ToArray();
            }
        }
        
        internal static object[] MultipleBrowserTags__chrome
        {
            get
            {
                int repeats = 1;
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> rows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                rows.Add(new NUnit.Framework.TestCaseData("chrome"));
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> repeatedRows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                System.Collections.Generic.List<NUnit.Framework.TestCaseData>.Enumerator repeatedEnumerator = rows.GetEnumerator();
                for (
                ; repeatedEnumerator.MoveNext(); 
                )
                {
                    NUnit.Framework.TestCaseData current = repeatedEnumerator.Current;
                    for (int i = 0; (i < repeats); i = (i + 1))
                    {
                        repeatedRows.Add(current);
                    }
                }
                return repeatedRows.ToArray();
            }
        }
        
        internal static object[] Repeated3Times__browser
        {
            get
            {
                int repeats = 3;
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> rows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                rows.Add(new NUnit.Framework.TestCaseData("browser"));
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> repeatedRows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                System.Collections.Generic.List<NUnit.Framework.TestCaseData>.Enumerator repeatedEnumerator = rows.GetEnumerator();
                for (
                ; repeatedEnumerator.MoveNext(); 
                )
                {
                    NUnit.Framework.TestCaseData current = repeatedEnumerator.Current;
                    for (int i = 0; (i < repeats); i = (i + 1))
                    {
                        repeatedRows.Add(current);
                    }
                }
                return repeatedRows.ToArray();
            }
        }
        
        internal static object[] Repeated3TimesWith2OutlineValues_outline___browser
        {
            get
            {
                int repeats = 3;
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> rows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                rows.Add(new NUnit.Framework.TestCaseData("browser", "other value", null));
                rows.Add(new NUnit.Framework.TestCaseData("browser", "value", null));
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> repeatedRows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                System.Collections.Generic.List<NUnit.Framework.TestCaseData>.Enumerator repeatedEnumerator = rows.GetEnumerator();
                for (
                ; repeatedEnumerator.MoveNext(); 
                )
                {
                    NUnit.Framework.TestCaseData current = repeatedEnumerator.Current;
                    for (int i = 0; (i < repeats); i = (i + 1))
                    {
                        repeatedRows.Add(current);
                    }
                }
                return repeatedRows.ToArray();
            }
        }
        
        internal static object[] NoTagsScenarioOutline_outline___no_browser
        {
            get
            {
                int repeats = 1;
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> rows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                rows.Add(new NUnit.Framework.TestCaseData("other value", null));
                rows.Add(new NUnit.Framework.TestCaseData("value", null));
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> repeatedRows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                System.Collections.Generic.List<NUnit.Framework.TestCaseData>.Enumerator repeatedEnumerator = rows.GetEnumerator();
                for (
                ; repeatedEnumerator.MoveNext(); 
                )
                {
                    NUnit.Framework.TestCaseData current = repeatedEnumerator.Current;
                    for (int i = 0; (i < repeats); i = (i + 1))
                    {
                        repeatedRows.Add(current);
                    }
                }
                return repeatedRows.ToArray();
            }
        }
        
        internal static object[] TagsButNoBrowserTagScenarioOutline_outline___no_browser
        {
            get
            {
                int repeats = 1;
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> rows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                rows.Add(new NUnit.Framework.TestCaseData("other value", null));
                rows.Add(new NUnit.Framework.TestCaseData("value", null));
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> repeatedRows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                System.Collections.Generic.List<NUnit.Framework.TestCaseData>.Enumerator repeatedEnumerator = rows.GetEnumerator();
                for (
                ; repeatedEnumerator.MoveNext(); 
                )
                {
                    NUnit.Framework.TestCaseData current = repeatedEnumerator.Current;
                    for (int i = 0; (i < repeats); i = (i + 1))
                    {
                        repeatedRows.Add(current);
                    }
                }
                return repeatedRows.ToArray();
            }
        }
        
        internal static object[] ScenarioOutlineWithSingleBrowserTag_outline___scenariooutlinebrowser
        {
            get
            {
                int repeats = 1;
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> rows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                rows.Add(new NUnit.Framework.TestCaseData("scenario-outline-browser", "value", null));
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> repeatedRows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                System.Collections.Generic.List<NUnit.Framework.TestCaseData>.Enumerator repeatedEnumerator = rows.GetEnumerator();
                for (
                ; repeatedEnumerator.MoveNext(); 
                )
                {
                    NUnit.Framework.TestCaseData current = repeatedEnumerator.Current;
                    for (int i = 0; (i < repeats); i = (i + 1))
                    {
                        repeatedRows.Add(current);
                    }
                }
                return repeatedRows.ToArray();
            }
        }
        
        internal static object[] ScenarioOutlineWithTwoBrowserTags_outline___chrome
        {
            get
            {
                int repeats = 1;
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> rows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                rows.Add(new NUnit.Framework.TestCaseData("chrome", "other value", null));
                rows.Add(new NUnit.Framework.TestCaseData("chrome", "value", null));
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> repeatedRows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                System.Collections.Generic.List<NUnit.Framework.TestCaseData>.Enumerator repeatedEnumerator = rows.GetEnumerator();
                for (
                ; repeatedEnumerator.MoveNext(); 
                )
                {
                    NUnit.Framework.TestCaseData current = repeatedEnumerator.Current;
                    for (int i = 0; (i < repeats); i = (i + 1))
                    {
                        repeatedRows.Add(current);
                    }
                }
                return repeatedRows.ToArray();
            }
        }
        
        internal static object[] ScenarioOutlineWithTwoBrowserTags_outline___firefox
        {
            get
            {
                int repeats = 1;
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> rows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                rows.Add(new NUnit.Framework.TestCaseData("firefox", "other value", null));
                rows.Add(new NUnit.Framework.TestCaseData("firefox", "value", null));
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> repeatedRows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                System.Collections.Generic.List<NUnit.Framework.TestCaseData>.Enumerator repeatedEnumerator = rows.GetEnumerator();
                for (
                ; repeatedEnumerator.MoveNext(); 
                )
                {
                    NUnit.Framework.TestCaseData current = repeatedEnumerator.Current;
                    for (int i = 0; (i < repeats); i = (i + 1))
                    {
                        repeatedRows.Add(current);
                    }
                }
                return repeatedRows.ToArray();
            }
        }
        
        internal static object[] ScenarioOutlineWithTwoBrowserTagsAndTaggedExamples_outline___chrome
        {
            get
            {
                int repeats = 1;
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> rows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                rows.Add(new NUnit.Framework.TestCaseData("chrome", "other untagged", null));
                rows.Add(new NUnit.Framework.TestCaseData("chrome", "untagged", null));
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> repeatedRows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                System.Collections.Generic.List<NUnit.Framework.TestCaseData>.Enumerator repeatedEnumerator = rows.GetEnumerator();
                for (
                ; repeatedEnumerator.MoveNext(); 
                )
                {
                    NUnit.Framework.TestCaseData current = repeatedEnumerator.Current;
                    for (int i = 0; (i < repeats); i = (i + 1))
                    {
                        repeatedRows.Add(current);
                    }
                }
                return repeatedRows.ToArray();
            }
        }
        
        internal static object[] ScenarioOutlineWithTwoBrowserTagsAndTaggedExamples_outline___firefox
        {
            get
            {
                int repeats = 1;
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> rows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                rows.Add(new NUnit.Framework.TestCaseData("firefox", "other untagged", null));
                rows.Add(new NUnit.Framework.TestCaseData("firefox", "untagged", null));
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> repeatedRows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                System.Collections.Generic.List<NUnit.Framework.TestCaseData>.Enumerator repeatedEnumerator = rows.GetEnumerator();
                for (
                ; repeatedEnumerator.MoveNext(); 
                )
                {
                    NUnit.Framework.TestCaseData current = repeatedEnumerator.Current;
                    for (int i = 0; (i < repeats); i = (i + 1))
                    {
                        repeatedRows.Add(current);
                    }
                }
                return repeatedRows.ToArray();
            }
        }
        
        internal static object[] ScenarioOutlineWithTwoBrowserTagsAndTaggedExamples_outline___chrome__nightly
        {
            get
            {
                int repeats = 1;
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> rows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                rows.Add(new NUnit.Framework.TestCaseData("chrome", "other nightly", null));
                rows.Add(new NUnit.Framework.TestCaseData("chrome", "nightly", null));
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> repeatedRows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                System.Collections.Generic.List<NUnit.Framework.TestCaseData>.Enumerator repeatedEnumerator = rows.GetEnumerator();
                for (
                ; repeatedEnumerator.MoveNext(); 
                )
                {
                    NUnit.Framework.TestCaseData current = repeatedEnumerator.Current;
                    for (int i = 0; (i < repeats); i = (i + 1))
                    {
                        repeatedRows.Add(current);
                    }
                }
                return repeatedRows.ToArray();
            }
        }
        
        internal static object[] ScenarioOutlineWithTwoBrowserTagsAndTaggedExamples_outline___firefox__nightly
        {
            get
            {
                int repeats = 1;
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> rows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                rows.Add(new NUnit.Framework.TestCaseData("firefox", "other nightly", null));
                rows.Add(new NUnit.Framework.TestCaseData("firefox", "nightly", null));
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> repeatedRows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                System.Collections.Generic.List<NUnit.Framework.TestCaseData>.Enumerator repeatedEnumerator = rows.GetEnumerator();
                for (
                ; repeatedEnumerator.MoveNext(); 
                )
                {
                    NUnit.Framework.TestCaseData current = repeatedEnumerator.Current;
                    for (int i = 0; (i < repeats); i = (i + 1))
                    {
                        repeatedRows.Add(current);
                    }
                }
                return repeatedRows.ToArray();
            }
        }
        
        internal static object[] ScenarioOutlineWithTwoBrowserTagsAndTaggedExamples_outline___chrome__eachcommit
        {
            get
            {
                int repeats = 1;
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> rows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                rows.Add(new NUnit.Framework.TestCaseData("chrome", "each-commit other", null));
                rows.Add(new NUnit.Framework.TestCaseData("chrome", "each-commit", null));
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> repeatedRows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                System.Collections.Generic.List<NUnit.Framework.TestCaseData>.Enumerator repeatedEnumerator = rows.GetEnumerator();
                for (
                ; repeatedEnumerator.MoveNext(); 
                )
                {
                    NUnit.Framework.TestCaseData current = repeatedEnumerator.Current;
                    for (int i = 0; (i < repeats); i = (i + 1))
                    {
                        repeatedRows.Add(current);
                    }
                }
                return repeatedRows.ToArray();
            }
        }
        
        internal static object[] ScenarioOutlineWithTwoBrowserTagsAndTaggedExamples_outline___firefox__eachcommit
        {
            get
            {
                int repeats = 1;
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> rows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                rows.Add(new NUnit.Framework.TestCaseData("firefox", "each-commit other", null));
                rows.Add(new NUnit.Framework.TestCaseData("firefox", "each-commit", null));
                System.Collections.Generic.List<NUnit.Framework.TestCaseData> repeatedRows = new System.Collections.Generic.List<NUnit.Framework.TestCaseData>();
                System.Collections.Generic.List<NUnit.Framework.TestCaseData>.Enumerator repeatedEnumerator = rows.GetEnumerator();
                for (
                ; repeatedEnumerator.MoveNext(); 
                )
                {
                    NUnit.Framework.TestCaseData current = repeatedEnumerator.Current;
                    for (int i = 0; (i < repeats); i = (i + 1))
                    {
                        repeatedRows.Add(current);
                    }
                }
                return repeatedRows.ToArray();
            }
        }
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "BrowserRequiredTest", "In order to avoid silly mistakes\r\nAs a math idiot\r\nI want to be told the sum of t" +
                    "wo numbers", ProgrammingLanguage.CSharp, new string[] {
                        "FeatureTag",
                        "Config:Default"});
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
            this.Browser = null;
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            TechTalk.SpecFlow.ScenarioContext.Current.Add("Browser", this.Browser);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
            testRunner.Given("I have a browser when running the background", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
        }
        
        private void GuardBrowserTagMissing()
        {
            System.Collections.Specialized.NameValueCollection appSettings = System.Configuration.ConfigurationManager.AppSettings;
            string browserMissingMessage = "No browser defined, please specify @Browser:someBrowser for your scenario.";
            string customBrowserMissingMessage = appSettings.Get("CatBrows-BrowserMissingMessage");
            if ((customBrowserMissingMessage != null))
            {
                browserMissingMessage = customBrowserMissingMessage;
            }
            string enforceExistenceOfBrowserTagRaw = appSettings.Get("CatBrows-RequiresBrowser");
            bool enforceExistenceOfBrowserTag;
            bool hasConfigSetting = bool.TryParse(enforceExistenceOfBrowserTagRaw, out enforceExistenceOfBrowserTag);
            bool hasBrowser = (string.IsNullOrEmpty(this.Browser) != true);
            bool shouldGuard = ((hasConfigSetting 
                        & (enforceExistenceOfBrowserTag != true)) 
                        != true);
            if ((shouldGuard 
                        & (hasBrowser != true)))
            {
                throw new System.Exception(browserMissingMessage);
            }
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.IgnoreAttribute()]
        public virtual void NoTagsAtAll()
        {
            this.GuardBrowserTagMissing();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No tags at all", new string[] {
                        "ignore"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.Then("the test method should throw a no browser exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.IgnoreAttribute()]
        [NUnit.Framework.CategoryAttribute("SomeTag")]
        public virtual void TagsButNoBrowserTag()
        {
            this.GuardBrowserTagMissing();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Tags but no browser tag", new string[] {
                        "SomeTag",
                        "ignore"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.Then("the test method should throw a no browser exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.TestCaseSourceAttribute("SingleBrowserTagChrome__chrome", Category="chrome")]
        public virtual void SingleBrowserTagChrome(string browser)
        {
            this.Browser = browser;
            this.GuardBrowserTagMissing();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Single browser tag chrome", new string[] {
                        "Browser:chrome"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.Then("the test method should have 1 testcase", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.CategoryAttribute("Duplicate:Property0")]
        [NUnit.Framework.CategoryAttribute("Duplicate:Property1")]
        [NUnit.Framework.Property("Duplicate", "Property0,Property1")]
        [NUnit.Framework.TestCaseSourceAttribute("MultipleBrowserTags__firefox", Category="firefox")]
        [NUnit.Framework.TestCaseSourceAttribute("MultipleBrowserTags__chrome", Category="chrome")]
        public virtual void MultipleBrowserTags(string browser)
        {
            this.Browser = browser;
            this.GuardBrowserTagMissing();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiple browser tags", new string[] {
                        "Browser:firefox",
                        "Browser:chrome",
                        "Duplicate:Property0",
                        "Duplicate:Property1"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.Then("the test method should have 2 testcases", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.CategoryAttribute("Repeat:3")]
        [NUnit.Framework.Property("Repeat", "3")]
        [NUnit.Framework.TestCaseSourceAttribute("Repeated3Times__browser", Category="browser")]
        public virtual void Repeated3Times(string browser)
        {
            this.Browser = browser;
            this.GuardBrowserTagMissing();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Repeated 3 times", new string[] {
                        "Browser:browser",
                        "Repeat:3"});
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.Then("the test method should have 1 testcase", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.CategoryAttribute("Repeat:3")]
        [NUnit.Framework.Property("Repeat", "3")]
        [NUnit.Framework.TestCaseSourceAttribute("Repeated3TimesWith2OutlineValues_outline___browser", Category="browser")]
        public virtual void Repeated3TimesWith2OutlineValues(string browser, string header, string[] exampleTags)
        {
            this.Browser = browser;
            this.GuardBrowserTagMissing();
            string[] @__tags = new string[] {
                    "Browser:browser",
                    "Repeat:3"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Repeated 3 times with 2 outline values", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.Then("the test method should have 1 testcase", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.IgnoreAttribute()]
        [NUnit.Framework.CategoryAttribute(":")]
        [NUnit.Framework.CategoryAttribute("a:")]
        [NUnit.Framework.CategoryAttribute(":a")]
        [NUnit.Framework.TestCaseSourceAttribute("NoTagsScenarioOutline_outline___no_browser", Category="")]
        public virtual void NoTagsScenarioOutline(string header, string[] exampleTags)
        {
            this.GuardBrowserTagMissing();
            string[] @__tags = new string[] {
                    "ignore",
                    ":",
                    "a:",
                    ":a"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No tags scenario outline", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.Then("the test method should throw a no browser exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.IgnoreAttribute()]
        [NUnit.Framework.CategoryAttribute("sometag")]
        [NUnit.Framework.TestCaseSourceAttribute("TagsButNoBrowserTagScenarioOutline_outline___no_browser", Category="")]
        public virtual void TagsButNoBrowserTagScenarioOutline(string header, string[] exampleTags)
        {
            this.GuardBrowserTagMissing();
            string[] @__tags = new string[] {
                    "sometag",
                    "ignore"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Tags but no browser tag scenario outline", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.Then("the test method should throw a no browser exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.TestCaseSourceAttribute("ScenarioOutlineWithSingleBrowserTag_outline___scenariooutlinebrowser", Category="scenario-outline-browser")]
        public virtual void ScenarioOutlineWithSingleBrowserTag(string browser, string header, string[] exampleTags)
        {
            this.Browser = browser;
            this.GuardBrowserTagMissing();
            string[] @__tags = new string[] {
                    "Browser:scenario-outline-browser"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("scenario outline with single browser tag", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.Then("the test method should have 1 testcases", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.TestCaseSourceAttribute("ScenarioOutlineWithTwoBrowserTags_outline___chrome", Category="chrome")]
        [NUnit.Framework.TestCaseSourceAttribute("ScenarioOutlineWithTwoBrowserTags_outline___firefox", Category="firefox")]
        public virtual void ScenarioOutlineWithTwoBrowserTags(string browser, string header, string[] exampleTags)
        {
            this.Browser = browser;
            this.GuardBrowserTagMissing();
            string[] @__tags = new string[] {
                    "Browser:chrome",
                    "Browser:firefox"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("scenario outline with two browser tags", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.Then("the test method should have 2 testcases", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.CategoryAttribute("OutlineTag")]
        [NUnit.Framework.CategoryAttribute("CustomProperty:PropertyValue")]
        [NUnit.Framework.Property("CustomProperty", "PropertyValue")]
        [NUnit.Framework.TestCaseSourceAttribute("ScenarioOutlineWithTwoBrowserTagsAndTaggedExamples_outline___chrome", Category="chrome")]
        [NUnit.Framework.TestCaseSourceAttribute("ScenarioOutlineWithTwoBrowserTagsAndTaggedExamples_outline___firefox", Category="firefox")]
        [NUnit.Framework.TestCaseSourceAttribute("ScenarioOutlineWithTwoBrowserTagsAndTaggedExamples_outline___chrome__nightly", Category="nightly,chrome")]
        [NUnit.Framework.TestCaseSourceAttribute("ScenarioOutlineWithTwoBrowserTagsAndTaggedExamples_outline___firefox__nightly", Category="nightly,firefox")]
        [NUnit.Framework.TestCaseSourceAttribute("ScenarioOutlineWithTwoBrowserTagsAndTaggedExamples_outline___chrome__eachcommit", Category="each-commit,chrome")]
        [NUnit.Framework.TestCaseSourceAttribute("ScenarioOutlineWithTwoBrowserTagsAndTaggedExamples_outline___firefox__eachcommit", Category="each-commit,firefox")]
        public virtual void ScenarioOutlineWithTwoBrowserTagsAndTaggedExamples(string browser, string header, string[] exampleTags)
        {
            this.Browser = browser;
            this.GuardBrowserTagMissing();
            string[] @__tags = new string[] {
                    "Browser:chrome",
                    "Browser:firefox",
                    "OutlineTag",
                    "CustomProperty:PropertyValue"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("scenario outline with two browser tags and tagged examples", @__tags);
            this.ScenarioSetup(scenarioInfo);
            this.FeatureBackground();
            testRunner.Then("the test method should have 4 testcases", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
