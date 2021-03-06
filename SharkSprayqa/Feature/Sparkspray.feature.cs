// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SharkSprayqa.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SharksprayAutomation")]
    public partial class SharksprayAutomationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Sparkspray.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SharksprayAutomation", "\tMatching input-output files hash code", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Visualize Model Data.")]
        [NUnit.Framework.CategoryAttribute("regression")]
        [NUnit.Framework.TestCaseAttribute("1", "oca2_p3", "oca2_dma.xml", "oca2_compression.xml", "oca2_tension.xlsx", "1", "PSA - Adhesive Transfer Tape (ATT)", "Phase 3 (DMA + Compression + Tension)", "Tension", "True", "oca2_p3_ModelFiles", new string[] {
                "source:Sharkspray_Testcases.xlsx:sheet1"}, Category="source:Sharkspray_Testcases.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("2", "q800", "q800.001", "", "", "1", "PSA - Adhesive Transfer Tape (ATT)", "Phase 1 (DMA)", "auto", "True", "q800_ModelFiles", new string[] {
                "source:Sharkspray_Testcases.xlsx:sheet1"}, Category="source:Sharkspray_Testcases.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("3", "q800_bad", "q800.txt", "", "", "1", "PSA - Adhesive Transfer Tape (ATT)", "Phase 1 (DMA)", "auto", "False", "", new string[] {
                "source:Sharkspray_Testcases.xlsx:sheet1"}, Category="source:Sharkspray_Testcases.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("4", "orchestrator", "orchestrator_hitemp.txt,orchestrator_lowtemp.txt", "", "", "1", "PSA - Adhesive Transfer Tape (ATT)", "Phase 1 (DMA)", "Shear", "True", "orchestrator_hitemp_ModelFiles", new string[] {
                "source:Sharkspray_Testcases.xlsx:sheet1"}, Category="source:Sharkspray_Testcases.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("5", "trios_typ", "trios_hitemp.txt,trios_lowtemp.txt", "", "", "1", "PSA - Adhesive Transfer Tape (ATT)", "Phase 1 (DMA)", "Shear", "True", "trios_hitemp_ModelFiles", new string[] {
                "source:Sharkspray_Testcases.xlsx:sheet1"}, Category="source:Sharkspray_Testcases.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("6", "trios_headings", "trios_hitemp_headings.txt,trios_lowtemp_headings.txt", "", "", "1", "PSA - Adhesive Transfer Tape (ATT)", "Phase 1 (DMA)", "Shear", "True", "trios_hitemp_ModelFiles", new string[] {
                "source:Sharkspray_Testcases.xlsx:sheet1"}, Category="source:Sharkspray_Testcases.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("7", "trios_headings-notes", "trios_hitemp_headings-notes.txt,trios_lowtemp_headings-notes.txt", "", "", "1", "PSA - Adhesive Transfer Tape (ATT)", "Phase 1 (DMA)", "Shear", "True", "trios_hitemp_ModelFiles", new string[] {
                "source:Sharkspray_Testcases.xlsx:sheet1"}, Category="source:Sharkspray_Testcases.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("8", "trios_headings-params", "trios_hitemp_headings-parameters.txt,trios_lowtemp_headings-parameters.txt", "", "", "1", "PSA - Adhesive Transfer Tape (ATT)", "Phase 1 (DMA)", "Shear", "True", "trios_hitemp_ModelFiles", new string[] {
                "source:Sharkspray_Testcases.xlsx:sheet1"}, Category="source:Sharkspray_Testcases.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("9", "trios_nodetail", "trios_hitemp_no-details.txt,trios_lowtemp_no-details.txt", "", "", "1", "PSA - Adhesive Transfer Tape (ATT)", "Phase 1 (DMA)", "Shear", "True", "trios_hitemp_ModelFiles", new string[] {
                "source:Sharkspray_Testcases.xlsx:sheet1"}, Category="source:Sharkspray_Testcases.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("10", "trios_params-nodetail", "trios_hitemp_parameters-no-details.txt,trios_lowtemp_parameters-no-details.txt", "", "", "1", "PSA - Adhesive Transfer Tape (ATT)", "Phase 1 (DMA)", "Shear", "True", "trios_hitemp_ModelFiles", new string[] {
                "source:Sharkspray_Testcases.xlsx:sheet1"}, Category="source:Sharkspray_Testcases.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("11", "tobias", "tobias.xlsx", "", "", "1", "PSA - Adhesive Transfer Tape (ATT)", "Phase 1 (DMA)", "Tension", "True", "tobias_ModelFiles", new string[] {
                "source:Sharkspray_Testcases.xlsx:sheet1"}, Category="source:Sharkspray_Testcases.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("12", "tobias_v2", "tobias_v2.xlsx", "", "", "1", "PSA - Adhesive Transfer Tape (ATT)", "Phase 1 (DMA)", "Tension", "True", "tobias_v2_ModelFiles", new string[] {
                "source:Sharkspray_Testcases.xlsx:sheet1"}, Category="source:Sharkspray_Testcases.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("13", "rheology_xlsx", "rheology.xlsx", "", "", "1", "PSA - Adhesive Transfer Tape (ATT)", "Phase 1 (DMA)", "Tension", "True", "rheology_xlsx_ModelFiles", new string[] {
                "source:Sharkspray_Testcases.xlsx:sheet1"}, Category="source:Sharkspray_Testcases.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("14", "sa_bt1", "sa_bt1.xlsx", "", "", "1", "PSA - Adhesive Transfer Tape (ATT)", "Phase 1 (DMA)", "Tension", "True", "sa_bt1_ModelFiles", new string[] {
                "source:Sharkspray_Testcases.xlsx:sheet1"}, Category="source:Sharkspray_Testcases.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("15", "oca", "oca.xlsx", "", "", "1", "PSA - Adhesive Transfer Tape (ATT)", "Phase 1 (DMA)", "Tension", "True", "oca_ModelFiles", new string[] {
                "source:Sharkspray_Testcases.xlsx:sheet1"}, Category="source:Sharkspray_Testcases.xlsx:sheet1")]
        [NUnit.Framework.TestCaseAttribute("16", "oca2_p2", "oca2_dma.xml", "oca2_compression.xml", "", "1", "PSA - Adhesive Transfer Tape (ATT)", "Phase 2 (DMA + Compression)", "Tension", "True", "oca2_p2_ModelFiles", new string[] {
                "source:Sharkspray_Testcases.xlsx:sheet1"}, Category="source:Sharkspray_Testcases.xlsx:sheet1")]
        public virtual void VisualizeModelData_(string sno_, string name, string dma_Filename, string compression_Filename, string tension_Filename, string reps, string adhesiveType, string modelPhase, string deformation_Mode, string should_Build, string reference_Filename, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "regression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Visualize Model Data.", null, @__tags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.Given("I have navigated to Sharkspray Web Application.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.When(string.Format("I set {0} and {1} from sheet.", adhesiveType, modelPhase), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
 testRunner.Then(string.Format("I compare {0},{1} and {2} from the sheet and upload it.", dma_Filename, compression_Filename, tension_Filename), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 8
 testRunner.Then(string.Format("I select {0} from sheet.", deformation_Mode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 9
 testRunner.And("Clicked on the genrate constitutive mechanical model button.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.Then("On visualize model page click on the save chart as png button.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.And("Click on export and save model check-box and description.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.Then("Click on the save select model button and verify it.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.And("Click on the export external data package(*.ZIP) and verify if it downloaded.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.Then("Extract the downloaded file.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.And(string.Format("Check the status of {0} and remove unnecessary lines from webfile and {1}.", should_Build, reference_Filename), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.Then(string.Format("Comapre hashvalue of web-data and {0} data and store with {1} file.", reference_Filename, name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
