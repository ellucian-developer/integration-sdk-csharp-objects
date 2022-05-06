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
    /// Information about employees' performance reviews. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class EmploymentPerformanceReviews_V10_0 : BaseModel2
    {    
       /// <summary>
       /// The employee who is the subject of the performance review.
       /// </summary>
       [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 Person { get; set; }
     
       /// <summary>
       /// The job for which the person's performance was reviewed.
       /// </summary>
       [JsonProperty("job", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 Job { get; set; }
     
       /// <summary>
       /// The date by which the review must be completed.
       /// </summary>
       [JsonConverter(typeof(DateOnlyConverter))]  
       [JsonProperty("dueOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public DateTime DueOn { get; set; }
     
       /// <summary>
       /// The date when the review was completed.
       /// </summary>
       [JsonConverter(typeof(DateOnlyConverter))]  
       [JsonProperty("completedOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public DateTime CompletedOn { get; set; }
     
       /// <summary>
       /// The type of the performance review.
       /// </summary> 
       [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 Type { get; set; }
     
       /// <summary>
       /// The person conducting the performance review.
       /// </summary>  
       [JsonProperty("reviewedBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 ReviewedBy { get; set; }
     
       /// <summary>
       /// The rating given in the performance review.
       /// </summary>
       [JsonProperty("rating", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public EmploymentPerformanceReviewsRatingDtoProperty Rating { get; set; }
     
       /// <summary>
       /// Any comments associated with the performance review.
       /// </summary> 
       [JsonProperty("comment", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string Comment { get; set; }
         
     }      
}          
