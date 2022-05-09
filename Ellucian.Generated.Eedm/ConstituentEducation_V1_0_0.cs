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

namespace Ellucian.Generated.Eedm.ConstituentEducation_V1_0_0
{
    using System = global::System;

    

    /// <summary>
    /// A record of a constituent's education.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ConstituentEducation_V1_0_0
    {
        /// <summary>
        /// Metadata about the JSON payload
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Metadata? Metadata { get; set; } = default!;

        /// <summary>
        /// The global identifier of the constituent education.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The person associated with the education record.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("person", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Person Person { get; set; } = new Person();

        /// <summary>
        /// Indicates the preferences of the education over all other education for the person.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("preferences", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Preferences? Preferences { get; set; } = default!;

        /// <summary>
        /// The educational institution where the person's education occurred.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("institution", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Institution Institution { get; set; } = new Institution();

        /// <summary>
        /// The campus where the education occurred.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Campus? Campus { get; set; } = default!;

        /// <summary>
        /// The institutional units associated with the education.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("institutionalUnits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<InstitutionalUnits>? InstitutionalUnits { get; set; } = default!;

        /// <summary>
        /// The academic program associated with the education.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("academicProgram", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AcademicProgram? AcademicProgram { get; set; } = default!;

        /// <summary>
        /// The academic level of the education (e.g. graduate, undergraduate).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("academicLevel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AcademicLevel? AcademicLevel { get; set; } = default!;

        /// <summary>
        /// The academic credential (degree, diploma, etc.) the person was awarded at the institution.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("credential", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Credential? Credential { get; set; } = default!;

        /// <summary>
        /// The academic disciplines associated with the person's education at the institution.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disciplines", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Disciplines? Disciplines { get; set; } = default!;

        /// <summary>
        /// The date when the person's education at the institution started.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartOn { get; set; } = default!;

        /// <summary>
        /// The date when the person's education at the institution ended.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndOn { get; set; } = default!;

        /// <summary>
        /// The academic recognitions received in conjunction with the person's education at the institution.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recognitions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Recognitions>? Recognitions { get; set; } = default!;

        /// <summary>
        /// The conferral type associated with the degree (e.g. honorary degree).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("conferralType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ConferralType? ConferralType { get; set; } = default!;

        /// <summary>
        /// The title of the thesis (dissertation) created as part of the person's education at the institution.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("thesisTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ThesisTitle { get; set; } = default!;

        /// <summary>
        /// The academic year in which the degree was awarded.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("degreeYear", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DegreeYear { get; set; } = default!;

        /// <summary>
        /// The reunion year associated with the education.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reunionYear", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReunionYear { get; set; } = default!;

        /// <summary>
        /// The class year to which the person prefers to associate the education.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("preferredClassYear", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PreferredClassYear { get; set; } = default!;

        /// <summary>
        /// The graduation status for the education.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("graduationStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GraduationStatus? GraduationStatus { get; set; } = default!;

        /// <summary>
        /// The date when the person graduated from the institution.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("graduatedOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GraduatedOn? GraduatedOn { get; set; } = default!;

        /// <summary>
        /// The admission status associated with the education.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admissionStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AdmissionStatus? AdmissionStatus { get; set; } = default!;

        /// <summary>
        /// The admission type associated with the education.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admissionType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AdmissionType? AdmissionType { get; set; } = default!;

        /// <summary>
        /// Notes concerning the education for the person.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Notes>? Notes { get; set; } = default!;

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
    public partial class Preferences
    {
        /// <summary>
        /// Indicates that the constituent prefers this education over all other education for the person.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("constituent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Constituent? Constituent { get; set; } = default!;

        /// <summary>
        /// Indicates the institution prefers this education over all other education for the person.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("institution", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Institution2? Institution { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Institution
    {
        /// <summary>
        /// The global identifier for the Institution.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Campus
    {
        /// <summary>
        /// The global identifier for the Campus.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class InstitutionalUnits
    {
        /// <summary>
        /// The type of institutional unit (e.g. division, college, department).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InstitutionalUnitsType Type { get; set; } = default!;

        /// <summary>
        /// An institutional unit associated with the education.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("institutionalUnit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public InstitutionalUnit InstitutionalUnit { get; set; } = new InstitutionalUnit();

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AcademicProgram
    {
        /// <summary>
        /// The global identifier for the Academic Program.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AcademicLevel
    {
        /// <summary>
        /// The global identifier for the Academic Level.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Credential
    {
        /// <summary>
        /// The global identifier for the Credential.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Disciplines
    {
        /// <summary>
        /// The major(s) associated with the person's education at the institution.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("majors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Majors>? Majors { get; set; } = default!;

        /// <summary>
        /// The minor(s) associated with the person's education at the institution.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Minors>? Minors { get; set; } = default!;

        /// <summary>
        /// The concentration(s) associated with the person's education at the institution.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("concentrations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Concentrations>? Concentrations { get; set; } = default!;

        /// <summary>
        /// The specialization(s) associated with the person's education at the institution.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("specializations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Specializations>? Specializations { get; set; } = default!;

    }

    /// <summary>
    /// The academic recognitions received in conjunction with the person's education at the institution.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Recognitions
    {
        /// <summary>
        /// The global identifier for the Recognitions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ConferralType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"honorary")]
        Honorary = 0,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GraduationStatus
    {
        /// <summary>
        /// The global identifier for the Graduation Status.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GraduatedOn
    {
        /// <summary>
        /// The year part of the date.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("year", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Year { get; set; } = default!;

        /// <summary>
        /// The month part of the date.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("month", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Month { get; set; } = default!;

        /// <summary>
        /// The day part of the date.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("day", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Day { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AdmissionStatus
    {
        /// <summary>
        /// The global identifier for the Admission Status.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AdmissionType
    {
        /// <summary>
        /// The global identifier for the Admission Type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Notes
    {
        /// <summary>
        /// The subject of the note.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subject", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Subject { get; set; } = default!;

        /// <summary>
        /// The content of the note.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Content { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum Constituent
    {

        [System.Runtime.Serialization.EnumMember(Value = @"primary")]
        Primary = 0,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum Institution2
    {

        [System.Runtime.Serialization.EnumMember(Value = @"primary")]
        Primary = 0,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum InstitutionalUnitsType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"division")]
        Division = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"college")]
        College = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"grantingCollege")]
        GrantingCollege = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"department")]
        Department = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class InstitutionalUnit
    {
        /// <summary>
        /// The global identifier for the Institutional Unit.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    /// <summary>
    /// The major(s) associated with the person's education at the institution.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Majors
    {
        /// <summary>
        /// The global identifier for the Majors.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    /// <summary>
    /// The minor(s) associated with the person's education at the institution.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Minors
    {
        /// <summary>
        /// The global identifier for the Minors.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    /// <summary>
    /// The concentration(s) associated with the person's education at the institution.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Concentrations
    {
        /// <summary>
        /// The global identifier for the Concentrations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    /// <summary>
    /// The specialization(s) associated with the person's education at the institution.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Specializations
    {
        /// <summary>
        /// The global identifier for the Specializations.
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