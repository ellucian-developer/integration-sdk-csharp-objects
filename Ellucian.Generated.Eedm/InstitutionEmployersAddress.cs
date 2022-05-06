// Copyright 2017 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Detailed information concerning financial aid applicant income. 
    /// </summary>
    [DataContract]
    public class InstitutionEmployersAddress
    {
        /// <summary>
        /// The address lines, such as a street address, post office box number, etc, of the
        /// physical address associated with the institution employer.
        /// </summary>
        [JsonProperty("addressLines", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> AddressLines { get; set; }

        /// <summary>
        /// The city associated with the employer.
        /// </summary>
        [JsonProperty("city", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// The state associated with the employer.
        /// </summary>
        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// The country associated with the employer.
        /// </summary>
        [JsonProperty("country", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// The postal code associated with the employer.
        /// </summary>
        [JsonProperty("postalCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PostalCode { get; set; }
    }
}
