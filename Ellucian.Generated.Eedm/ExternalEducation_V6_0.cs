// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An External Education Dto
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ExternalEducation_V6_0 : BaseModel2
    {

        /// <summary>
        ///  The person who was educated at the institution.
        /// </summary>
        [JsonProperty("person")]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The educational institution where the person studied.
        /// </summary>
        [JsonProperty("institution")]
        public GuidObject2 Institution { get; set; }

        /// <summary>
        /// The academic credential (degree, diploma, etc.) the person was awarded at the institution.
        /// </summary>
        [JsonProperty("credential", NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Credential { get; set; }

        /// <summary>
        /// The academic disciplines associated with the person's course of study at the institution.
        /// </summary>
        [JsonProperty("disciplines", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GuidObject2> Disciplines { get; set; }

        /// <summary>
        /// The date when the person's education at the institution began.
        /// </summary>
        [JsonProperty("startOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateDtoProperty StartOn { get; set; }

        /// <summary>
        /// The date when the person's education at the institution ended.
        /// </summary>
        [JsonProperty("endOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateDtoProperty EndOn { get; set; }

        /// <summary>
        ///  A measurement of the student's educational performance at the institution (e.g. GPA).
        /// </summary>
        [JsonProperty("performanceMeasure", NullValueHandling = NullValueHandling.Ignore)]
        public string PerformanceMeasure { get; set; }

        /// <summary>
        /// The academic recognition received by the person at the institution.
        /// </summary>
        [JsonProperty("recognitions", NullValueHandling = NullValueHandling.Ignore)]
        public List<GuidObject2> Recognition { get; set; }

        /// <summary>
        /// The date the student graduated from the institution
        /// </summary>   
        [JsonConverter(typeof(DateOnlyConverter))]  
        [JsonProperty("graduatedOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? GraduatedOn { get; set; }

        /// <summary>
        /// The date when the institution awarded a credential (e.g. degree) to the person.
        /// </summary>   
        [JsonConverter(typeof(DateOnlyConverter))]  
        [JsonProperty("credentialsDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CredentialsDate { get; set; }

        /// <summary>
        ///  The date that the transcript for the student's education was received.
        /// </summary>     
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("transcriptReceivedOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TranscriptReceivedOn { get; set; }

        /// <summary>
        ///  The title of the thesis (dissertation).
        /// </summary>
        [JsonProperty("thesisTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string ThesisTitle { get; set; }

        /// <summary>
        /// The number of credits earned during the person's course of study at the institution.
        /// </summary>
        [JsonProperty("creditsEarned", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreditsEarned { get; set; }

        /// <summary>
        ///  The size of the class associate with the person's course of study
        /// </summary>
        [JsonProperty("classSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClassSize { get; set; }

        /// <summary>
        /// The person's class percentile.
        /// </summary>
        [JsonProperty("classPercentile", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClassPercentile { get; set; }

        /// <summary>
        /// The person's class rank.
        /// </summary>
        [JsonProperty("classRank", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClassRank { get; set; }

    }
}