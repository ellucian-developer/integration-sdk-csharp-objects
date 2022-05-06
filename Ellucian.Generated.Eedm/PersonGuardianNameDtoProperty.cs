// Copyright 2016 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The name of the contact
    /// </summary>
    [DataContract]
    public class PersonGuardianNameDtoProperty
    {
        /// <summary>
        /// Guardians full name
        /// </summary>
        [JsonProperty("fullName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FullName { get; set; }

        /// <summary>
        /// Guardians first name
        /// </summary>
        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// Guardians last name
        /// </summary>
        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// Guardians middle name
        /// </summary>
        [JsonProperty("middleName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MiddleName { get; set; }
    }
}
