using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace Testing.IntegrationTests
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
           ScenarioContext.Current.Add("First" + p0.ToString(), p0);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Add("Sum", 
                ScenarioContext.Current.Get<int>("First50") +
                ScenarioContext.Current.Get<int>("First70"));
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            int expectedVal = 120;
            int recivedVal = ScenarioContext.Current.Get<int>("Sum");
            Assert.AreEqual(recivedVal, expectedVal);
        }
    }
}
