//Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The individual line items associated with the procurement receipt. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ProcurementReceiptsLineItems
    {

        /// <summary>
        /// The line item number referenced from the purchase order.
        /// </summary>
        [JsonProperty("lineItemNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LineItemNumber { get; set; }

        /// <summary>
        /// The received quantity or amount for the line item including the rejected quantity or amount.
        /// </summary>
        [JsonProperty("received", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public QuantityAmount2DtoProperty Received { get; set; }

        /// <summary>
        /// The rejected quantity or amount for line item.
        /// </summary>
        [JsonProperty("rejected", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public QuantityAmount2DtoProperty Rejected { get; set; }

        /// <summary>
        /// The comment associated with the line item.
        /// </summary>
        [JsonProperty("comment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Comment { get; set; }
    }
}