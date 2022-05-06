// Copyright 2017-2020 Ellucian Company L.P. and its affiliates.

using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The individual line item associated with an invoice.
    /// </summary>
    [DataContract]
    public class AccountsPayableInvoicesLineItemDtoProperty2
    {
        /// <summary>
        /// The originating document associated with the line item, which indicates what encumbrance needs to be relieved
        /// </summary>
        [DataMember(Name = "referenceDocument", EmitDefaultValue = false)]
        public LineItemReferenceDocumentDtoProperty2 ReferenceDocument { get; set; }

        /// <summary>
        /// The reference document line item number associated with the invoice
        /// </summary>
        [DataMember(Name = "referenceDocumentLineItemNumber", EmitDefaultValue = false)]
        public string ReferenceDocumentLineItemNumber { get; set; }

        /// <summary>
        /// A system generated number to identify the line item.
        /// </summary>
        [DataMember(Name = "lineItemNumber", EmitDefaultValue = false)]
        public string LineItemNumber { get; set; }

        /// <summary>
        /// The description of the line item.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The commodity specified by the line item.
        /// </summary>
        [DataMember(Name = "commodityCode", EmitDefaultValue = false)]
        public GuidObject2 CommodityCode { get; set; }

        /// <summary>
        /// The fixed asset designation associated with the line item.
        /// </summary>
        [DataMember(Name = "fixedAssetDesignation", EmitDefaultValue = false)]      
        public GuidObject2 FixedAssetDesignation { get; set; }

        /// <summary>
        /// The number of units specified for the line item.
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The number of units for the line item as specified by the vendor.
        /// </summary>
        [DataMember(Name = "vendorBilledQuantity", EmitDefaultValue = false)]
        public int? VendorBilledQuantity { get; set; }

        /// <summary>
        /// The unit of measure used for the line item.
        /// </summary>
        [DataMember(Name = "unitOfMeasure", EmitDefaultValue = false)]
        public GuidObject2 UnitofMeasure { get; set; }

        /// <summary>
        /// The price per unit for the commodity specified for the line item.
        /// </summary>
        [DataMember(Name = "unitPrice", EmitDefaultValue = false)]
        public Amount2DtoProperty UnitPrice { get; set; }

        /// <summary>
        /// The price per unit for the commodity specified for the line item as specified by the vendor.
        /// </summary>
        [DataMember(Name = "vendorBilledUnitPrice", EmitDefaultValue = false)]
        public Amount2DtoProperty VendorBilledUnitPrice { get; set; }

        /// <summary>
        /// Additional charges/discounts applied to the line item (e.g. freight)
        /// </summary>
        [DataMember(Name = "additionalAmount", EmitDefaultValue = false)]
        public Amount2DtoProperty AdditionalAmount { get; set; }

        /// <summary>
        /// The taxes that are applicable to the line item if different from the invoice.
        /// </summary>
        [DataMember(Name = "taxes", EmitDefaultValue = false)]
        public List<AccountsPayableInvoicesTaxesDtoProperty> Taxes { get; set; }

        /// <summary>
        /// The discount applied to the line item (e.g. trade/volume discounts).
        /// </summary>
        [DataMember(Name = "discount", EmitDefaultValue = false)]
        public AccountsPayableInvoicesDiscountDtoProperty Discount { get; set; }

        /// <summary>
        /// An indication if payment for the the line item is on hold.
        /// </summary>
        [DataMember(Name = "paymentStatus", EmitDefaultValue = false)]
        public AccountsPayableInvoicesPaymentStatus? PaymentStatus { get; set; }

        /// <summary>
        /// An indicator specifying if the encumbrance for the line item should be liquidated in full (final payment).
        /// </summary>
        [DataMember(Name = "encumbranceStatus", EmitDefaultValue = false)]
        public AccountsPayableInvoicesEncumbranceStatus EncumbranceStatus { get; set; }

        /// <summary>
        /// Additional comment associated with the line Item
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// The status of the line item (open, closed).
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public AccountsPayableInvoicesStatus? Status { get; set; }

        /// <summary>
        /// The detail account information for the line item.
        /// </summary>
        [DataMember(Name = "accountDetails", EmitDefaultValue = false)]
        public List<AccountsPayableInvoicesAccountDetailDtoProperty> AccountDetails { get; set; }

    }
}