// Copyright 2015 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// AcademicPeriod DTO property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CreditCategoryDtoProperty : BaseCodeTitleDetailDtoProperty
    {
        /// <summary>
        /// The higher-level category of academic credits
        /// </summary>
        [JsonProperty("creditType")]
        public CreditCategoryType2? CreditType { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public CreditCategoryDtoProperty() : base() { }
    }
}

