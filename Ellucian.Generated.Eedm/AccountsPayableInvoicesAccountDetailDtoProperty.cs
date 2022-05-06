// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The detail account information for the line item.
    /// </summary>
    [DataContract]
    public class AccountsPayableInvoicesAccountDetailDtoProperty
    {

        /// <summary>
        ///The sequence number associated with the account detail item.
        /// </summary>
        [DataMember(Name = "sequenceNumber", EmitDefaultValue = false)]
        public int? SequenceNumber { get; set; }

        /// <summary>
        /// The accounting string associated with the account detail item.
        /// </summary>
        [DataMember(Name = "accountingString", EmitDefaultValue = false)]
        public string AccountingString { get; set; }

        /// <summary>
        /// The tax form component associated with the line item.
        /// </summary>
        [DataMember(Name = "taxFormComponent", EmitDefaultValue = false)]
        public GuidObject2 TaxFormComponent { get; set; }

        /// <summary>
        /// The allocation of line item values to the accounting string.
        /// </summary>
        [DataMember(Name = "allocation", EmitDefaultValue = false)]
        public AccountsPayableInvoicesAllocationDtoProperty Allocation { get; set; }


        /// <summary>
        /// The source account for the payment to the accounting string if different from the source specified for the invoice.
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public GuidObject2 Source { get; set; }


        /// <summary>
        /// An indication if budget checking should be enforced or overridden.
        /// </summary>
        [DataMember(Name = "budgetCheck", EmitDefaultValue = false)]
        public AccountsPayableInvoicesAccountBudgetCheck? BudgetCheck { get; set; }

        /// <summary>
        /// The person who made the submit request.
        /// </summary>
        [DataMember(Name = "submittedBy", EmitDefaultValue = false)]
        public GuidObject2 SubmittedBy { get; set; }
    }
}