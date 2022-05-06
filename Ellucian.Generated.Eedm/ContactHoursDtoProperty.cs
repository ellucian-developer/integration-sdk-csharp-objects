using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The contact hours that may be assigned to the course
    /// </summary>
    /// 
    [DataContract]
    public class ContactHoursDtoProperty
    {
        /// <summary>
        /// The minimum number of contact hours that may be assigned to the course
        /// </summary>
        [DataMember(Name = "minimum", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Minimum { get; set; }

        /// <summary>
        /// The maximum number of contact hours that may be assigned to the course
        /// </summary>
        [DataMember(Name = "maximum", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Maximum { get; set; }

        /// <summary>
        /// The increment by which the range of values for contact hours can change from the minimum to the maximum
        /// </summary>
        [DataMember(Name = "increment", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Increment { get; set; }

        /// <summary>
        /// The time interval of the contact hours
        /// </summary>
        [DataMember(Name = "interval", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ContactHoursPeriod? Interval { get; set; }
    }
}
