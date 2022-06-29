//Copyright 2020 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details for the vendor contact. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class VendorContactsContact
    {
        /// <summary>
        /// The type of relationship between the vendor and the contact.
        /// </summary>

        [JsonProperty("relationshipType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 RelationshipType { get; set; }

        /// <summary>
        /// The person who is the vendor contact.
        /// </summary>

        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public VendorContactsPerson Person { get; set; }

        /// <summary>
        /// The phone type, number and extension of the contact person.
        /// </summary>

        [JsonProperty("phones", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<VendorContactsPhones> Phones { get; set; }

        /// <summary>
        /// The earliest date when the contact is active.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The last date when the contact was active.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? EndOn { get; set; }

    }
}