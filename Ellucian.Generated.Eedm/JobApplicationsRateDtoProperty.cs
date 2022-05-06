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
    /// The rate charged for the job application specified. 
    /// </summary>
   [JsonObject(MemberSerialization.OptIn)]
    public class JobApplicationsRateDtoProperty
    {    
        /// <summary>
       /// The monetary value
       /// </summary>
          
       [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public Decimal? Value { get; set; }
     
        /// <summary>
       /// The ISO 4217 currency code
       /// </summary>
          
       [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public CurrencyIsoCode Currency { get; set; }
 

     }      
}  

