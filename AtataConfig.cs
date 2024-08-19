namespace AtataAdvancedNunitProject
{

    /// <summary>
    /// Represents configuration that is read from "Atata.json".
    /// The name of class doesn't matter, it can be: "Config", "AppConfig", etc.
    /// </summary>
    public sealed class AtataConfig : JsonConfig<AtataConfig>
    {
        // Custom configuration properties can be added here.
        // See https://github.com/atata-framework/atata-configuration-json#custom-settings

        public AccountConfiguration Account { get; set; }

        public class AccountConfiguration
        {
            public string Email { get; set; }

            public string Password { get; set; }
        }
    }
}
