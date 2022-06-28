//Copyright 2019-2020 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Credentials earned by persons outside of their home institution. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonExternalEducationCredentials_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The details of the external education associated with the credential.
        /// </summary>    
        [JsonProperty("externalEducation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 ExternalEducation { get; set; }

        /// <summary>
        /// The academic credential (degree, diploma, etc.) the person earned at the institution.
        /// </summary>
        [JsonProperty("credential", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Credential { get; set; }

        /// <summary>
        /// The date when the person earned the credential.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("earnedOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? EarnedOn { get; set; }

        /// <summary>
        /// The academic disciplines associated with the person's course of study at the institution.
        /// </summary>
        [JsonProperty("disciplines", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> Disciplines { get; set; }

        /// <summary>
        /// The supplemental academic credential (degree, diploma, etc.) the person earned at the institution.
        /// </summary>
        [JsonProperty("supplementalCredentials", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<PersonExternalEducationCredentialsSupplementalcredentialsDtoProperty> SupplementalCredentials { get; set; }

        /// <summary>
        /// The periods associated with the person's attendance at the institution.
        /// </summary>
        [JsonProperty("attendancePeriods", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<PersonExternalEducationCredentialsAttendanceperiodsDtoProperty> AttendancePeriods { get; set; }

        /// <summary>
        /// A measurement of the student's educational performance at the institution (e.g. GPA).
        /// </summary>
        [JsonProperty("performanceMeasure", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PerformanceMeasure { get; set; }

        /// <summary>
        /// The academic recognitions received by the person at the institution.
        /// </summary>
        [JsonProperty("recognitions", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> Recognitions { get; set; }

        /// <summary>
        /// The size of the class associated with the person's course of study.
        /// </summary>
        [JsonProperty("classSize", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? ClassSize { get; set; }

        /// <summary>
        /// The person's class percentile.
        /// </summary>
        [JsonProperty("classPercentile", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? ClassPercentile { get; set; }

        /// <summary>
        /// The person's class rank.
        /// </summary>
        [JsonProperty("classRank", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? ClassRank { get; set; }

        /// <summary>
        /// The person's thesis (dissertation) title.
        /// </summary>
        [JsonProperty("thesisTitle", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ThesisTitle { get; set; }

    }
}