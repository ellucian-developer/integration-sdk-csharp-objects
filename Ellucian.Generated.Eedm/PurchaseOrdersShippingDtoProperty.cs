// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The shipping information associated with the purchase order
    /// </summary>
    [DataContract]
    public class PurchaseOrdersShippingDtoProperty
    {
        /// <summary>
        /// The person or office to which the shippment is directed
        /// </summary>
        [DataMember(Name = "attention", EmitDefaultValue = false)]
        public string Attention { get; set; }


        /// <summary>
        /// The destination to which the items should be shipped
        /// </summary>
        [DataMember(Name = "shipTo", EmitDefaultValue = false)]
        public GuidObject2 ShipTo { get; set; }

        /// <summary>
        /// The free on board (FOB) type specified for the purchase order
        /// </summary>
        [DataMember(Name = "freeOnBoard", EmitDefaultValue = false)]
        public GuidObject2 FreeOnBoard { get; set; }
    }
}