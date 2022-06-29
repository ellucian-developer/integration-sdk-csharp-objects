//Copyright 2020 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The name, phone, and email of the person who is the vendor contact.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class VendorPersonContact
    {

        /// <summary>
        /// The first name of the vendor contact person.
        /// </summary>

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The middle name of the vendor contact person.
        /// </summary>

        [JsonProperty("middleName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MiddleName { get; set; }

        /// <summary>
        /// The last name of the vendor contact person.
        /// </summary>

        [JsonProperty("lastName")]
        public string LastName { get; set; }

    }
}