namespace AtataAdvancedNunitProject.Components
{

    using _ = SignInPage;

    [Url("signin")]
    [VerifyTitle]
    [VerifyH1]
    public class SignInPage : BasePage<_>
    {

        [FindById]
        public TextInput<_> Email { get; private set; }

        [FindById]
        public PasswordInput<_> Password { get; private set; }

        [FindItemByLabel]
        public Button<_> SignIn { get; private set; }

        public ValidationMessageList<_> ValidationMessages { get; private set; }

    }
}
