//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// People who will be contacted in the event of an emergency situation related to the subject person. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonEmergencyContacts_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The subject person.
        /// </summary>

        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The details of the person who is the emergency contact.
        /// </summary>

        [JsonProperty("contact", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonEmergencyContactsContact Contact { get; set; }

    }
}