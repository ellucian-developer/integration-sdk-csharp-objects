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

namespace Ellucian.Generated.Eedm.InstructionalEvents_V6_0
{
    using System = global::System;

    

    /// <summary>
    /// An instructional activity that takes place during a section.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class InstructionalEvents_V6_0
    {
        /// <summary>
        /// Metadata about the JSON payload
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Metadata? Metadata { get; set; } = default!;

        /// <summary>
        /// A globally unique identifier of an instructional activity to be used in all external references.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The full name of an instructional activity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Title { get; set; } = default!;

        /// <summary>
        /// A description of an instructional activity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// An instance of a course.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("section", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Section Section { get; set; } = new Section();

        /// <summary>
        /// The method, style, or format of instruction associated with the instructor's involvement with the section (for example, 'Lecture', 'Lab').
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instructionalMethod", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public InstructionalMethod InstructionalMethod { get; set; } = new InstructionalMethod();

        /// <summary>
        /// The total amount of work associated with the instructional event.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("workLoad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WorkLoad { get; set; } = default!;

        /// <summary>
        /// The recurring meeting time pattern associated with the instructional event.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recurrence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Recurrence? Recurrence { get; set; } = default!;

        /// <summary>
        /// The locations where the instructional event will take place.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("locations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Locations>? Locations { get; set; } = default!;

        /// <summary>
        /// The roster of instructors assigned to teach an instructional event.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instructorRoster", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<InstructorRoster>? InstructorRoster { get; set; } = default!;

        /// <summary>
        /// The type and source of approvals applied to the instructional event.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("approvals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Approvals>? Approvals { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Section
    {
        /// <summary>
        /// The global identifier for the Section.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class InstructionalMethod
    {
        /// <summary>
        /// The global identifier for the Instructional Method.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Recurrence
    {
        /// <summary>
        /// The period of time to be repeated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timePeriod", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TimePeriod TimePeriod { get; set; } = new TimePeriod();

        /// <summary>
        /// The rule that describes how to repeat the time period.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("repeatRule", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RepeatRule RepeatRule { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Locations
    {
        /// <summary>
        /// The location where the instructional event will take place.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Location Location { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class InstructorRoster
    {
        /// <summary>
        /// The person assigned to teach an instruction method of a section
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instructor", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Instructor Instructor { get; set; } = new Instructor();

        /// <summary>
        /// The rate or proportion per hundred of the instructional method's work load that is attributable to the instructor.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("workLoadPercentage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WorkLoadPercentage { get; set; } = default!;

        /// <summary>
        /// The rate or proportion per hundred of the responsibility for managing the instructional method's activities that is attributable to the instructor.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("responsibilityPercentage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ResponsibilityPercentage { get; set; } = default!;

        /// <summary>
        /// The date when an instructor is assigned to start teaching the scheduled event for a section.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("workStartOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? WorkStartOn { get; set; } = default!;

        /// <summary>
        /// The date after which an instructor is no longer assigned to the scheduled event for a section.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("workEndOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? WorkEndOn { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Approvals
    {
        /// <summary>
        /// The type of approval granted.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("approvalType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ApprovalsApprovalType ApprovalType { get; set; } = default!;

        /// <summary>
        /// The entity that granted approval.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("approvalEntity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ApprovalsApprovalEntity ApprovalEntity { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TimePeriod
    {
        /// <summary>
        /// The beginning of the time period being repeated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startOn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset StartOn { get; set; } = default!;

        /// <summary>
        /// The end of the time period being repeated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endOn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndOn { get; set; } = default!;

    }

    /// <summary>
    /// Rules for repeating on a daily basis.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RepeatRule
    {
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RepeatRuleType Type { get; set; } = default!;

        /// <summary>
        /// Number of days between each repetition.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("interval", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Interval { get; set; } = default!;

        /// <summary>
        /// When to end the daily repetitions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ends", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Ends? Ends { get; set; } = default!;

    }

    /// <summary>
    /// A physical location within the organization where the event will take place
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Location
    {
        /// <summary>
        /// The type of location (i.e. site).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LocationType Type { get; set; } = default!;

        /// <summary>
        /// The physical site where the event will take place
        /// </summary>
        [Newtonsoft.Json.JsonProperty("site", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Site Site { get; set; } = new Site();

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Instructor
    {
        /// <summary>
        /// The global identifier for the Instructor.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ApprovalsApprovalType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"instructorAvailability")]
        InstructorAvailability = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"instructorCapacity")]
        InstructorCapacity = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"roomAvailability")]
        RoomAvailability = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"roomCapacity")]
        RoomCapacity = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ApprovalsApprovalEntity
    {

        [System.Runtime.Serialization.EnumMember(Value = @"user")]
        User = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"system")]
        System = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum RepeatRuleType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"daily")]
        Daily = 0,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ends
    {
        /// <summary>
        /// Number of times to repeat, then stop.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("repetitions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Repetitions { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum LocationType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"site")]
        Site = 0,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Site
    {
        /// <summary>
        /// The global identifier for the Site.
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