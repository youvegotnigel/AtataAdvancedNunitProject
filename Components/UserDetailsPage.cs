namespace AtataAdvancedNunitProject.Components
{
    using AtataAdvancedNunitProject.Models;
    using _ = UserDetailsPage;
    public sealed class UserDetailsPage : BasePage<_>
    {
        [FindByDescriptionTerm]
        public Text<_> Email { get; private set; }

        [FindByDescriptionTerm]
        public Content<Office, _> Office { get; private set; }

        [FindByDescriptionTerm]
        public Content<Gender, _> Gender { get; private set; }

        [FindByDescriptionTerm]
        public Content<DateTime?, _> Birthday { get; private set; }

        [FindByDescriptionTerm]
        public Text<_> Notes { get; private set; }
    }
}
