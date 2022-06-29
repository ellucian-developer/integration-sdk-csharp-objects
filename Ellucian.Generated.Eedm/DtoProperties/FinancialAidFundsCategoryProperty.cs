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
    /// Property to contain the financial aid fund categories enum and id
    /// </summary>
    [DataContract]
    public class FinancialAidFundsCategoryProperty
    {
        /// <summary>
        /// The higher-level category of financial aid funds
        /// </summary>
        [DataMember(Name = "name")]
        public FinancialAidFundAidCategoryType? CategoryName { get; set; }

        /// <summary>
        /// Id of the financial aid fund category
        /// </summary>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// constructor to initialize properties
        /// </summary>
        public FinancialAidFundsCategoryProperty()
        {
            Detail = new GuidObject2();
        }
    }
}
