// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE FOR THE WORLD
// -------------------------------------------------------

using System;
using System.Threading.Tasks;
using Sofee.Core.Api.Brokers.DateTimes;
using Sofee.Core.Api.Brokers.Loggings;
using Sofee.Core.Api.Brokers.Storages;
using Sofee.Core.Api.Models.Countries;

namespace Sofee.Core.Api.Services.Foundations.Countries;

public class CountryService : ICountryService
{
    private readonly IDateTimeBroker dateTimeBroker;
    private readonly ILoggingBroker loggingBroker;
    private readonly IStorageBroker storageBroker;

    public CountryService(
        IStorageBroker storageBroker,
        IDateTimeBroker dateTimeBroker,
        ILoggingBroker loggingBroker)
    {
        this.storageBroker = storageBroker;
        this.dateTimeBroker = dateTimeBroker;
        this.loggingBroker = loggingBroker;
    }

    public ValueTask<Country> AddCountryAsync(Country country)
    {
        throw new NotImplementedException();
    }
}