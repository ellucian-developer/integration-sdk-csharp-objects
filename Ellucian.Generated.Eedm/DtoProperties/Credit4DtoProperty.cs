//Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The method of approval. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Credit4DtoProperty
    {
        /// <summary>
       /// The type of approval granted.
       /// </summary>
          
       [JsonProperty("measure")]  
       public StudentCourseTransferMeasure? Measure { get; set; }
     
        /// <summary>
       /// The entity granting approval.
       /// </summary>
          
       [JsonProperty("registrationCredit")]
       public decimal? RegistrationCredit { get; set; }
     }      
}  

