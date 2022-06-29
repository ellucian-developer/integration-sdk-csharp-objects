// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The tax code rate(s) that apply to the line item.
    /// </summary>
    [DataContract]
    public class LineItemTaxCodeRateDtoProperty
    {
        /// <summary>
        /// The tax code rate that applies to the line item.
        /// </summary>
        [DataMember(Name = "rate", EmitDefaultValue = false)]
        public GuidObject2 Rate { get; set; }

        /// <summary>
        /// The tax amount associated with the line item - overrides the distributed line amounts if specified.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount2DtoProperty Amount { get; set; }

    }
}