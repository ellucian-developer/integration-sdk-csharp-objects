//Copyright 2017 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Supporting items required for application of student admission. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AdmissionApplicationSupportingItems_V12_0 : BaseModel2
    {
        /// <summary>
        /// The application for which the supplementary items are required.
        /// </summary>
        [JsonProperty("application", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Application { get; set; }

        /// <summary>
        /// The type of supplementary item.
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Type { get; set; }

        /// <summary>
        /// The date when the supplementary item was received.
        /// </summary>
        [JsonProperty("receivedOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? ReceivedOn { get; set; }

        /// <summary>
        /// Requiredness of the supplementary item.
        /// </summary>
        [JsonProperty("required", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AdmissionApplicationSupportingItemsRequired Required { get; set; }

        /// <summary>
        /// The date by which the supplementary item is required.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("requiredByDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? RequiredByDate { get; set; }

        /// <summary>
        /// The date the supplementary item was assigned as a requirement.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("assignedOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? AssignedOn { get; set; }

        /// <summary>
        /// An external reference of the supplementary item.
        /// </summary>
        [JsonProperty("externalReference", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ExternalReference { get; set; }

        /// <summary>
        /// The status of the supplementary item.
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AdmissionApplicationSupportingItemsStatus Status { get; set; }

    }
}
