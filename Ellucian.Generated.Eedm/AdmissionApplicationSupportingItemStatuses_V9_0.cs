//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Ellucian.Generated.Eedm;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The list of valid statuses for admission application supporting items. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AdmissionApplicationSupportingItemStatuses_V9_0 : CodeItem2
    {
        /// <summary>
        /// The type of the admission application supporting item status.
        /// </summary>

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AdmissionApplicationSupportingItemStatusType Type { get; set; }

    }
}
