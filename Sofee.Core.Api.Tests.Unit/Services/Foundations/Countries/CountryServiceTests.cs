// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE FOR THE WORLD
// -------------------------------------------------------

using System;
using System.Globalization;
using Moq;
using Sofee.Core.Api.Brokers.DateTimes;
using Sofee.Core.Api.Brokers.Loggings;
using Sofee.Core.Api.Brokers.Storages;
using Sofee.Core.Api.Models.Countries;
using Sofee.Core.Api.Services.Foundations.Countries;
using Tynamix.ObjectFiller;

namespace Sofee.Core.Api.Tests.Unit.Services.Foundations.Countries
{
    public partial class CountryServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly Mock<IDateTimeBroker> dateTimeBrokerMock;
        private readonly Mock<ILoggingBroker> loggingBrokerMock;
        private readonly ICountryService countryService;

        public CountryServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();
            this.dateTimeBrokerMock = new Mock<IDateTimeBroker>();
            this.loggingBrokerMock = new Mock<ILoggingBroker>();

            this.countryService = new CountryService(
                storageBroker: storageBrokerMock.Object,
                dateTimeBroker: dateTimeBrokerMock.Object,
                loggingBroker: loggingBrokerMock.Object);
        }

        private Country CreateRandomCountry() =>
            CreateCountryFiller(dates: GetRandomDateTime()).Create();

        private static Filler<Country> CreateCountryFiller(DateTimeOffset dates)
        {
            var filler = new Filler<Country>();
            Guid createdById = Guid.NewGuid();

            filler.Setup()
                .OnProperty(country => country.CreatedDate).Use(dates)
                .OnProperty(country => country.UpdatedDate).Use(dates)
                .OnProperty(country => country.CreatedBy).Use(createdById)
                .OnProperty(country => country.UpdatedBy).Use(createdById);

            return filler;
        }

        private static DateTimeOffset GetRandomDateTime() =>
            new DateTimeRange(earliestDate: new DateTime()).GetValue();
    }
}