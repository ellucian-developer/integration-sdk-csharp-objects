//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The valid list of user defined ratings that may be used on employment performance reviews. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class EmploymentPerformanceReviewTypes_V10_0 : CodeItem2
    {    
       /// <summary>
       /// The frequency at which the performance review occurs.
       /// </summary>
       [JsonProperty("frequency", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public FrequencyDtoProperty Frequency { get; set; }
         
     }      
}          
