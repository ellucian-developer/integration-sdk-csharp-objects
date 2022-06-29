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
    /// Detailed information concerning financial aid applicant income. 
    /// </summary>
    [DataContract]
    public class FinancialAidApplicationApplicantIncomeDtoProperty
    {

        /// <summary>
        /// Financial aid applicant's tax return status
        /// </summary>
        [DataMember(Name = "taxReturn", EmitDefaultValue = false)]
        public FinancialAidApplicationsTaxReturnStatus taxReturn { get; set; }

        /// <summary>
        /// Financial aid applicant's adjusted gross income
        /// </summary>
        [DataMember(Name = "adjustedGrossIncome", EmitDefaultValue = false)]
        public AmountDtoProperty AdjustedGrossIncome { get; set; }

        /// <summary>
        /// Financial aid applicant's total income
        /// </summary>
        [DataMember(Name = "totalIncome", EmitDefaultValue = false)]
        public AmountDtoProperty TotalIncome { get; set; }

        /// <summary>
        /// Financial aid applicant's earned income
        /// </summary>
        [DataMember(Name = "applicantEarnedIncome", EmitDefaultValue = false)]
        public AmountDtoProperty EarnedIncome { get; set; }

        /// <summary>
        /// Financial aid applicant's spouse's earned income
        /// </summary>
        [DataMember(Name = "spouseEarnedIncome", EmitDefaultValue = false)]
        public AmountDtoProperty SpouseEarnedIncome { get; set; }
    }
}
