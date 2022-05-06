// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// AcademicPeriod DTO property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CreditCategory2DtoProperty : BaseCodeTitleDetailDtoProperty2
    {
        /// <summary>
        /// The higher-level category of academic credits
        /// </summary>
        [JsonProperty("creditType")]
        public CreditCategoryType3? CreditType { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public CreditCategory2DtoProperty() : base() { }
    }
}

