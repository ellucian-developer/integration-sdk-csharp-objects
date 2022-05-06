// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The line items for which the payment occurred.
    /// </summary>
    [DataContract]
    public class PaymentTransactionsLineItemDtoProperty
    {
        /// <summary>
        /// A system generated number to identify the line item.
        /// </summary>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public string LineItemNumber { get; set; }

        /// <summary>
        /// The amount associated with the line item.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount2DtoProperty Amount { get; set; }      

    }
}