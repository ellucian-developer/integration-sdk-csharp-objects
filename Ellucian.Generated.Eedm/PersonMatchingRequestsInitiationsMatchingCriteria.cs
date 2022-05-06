//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Additional matching criteria - minimum of one is required. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonMatchingRequestsInitiationsMatchingCriteria
    {
        /// <summary>
        /// The date when a prospect was born.
        /// </summary>
        [JsonProperty("dateOfBirth", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Information that identifies a user to a system.
        /// </summary>
        [JsonProperty("credential", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonMatchRequestCredentialDtoProperty Credential { get; set; }

        /// <summary>
        /// Alternative information that uniquely identifies a user.
        /// </summary>
        [JsonProperty("alternativeCredentials", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<PersonMatchRequestAlternativeCredentials> AlternativeCredentials { get; set; }

        /// <summary>
        /// The physical address associated with a prospect.
        /// </summary>
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonMatchRequestAddressDtoProperty Address { get; set; }

        /// <summary>
        /// The phone associated with a prospect.
        /// </summary>
        [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonMatchRequestPhoneDtoProperty Phone { get; set; }

        /// <summary>
        /// The email address associated with a prospect.
        /// </summary>
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonMatchingRequestEmailDtoProperty Email { get; set; }
    }
}

