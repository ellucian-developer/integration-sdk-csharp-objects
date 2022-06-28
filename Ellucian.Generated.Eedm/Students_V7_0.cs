// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a person who is registered/enrolled in the institution as a student.
    /// </summary>
    [DataContract]
    public class Students_V7_0 : BaseModel2
    {
        /// <summary>
        /// A reference to link a student to the common HEDM persons entity.
        /// </summary>
        [DataMember(Name = "person")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Person { get; set; }
    
        /// <summary>
        /// Type of the student.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Type { get; set; }

        /// <summary>
        /// Groupings of students for reporting/tracking purposes (cohorts) to which the student is associated.
        /// </summary>
        [DataMember(Name = "cohorts", EmitDefaultValue = false)]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public List<GuidObject2> Cohorts { get; set; }

        /// <summary>
        /// A list of custom defined attributes or characteristics (tags) assigned to the student.
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<GuidObject2> Tags { get; set; }
        
        /// <summary>
        /// The residency type of the student (e.g.: international, in state, out of state, etc.).
        /// </summary>
        [DataMember(Name = "residency", EmitDefaultValue = false)]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Residency { get; set; }

        /// <summary>
        /// Measures (GPA, year classification) associated with the student for the academic period by academic level.
        /// </summary>
        [DataMember(Name = "measures", EmitDefaultValue = false)]
        public List<PerformanceMeasureDtoProperty> Measures { get; set; }

    }
}