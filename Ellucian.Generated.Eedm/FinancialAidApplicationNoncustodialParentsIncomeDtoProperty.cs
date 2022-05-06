// Copyright 2017 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Detailed information concerning financial aid applicant's custodial parents' income. 
    /// </summary>
    [DataContract]
    public class FinancialAidApplicationNoncustodialParentsIncomeDtoProperty
    {

        /// <summary>
        /// Financial aid applicant's parents' tax return status
        /// </summary>
        [DataMember(Name = "taxReturn", EmitDefaultValue = false)]
        public FinancialAidApplicationsTaxReturnStatus taxReturn { get; set; }

        /// <summary>
        /// Financial aid applicant's parents' adjusted gross income
        /// </summary>
        [DataMember(Name = "adjustedGrossIncome", EmitDefaultValue = false)]
        public AmountDtoProperty AdjustedGrossIncome { get; set; }

        /// <summary>
        /// Financial aid applicant's parents' total income
        /// </summary>
        [DataMember(Name = "totalIncome", EmitDefaultValue = false)]
        public AmountDtoProperty TotalIncome { get; set; }

        /// <summary>
        /// Financial aid applicant's first parent's earned income
        /// </summary>
        [DataMember(Name = "firstParentEarnedIncome", EmitDefaultValue = false)]
        public AmountDtoProperty firstParentEarnedIncome { get; set; }

        /// <summary>
        /// Financial aid applicant's second parent's earned income
        /// </summary>
        [DataMember(Name = "secondParentEarnedIncome", EmitDefaultValue = false)]
        public AmountDtoProperty secondParentEarnedIncome { get; set; }

        /// <summary>
        /// Financial aid applicant's first parent's highest education level
        /// </summary>
        [DataMember(Name = "firstParentHighestEducationLevel", EmitDefaultValue = false)]
        public FinancialAidApplicationsEducationLevel FirstParentHighestEducationLevel { get; set; }

        /// <summary>
        /// Financial aid applicant's second parent's highest education level
        /// </summary>
        [DataMember(Name = "secondParentHighestEducationLevel", EmitDefaultValue = false)]
        public FinancialAidApplicationsEducationLevel SecondParentHighestEducationLevel { get; set; }
    }
}
