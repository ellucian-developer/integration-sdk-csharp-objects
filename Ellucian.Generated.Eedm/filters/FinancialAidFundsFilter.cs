// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// financial-aid-funds filtering
    /// </summary>
    [DataContract]
    public class FinancialAidFundsFilter : CodeItemFilter
    {
        /// <summary>
        /// The source of the financial aid fund (federal, state, institutional, other).
        /// </summary>

        [DataMember(Name = "source", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public FinancialAidFundsSource Source { get; set; }

        /// <summary>
        /// Type of the financial aid fund (loan, grant, scholarship, work).
        /// </summary>

        [DataMember(Name = "aidType", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public FinancialAidFundsAidType AidType { get; set; }

        /// <summary>
        /// The classifications assigned to the financial aid fund.
        /// </summary>

        [DataMember(Name = "classifications", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(ArrayGuidObject2FilterConverter))]
        public List<GuidObject2> Classifications { get; set; }

        /// <summary>
        /// Category of the financial aid fund.
        /// </summary>

        [DataMember(Name = "category", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public FinancialAidFundsCategory2Filter Category { get; set; }
    }

    /// <summary>
    /// Information about an Academic Period Category
    /// </summary>
    [DataContract]
    public class FinancialAidFundsCategory2Filter
    {
        /// <summary>
        /// The higher-level category of financial aid funds
        /// </summary>
        [DataMember(Name = "name")]
        [FilterProperty("criteria")]
        public FinancialAidFundAidCategoryType? CategoryName { get; set; }

        /// <summary>
        /// Id of the financial aid fund category
        /// </summary>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Detail { get; set; }
    }

}
