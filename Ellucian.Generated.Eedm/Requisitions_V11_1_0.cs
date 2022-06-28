//Copyright 2017-2021 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Requests to purchase goods or services that may reserve funds in financial ledgers. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Requisitions_V11_1_0 : BaseModel2
    {
        /// <summary>
        /// The number associated with the requisition assigned by the finance system.
        /// </summary>
        [JsonProperty("requisitionNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string RequisitionNumber { get; set; }

        /// <summary>
        /// A reference number specified for the requisition by an external system.
        /// </summary>
        [JsonProperty("referenceNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// The type of requisition, i.e. Procurement or eProcurement.
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RequisitionTypes? Type { get; set; }

        /// <summary>
        /// The payment source associated with the requisition which is used for calculating taxes
        /// </summary>
        [JsonProperty("paymentSource", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 PaymentSource { get; set; }

        /// <summary>
        /// The date when the request was originated.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("requestedOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime RequestedOn { get; set; }

        /// <summary>
        /// The transaction date for the requisition. This will be the date used when entering the transactions into the general ledger.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("transactionDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// The status of the requisition.
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RequisitionsStatus? Status { get; set; }

        /// <summary>
        /// The date by which the items are requested to be delivered.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("deliveredBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? DeliveredBy { get; set; }

        /// <summary>
        /// The initiator of the requisition.
        /// </summary>
        [JsonProperty("initiator", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InitiatorDtoProperty Initiator { get; set; }

        /// <summary>
        /// The purchasing agent assigned to the requisition.
        /// </summary>
        [JsonProperty("buyer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Buyer { get; set; }

        /// <summary>
        /// The shipping information associated with the requisition.
        /// </summary>
        [JsonProperty("shipping", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ShippingDtoProperty Shipping { get; set; }

        /// <summary>
        /// Override of the shipping information specified in the ship to destination.
        /// </summary>
        [JsonProperty("overrideShippingDestination", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public OverrideShippingDestinationDtoProperty OverrideShippingDestination { get; set; }

        /// <summary>
        /// The vendor associated with the requisition.
        /// </summary>
        [JsonProperty("vendor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public VendorDtoProperty Vendor { get; set; }

        /// <summary>
        /// The vendor payment terms and conditions that are applicable to the requisition.
        /// </summary>
        [JsonProperty("paymentTerms", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 PaymentTerms { get; set; }

        /// <summary>
        /// The person who made the submit request for the requisition.
        /// </summary>
        [JsonProperty("submittedBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 SubmittedBy { get; set; }

        /// <summary>
        /// The comments associated with the requisition.
        /// </summary>
        [JsonProperty("comments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<CommentsDtoProperty> Comments { get; set; }

        /// <summary>
        /// The individual line items associated with the requisition.
        /// </summary>
        [JsonProperty("lineItems", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<RequisitionsLineItemsDtoProperty> LineItems { get; set; }

    }
}
