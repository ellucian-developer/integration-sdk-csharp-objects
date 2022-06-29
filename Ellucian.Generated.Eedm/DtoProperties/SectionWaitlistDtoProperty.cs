using Ellucian.Generated.Eedm;
using Newtonsoft.Json;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Section waitlist DTO property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SectionWaitlistDtoProperty
    {
        /// <summary>
        /// Waitlist Maximum
        /// </summary>
        [JsonProperty("waitlistMaximum", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? WaitlistMaximum{ get; set; }

        /// <summary>
        /// Registration Interval detail
        /// </summary>
        [JsonProperty("registrationInterval", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SectionRegistrationIntervalDtoProperty RegistrationInterval { get; set; }

        /// <summary>
        /// An indicator as to whether the section is eligible for a waitlist.
        /// </summary>
        [JsonProperty("eligible", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SectionWaitlistEligible? Eligible { get; set; }

        /// <summary>
        /// Waitlist Registration Status
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SectionWaitlistStatus? Status { get; set; }
        
        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public SectionWaitlistDtoProperty()
        {

        }
    }
}
