//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
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

namespace Ellucian.Generated.Eedm.PersonsCredentials_V11_1_0
{
    using System = global::System;

    

    /// <summary>
    /// A subset of person's data, including only their credentials.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PersonsCredentials_V11_1_0
    {
        /// <summary>
        /// A global identifier of a person.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Information that identifies a user to a system such as a network or computer.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("credentials", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Credentials>? Credentials { get; set; } = default!;

        /// <summary>
        /// Alternative information that uniquely identifies a user.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alternativeCredentials", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AlternativeCredentials>? AlternativeCredentials { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Credentials
    {
        /// <summary>
        /// The type of credential, such as "Person ID" or "System ID".
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CredentialsType Type { get; set; } = default!;

        /// <summary>
        /// The current value of the credential.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// The date when the credential starts being valid.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartOn { get; set; } = default!;

        /// <summary>
        /// The date when the credential stops being valid.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndOn { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AlternativeCredentials
    {
        /// <summary>
        /// The type of alternative credential.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Type? Type { get; set; } = default!;

        /// <summary>
        /// The value of the alternative credential.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum CredentialsType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"ssn")]
        Ssn = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"sin")]
        Sin = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"bannerId")]
        BannerId = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"colleaguePersonId")]
        ColleaguePersonId = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"elevateId")]
        ElevateId = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"bannerSourcedId")]
        BannerSourcedId = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"bannerUserName")]
        BannerUserName = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"bannerUdcId")]
        BannerUdcId = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"colleagueUserName")]
        ColleagueUserName = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"taxIdentificationNumber")]
        TaxIdentificationNumber = 9,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Type
    {
        /// <summary>
        /// The global identifier for the Type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603