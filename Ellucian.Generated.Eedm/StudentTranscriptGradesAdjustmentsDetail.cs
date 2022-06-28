//Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details of the adjustments to the student transcript. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentTranscriptGradesAdjustmentsDetail
    {
        /// <summary>
        /// The grade supplied for the adjustment.
        /// </summary>

        [JsonProperty("grade", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Grade { get; set; }

        /// <summary>
        /// The adjustments to be applied to the default incomplete final grade and/or the extension date.
        /// </summary>

        [JsonProperty("incompleteGrade", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentTranscriptGradesIncompleteGradeDtoProperty IncompleteGrade { get; set; }

        /// <summary>
        /// The reason specified for the adjustment.
        /// </summary>

        [JsonProperty("changeReason", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 ChangeReason { get; set; }

       
    }
}

