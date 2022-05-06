// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The originating document associated with the line item, which indicates what encumbrance needs to be relieved
    /// </summary>
    [DataContract]
    public class LineItemReferenceDocumentDtoProperty2
    {
        /// <summary>
        /// The originating purchase order associated with the line item.
        /// </summary>
        [DataMember(Name = "purchaseOrder", EmitDefaultValue = false)]
        public GuidObject2 PurchaseOrder { get; set; }

        /// <summary>
        /// The originating blanket purchase order associated with the line item.
        /// </summary>
        [DataMember(Name = "blanketPurchaseOrder", EmitDefaultValue = false)]
        public GuidObject2 BlanketPurchaseOrder { get; set; }

        /// <summary>
        /// The originating recurring voucher associated with the line item.
        /// </summary>
        [DataMember(Name = "recurringVoucher", EmitDefaultValue = false)]
        public string RecurringVoucher { get; set; }

        /// <summary>
        /// The originating purchasing arrangement associated with the line item.
        /// </summary>
        [DataMember(Name = "purchasingArrangement", EmitDefaultValue = false)]
        public GuidObject2 PurchasingArrangement { get; set; }

    }
}