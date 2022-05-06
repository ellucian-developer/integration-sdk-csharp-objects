//Copyright 2019 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The phone details at which the contact can be reached. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonEmergencyContactsPhones
    {


        /// <summary>
        /// The availability of the contact for this number.
        /// </summary>

        [JsonProperty("contactAvailability", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 ContactAvailability { get; set; }

        /// <summary>
        /// The country calling code of the telephone and/or mobile device when dialing internationally.
        /// </summary>

        [JsonProperty("countryCallingCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CountryCallingCode { get; set; }

        /// <summary>
        /// The number assigned to the phone.
        /// </summary>

        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// The extension used to connect to the phone when multiple phones share the same primary number.
        /// </summary>

        [JsonProperty("extension", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Extension { get; set; }


    }
}

