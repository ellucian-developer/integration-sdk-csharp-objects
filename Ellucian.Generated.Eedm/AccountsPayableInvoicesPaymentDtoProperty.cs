// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information concerning the payment of the invoice.
    /// </summary>
    [DataContract]
    public class AccountsPayableInvoicesPaymentDtoProperty
    {
        /// <summary>
        /// The source account for the payment of the invoice.
        /// </summary>
        [DataMember(Name = "source")]
        public GuidObject2 Source { get; set; }

        /// <summary>
        /// The date the invoice payment is due.
        /// </summary>
        [JsonConverter(typeof (DateOnlyConverter))]
        [DataMember(Name = "paymentDueOn")]
        public DateTime? PaymentDueOn { get; set; }

        /// <summary>
        /// An indication if direct deposit should not be used for the invoice or if the vendor default for direct deposit should be used.
        /// </summary>
        [DataMember(Name = "directDepositOverride", EmitDefaultValue = false)]
        public AccountsPayableInvoicesDirectDepositOverride? DirectDepositOverride { get; set; }

        /// <summary>
        /// The vendor payment terms and conditions that are applicable to this invoice.
        /// </summary>
        [DataMember(Name = "paymentTerms", EmitDefaultValue = false)]
        public GuidObject2 PaymentTerms { get; set; }
    }
}