// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A person or organization who offers products or services to an institution. 
    /// </summary>
    [DataContract]
    public class Vendors_V11_1_0 : BaseModel2
    {      
        /// <summary>
        /// The person or organization acting as the vendor.
        /// </summary>
        [DataMember(Name = "vendorDetail")]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(VendorDetailFilterConverter))]
        public VendorDetailsDtoProperty VendorDetail { get; set; }

        /// <summary>
        /// The federal tax identification number for the vendor.
        /// </summary>
        [DataMember(Name = "taxId", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public string TaxId { get; set; }

        /// <summary>
        /// The vendor assigned to receive payment for this vendor or the parent vendor.
        /// </summary>
        [DataMember(Name = "relatedVendors", EmitDefaultValue = false)]
        public List<RelatedVendorDtoProperty> RelatedVendor { get; set; }

        /// <summary>
        /// The vendor assigned to receive payment for this vendor or the parent vendor.
        /// </summary>
        [DataMember(Name = "types", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public List<VendorTypes> Types { get; set; }

        /// <summary>
        /// The vendors classification (E.g. federal contract, small business, etc. )
        /// </summary>
        [DataMember(Name = "classifications", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(ArrayGuidObject2FilterConverter))]
        public List<GuidObject2> Classifications { get; set; }

        /// <summary>
        /// The payment terms and conditions that may be applied to the vendor.
        /// </summary>
        [DataMember(Name = "paymentTerms", EmitDefaultValue = false)]
        public List<GuidObject2> PaymentTerms { get; set; }

        /// <summary>
        /// The accounts payable sources associated with the vendor.
        /// </summary>
        [DataMember(Name = "paymentSources", EmitDefaultValue = false)]
        public List<GuidObject2> PaymentSources { get; set; }

        /// <summary>
        /// The statuses (active, approved, stop payment) that apply to the vendor.
        /// </summary>
        [DataMember(Name = "statuses", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public List<VendorsStatuses?> Statuses { get; set; }

        /// <summary>
        /// The reasons the vendor has been placed on hold.
        /// </summary>
        [DataMember(Name = "vendorHoldReasons", EmitDefaultValue = false)]
        public List<GuidObject2> VendorHoldReasons { get; set; }

        /// <summary>
        /// The first date when the vendor was active/registered.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "startOn", EmitDefaultValue = false)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The last date when the vendor was active.
        /// </summary>
        [DataMember(Name = "endOn", EmitDefaultValue = false)]
        [JsonConverter(typeof(DateOnlyConverter))]
        public DateTime? EndOn { get; set; }

        /// <summary>
        /// The default currency for the vendor.
        /// </summary>
        [DataMember(Name = "defaultCurrency", EmitDefaultValue = false)]
        public CurrencyIsoCode? DefaultCurrency { get; set; }

        /// <summary>
        /// The default tax form component associated with the vendor.
        /// </summary>
        [DataMember(Name = "defaultTaxFormComponent", EmitDefaultValue = false)]        
        public GuidObject2 DefaultTaxFormComponent { get; set; }

        /// <summary>
        /// Comment generated regarding the vendor.
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Related Reference is a concept not supported in Colleague.  
        /// </summary>
        [JsonProperty("relatedReference", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<RelatedVendorDtoProperty> relatedReference { get; set; }

        /// <summary>
        /// The default address(es) associated with the vendor  
        /// </summary>
        [JsonProperty("defaultAddresses", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<VendorsAddressesDtoProperty> DefaultAddresses { get; set; }
    }
}