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

namespace Ellucian.Generated.Eedm.Designations_V9_0
{
    using System = global::System;

    

    /// <summary>
    /// A designated use of a donation.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Designations_V9_0
    {
        /// <summary>
        /// Metadata about the JSON payload
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Metadata? Metadata { get; set; } = default!;

        /// <summary>
        /// A global identifier of the designation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The full name of the designation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// An alternate title of the designation used for sorting.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sortTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SortTitle { get; set; } = default!;

        /// <summary>
        /// A code that represents the designation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// A full description of the designation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// The higher level categorization of the designation (e.g. Endowment, Scholarship, ...).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Type Type { get; set; } = new Type();

        /// <summary>
        /// The status of the designation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Designations_V9_0Status Status { get; set; } = default!;

        /// <summary>
        /// The date when the designation was first available for use.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartOn { get; set; } = default!;

        /// <summary>
        /// The date when the designation was last available for use.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndOn { get; set; } = default!;

        /// <summary>
        /// The campus specified for the designation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Campus? Campus { get; set; } = default!;

        /// <summary>
        /// The general area within the institution with which the designation is associated (e.g. "Student Financial Aid", "Library", "Research")
        /// </summary>
        [Newtonsoft.Json.JsonProperty("areaOfGiving", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AreaOfGiving? AreaOfGiving { get; set; } = default!;

        /// <summary>
        /// The general funding purpose that is associated with the designation (e.g. "Annual Scholarships", "Capital Improvements", "Faculty Support").
        /// </summary>
        [Newtonsoft.Json.JsonProperty("purpose", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Purpose? Purpose { get; set; } = default!;

        /// <summary>
        /// An indication of whether the designation is annual or not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("annual", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Annual? Annual { get; set; } = default!;

        /// <summary>
        /// An indication of whether the designation is related to athletics or not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("athletics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Athletics? Athletics { get; set; } = default!;

        /// <summary>
        /// The funding goal and current status for the designation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("funding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Funding? Funding { get; set; } = default!;

        /// <summary>
        /// The rule that is used to calculate totals for the designation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Rule? Rule { get; set; } = default!;

        /// <summary>
        /// A classification of the restrictions on the usage of funds associated with the designation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("restrictionClassification", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RestrictionClassification? RestrictionClassification { get; set; } = default!;

        /// <summary>
        /// Restrictions to the usage of funds associated with the designation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("restrictions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Restrictions>? Restrictions { get; set; } = default!;

        /// <summary>
        /// The units of the educational institution (e.g., schools, divisions, departments)  associated with the designation
        /// </summary>
        [Newtonsoft.Json.JsonProperty("institutionUnits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<InstitutionUnits>? InstitutionUnits { get; set; } = default!;

        /// <summary>
        /// Properties required for governmental or other reporting.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reporting", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Reporting? Reporting { get; set; } = default!;

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

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum Designations_V9_0Status
    {

        [System.Runtime.Serialization.EnumMember(Value = @"active")]
        Active = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"inactive")]
        Inactive = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Campus
    {
        /// <summary>
        /// The global identifier for the Campus.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AreaOfGiving
    {
        /// <summary>
        /// The global identifier for the Area of Giving.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Purpose
    {
        /// <summary>
        /// The global identifier for the Purpose.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum Annual
    {

        [System.Runtime.Serialization.EnumMember(Value = @"annual")]
        Annual = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"notAnnual")]
        NotAnnual = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum Athletics
    {

        [System.Runtime.Serialization.EnumMember(Value = @"related")]
        Related = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"notRelated")]
        NotRelated = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Funding
    {
        /// <summary>
        /// The desired amount of funds to be raised for the designation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goal", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Goal Goal { get; set; } = new Goal();

        /// <summary>
        /// The date when the funding of the designation reached the goal.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goalReachedOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? GoalReachedOn { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Rule
    {
        /// <summary>
        /// The global identifier for the Rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum RestrictionClassification
    {

        [System.Runtime.Serialization.EnumMember(Value = @"unrestricted")]
        Unrestricted = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"donorRestricted")]
        DonorRestricted = 1,

    }

    /// <summary>
    /// Restrictions to the usage of funds associated with the designation.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Restrictions
    {
        /// <summary>
        /// The global identifier for the Restrictions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    /// <summary>
    /// The units of the educational institution (e.g., schools, divisions, departments)  associated with the designation
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class InstitutionUnits
    {
        /// <summary>
        /// The global identifier for the Institution Units.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Reporting
    {
        /// <summary>
        /// The country specific reporting requirements.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Country? Country { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Goal
    {
        /// <summary>
        /// The monetary value
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// The ISO 4217 currency code
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GoalCurrency Currency { get; set; } = default!;

    }

    /// <summary>
    /// Reporting requirements for the United States of America
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Country
    {
        /// <summary>
        /// The country code for the United States of America.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CountryCode Code { get; set; } = default!;

        /// <summary>
        /// VSE Survey purpose category.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vsePurpose", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public VsePurpose? VsePurpose { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum GoalCurrency
    {

        [System.Runtime.Serialization.EnumMember(Value = @"AED")]
        AED = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"AFN")]
        AFN = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"ALL")]
        ALL = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"AMD")]
        AMD = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"ANG")]
        ANG = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"AOA")]
        AOA = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"ARS")]
        ARS = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"AUD")]
        AUD = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"AWG")]
        AWG = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"AZN")]
        AZN = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"BAM")]
        BAM = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"BBD")]
        BBD = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"BDT")]
        BDT = 12,

        [System.Runtime.Serialization.EnumMember(Value = @"BGN")]
        BGN = 13,

        [System.Runtime.Serialization.EnumMember(Value = @"BHD")]
        BHD = 14,

        [System.Runtime.Serialization.EnumMember(Value = @"BIF")]
        BIF = 15,

        [System.Runtime.Serialization.EnumMember(Value = @"BMD")]
        BMD = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"BND")]
        BND = 17,

        [System.Runtime.Serialization.EnumMember(Value = @"BOB")]
        BOB = 18,

        [System.Runtime.Serialization.EnumMember(Value = @"BRL")]
        BRL = 19,

        [System.Runtime.Serialization.EnumMember(Value = @"BSD")]
        BSD = 20,

        [System.Runtime.Serialization.EnumMember(Value = @"BTN")]
        BTN = 21,

        [System.Runtime.Serialization.EnumMember(Value = @"BWP")]
        BWP = 22,

        [System.Runtime.Serialization.EnumMember(Value = @"BYR")]
        BYR = 23,

        [System.Runtime.Serialization.EnumMember(Value = @"BZD")]
        BZD = 24,

        [System.Runtime.Serialization.EnumMember(Value = @"CAD")]
        CAD = 25,

        [System.Runtime.Serialization.EnumMember(Value = @"CDF")]
        CDF = 26,

        [System.Runtime.Serialization.EnumMember(Value = @"CHF")]
        CHF = 27,

        [System.Runtime.Serialization.EnumMember(Value = @"CLP")]
        CLP = 28,

        [System.Runtime.Serialization.EnumMember(Value = @"CNY")]
        CNY = 29,

        [System.Runtime.Serialization.EnumMember(Value = @"COP")]
        COP = 30,

        [System.Runtime.Serialization.EnumMember(Value = @"CRC")]
        CRC = 31,

        [System.Runtime.Serialization.EnumMember(Value = @"CUC")]
        CUC = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"CUP")]
        CUP = 33,

        [System.Runtime.Serialization.EnumMember(Value = @"CVE")]
        CVE = 34,

        [System.Runtime.Serialization.EnumMember(Value = @"CZK")]
        CZK = 35,

        [System.Runtime.Serialization.EnumMember(Value = @"DJF")]
        DJF = 36,

        [System.Runtime.Serialization.EnumMember(Value = @"DKK")]
        DKK = 37,

        [System.Runtime.Serialization.EnumMember(Value = @"DOP")]
        DOP = 38,

        [System.Runtime.Serialization.EnumMember(Value = @"DZD")]
        DZD = 39,

        [System.Runtime.Serialization.EnumMember(Value = @"EGP")]
        EGP = 40,

        [System.Runtime.Serialization.EnumMember(Value = @"ERN")]
        ERN = 41,

        [System.Runtime.Serialization.EnumMember(Value = @"ETB")]
        ETB = 42,

        [System.Runtime.Serialization.EnumMember(Value = @"EUR")]
        EUR = 43,

        [System.Runtime.Serialization.EnumMember(Value = @"FJD")]
        FJD = 44,

        [System.Runtime.Serialization.EnumMember(Value = @"FKP")]
        FKP = 45,

        [System.Runtime.Serialization.EnumMember(Value = @"GBP")]
        GBP = 46,

        [System.Runtime.Serialization.EnumMember(Value = @"GEL")]
        GEL = 47,

        [System.Runtime.Serialization.EnumMember(Value = @"GHS")]
        GHS = 48,

        [System.Runtime.Serialization.EnumMember(Value = @"GIP")]
        GIP = 49,

        [System.Runtime.Serialization.EnumMember(Value = @"GMD")]
        GMD = 50,

        [System.Runtime.Serialization.EnumMember(Value = @"GNF")]
        GNF = 51,

        [System.Runtime.Serialization.EnumMember(Value = @"GTQ")]
        GTQ = 52,

        [System.Runtime.Serialization.EnumMember(Value = @"GYD")]
        GYD = 53,

        [System.Runtime.Serialization.EnumMember(Value = @"HKD")]
        HKD = 54,

        [System.Runtime.Serialization.EnumMember(Value = @"HNL")]
        HNL = 55,

        [System.Runtime.Serialization.EnumMember(Value = @"HRK")]
        HRK = 56,

        [System.Runtime.Serialization.EnumMember(Value = @"HTG")]
        HTG = 57,

        [System.Runtime.Serialization.EnumMember(Value = @"HUF")]
        HUF = 58,

        [System.Runtime.Serialization.EnumMember(Value = @"IDR")]
        IDR = 59,

        [System.Runtime.Serialization.EnumMember(Value = @"ILS")]
        ILS = 60,

        [System.Runtime.Serialization.EnumMember(Value = @"INR")]
        INR = 61,

        [System.Runtime.Serialization.EnumMember(Value = @"IQD")]
        IQD = 62,

        [System.Runtime.Serialization.EnumMember(Value = @"IRR")]
        IRR = 63,

        [System.Runtime.Serialization.EnumMember(Value = @"ISK")]
        ISK = 64,

        [System.Runtime.Serialization.EnumMember(Value = @"JMD")]
        JMD = 65,

        [System.Runtime.Serialization.EnumMember(Value = @"JOD")]
        JOD = 66,

        [System.Runtime.Serialization.EnumMember(Value = @"JPY")]
        JPY = 67,

        [System.Runtime.Serialization.EnumMember(Value = @"KES")]
        KES = 68,

        [System.Runtime.Serialization.EnumMember(Value = @"KGS")]
        KGS = 69,

        [System.Runtime.Serialization.EnumMember(Value = @"KHR")]
        KHR = 70,

        [System.Runtime.Serialization.EnumMember(Value = @"KMF")]
        KMF = 71,

        [System.Runtime.Serialization.EnumMember(Value = @"KPW")]
        KPW = 72,

        [System.Runtime.Serialization.EnumMember(Value = @"KRW")]
        KRW = 73,

        [System.Runtime.Serialization.EnumMember(Value = @"KWD")]
        KWD = 74,

        [System.Runtime.Serialization.EnumMember(Value = @"KYD")]
        KYD = 75,

        [System.Runtime.Serialization.EnumMember(Value = @"KZT")]
        KZT = 76,

        [System.Runtime.Serialization.EnumMember(Value = @"LAK")]
        LAK = 77,

        [System.Runtime.Serialization.EnumMember(Value = @"LBP")]
        LBP = 78,

        [System.Runtime.Serialization.EnumMember(Value = @"LKR")]
        LKR = 79,

        [System.Runtime.Serialization.EnumMember(Value = @"LRD")]
        LRD = 80,

        [System.Runtime.Serialization.EnumMember(Value = @"LSL")]
        LSL = 81,

        [System.Runtime.Serialization.EnumMember(Value = @"LYD")]
        LYD = 82,

        [System.Runtime.Serialization.EnumMember(Value = @"MAD")]
        MAD = 83,

        [System.Runtime.Serialization.EnumMember(Value = @"MDL")]
        MDL = 84,

        [System.Runtime.Serialization.EnumMember(Value = @"MGA")]
        MGA = 85,

        [System.Runtime.Serialization.EnumMember(Value = @"MKD")]
        MKD = 86,

        [System.Runtime.Serialization.EnumMember(Value = @"MMK")]
        MMK = 87,

        [System.Runtime.Serialization.EnumMember(Value = @"MNT")]
        MNT = 88,

        [System.Runtime.Serialization.EnumMember(Value = @"MOP")]
        MOP = 89,

        [System.Runtime.Serialization.EnumMember(Value = @"MRO")]
        MRO = 90,

        [System.Runtime.Serialization.EnumMember(Value = @"MUR")]
        MUR = 91,

        [System.Runtime.Serialization.EnumMember(Value = @"MVR")]
        MVR = 92,

        [System.Runtime.Serialization.EnumMember(Value = @"MWK")]
        MWK = 93,

        [System.Runtime.Serialization.EnumMember(Value = @"MXN")]
        MXN = 94,

        [System.Runtime.Serialization.EnumMember(Value = @"MYR")]
        MYR = 95,

        [System.Runtime.Serialization.EnumMember(Value = @"MZN")]
        MZN = 96,

        [System.Runtime.Serialization.EnumMember(Value = @"NAD")]
        NAD = 97,

        [System.Runtime.Serialization.EnumMember(Value = @"NGN")]
        NGN = 98,

        [System.Runtime.Serialization.EnumMember(Value = @"NIO")]
        NIO = 99,

        [System.Runtime.Serialization.EnumMember(Value = @"NOK")]
        NOK = 100,

        [System.Runtime.Serialization.EnumMember(Value = @"NPR")]
        NPR = 101,

        [System.Runtime.Serialization.EnumMember(Value = @"NZD")]
        NZD = 102,

        [System.Runtime.Serialization.EnumMember(Value = @"OMR")]
        OMR = 103,

        [System.Runtime.Serialization.EnumMember(Value = @"PAB")]
        PAB = 104,

        [System.Runtime.Serialization.EnumMember(Value = @"PEN")]
        PEN = 105,

        [System.Runtime.Serialization.EnumMember(Value = @"PGK")]
        PGK = 106,

        [System.Runtime.Serialization.EnumMember(Value = @"PHP")]
        PHP = 107,

        [System.Runtime.Serialization.EnumMember(Value = @"PKR")]
        PKR = 108,

        [System.Runtime.Serialization.EnumMember(Value = @"PLN")]
        PLN = 109,

        [System.Runtime.Serialization.EnumMember(Value = @"PYG")]
        PYG = 110,

        [System.Runtime.Serialization.EnumMember(Value = @"QAR")]
        QAR = 111,

        [System.Runtime.Serialization.EnumMember(Value = @"RON")]
        RON = 112,

        [System.Runtime.Serialization.EnumMember(Value = @"RSD")]
        RSD = 113,

        [System.Runtime.Serialization.EnumMember(Value = @"RUB")]
        RUB = 114,

        [System.Runtime.Serialization.EnumMember(Value = @"RWF")]
        RWF = 115,

        [System.Runtime.Serialization.EnumMember(Value = @"SAR")]
        SAR = 116,

        [System.Runtime.Serialization.EnumMember(Value = @"SBD")]
        SBD = 117,

        [System.Runtime.Serialization.EnumMember(Value = @"SCR")]
        SCR = 118,

        [System.Runtime.Serialization.EnumMember(Value = @"SDG")]
        SDG = 119,

        [System.Runtime.Serialization.EnumMember(Value = @"SEK")]
        SEK = 120,

        [System.Runtime.Serialization.EnumMember(Value = @"SGD")]
        SGD = 121,

        [System.Runtime.Serialization.EnumMember(Value = @"SHP")]
        SHP = 122,

        [System.Runtime.Serialization.EnumMember(Value = @"SLL")]
        SLL = 123,

        [System.Runtime.Serialization.EnumMember(Value = @"SOS")]
        SOS = 124,

        [System.Runtime.Serialization.EnumMember(Value = @"SRD")]
        SRD = 125,

        [System.Runtime.Serialization.EnumMember(Value = @"SSP")]
        SSP = 126,

        [System.Runtime.Serialization.EnumMember(Value = @"STD")]
        STD = 127,

        [System.Runtime.Serialization.EnumMember(Value = @"SVC")]
        SVC = 128,

        [System.Runtime.Serialization.EnumMember(Value = @"SYP")]
        SYP = 129,

        [System.Runtime.Serialization.EnumMember(Value = @"SZL")]
        SZL = 130,

        [System.Runtime.Serialization.EnumMember(Value = @"THB")]
        THB = 131,

        [System.Runtime.Serialization.EnumMember(Value = @"TJS")]
        TJS = 132,

        [System.Runtime.Serialization.EnumMember(Value = @"TMT")]
        TMT = 133,

        [System.Runtime.Serialization.EnumMember(Value = @"TND")]
        TND = 134,

        [System.Runtime.Serialization.EnumMember(Value = @"TOP")]
        TOP = 135,

        [System.Runtime.Serialization.EnumMember(Value = @"TRY")]
        TRY = 136,

        [System.Runtime.Serialization.EnumMember(Value = @"TTD")]
        TTD = 137,

        [System.Runtime.Serialization.EnumMember(Value = @"TWD")]
        TWD = 138,

        [System.Runtime.Serialization.EnumMember(Value = @"TZS")]
        TZS = 139,

        [System.Runtime.Serialization.EnumMember(Value = @"UAH")]
        UAH = 140,

        [System.Runtime.Serialization.EnumMember(Value = @"UGX")]
        UGX = 141,

        [System.Runtime.Serialization.EnumMember(Value = @"USD")]
        USD = 142,

        [System.Runtime.Serialization.EnumMember(Value = @"UYU")]
        UYU = 143,

        [System.Runtime.Serialization.EnumMember(Value = @"UZS")]
        UZS = 144,

        [System.Runtime.Serialization.EnumMember(Value = @"VEF")]
        VEF = 145,

        [System.Runtime.Serialization.EnumMember(Value = @"VND")]
        VND = 146,

        [System.Runtime.Serialization.EnumMember(Value = @"VUV")]
        VUV = 147,

        [System.Runtime.Serialization.EnumMember(Value = @"WST")]
        WST = 148,

        [System.Runtime.Serialization.EnumMember(Value = @"XAF")]
        XAF = 149,

        [System.Runtime.Serialization.EnumMember(Value = @"XCD")]
        XCD = 150,

        [System.Runtime.Serialization.EnumMember(Value = @"XOF")]
        XOF = 151,

        [System.Runtime.Serialization.EnumMember(Value = @"XPF")]
        XPF = 152,

        [System.Runtime.Serialization.EnumMember(Value = @"YER")]
        YER = 153,

        [System.Runtime.Serialization.EnumMember(Value = @"ZAR")]
        ZAR = 154,

        [System.Runtime.Serialization.EnumMember(Value = @"ZMW")]
        ZMW = 155,

        [System.Runtime.Serialization.EnumMember(Value = @"ZWL")]
        ZWL = 156,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum CountryCode
    {

        [System.Runtime.Serialization.EnumMember(Value = @"USA")]
        USA = 0,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class VsePurpose
    {
        /// <summary>
        /// VSE Survey purpose category.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("purpose", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public VsePurposePurpose Purpose { get; set; } = default!;

        /// <summary>
        /// VSE Survey sub-purpose category.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subPurpose", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public VsePurposeSubPurpose SubPurpose { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum VsePurposePurpose
    {

        [System.Runtime.Serialization.EnumMember(Value = @"currentRestricted")]
        CurrentRestricted = 0,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum VsePurposeSubPurpose
    {

        [System.Runtime.Serialization.EnumMember(Value = @"academicDivisions")]
        AcademicDivisions = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"compensation")]
        Compensation = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"research")]
        Research = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"extensionServices")]
        ExtensionServices = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"library")]
        Library = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"physicalPlant")]
        PhysicalPlant = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"financialAid")]
        FinancialAid = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"athletics")]
        Athletics = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"other")]
        Other = 8,

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603