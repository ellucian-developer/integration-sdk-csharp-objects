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

namespace Ellucian.Generated.Eedm.ConstituentPersonBusinessRelationships_V9_0
{
    using System = global::System;

    

    /// <summary>
    /// Information about business relationships between constituents, at least one of whom is a person
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ConstituentPersonBusinessRelationships_V9_0
    {
        /// <summary>
        /// Metadata about the JSON payload
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Metadata? Metadata { get; set; } = default!;

        /// <summary>
        /// The global identifier of the business relationship
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The subject person involved in the relationship
        /// </summary>
        [Newtonsoft.Json.JsonProperty("person", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Person Person { get; set; } = new Person();

        /// <summary>
        /// The other party of the relationship
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relatedParty", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RelatedParty RelatedParty { get; set; } = default!;

        /// <summary>
        /// The relationship between the subject person and the other party, pointing from the former to the latter
        /// </summary>
        [Newtonsoft.Json.JsonProperty("directRelationship", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DirectRelationship DirectRelationship { get; set; } = new DirectRelationship();

        /// <summary>
        /// The relationship between the subject person and the other party, pointing from the latter to the former
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reciprocalRelationship", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ReciprocalRelationship? ReciprocalRelationship { get; set; } = default!;

        /// <summary>
        /// Detailed information about the relationship depending on its type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relationshipDetails", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RelationshipDetails? RelationshipDetails { get; set; } = default!;

        /// <summary>
        /// The status of the relationship
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Status Status { get; set; } = new Status();

        /// <summary>
        /// The start date of the relationship
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StartOn? StartOn { get; set; } = default!;

        /// <summary>
        /// The end date of the relationship
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EndOn? EndOn { get; set; } = default!;

        /// <summary>
        /// The source of information about the relationship
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Source? Source { get; set; } = default!;

        /// <summary>
        /// The comment about the relationship
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Comment { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Person
    {
        /// <summary>
        /// The global identifier for the Person.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RelatedParty
    {
        /// <summary>
        /// The related organization
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organization", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Organization? Organization { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DirectRelationship
    {
        /// <summary>
        /// The global identifier for the Direct Relationship.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ReciprocalRelationship
    {
        /// <summary>
        /// The global identifier for the Reciprocal Relationship.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RelationshipDetails
    {
        /// <summary>
        /// Employment details
        /// </summary>
        [Newtonsoft.Json.JsonProperty("employment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Employment? Employment { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Status
    {
        /// <summary>
        /// The global identifier for the Status.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class StartOn
    {
        /// <summary>
        /// The year when the relationship started
        /// </summary>
        [Newtonsoft.Json.JsonProperty("year", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Year { get; set; } = default!;

        /// <summary>
        /// The month when the relationship started
        /// </summary>
        [Newtonsoft.Json.JsonProperty("month", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Month { get; set; } = default!;

        /// <summary>
        /// The day of month when the relationship started
        /// </summary>
        [Newtonsoft.Json.JsonProperty("day", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Day { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EndOn
    {
        /// <summary>
        /// The year when the relationship ended
        /// </summary>
        [Newtonsoft.Json.JsonProperty("year", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Year { get; set; } = default!;

        /// <summary>
        /// The month when the relationship ended
        /// </summary>
        [Newtonsoft.Json.JsonProperty("month", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Month { get; set; } = default!;

        /// <summary>
        /// The day of month when the relationship ended
        /// </summary>
        [Newtonsoft.Json.JsonProperty("day", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Day { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Source
    {
        /// <summary>
        /// The global identifier for the Source.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Organization
    {
        /// <summary>
        /// The global identifier for the Organization.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Employment
    {
        /// <summary>
        /// The indicator it the employer is the primary one for the person
        /// </summary>
        [Newtonsoft.Json.JsonProperty("primaryEmployer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PrimaryEmployer? PrimaryEmployer { get; set; } = default!;

        /// <summary>
        /// The indicator if the person is a part of employer's roster or self-employed
        /// </summary>
        [Newtonsoft.Json.JsonProperty("employmentAffiliation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmploymentAffiliation? EmploymentAffiliation { get; set; } = default!;

        /// <summary>
        /// The title of the position the person holds with the employer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("positionTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PositionTitle { get; set; } = default!;

        /// <summary>
        /// The description of the position the person holds with the employer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("positionDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PositionDescription { get; set; } = default!;

        /// <summary>
        /// The level of the position in employer's organizational chart
        /// </summary>
        [Newtonsoft.Json.JsonProperty("positionLevel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PositionLevel? PositionLevel { get; set; } = default!;

        /// <summary>
        /// The start date of the employment in this position
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartOn { get; set; } = default!;

        /// <summary>
        /// The occupation associated with the position
        /// </summary>
        [Newtonsoft.Json.JsonProperty("occupation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Occupation? Occupation { get; set; } = default!;

        /// <summary>
        /// The field of work associated with the position
        /// </summary>
        [Newtonsoft.Json.JsonProperty("workField", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public WorkField? WorkField { get; set; } = default!;

        /// <summary>
        /// The fields of specialty associated with the position
        /// </summary>
        [Newtonsoft.Json.JsonProperty("specialtyFields", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Anonymous>? SpecialtyFields { get; set; } = default!;

        /// <summary>
        /// The type of the place of work the position is associated with
        /// </summary>
        [Newtonsoft.Json.JsonProperty("workPlaceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public WorkPlaceType? WorkPlaceType { get; set; } = default!;

        /// <summary>
        /// The number of hours the person works per period
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hoursWorked", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public HoursWorked? HoursWorked { get; set; } = default!;

        /// <summary>
        /// The level of income associated with the position
        /// </summary>
        [Newtonsoft.Json.JsonProperty("incomeLevel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IncomeLevel? IncomeLevel { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum PrimaryEmployer
    {

        [System.Runtime.Serialization.EnumMember(Value = @"primary")]
        Primary = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"secondary")]
        Secondary = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum EmploymentAffiliation
    {

        [System.Runtime.Serialization.EnumMember(Value = @"selfEmployed")]
        SelfEmployed = 0,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PositionLevel
    {
        /// <summary>
        /// The global identifier for the Position Level.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Occupation
    {
        /// <summary>
        /// The global identifier for the Occupation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class WorkField
    {
        /// <summary>
        /// The global identifier for the Work Field.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    /// <summary>
    /// The fields of specialty associated with the position
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Anonymous
    {
        /// <summary>
        /// The global identifier for the Specialty Fields.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class WorkPlaceType
    {
        /// <summary>
        /// The global identifier for the Work Place Type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class HoursWorked
    {
        /// <summary>
        /// The period the hours of work are defined for
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HoursWorkedPeriod Period { get; set; } = default!;

        /// <summary>
        /// The number of hours the person works in this period
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hours", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Hours { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class IncomeLevel
    {
        /// <summary>
        /// The global identifier for the Income Level.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum HoursWorkedPeriod
    {

        [System.Runtime.Serialization.EnumMember(Value = @"day")]
        Day = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"week")]
        Week = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"month")]
        Month = 2,

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603