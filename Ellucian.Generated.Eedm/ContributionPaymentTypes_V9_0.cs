//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#nullable enable

using Ellucian.Generated.Eedm;

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"

namespace Ellucian.Generated.Eedm.ContributionPaymentTypes_V9_0
{
    using System = global::System;

    

    /// <summary>
    /// A list of valid contribution payment types.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ContributionPaymentTypes_V9_0
    {
        /// <summary>
        /// Metadata about the JSON payload
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Metadata? Metadata { get; set; } = default!;

        /// <summary>
        /// The global identifier of the contribution payment type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The full name of the contribution payment type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The description of the contribution payment type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// The type of tender being used for the contribution.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tenderType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ContributionPaymentTypes_V9_0TenderType TenderType { get; set; } = default!;

        /// <summary>
        /// An indication if an amount must be specified for the contribution payment type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amountRequired", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ContributionPaymentTypes_V9_0AmountRequired AmountRequired { get; set; } = default!;

        /// <summary>
        /// The accounting string associated with the contribution payment type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accountingString", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountingString { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ContributionPaymentTypes_V9_0TenderType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"localCurrency")]
        LocalCurrency = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"eCommerce")]
        ECommerce = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"foreignCurrency")]
        ForeignCurrency = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"insurance")]
        Insurance = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"securities")]
        Securities = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"giftInKind")]
        GiftInKind = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"check")]
        Check = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"payrollDeduction")]
        PayrollDeduction = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"electronicFundTransfer")]
        ElectronicFundTransfer = 8,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ContributionPaymentTypes_V9_0AmountRequired
    {

        [System.Runtime.Serialization.EnumMember(Value = @"required")]
        Required = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"notRequired")]
        NotRequired = 1,

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603