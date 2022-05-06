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
    /// The details of the person who is the emergency contact. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonEmergencyContactsContact
    {
        /// <summary>
        /// The name of the contact.
        /// </summary>

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonContactName Name { get; set; }

        /// <summary>
        /// The types of situations when the person should be contacted.
        /// </summary>

        [JsonProperty("types", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> Types { get; set; }

        /// <summary>
        /// The phone details at which the contact can be reached.
        /// </summary>

        [JsonProperty("phones", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<PersonEmergencyContactsPhones> Phones { get; set; }

        /// <summary>
        /// The relationship between the subject person and the contact.
        /// </summary>

        [JsonProperty("relationship", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonEmergencyContactsRelationship Relationship { get; set; }

    }
}

