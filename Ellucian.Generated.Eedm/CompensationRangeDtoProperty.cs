// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The range of compensation awarded for the position.
    /// </summary>
    [DataContract]
    public class CompensationRangeDtoProperty
    {
        /// <summary>
        /// The lower bound of compensation offered for the position.
        /// </summary>
        [DataMember(Name = "lowerBound", EmitDefaultValue = false)]
        public decimal? LowerBound { get; set; }

        /// <summary>
        /// The upper bound of compensation offered for the position.
        /// </summary>
        [DataMember(Name = "upperBound", EmitDefaultValue = false)]
        public decimal? UpperBound { get; set; }

        /// <summary>
        /// The ISO 4217 currency code
        /// </summary>
        [DataMember(Name = "currencyCode", EmitDefaultValue = false)]
        public CurrencyIsoCode CurrencyCode { get; set; }


        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public CompensationRangeDtoProperty()
        {
        }
    }
}
