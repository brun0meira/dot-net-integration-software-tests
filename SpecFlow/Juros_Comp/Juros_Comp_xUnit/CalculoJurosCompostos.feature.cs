// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.5.0.0
//      SpecFlow Generator Version:3.5.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace APIFinancas.Especificacoes
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class CalculoDeJurosCompostosFeature : object, Xunit.IClassFixture<CalculoDeJurosCompostosFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CalculoJurosCompostos.feature"
#line hidden
        
        public CalculoDeJurosCompostosFeature(CalculoDeJurosCompostosFeature.FixtureData fixtureData, APIFinancas_Especificacoes_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "", "Cálculo de Juros Compostos", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="SimulacaoJurosCompostos01")]
        [Xunit.TraitAttribute("FeatureTitle", "Cálculo de Juros Compostos")]
        [Xunit.TraitAttribute("Description", "SimulacaoJurosCompostos01")]
        public virtual void SimulacaoJurosCompostos01()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SimulacaoJurosCompostos01", null, tagsOfScenario, argumentsOfScenario);
#line 3
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
#line 4
 testRunner.Given("que o valor o valor do empréstimo é de R$ 10.000,00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 5
 testRunner.And("que este empréstimo será por 12 meses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 6
 testRunner.And("que a taxa de juros é de 2,00% ao mês", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 7
 testRunner.When("eu solicitar o cálculo do valor total a ser pago ao final do período", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 8
 testRunner.Then("o resultado será 12.682,42", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="SimulacaoJurosCompostos02")]
        [Xunit.TraitAttribute("FeatureTitle", "Cálculo de Juros Compostos")]
        [Xunit.TraitAttribute("Description", "SimulacaoJurosCompostos02")]
        public virtual void SimulacaoJurosCompostos02()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SimulacaoJurosCompostos02", null, tagsOfScenario, argumentsOfScenario);
#line 10
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
#line 11
 testRunner.Given("que o valor o valor do empréstimo é de R$ 11.937,28", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 12
 testRunner.And("que este empréstimo será por 24 meses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 13
 testRunner.And("que a taxa de juros é de 4,00% ao mês", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 14
 testRunner.When("eu solicitar o cálculo do valor total a ser pago ao final do período", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 15
 testRunner.Then("o resultado será 30.598,88", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="SimulacaoJurosCompostos03")]
        [Xunit.TraitAttribute("FeatureTitle", "Cálculo de Juros Compostos")]
        [Xunit.TraitAttribute("Description", "SimulacaoJurosCompostos03")]
        public virtual void SimulacaoJurosCompostos03()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SimulacaoJurosCompostos03", null, tagsOfScenario, argumentsOfScenario);
#line 17
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
#line 18
 testRunner.Given("que o valor o valor do empréstimo é de R$ 15.000,00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 19
 testRunner.And("que este empréstimo será por 36 meses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 20
 testRunner.And("que a taxa de juros é de 6,00% ao mês", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 21
 testRunner.When("eu solicitar o cálculo do valor total a ser pago ao final do período", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 22
 testRunner.Then("o resultado será 122.208,78", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="SimulacaoJurosCompostos04")]
        [Xunit.TraitAttribute("FeatureTitle", "Cálculo de Juros Compostos")]
        [Xunit.TraitAttribute("Description", "SimulacaoJurosCompostos04")]
        public virtual void SimulacaoJurosCompostos04()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SimulacaoJurosCompostos04", null, tagsOfScenario, argumentsOfScenario);
#line 24
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
#line 25
 testRunner.Given("que o valor o valor do empréstimo é de R$ 10.000,00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 26
 testRunner.And("que este empréstimo será por 2 meses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 27
 testRunner.And("que a taxa de juros é de 2,00% ao mês", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 28
 testRunner.When("eu solicitar o cálculo do valor total a ser pago ao final do período", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 29
 testRunner.Then("o resultado será 10.404,00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="SimulacaoJurosCompostos05")]
        [Xunit.TraitAttribute("FeatureTitle", "Cálculo de Juros Compostos")]
        [Xunit.TraitAttribute("Description", "SimulacaoJurosCompostos05")]
        public virtual void SimulacaoJurosCompostos05()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SimulacaoJurosCompostos05", null, tagsOfScenario, argumentsOfScenario);
#line 31
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
#line 32
 testRunner.Given("que o valor o valor do empréstimo é de R$ 20.000,00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 33
 testRunner.And("que este empréstimo será por 36 meses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 34
 testRunner.And("que a taxa de juros é de 6,00% ao mês", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 35
 testRunner.When("eu solicitar o cálculo do valor total a ser pago ao final do período", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 36
 testRunner.Then("o resultado será 162.945,04", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="SimulacaoJurosCompostos06")]
        [Xunit.TraitAttribute("FeatureTitle", "Cálculo de Juros Compostos")]
        [Xunit.TraitAttribute("Description", "SimulacaoJurosCompostos06")]
        public virtual void SimulacaoJurosCompostos06()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SimulacaoJurosCompostos06", null, tagsOfScenario, argumentsOfScenario);
#line 38
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
#line 39
 testRunner.Given("que o valor o valor do empréstimo é de R$ 25.000,00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 40
 testRunner.And("que este empréstimo será por 48 meses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 41
 testRunner.And("que a taxa de juros é de 6,00% ao mês", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 42
 testRunner.When("eu solicitar o cálculo do valor total a ser pago ao final do período", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 43
 testRunner.Then("o resultado será 409.846,79", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="SimulacaoJurosCompostos07")]
        [Xunit.TraitAttribute("FeatureTitle", "Cálculo de Juros Compostos")]
        [Xunit.TraitAttribute("Description", "SimulacaoJurosCompostos07")]
        public virtual void SimulacaoJurosCompostos07()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SimulacaoJurosCompostos07", null, tagsOfScenario, argumentsOfScenario);
#line 45
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
#line 46
 testRunner.Given("que o valor o valor do empréstimo é de R$ 30.000,00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 47
 testRunner.And("que este empréstimo será por 3 meses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 48
 testRunner.And("que a taxa de juros é de 3,00% ao mês", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 49
 testRunner.When("eu solicitar o cálculo do valor total a ser pago ao final do período", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 50
 testRunner.Then("o resultado será 32.781,81", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.5.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                CalculoDeJurosCompostosFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CalculoDeJurosCompostosFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion