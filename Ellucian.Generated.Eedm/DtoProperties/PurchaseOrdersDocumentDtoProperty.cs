//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The reference document associated with the line item.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PurchaseOrdersDocumentDtoProperty
    {
        /// <summary>
        /// The purchasing arrangement associated with the line item.
        /// </summary>
        [JsonProperty("purchasingArrangement", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 PurchasingArrangement { get; set; }

        /// <summary>
        /// The requisition associated with the line item.
        /// </summary>
        [JsonProperty("requisition", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Requisition { get; set; }

    }
}