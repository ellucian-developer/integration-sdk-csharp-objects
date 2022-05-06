// Copyright 2015 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Instructor DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class InstructorDtoProperty3
    {
        /// <summary>
        /// Id of the Instructor
        /// </summary>
        [JsonProperty("detail")]
        [FilterProperty("criteria")]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// The name of the instructor
        /// </summary>
        [JsonProperty("names", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<InstructorNameDtoProperty2> Names { get; set; }

        /// <summary>
        /// The credentials of the instructor
        /// </summary>
        [JsonProperty("credentials", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<InstructorCredential3DtoProperty> Credentials { get; set; }

        /// <summary>
        /// An indication whether the instructor is identified as the primary instructor for the section.
        /// </summary>

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SectionInstructorsInstructorRole InstructorRole { get; set; }
    }
}
