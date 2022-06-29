//Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The grade change details of the grades eligible to be displayed on the transcript. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentTranscriptGradesChangeDetails
    {
        /// <summary>
        /// The sequence number of the grade change.
        /// </summary>
        [JsonProperty("sequenceNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SequenceNumber { get; set; }

        /// <summary>
        /// The grade entered.
        /// </summary>
        [JsonProperty("grade", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Grade { get; set; }

        /// <summary>
        /// The default incomplete final grade and the extension date associated with the student's grade.
        /// </summary>
        [JsonProperty("incompleteGrade", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentTranscriptGradesIncompleteGradeDtoProperty IncompleteGrade { get; set; }

        /// <summary>
        /// The award grade scheme assigned to the student.
        /// </summary>
        [JsonProperty("awardGradeScheme", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AwardGradeScheme { get; set; }

        /// <summary>
        /// The reason specified for a change to a previously entered grade.
        /// </summary>
        [JsonProperty("changeReason", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 ChangeReason { get; set; }

        /// <summary>
        /// The date the grade change was recorded.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("recordedOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? RecordedOn { get; set; }

    }
}