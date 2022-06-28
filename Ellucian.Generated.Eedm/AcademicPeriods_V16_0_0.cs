// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Academic Period 
    /// </summary>
    [DataContract]
    public class AcademicPeriods_V16_0_0 : CodeItem2
    {
        /// <summary>
        /// The <see cref="AcademicPeriodCategory3">Academic Period category</see>
        /// </summary>
        [DataMember(Name = "category")]
        public AcademicPeriodCategory3 Category { get; set; }

        /// <summary>
        /// Start
        /// </summary>
        [DataMember(Name = "startOn", EmitDefaultValue= false)]
        public DateTimeOffset? Start { get; set; }


        /// <summary>
        /// End
        /// </summary>
        [DataMember(Name = "endOn", EmitDefaultValue = false)]
        public DateTimeOffset? End { get; set; }
      
        /// <summary>
        /// Registration Status
        /// </summary>
        [DataMember(Name = "registration", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public TermRegistrationStatus? RegistrationStatus { get; set; }

        /// <summary>
        /// Census Dates
        /// </summary>
        [JsonProperty(ItemConverterType = typeof(DateOnlyConverter), DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DataMember(Name = "censusDates", EmitDefaultValue = false)]
        public List<DateTime?> CensusDates { get; set; }
     }
 }
