using AtataAdvancedNunitProject.Controls;

namespace AtataAdvancedNunitProject.Components;

[WaitForDocumentReadyState(Priority = TriggerPriority.Highest)]
public abstract class BasePage<TOwner> : Page<TOwner>
    where TOwner : BasePage<TOwner>
{
    [FindByContent("Calculations")]
    public Link<CalculationsPage, TOwner> Calculations { get; private set; }

    [FindByContent("Plans")]
    public Link<PlansPage, TOwner> Plans { get; private set; }

    [FindByContent("Products")]
    public Link<ProductsPage, TOwner> Products { get; private set; }

    [FindByContent("Sign In")]
    public Link<SignInPage, TOwner> SignInPage { get; private set; }

    [FindByContent("Sign Up")]
    public Link<SignUpPage, TOwner> SignUpPage { get; private set; }

    public MainMenu<TOwner> Menu { get; private set; }

    [FindFirst]
    public H1<TOwner> Header { get; private set; }
}
