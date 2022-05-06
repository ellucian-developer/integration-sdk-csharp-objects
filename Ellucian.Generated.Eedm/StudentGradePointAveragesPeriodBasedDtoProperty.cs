//Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The period based grade point averages for the student. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentGradePointAveragesPeriodBasedDtoProperty
    {


        /// <summary>
        /// The academic period associated with the calculated grade point average.
        /// </summary>

        [JsonProperty("academicPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// An indication of the academic sources that have been included in the grade point average (e.g. institution, transfer or all).
        /// </summary>

        [JsonProperty("academicSource", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AcademicSource { get; set; }

        /// <summary>
        /// The academic level associated with the calculated grade point average.
        /// </summary>

        [JsonProperty("academicLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AcademicLevel { get; set; }

        /// <summary>
        /// The grade point average.
        /// </summary>

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        //[JsonConverter(typeof(DecimalJsonConverter), 3)]
        public Decimal? Value { get; set; }

        /// <summary>
        /// The number of attempted credits used to compute the grade point average.
        /// </summary>

        [JsonProperty("attemptedCredits", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Decimal? AttemptedCredits { get; set; }

        /// <summary>
        /// The number of earned credits used to compute the grade point average.
        /// </summary>

        [JsonProperty("earnedCredits", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Decimal? EarnedCredits { get; set; }

        /// <summary>
        /// The number of quality points used to compute the grade point average.
        /// </summary>

        [JsonProperty("qualityPoints", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Decimal? QualityPoints { get; set; }


    }
}