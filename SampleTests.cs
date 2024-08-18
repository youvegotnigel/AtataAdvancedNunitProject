using AtataAdvancedNunitProject.Components;

namespace AtataAdvancedNunitProject
{
    public sealed class SampleTests : UITestFixture
    {
        [Test]
        public void VerifyPageTitle()
        {
            Go.To<OrdinaryPage>().PageTitle.Should.Contain("Atata");
            AtataContext.Current.TakeScreenshot();
        }


        [Test]
        public void VerifySignIn()
        {
            Go.To<SignInPage>().PageTitle.Should.Contain("Sign In");

            Go.To<SignInPage>()
            .Email.Type("admin@mail.com")
            .Password.Type("abc123")
            .SignIn.Click();


            AtataContext.Current.TakeScreenshot();
        }



    }
}
