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

namespace Ellucian.Generated.Eedm.PayClasses_V12_0
{
    using System = global::System;

    

    /// <summary>
    /// The standard method of paying employees.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PayClasses_V12_0
    {
        /// <summary>
        /// Metadata about the JSON payload
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Metadata? Metadata { get; set; } = default!;

        /// <summary>
        /// The global identifier of the pay class.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The full name of the pay class.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The description of the pay class.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// A code that may be used to identify the pay class.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Code { get; set; } = default!;

        /// <summary>
        /// The number of pays per year employees are scheduled to receive.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paysPerYear", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PaysPerYear { get; set; } = default!;

        /// <summary>
        /// An indicator if the pay class is supplemental to (used in addition to) another pay class.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("classType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ClassType? ClassType { get; set; } = default!;

        /// <summary>
        /// The cycle which determines how employees are paid for the given pay class.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payCycle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PayCycle? PayCycle { get; set; } = default!;

        /// <summary>
        /// The frequency at which employees are paid when they are working.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payFrequency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PayFrequency? PayFrequency { get; set; } = default!;

        /// <summary>
        /// The default pay period work hours for positions associated with the pay class.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hoursPerPeriod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<HoursPerPeriod>? HoursPerPeriod { get; set; } = default!;

        /// <summary>
        /// The status of the pay class (e.g. active or inactive).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Status? Status { get; set; } = default!;

        /// <summary>
        /// The compensation type associated with the pay class (e.g. salary or wages).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("compensationType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CompensationType? CompensationType { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ClassType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"supplemental")]
        Supplemental = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"notSupplemental")]
        NotSupplemental = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PayCycle
    {
        /// <summary>
        /// The global identifier for the Pay Cycle.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PayFrequency
    {
        /// <summary>
        /// The global identifier for the Pay Frequency.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class HoursPerPeriod
    {
        /// <summary>
        /// The default time period (e.g. day, week, month, etc.).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HoursPerPeriodPeriod Period { get; set; } = default!;

        /// <summary>
        /// The default work hours in the specified time period.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hours", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Hours { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum Status
    {

        [System.Runtime.Serialization.EnumMember(Value = @"active")]
        Active = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"inactive")]
        Inactive = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum CompensationType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"salary")]
        Salary = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"wages")]
        Wages = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum HoursPerPeriodPeriod
    {

        [System.Runtime.Serialization.EnumMember(Value = @"day")]
        Day = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"week")]
        Week = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"month")]
        Month = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"year")]
        Year = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"payPeriod")]
        PayPeriod = 4,

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603