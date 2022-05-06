// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The portion (or percentage) of the line item amount or quantity allocated to the accounting string.
    /// </summary>
    [DataContract]
    public class RequisitionsAllocatedDtoProperty
    {
        /// <summary>
        /// The amount allocated to the accounting string.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount2DtoProperty Amount { get; set; }

        /// <summary>
        /// The quantity allocated to the accounting string.
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public decimal? Quantity { get; set; }


        /// <summary>
        /// The percentage of the line item amount allocated to the accounting string.
        /// </summary>
        [DataMember(Name = "percent", EmitDefaultValue = false)]
        public decimal? Percentage { get; set; }
    }
}