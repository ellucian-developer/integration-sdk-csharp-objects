// Copyright 2015 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Property to contain the credittype enum and id
    /// </summary>
    [DataContract]
    public class CreditIdAndTypeProperty
    {
        /// <summary>
        /// The higher-level category of academic credits
        /// </summary>
        [DataMember(Name = "creditType")]
        public CreditCategoryType2? CreditType { get; set; }

        /// <summary>
        /// Id of the creditType
        /// </summary>
        [DataMember(Name="detail")]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// constructor to initialize properties
        /// </summary>
        public CreditIdAndTypeProperty()
        {
            //Detail = new GuidObject2();
        }
    }
}
