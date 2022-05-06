//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The order details associated with the blanket purchase order. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class BlanketPurchaseOrdersOrderdetails
    {
        /// <summary>
        /// A system generated number to identify the order detail. User specified values will be overwritten.
        /// </summary>

        [JsonProperty("orderDetailNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string OrderDetailNumber { get; set; }

        /// <summary>
        /// The description of the commodity specified in the order detail.
        /// </summary>

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The commodity code associated with the item ordered.
        /// </summary>

        [JsonProperty("commodityCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 CommodityCode { get; set; }

        /// <summary>
        /// The amount associated with the item ordered.
        /// </summary>

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Amount2DtoProperty Amount { get; set; }

        /// <summary>
        /// Additional charges/discounts applied to the item ordered (e.g. freight).
        /// </summary>

        [JsonProperty("additionalAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Amount2DtoProperty AdditionalAmount { get; set; }

        /// <summary>
        /// The tax codes applicable to the item ordered.
        /// </summary>

        [JsonProperty("taxCodes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> TaxCodes { get; set; }

        /// <summary>
        /// The discount amount applied to the item ordered, which may be calculated from the overall discount or overridden.
        /// </summary>

        [JsonProperty("discountAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Amount2DtoProperty DiscountAmount { get; set; }

        /// <summary>
        /// The comments associated with the item ordered.
        /// </summary>

        [JsonProperty("comments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<BlanketPurchaseOrdersComments> Comments { get; set; }

        /// <summary>
        /// The requisitions referenced for the item ordered.
        /// </summary>

        [JsonProperty("referenceRequisitions", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<BlanketPurchaseOrdersReferenceDtoProperty> ReferenceRequisitions { get; set; }

        /// <summary>
        /// The account details associated with the item ordered.
        /// </summary>

        [JsonProperty("accountDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<BlanketPurchaseOrdersAccountDetailDtoProperty> AccountDetails { get; set; }


    }
}