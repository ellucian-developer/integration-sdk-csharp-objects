//Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The grade point average of the student for earned degrees. 
    /// </summary>
   [JsonObject(MemberSerialization.OptIn)]
    public class StudentGradePointAveragesEarnedDegreesDtoProperty
    {
        /// <summary>
       /// The academic program associated with the grade point average.
       /// </summary>
          
       [JsonProperty("academicProgram", DefaultValueHandling = DefaultValueHandling.Ignore)]  
       public GuidObject2 AcademicProgram { get; set; }
     
        /// <summary>
       /// An indication of the academic sources that have been included in the grade point average (e.g. institution, transfer or all).
       /// </summary>
          
       [JsonProperty("academicSource", DefaultValueHandling = DefaultValueHandling.Ignore)]  
       public string AcademicSource { get; set; }
     
        /// <summary>
       /// The date the student earned the degree.
       /// </summary>
         [JsonConverter(typeof(DateOnlyConverter))]   
       [JsonProperty("earnedOn", DefaultValueHandling = DefaultValueHandling.Ignore)]  
       public DateTime EarnedOn { get; set; }
     
        /// <summary>
       /// The grade point average.
       /// </summary>
          
       [JsonProperty("value")]  
       public Decimal Value { get; set; }
     
        /// <summary>
       /// The number of attempted credits used to compute the grade point average.
       /// </summary>
          
       [JsonProperty("attemptedCredits")]  
       public Decimal AttemptedCredits { get; set; }
     
        /// <summary>
       /// The number of earned credits used to compute the grade point average.
       /// </summary>
          
       [JsonProperty("earnedCredits")]  
       public Decimal EarnedCredits { get; set; }
     
        /// <summary>
       /// The number of quality points used to compute the grade point average.
       /// </summary>
          
       [JsonProperty("qualityPoints")]  
       public Decimal QualityPoints { get; set; }
     }
}