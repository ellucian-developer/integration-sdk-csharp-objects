// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A request for payment for goods sold, services provided or expenses incurred, containing individual prices, additional charges, payment terms and account information 
    /// </summary>
    [DataContract]
    public class AccountsPayableInvoices_V11_2_0 : BaseModel2
    {
      
        /// <summary>
        /// The vendor associated with the invoice.
        /// </summary>
        [DataMember(Name = "vendor")]
        public AccountsPayableInvoicesVendorDtoProperty Vendor { get; set; }

        /// <summary>
        /// The purchase order number, encumbrance number, or other reference number associated with the invoice.
        /// </summary>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = false)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// A system-generated number associated with the invoice
        /// </summary>
        [FilterProperty("criteria")]
        [DataMember(Name = "invoiceNumber", EmitDefaultValue = false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// The invoice number specified by the vendor.
        /// </summary>
        [DataMember(Name = "vendorInvoiceNumber", EmitDefaultValue = false)]
        public string VendorInvoiceNumber { get; set; }

        /// <summary>
        /// The type of accounts payable invoice, i.e. Procurement, eProcurement, or Travel.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public AccountsPayableInvoicesType? Type { get; set; }

        /// <summary>
        /// The transaction date for the invoice. This will be the date used when entering the transactions into the general ledger.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "transactionDate")]
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// The invoice date as specified by the vendor.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "vendorInvoiceDate", EmitDefaultValue = false)]
        public DateTime? VendorInvoiceDate { get; set; }

        /// <summary>
        /// The date on which the invoice was voided, if applicable.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "voidDate", EmitDefaultValue = false)]
        public DateTime? VoidDate { get; set; }
        
        /// <summary>
        /// The current state of the processing of the invoice.
        /// </summary>
        [DataMember(Name = "processState", EmitDefaultValue = false)]
        public AccountsPayableInvoicesProcessState? ProcessState { get; set; }
        
        /// <summary>
        /// An indicator specifying if payment for the invoice is on hold.
        /// </summary>
        [DataMember(Name = "paymentStatus", EmitDefaultValue = false)]
        public AccountsPayableInvoicesPaymentStatus? PaymentStatus { get; set; }

        /// <summary>
        /// The billed amount as specified by the vendor.
        /// </summary>
        [DataMember(Name = "vendorBilledAmount", EmitDefaultValue = false)]
        public Amount2DtoProperty VendorBilledAmount { get; set; }

        /// <summary>
        /// The discount applied to the overall invoice.
        /// </summary>
        [DataMember(Name = "invoiceDiscountAmount", EmitDefaultValue = false)]
        public Amount2DtoProperty InvoiceDiscountAmount { get; set; }

        /// <summary>
        /// The taxes that are applicable to the line item if different from the invoice.
        /// </summary>
        [DataMember(Name = "taxes", EmitDefaultValue = false)]
        public List<AccountsPayableInvoicesTaxesDtoProperty> Taxes { get; set; }
    
        /// <summary>
        /// An indicator specifying if the invoice is a standard or a credit invoice.
        /// </summary>
        [DataMember(Name = "invoiceType", EmitDefaultValue = false)]
        public AccountsPayableInvoicesInvoiceType? InvoiceType { get; set; }

        /// <summary>
        /// Information concerning the payment of the invoice.
        /// </summary>
        [DataMember(Name = "payment", EmitDefaultValue = false)]
        public AccountsPayableInvoicesPaymentDtoProperty Payment { get; set; }
        
        /// <summary>
        /// Comments on the invoice as a whole.
        /// </summary>
        [DataMember(Name = "invoiceComment", EmitDefaultValue = false)]
        public string InvoiceComment { get; set; }

        /// <summary>
        /// Information required for government reporting.
        /// </summary>
        [DataMember(Name = "governmentReporting", EmitDefaultValue = false)]
        public List<GovernmentReportingDtoProperty> GovernmentReporting { get; set; }

        /// <summary>
        /// The person who made the submit request for the invoice
        /// </summary>
        [JsonProperty("submittedBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 SubmittedBy { get; set; }

        /// <summary>
        /// The individual line items associated with an invoice.
        /// </summary>
        [DataMember(Name = "lineItems", EmitDefaultValue = false)]
        public List<AccountsPayableInvoicesLineItemDtoProperty2> LineItems { get; set; }


    }
}
