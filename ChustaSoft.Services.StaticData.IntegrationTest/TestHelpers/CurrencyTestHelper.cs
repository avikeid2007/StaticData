﻿using ChustaSoft.Services.StaticData.Base;
using ChustaSoft.Services.StaticData.Helpers;
using ChustaSoft.Services.StaticData.IntegrationTest.TestConstants;
using ChustaSoft.Services.StaticData.Repositories;
using ChustaSoft.Services.StaticData.Services;

namespace ChustaSoft.Services.StaticData.IntegrationTest.TestHelpers
{
    internal static class CurrencyTestHelper
    {

        #region Internal methods

        internal static ICurrencyRepository CreateMockRepository()
        {
            var mockedConfiguration = new InternalConfiguration(StaticDataConfigurationBuilder.Configure().AddCurrencyConverterApiKey(TestKeys.TestFreeCurrencyConverterKey));

            return new CurrencyExternalService(mockedConfiguration);
        }

        internal static ICurrencyService CreateMockService()
        {
            var repository = CreateMockRepository();

            return new CurrencyService(repository);
        }

        #endregion

    }
}
