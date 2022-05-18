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

namespace Ellucian.Generated.Eedm.AdmissionApplicationReviews_V12_0
{
    using System = global::System;

    

    /// <summary>
    /// Review of student applications.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AdmissionApplicationReviews_V12_0
    {
        /// <summary>
        /// Metadata about the JSON payload
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Metadata? Metadata { get; set; } = default!;

        /// <summary>
        /// The global identifier of the admission application review.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The application reviewed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Application Application { get; set; } = new Application();

        /// <summary>
        /// The individual or team that reviewed the application.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reviewer", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Reviewer Reviewer { get; set; } = default!;

        /// <summary>
        /// The review status of the application.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AdmissionApplicationReviews_V12_0Status Status { get; set; } = default!;

        /// <summary>
        /// The date when the application was last reviewed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reviewedOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReviewedOn { get; set; } = default!;

        /// <summary>
        /// The recommendations made by the reviewers for the application.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recommendedAction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RecommendedAction? RecommendedAction { get; set; } = default!;

        /// <summary>
        /// The ratings of the application.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ratings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ratings>? Ratings { get; set; } = default!;

        /// <summary>
        /// The comments associated with the application during review process.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comments", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Comments>? Comments { get; set; } = default!;

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

    /// <summary>
    /// The individual who reviewed the application.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Reviewer
    {
        /// <summary>
        /// The individual who reviewed the application.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("representative", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Representative? Representative { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum AdmissionApplicationReviews_V12_0Status
    {

        [System.Runtime.Serialization.EnumMember(Value = @"notStarted")]
        NotStarted = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"earlyRead")]
        EarlyRead = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"inProgress")]
        InProgress = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"completed")]
        Completed = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RecommendedAction
    {
        /// <summary>
        /// The global identifier for the Recommended Action.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ratings
    {
        /// <summary>
        /// The type of rating.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RatingsType Type { get; set; } = default!;

        /// <summary>
        /// The user defined rating type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Detail? Detail { get; set; } = default!;

        /// <summary>
        /// The rating of the application.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rating", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Rating { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Comments
    {
        /// <summary>
        /// The type of comment (academic, activities, essay, recommendation, overall).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CommentsType Type { get; set; } = default!;

        /// <summary>
        /// The comment associated with the application during review process.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Comment { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Representative
    {
        /// <summary>
        /// The global identifier for the Representative.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum RatingsType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"academic")]
        Academic = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"application")]
        Application = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"committee")]
        Committee = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"personal")]
        Personal = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Detail
    {
        /// <summary>
        /// The global identifier for the Detail.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum CommentsType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"academic")]
        Academic = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"activities")]
        Activities = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"essay")]
        Essay = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"recommendation")]
        Recommendation = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"overall")]
        Overall = 4,

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603