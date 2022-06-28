// Copyright 2016 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A category of academic credit.
    /// </summary>
    [DataContract]
    public class CreditCategories_V6_0 : CodeItem2
    {
        /// <summary>
        /// The higher-level category of academic credits
        /// </summary>
        [DataMember(Name = "creditType")]
        public CreditCategoryType3? CreditType { get; set; }
    }
}
