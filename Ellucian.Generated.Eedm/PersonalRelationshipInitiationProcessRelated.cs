//Copyright 2020 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The person who has the relationship with the subject person.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonalRelationshipInitiationProcessRelated
    {
        /// <summary>
        /// The person who has the relationship with the subject person.
        /// </summary>

        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The first name of the related person.
        /// </summary>

        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// The middle name of the related person.
        /// </summary>

        [JsonProperty("middleName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MiddleName { get; set; }

        /// <summary>
        /// The last name of the related person.
        /// </summary>

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// The date when a prospect was born.
        /// </summary>
        [JsonProperty("dateOfBirth", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? DateOfBirth { get; set; }

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