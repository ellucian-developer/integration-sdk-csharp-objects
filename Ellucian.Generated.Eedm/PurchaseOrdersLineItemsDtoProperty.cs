//Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The line items associated with the purchase order. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PurchaseOrdersLineItemsDtoProperty
    {

        /// <summary>
        /// A system generated number to identify the line item. User specified values will be overwritten.
        /// </summary>
        [JsonProperty("lineItemNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LineItemNumber { get; set; }

        /// <summary>
        /// The description of the commodity specified by the line item.
        /// </summary>
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The commodity code associated with the line item.
        /// </summary>
        [JsonProperty("commodityCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 CommodityCode { get; set; }


        /// <summary>
        /// The fixed asset designation associated with the line item.
        /// </summary>
        [JsonProperty("fixedAssetDesignation", DefaultValueHandling = DefaultValueHandling.Ignore)]        
        public GuidObject2 FixedAssetDesignation { get; set; }

        /// <summary>
        /// The vendor part number for the line item.
        /// </summary>
        [JsonProperty("partNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PartNumber { get; set; }

        /// <summary>
        /// The date when the item specified for the line item is needed.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("desiredDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? DesiredDate { get; set; }

        /// <summary>
        /// The quantity of the line item.
        /// </summary>
        [JsonProperty("quantity", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Decimal? Quantity { get; set; }

        /// <summary>
        /// The unit of measure used for the line item.
        /// </summary>
        [JsonProperty("unitOfMeasure", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 UnitOfMeasure { get; set; }

        /// <summary>
        /// The price per unit for the commodity specified for the line item.
        /// </summary>
        [JsonProperty("unitPrice", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Amount2DtoProperty UnitPrice { get; set; }

        /// <summary>
        /// Additional charges/discounts applied to the line item (e.g. freight).
        /// </summary>
        [JsonProperty("additionalAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Amount2DtoProperty AdditionalAmount { get; set; }

        /// <summary>
        /// The tax codes applicable to the line item.
        /// </summary>
        [JsonProperty("taxCodes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> TaxCodes { get; set; }

        /// <summary>
        /// The discount amount applied to the line item, which may be calculated from the overall discount or overridden.
        /// </summary>
        [JsonProperty("discountAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// The status of the line item.
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LineItemStatus? Status { get; set; }

        /// <summary>
        /// A discount applied to the line item in addition to the overall vendor discount, e.g. discount based on quantity purchased.
        /// </summary>
        [JsonProperty("tradeDiscount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public TradeDiscountDtoProperty TradeDiscount { get; set; }

        /// <summary>
        /// The comments associated with the line item.
        /// </summary>
        [JsonProperty("comments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<PurchaseOrdersCommentsDtoProperty> Comments { get; set; }
    
        /// <summary>
        /// The reference associated with the line item.
        /// </summary>
        [JsonProperty("reference", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PurchaseOrdersReferenceDtoProperty Reference { get; set; }

        /// <summary>
        /// The account details associated with the line item.
        /// </summary>
        [JsonProperty("accountDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<PurchaseOrdersAccountDetailDtoProperty> AccountDetail { get; set; }

    }
}

