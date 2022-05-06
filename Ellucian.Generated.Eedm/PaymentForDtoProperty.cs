//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The invoices or refunds for which the payment occurred. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PaymentsForDtoProperty
    {

        /// <summary>
        /// The invoice or refunds for which the payment occurred.
        /// </summary>
        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InvoiceDtoProperty Document { get; set; }

        /// <summary>
        /// The amount paid for the invoice or refund.
        /// </summary>
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Amount2DtoProperty Amount { get; set; }

    }
}