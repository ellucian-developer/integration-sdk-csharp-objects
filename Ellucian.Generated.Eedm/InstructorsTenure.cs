using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The tenure of the instructor.
    /// </summary>
    [DataContract]
    public class InstructorsTenure
    {
        /// <summary>
        /// The type of tenure (e.g tenured, non-tenured, on track, ineligible, without faculty status).
        /// </summary>        
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public GuidObject2 TenureType { get; set; }

        /// <summary>
        /// The date when tenure was awarded to the instructor. 
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "startOn", EmitDefaultValue = false)]
        public DateTime? TenureStatusStartOn { get; set; }

        /// <summary>
        /// The date the instructor was last reviewed for tenure.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "reviewedOn", EmitDefaultValue = false)]
        public DateTime? TenureReviewedOn { get; set; }
    }
}
