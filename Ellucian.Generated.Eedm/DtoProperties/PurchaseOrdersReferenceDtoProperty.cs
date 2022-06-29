//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The reference associated with the line item.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PurchaseOrdersReferenceDtoProperty
    {
        /// <summary>
        /// The reference document associated with the line item.
        /// </summary>
        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PurchaseOrdersDocumentDtoProperty Document { get; set; }

        /// <summary>
        /// The line item number associated with the lione item
        /// </summary>
        [JsonProperty("lineItemNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string lineItemNumber { get; set; }

    }
}