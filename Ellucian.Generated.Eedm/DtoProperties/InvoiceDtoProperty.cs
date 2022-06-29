//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The invoices or refunds for which the payment occurred. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class InvoiceDtoProperty
    {

        /// <summary>
        /// The invoice for which the payment occurred.
        /// </summary>
        [JsonProperty("invoice", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Invoice { get; set; }

        /// <summary>
        /// The originating purchase order or encumbrance document associated with the invoice.
        /// </summary>
        [FilterProperty("criteria")]
        [JsonProperty("referenceDocument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LineItemReferenceDocumentDtoProperty2 ReferenceDocument { get; set; }

        /// <summary>
        /// The line items for which the payment occurred.
        /// </summary>
        [JsonProperty("lineItems", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<PaymentTransactionsLineItemDtoProperty> LineItems { get; set; }

        /// <summary>
        /// The refund for which the payment occurred.
        /// </summary>
        [JsonProperty("refund", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Refund { get; set; }
    }
}