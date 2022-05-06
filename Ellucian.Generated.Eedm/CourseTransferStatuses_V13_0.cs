//Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The list of valid statuses for course transfers. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CourseTransferStatuses_V13_0 : CodeItem2
    {    
        /// <summary>
       /// The category to which the course transfer status belongs.
       /// </summary>
         
       [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public CourseTransferStatusesCategory Category { get; set; }
         
     }      
}          
