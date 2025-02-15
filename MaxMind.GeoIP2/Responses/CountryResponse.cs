﻿#region

using MaxMind.Db;
using MaxMind.GeoIP2.Model;

#endregion

namespace MaxMind.GeoIP2.Responses
{
    /// <summary>
    ///     This class provides a model for the data returned by the GeoIP2 Precision: Country and GeoIP2 Country.
    ///     The only difference between the City and Insights response classes is
    ///     which fields in each record may be populated.
    ///     See
    ///     <a href="https://dev.maxmind.com/geoip/docs/web-services?lang=en">
    ///         GeoIP2 Web
    ///         Services
    ///     </a>
    /// </summary>
    public class CountryResponse : AbstractCountryResponse
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        public CountryResponse()
        {
        }

        /// <summary>
        ///     Constructor
        /// </summary>
        [Constructor]
        public CountryResponse(
            Continent? continent = null,
            Country? country = null,
            [Parameter("maxmind")] Model.MaxMind? maxMind = null,
            [Parameter("registered_country")] Country? registeredCountry = null,
            [Parameter("represented_country")] RepresentedCountry? representedCountry = null,
            [Parameter("traits", true)] Traits? traits = null
            ) : base(continent, country, maxMind, registeredCountry, representedCountry, traits)
        {
        }
    }
}
