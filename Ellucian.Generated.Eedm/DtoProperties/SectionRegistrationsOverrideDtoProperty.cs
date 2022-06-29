//Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The method of approval. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SectionRegistrationsOverrideDtoProperty
    {
        /// <summary>
        /// The academic period for the registration.
        /// </summary>
        [JsonProperty("academicPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]  
       public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// The global identifier for the Site.
        /// </summary>
        [JsonProperty("site", DefaultValueHandling = DefaultValueHandling.Ignore)]  
       public GuidObject2 Site { get; set; }
     }      
}  

