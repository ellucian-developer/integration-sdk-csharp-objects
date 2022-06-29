// Copyright 2015-2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Reporting DTO property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ReportingCountryDtoProperty
    {
        /// <summary>
        /// The ISO Country code of the reporting country
        /// </summary>
        [JsonProperty("code")]
        public IsoCode Code { get; set; }


        /// <summary>
        /// The CIP code of the academic discipline
        /// </summary>
        [JsonProperty("cipCode")]
        public string Value { get; set; }

    }
}
