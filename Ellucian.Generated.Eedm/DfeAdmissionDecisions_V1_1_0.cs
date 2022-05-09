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

namespace Ellucian.Generated.Eedm.DfeAdmissionDecisions_V1_1_0
{
    using System = global::System;

    

    /// <summary>
    /// Decisions made on teachers training applications in UK under UK Government Department, DfE (Department for Education).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DfeAdmissionDecisions_V1_1_0
    {
        /// <summary>
        /// Metadata about the JSON payload
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Metadata? Metadata { get; set; } = default!;

        /// <summary>
        /// The global identifier of the decision for the admission application.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The admission application on which this decision was made.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Application? Application { get; set; } = default!;

        /// <summary>
        /// The unique DfE ID of the application on which this decision was made.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dfeApplicationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DfeApplicationId { get; set; } = default!;

        /// <summary>
        /// Decisions made on admission applications.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admissionDecision", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AdmissionDecision? AdmissionDecision { get; set; } = default!;

        /// <summary>
        /// The decision made on DfE admission application.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("decision", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Decision? Decision { get; set; } = default!;

        /// <summary>
        /// Identifies the subject offered by the institution and all related information.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("courseInformation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CourseInformation? CourseInformation { get; set; } = default!;

        /// <summary>
        /// The conditions of the offer.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string>? Conditions { get; set; } = default!;

        /// <summary>
        /// The date of the decision on the admission application.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("decidedOn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset DecidedOn { get; set; } = default!;

        /// <summary>
        /// The individual representing the institution who made this decision.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("representative", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Representative Representative { get; set; } = new Representative();

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Application
    {
        /// <summary>
        /// The global identifier for the Application.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AdmissionDecision
    {
        /// <summary>
        /// The global identifier for the Admission Decision.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    /// <summary>
    /// Make an offer to the candidate.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Decision
    {
        /// <summary>
        /// Make an offer to the candidate.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offer", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Offer { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CourseInformation
    {
        /// <summary>
        /// The course’s recruitment cycle year.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("year", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Year { get; set; } = default!;

        /// <summary>
        /// The provider’s code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("providerCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ProviderCode { get; set; } = default!;

        /// <summary>
        /// The course’s code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dfeCourseCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DfeCourseCode { get; set; } = default!;

        /// <summary>
        /// The site’s code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dfeSiteCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DfeSiteCode { get; set; } = default!;

        /// <summary>
        /// Can be 'full_time' or 'part_time'.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("studyMode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StudyMode { get; set; } = default!;

        /// <summary>
        /// Indicates when this course starts.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StartDate { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Representative
    {
        /// <summary>
        /// The full name of the user who made this update.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fullName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FullName { get; set; } = default!;

        /// <summary>
        /// The ID of the user in the Student Record System.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The email address of the user who made this update.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email { get; set; } = default!;

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603