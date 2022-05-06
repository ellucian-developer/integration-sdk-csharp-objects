using Newtonsoft.Json;
// Copyright 2016 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about an address seasonal recurrence
    /// </summary>
    [DataContract]
    public class PersonAddressRecurrenceDtoProperty
    {
        /// <summary>
        /// Object representing seaonsal start and end
        /// </summary>
        [JsonProperty("recurrence", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Recurrence3 Recurrence { get; set; }
    }
}