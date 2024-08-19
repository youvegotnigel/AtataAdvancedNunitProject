using AtataAdvancedNunitProject.Components;

namespace AtataAdvancedNunitProject
{

    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class UITestFixture
    {

        public static AtataConfig Config =>
            AtataConfig.Current;


        [SetUp]
        public void SetUp() =>
            AtataContext.Configure().Build();

        [TearDown]
        public void TearDown() =>
            AtataContext.Current?.Dispose();

        protected static UsersPage Login() =>
            Go.To<SignInPage>()
                .Email.Set(Config.Account.Email)
                .Password.Set(Config.Account.Password)
                .SignIn();

    }
}
