using System.Collections.Generic;

namespace PX.SmsProvider.Plivo
{
    public class PlivoSmsProviderFactory : ISmsProviderFactory
    {
        //Create Provider and initialize with settings
        public ISmsProvider Create(IEnumerable<ISmsProviderSetting> settings)
        {
            var provider = new PlivoSmsProvider();
            provider.LoadSettings(settings);
            return provider;
        }

        public ISmsProvider Create()
        {
            var provider = new PlivoSmsProvider();
            return provider;
        }

        //Description of the Provider - the way you need it to be displayed in Provider Type box on the SMS Provider (SM203535) screen
        public string Description { get; } = Messages.ProviderName;
        //Name of the Provider - the way you need it to be displayed in Provider Type box on the SMS Provider (SM203535) screen
        public string Name { get; } = typeof(PlivoSmsProvider).FullName;
    }
}