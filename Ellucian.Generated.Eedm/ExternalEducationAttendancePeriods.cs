//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The periods associated with the person's attendance at the institution. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ExternalEducationAttendancePeriods
    {

        /// <summary>
        /// The date when the person's education at the institution began.
        /// </summary>
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateDtoProperty StartDate { get; set; }

        /// <summary>
        /// The date when the person's education at the institution ended.
        /// </summary>
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateDtoProperty EndDate { get; set; }

    }
}