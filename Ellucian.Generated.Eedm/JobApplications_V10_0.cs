//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about applications for employment. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class JobApplications_V10_0 : BaseModel2
    {
        /// <summary>
        /// The person applying for employment.
        /// </summary>

        [JsonProperty("person")]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The position associated with the application.
        /// </summary>

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Position { get; set; }

        /// <summary>
        /// The applicant's desired compensation.
        /// </summary>

        [JsonProperty("desiredCompensation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DesiredCompensationProperty DesiredCompensation { get; set; }

        /// <summary>
        /// The date when the application was submitted.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("appliedOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime AppliedOn { get; set; }

    }
}
