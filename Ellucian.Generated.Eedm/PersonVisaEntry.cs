// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Entries into the country on this visa.
    /// </summary>
    [DataContract]
    public class PersonVisaEntry
    {        
        /// <summary>
        /// The date of entry.
        /// </summary>
        [DataMember(Name = "enteredOn", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EnteredOn { get; set; }        
    }
}