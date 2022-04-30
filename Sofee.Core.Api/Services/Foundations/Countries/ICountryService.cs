// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE FOR THE WORLD
// -------------------------------------------------------

using System.Threading.Tasks;
using Sofee.Core.Api.Models.Countries;

namespace Sofee.Core.Api.Services.Foundations.Countries
{
    public interface ICountryService
    {
        ValueTask<Country> AddCountryAsync(Country country);
    }
}