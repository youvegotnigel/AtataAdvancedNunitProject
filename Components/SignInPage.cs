namespace AtataAdvancedNunitProject.Components
{

    using _ = SignInPage;

    [Url("signin")]
    public class SignInPage : BasePage<_>
    {

        [FindById]
        public TextInput<_> Email { get; private set; }

        [FindById]
        public PasswordInput<_> Password { get; private set; }

        [FindItemByLabel]
        public Button<_> SignIn { get; private set; }



    }
}
