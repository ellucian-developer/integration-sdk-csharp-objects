// Copyright 2017 Ellucian Company L.P. and its affiliates.

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
    public class BlanketPurchaseOrdersAccountDetailDtoProperty
    {
        /// <summary>
        /// The accounting string associated with the account detail item.
        /// </summary>
        [DataMember(Name = "accountingString", EmitDefaultValue = false)]
        public string AccountingString { get; set; }

        /// <summary>
        /// The allocation of line item values to the accounting string.
        /// </summary>
        [DataMember(Name = "allocation", EmitDefaultValue = false)]
        public BlanketPurchaseOrdersAllocationDtoProperty Allocation { get; set; }

     
        /// <summary>
        /// An indication if budget checking should be enforced or overridden.
        /// </summary>
        [DataMember(Name = "budgetCheck", EmitDefaultValue = false)]
        public PurchaseOrdersAccountBudgetCheck? BudgetCheck { get; set; }
    }
}