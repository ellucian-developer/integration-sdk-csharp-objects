// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Property to contain the financial aid fund financials year id, office id, and budgeted amount
    /// </summary>
    [DataContract]
    public class FinancialAidFundsFinancialProperty
    {
        /// <summary>
        /// Id of the financial aid fund year
        /// </summary>
        [DataMember(Name = "aidYear")]
        public GuidObject2 AidYear { get; set; }

        /// <summary>
        /// Id of the financial aid fund office
        /// </summary>
        [DataMember(Name = "office", EmitDefaultValue = false)]
        public GuidObject2 Office { get; set; }

        /// <summary>
        /// The budgeted amount of financial aid funds
        /// </summary>
        [DataMember(Name = "budgetedAmount")]
        public FinancialDtoProperty BudgetedAmount { get; set; }

        /// <summary>
        /// The maximum offered budget amount of financial aid funds
        /// </summary>
        [DataMember(Name = "maximumOfferedBudgetAmount", EmitDefaultValue = false)]
        public FinancialDtoProperty MaximumOfferedBudgetAmount { get; set; }

        /// <summary>
        /// constructor to initialize properties
        /// </summary>
        public FinancialAidFundsFinancialProperty()
        {
        }
    }
}
