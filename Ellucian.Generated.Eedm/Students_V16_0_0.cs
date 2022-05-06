// Copyright 2019 Ellucian Company L.P. and its affiliates.

using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a person who is registered/enrolled in the institution as a student.
    /// </summary>
    [DataContract]
    public class Students_V16_0_0 : BaseModel2
    {
        /// <summary>
        /// A reference to link a student to the common HEDM persons entity.
        /// </summary>
        [DataMember(Name = "person")]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// Types of the student.
        /// </summary>        
        [JsonProperty("types", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<StudentTypesDtoProperty> Types { get; set; }
       
        /// <summary>
        /// A list of residency types of the student (e.g.: international, in state, out of state, etc.).
        /// </summary>
        [DataMember(Name = "residencies", EmitDefaultValue = false)]
        public List<StudentResidenciesDtoProperty> Residencies { get; set; }

        /// <summary>
        /// A list of statuses associated with the student for specified effective periods.
        /// Banner-only
        /// </summary>
        [DataMember(Name = "statuses", EmitDefaultValue = false)]
        public List<StudentStatusesDtoProperty> Statuses { get; set; }

        /// <summary>
        /// A list of classifications for each academic level for a student.
        /// </summary>
        [DataMember(Name = "levelClassifications", EmitDefaultValue = false)]
        public List<StudentLevelClassificationsDtoProperty> LevelClassifications { get; set; }
    }
}
