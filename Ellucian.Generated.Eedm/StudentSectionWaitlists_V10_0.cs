//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Sections' waitlists for students. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentSectionWaitlists_V10_0 : BaseModel2
    {
        /// <summary>
        /// The student associated with the section waitlist.
        /// </summary>

        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentSectionWaitlistsPersonDtoProperty Person { get; set; }

        /// <summary>
        /// The section associated with the waitlist.
        /// </summary>

        [JsonProperty("section", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentSectionWaitlistsSectionDtoProperty Section { get; set; }

        /// <summary>
        /// The number that represents the ranking of the waitlisted student for the given section.
        /// </summary>

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? Priority { get; set; }

    }
}
