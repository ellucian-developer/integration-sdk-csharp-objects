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

namespace Ellucian.Generated.Eedm.ExternalAdmissionsApplicationDecisionStatuses_V1_1_0
{
    using System = global::System;

    

    /// <summary>
    /// Status of the decisions made on the Applications
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ExternalAdmissionsApplicationDecisionStatuses_V1_1_0
    {
        /// <summary>
        /// Metadata about the JSON payload
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Metadata? Metadata { get; set; } = default!;

        /// <summary>
        /// Decisions made on admission applications.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admissionDecision", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AdmissionDecision? AdmissionDecision { get; set; } = default!;

        /// <summary>
        /// The global identifier of the interview for the admission application.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admissionInterview", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AdmissionInterview? AdmissionInterview { get; set; } = default!;

        /// <summary>
        /// The unique DfE ID of the application on which this decision was made.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dfeApplicationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DfeApplicationId { get; set; } = default!;

        /// <summary>
        /// Status of the decision
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ExternalAdmissionsApplicationDecisionStatuses_V1_1_0Status Status { get; set; } = default!;

        /// <summary>
        /// Correlation id of the job run
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobRunId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string JobRunId { get; set; } = default!;

        /// <summary>
        /// Details of the Error occurred
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errorDetail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ErrorDetail { get; set; } = default!;

        /// <summary>
        /// Description of the error occurred
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errorDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ErrorDescription { get; set; } = default!;

        /// <summary>
        /// Response code received while sending information to 3rd Party
        /// </summary>
        [Newtonsoft.Json.JsonProperty("responseCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ResponseCode { get; set; } = default!;

        /// <summary>
        /// Pipeline Job run date and time
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobRunDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? JobRunDate { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AdmissionDecision
    {
        /// <summary>
        /// The global identifier for the Admission Decision.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AdmissionInterview
    {
        /// <summary>
        /// The global identifier for the Admission Interview.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ExternalAdmissionsApplicationDecisionStatuses_V1_1_0Status
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Success")]
        Success = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Failure")]
        Failure = 1,

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603