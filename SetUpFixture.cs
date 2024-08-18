namespace AtataAdvancedNunitProject
{
    [SetUpFixture]
    public sealed class SetUpFixture
    {
        [OneTimeSetUp]
        public void GlobalSetUp()
        {
            string testEnvironmentAlias = TestContext.Parameters.Get("TestEnvironment", "local");
            string driverAlias = TestContext.Parameters.Get("DriverAlias", DriverAliases.Chrome);

            // Find information on AtataContext configuration on https://atata.io/getting-started/#configuration
            // Find information on Atata JSON configuration on https://github.com/atata-framework/atata-configuration-json
            AtataContext.GlobalConfiguration
                .ApplyJsonConfig<AtataConfig>()
                .ApplyJsonConfig<AtataConfig>(environmentAlias: testEnvironmentAlias)
                .Screenshots.UseFullPageOrViewportStrategy()
                .Screenshots.UseFileNameTemplate("{test-name}_{screenshot-number:D2}")
                .UseDriver(driverAlias);

            AtataContext.GlobalConfiguration.AutoSetUpDriverToUse();
        }
    }
}


/*
   Screenshot Naming Template Options:

   1. Timestamp-based:
      "{screenshot-timestamp:yyyyMMdd_HHmmss}" -> e.g., 20240818_143530.png

   2. Test Name with Sequence Number:
      "{test-name}_{screenshot-number:D2}" -> e.g., LoginTest_01.png

   3. Random GUID:
      "{screenshot-guid}" -> e.g., a1b2c3d4-5678-9101-1121-314151617181.png

   4. Test Name with Timestamp:
      "{test-name}_{screenshot-timestamp:yyyyMMdd_HHmmss}" -> e.g., LoginTest_20240818_143530.png

   5. Custom Label with Sequence Number:
      "{custom-label}_{screenshot-number:D2}" -> e.g., HomePage_01.png

   6. Browser Name with Sequence Number:
      "{browser-name}_{screenshot-number:D2}" -> e.g., Chrome_01.png

   7. Combined Variables:
      "{test-name}_{browser-name}_{screenshot-timestamp:yyyyMMdd_HHmmss}_{screenshot-number:D2}"
      -> e.g., LoginTest_Chrome_20240818_143530_01.png

   8. Simple Sequence Number:
      "{screenshot-number}" -> e.g., 1.png, 2.png, etc.

   Adjust the template as needed to create descriptive, unique filenames for your screenshots.
*/


