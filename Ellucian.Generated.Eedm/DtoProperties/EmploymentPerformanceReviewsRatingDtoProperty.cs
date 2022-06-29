//Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The rating given in the performance review. 
    /// </summary>
   [JsonObject(MemberSerialization.OptIn)]
    public class EmploymentPerformanceReviewsRatingDtoProperty 
    {    
        /// <summary>
       /// The value of the rating given.
       /// </summary>
          
       [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string Value { get; set; }
     
        /// <summary>
       /// The details of the performance review rating.
       /// </summary>
          
       [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 Detail { get; set; }

     }      
}  

