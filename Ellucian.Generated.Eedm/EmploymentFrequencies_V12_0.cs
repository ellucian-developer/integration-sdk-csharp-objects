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
    /// The valid list of user defined frequencies used with employment information. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class EmploymentFrequencies_V12_0 : CodeItem2
    {    
        /// <summary>
       /// The type of the employment frequency.
       /// </summary>
         
       [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public EmploymentFrequenciesType Type { get; set; }
         
     }      
}          
