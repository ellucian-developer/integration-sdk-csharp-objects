// Copyright 2016 Ellucian Company L.P. and its affiliates.
using System;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a phone number.
    /// </summary>
    [DataContract]
    public class PersonContactPhoneDtoProperty
    {
        /// <summary>
        /// The avaialbility of (best time to call) the contact on this number
        /// </summary>
        [JsonProperty("contactAvailability")]
        public BestContactTimeType ContactAvailability { get; set; }

        /// <summary>
        /// The country calling code of telephone and/or mobile device when dialing internationally.
        /// </summary>
        [JsonProperty("countryCallingCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CountryCallingCode { get; set; }

        /// <summary>
        /// The phone number
        /// </summary>
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// The phone number extension
        /// </summary>
        [JsonProperty("extension", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Extension { get; set; }       
    }
}