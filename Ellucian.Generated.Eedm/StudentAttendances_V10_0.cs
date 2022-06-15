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

namespace Ellucian.Generated.Eedm.StudentAttendances_V10_0
{
    using System = global::System;

    

    /// <summary>
    /// The detailed information of students' attendances at instructional events.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class StudentAttendances_V10_0
    {
        /// <summary>
        /// Metadata about the JSON payload
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Metadata? Metadata { get; set; } = default!;

        /// <summary>
        /// The global identifier of the student attendance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The student for whom attendance was taken.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("student", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Student Student { get; set; } = new Student();

        /// <summary>
        /// The instructional event for which the student’s attendance applies.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instructionalEvent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public InstructionalEvent InstructionalEvent { get; set; } = new InstructionalEvent();

        /// <summary>
        /// The instance of the instructional event for which attendance was taken.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instructionalEventInstance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public InstructionalEventInstance? InstructionalEventInstance { get; set; } = default!;

        /// <summary>
        /// The date and time for which the attendance applies.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attendanceTaken", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset AttendanceTaken { get; set; } = default!;

        /// <summary>
        /// The categorization of the student's attendance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attendance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Attendance Attendance { get; set; } = new Attendance();

        /// <summary>
        /// The percentage of the total session time the student was in attendance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("percentAttended", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PercentAttended { get; set; } = default!;

        /// <summary>
        /// Comments regarding the student’s attendance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Comment { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Student
    {
        /// <summary>
        /// The global identifier for the Student.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class InstructionalEvent
    {
        /// <summary>
        /// The global identifier for the Instructional Event.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class InstructionalEventInstance
    {
        /// <summary>
        /// The global identifier for the Instructional Event Instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Attendance
    {
        /// <summary>
        /// The student’s attendance category.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AttendanceCategory Category { get; set; } = default!;

        /// <summary>
        /// A user defined category applied to the student's attendance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Detail? Detail { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum AttendanceCategory
    {

        [System.Runtime.Serialization.EnumMember(Value = @"presentFull")]
        PresentFull = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"presentPartial")]
        PresentPartial = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"absentExcused")]
        AbsentExcused = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"absentNotExcused")]
        AbsentNotExcused = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Detail
    {
        /// <summary>
        /// The global identifier for the Detail.
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