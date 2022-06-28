//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details of transactions representing disbursements from the institution. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PaymentTransactions_V12_0 : BaseModel2
    {
        /// <summary>
        /// The document number associated with the payment transaction (i.e. check number, payment transaction number).
        /// </summary>
        [FilterProperty("criteria")]
        [JsonProperty("documentNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// The reference number associated with the payment transaction.
        /// </summary>
        [JsonProperty("referenceNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// The payment method used for the transaction.
        /// </summary>
        [JsonProperty("paymentMethod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// The date the payment occurred.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("paymentDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// The invoices or refunds for which the payment occurred.
        /// </summary>
        [JsonProperty("paymentsFor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<PaymentsForDtoProperty> PaymentsFor { get; set; }

        /// <summary>
        /// The total amount paid as part of the transaction.
        /// </summary>
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Amount2DtoProperty Amount { get; set; }

        /// <summary>
        /// The details associated with the payee.
        /// </summary>
        [JsonProperty("payeeDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PayeeDetailsDtoProperty PayeeDetails { get; set; }

        /// <summary>
        /// The status of the payment transaction.
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PaymentTransactionsStatus Status { get; set; }

        /// <summary>
        /// The void type and date associated with the transaction.
        /// </summary>
        [JsonProperty("void", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PaymentVoidDtoProperty Void { get; set; }

    }
}
