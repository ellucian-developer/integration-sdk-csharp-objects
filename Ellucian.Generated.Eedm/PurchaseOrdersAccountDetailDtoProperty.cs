// Copyright 2017-2020 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Converters;
using System;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The detail account information for the line item.
    /// </summary>
    [DataContract]
    public class PurchaseOrdersAccountDetailDtoProperty
    {

        /// <summary>
        /// The sequence number associated with the account detail item
        /// </summary>
        [DataMember(Name = "sequenceNumber", EmitDefaultValue = false)]
        public int SequenceNumber { get; set; }


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
        public PurchaseOrdersAllocationDtoProperty Allocation { get; set; }
     
        /// <summary>
        /// An indication if budget checking should be enforced or overridden.
        /// </summary>
        [DataMember(Name = "budgetCheck", EmitDefaultValue = false)]
        public PurchaseOrdersAccountBudgetCheck? BudgetCheck { get; set; }

        /// <summary>
        /// The person who made the submit request for the line item
        /// </summary>
        [DataMember(Name = "submittedBy", EmitDefaultValue = false)]
        public GuidObject2 SubmittedBy { get; set; }

        /// <summary>
        /// The date associated with the line item's status
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "statusDate", EmitDefaultValue = false)]
        public DateTime? StatusDate { get; set; }


        /// <summary>
        /// The status of the line item.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public LineItemStatus? Status { get; set; }
    }
}