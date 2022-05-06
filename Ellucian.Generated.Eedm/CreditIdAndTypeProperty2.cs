// Copyright 2016-2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Property to contain the credittype enum and id
    /// </summary>
    [DataContract]
    public class CreditIdAndTypeProperty2
    {
        /// <summary>
        /// The higher-level category of academic credits
        /// </summary>
        [DataMember(Name = "creditType", EmitDefaultValue = false)]
        public CreditCategoryType3? CreditType { get; set; }

        /// <summary>
        /// Id of the creditType
        /// </summary>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// constructor to initialize properties
        /// </summary>
        public CreditIdAndTypeProperty2()
        {
        }
    }
}
