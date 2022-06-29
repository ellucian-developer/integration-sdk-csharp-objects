// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The discount applied to the line item (e.g. trade/volume discounts).
    /// </summary>
    [DataContract]
    public class AccountsPayableInvoicesDiscountDtoProperty
    {
        /// <summary>
        /// The amount of the discount for the line item, if specified.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount2DtoProperty Amount { get; set; }

        /// <summary>
        /// The discount percentage applied to the line item, if specified.
        /// </summary>
        [DataMember(Name = "percent", EmitDefaultValue = false)]
        public decimal? Percent { get; set; }
    }
}