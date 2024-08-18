namespace AtataAdvancedNunitProject
{
    public sealed class SampleTests : UITestFixture
    {
        [Test]
        public void VerifyPageTitle()
        {
            Go.To<OrdinaryPage>()
                    .PageTitle.Should.Contain("Atata");

            AtataContext.Current.TakeScreenshot();
        }

    }
}
