// Copyright 2016-2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about an address
    /// </summary>
    [DataContract]
    public class PersonAddressDtoProperty
    {
        /// <summary>
        /// Globally unique identifier of the address
        /// </summary>
        [JsonProperty("address")]
        public PersonAddress address { get; set; }

        /// <summary>
        /// The <see cref="Type">type</see> of address
        /// </summary>
        [JsonProperty("type")]
        public PersonAddressTypeDtoProperty Type { get; set; }

        /// <summary>
        /// The effective start of an address
        /// </summary>
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? AddressEffectiveStart { get; set; }

        /// <summary>
        /// The effective end of an address
        /// </summary>
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? AddressEffectiveEnd { get; set; }

        /// <summary>
        /// Set to "primary" if the address is the preferred residence
        /// </summary>
        [JsonProperty("preference", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonPreference? Preference { get; set; }
    
        /// <summary>
        /// Object representing seasonal start and end
        /// </summary>
        [JsonProperty("seasonalOccupancies", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<PersonAddressRecurrenceDtoProperty> SeasonalOccupancies { get; set; }
    }
}