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
    public class StudentFinancialAidNeedsByMethodologyDtoProperty
    {

        /// <summary>
        /// Student financial aid need methodolgy
        /// </summary>
        [DataMember(Name = "methodology", EmitDefaultValue = false)]
        public StudentFinancialAidNeedMethodology Methodology { get; set; }

        /// <summary>
        /// Student financial aid application outcome
        /// </summary>
        [DataMember(Name = "applicationOutcome", EmitDefaultValue = false)]
        public GuidObject2 ApplicationOutcome { get; set; }

        /// <summary>
        /// Student financial aid budget duration
        /// </summary>
        [DataMember(Name = "budgetDuration", EmitDefaultValue = false)]
        public decimal? BudgetDuration { get; set; }

        /// <summary>
        /// Student financial aid total cost of attendance
        /// </summary>
        [DataMember(Name = "costOfAttendance", EmitDefaultValue = false)]
        public AmountDtoProperty TotalCostOfAttendance { get; set; }

        /// <summary>
        /// Student financial aid expected family contribution
        /// </summary>
        [DataMember(Name = "expectedFamilyContribution", EmitDefaultValue = false)]
        public AmountDtoProperty ExpectedFamilyContribution { get; set; }

        /// <summary>
        /// Student financial aid gross need
        /// </summary>
        [DataMember(Name = "grossNeed", EmitDefaultValue = false)]
        public AmountDtoProperty GrossNeed { get; set; }

        /// <summary>
        /// The financial aid resources managed by the financial aid office which are available to the applicant.
        /// </summary>
        [DataMember(Name = "needReduction", EmitDefaultValue = false)]
        public AmountDtoProperty TotalNeedReduction { get; set; }        
    }
}
