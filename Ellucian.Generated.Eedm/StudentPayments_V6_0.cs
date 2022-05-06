// Copyright 2017 Ellucian Company L.P. an?d its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information student payments.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentPayments_V6_0 : BaseModel2
    {
        /// <summary>
        /// The person (student), who incurred the charge.  Specifically, this is the global identifier for the Student.
        /// </summary>
        [JsonProperty("student")]
        [FilterProperty("criteria")]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The account receivable type the charge is attached to.  Specifically, the global identifier for the Account Receivable Type.
        /// </summary>
        [JsonProperty("accountReceivableType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AccountReceivableType { get; set; }

        /// <summary>
        /// Accounting Code the charge is associated with.  Specifically, this is the global identifier for the Accounting Code.
        /// </summary>
        [JsonProperty("accountingCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 AccountingCode { get; set; }

        /// <summary>
        /// The term the charges are incurred in.  Specifically, this is the global identifier for the Academic Period.
        /// </summary>
        [JsonProperty("academicPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// Type of the charge the student incurred. 
        /// </summary>
        [JsonProperty("paymentType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public StudentPaymentTypes PaymentType { get; set; }

        /// <summary>
        /// The date when the student becomes liable for the charge.
        /// </summary>
        [JsonProperty("paidOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? PaidOn { get; set; }

        /// <summary>
        /// Comments of the charges.
        /// </summary>
        [JsonProperty("comments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Comments { get; set; }

        /// <summary>
        /// The monetary value for the specified currency.
        /// </summary>
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AmountDtoProperty Amount { get; set; }
    }
}
