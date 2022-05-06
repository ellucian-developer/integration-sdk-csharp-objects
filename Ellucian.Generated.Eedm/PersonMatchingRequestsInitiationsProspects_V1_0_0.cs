//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information that may be used for new prospective student person requests that will be processed by duplicate prevention matching rules. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonMatchingRequestsInitiationsProspects_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The names associated with a prospect, specified by type (for example, "legal" or "birth").
        /// </summary>
        [JsonProperty("names", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonMatchingRequestNamesDtoProperty Names { get; set; }

        /// <summary>
        /// The biological masculinity or femininity of the prospect.
        /// </summary>
        [JsonProperty("gender", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GenderType2? Gender { get; set; }

        /// <summary>
        /// Additional matching criteria - minimum of one is required.
        /// </summary>
        [JsonProperty("matchingCriteria", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonMatchingRequestsInitiationsMatchingCriteria MatchingCriteria { get; set; }

    }
}
