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
    /// Information on the categorizations of pay. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PayClassifications_V12_0 : BaseModel2
    {    
        /// <summary>
       /// The full name of the pay classification.
       /// </summary>
       [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string Title { get; set; }
     
        /// <summary>
       /// A code that may be used to identify the pay classification.
       /// </summary>
       [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string Code { get; set; }
     
        /// <summary>
       /// The compensation type associated with the pay classification (e.g. salary or wages).
       /// </summary>
       [JsonProperty("compensationTypes", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public List<PayClassificationsCompensationType> CompensationType { get; set; }
     
        /// <summary>
       /// The pay table associated with the pay classification (e.g. AD for Admin, FAC for Faculty, etc.).
       /// </summary>
       [JsonProperty("payTable", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string PayTable { get; set; }
     
        /// <summary>
       /// The type of pay classification (e.g. matrix or range).
       /// </summary>
       [JsonProperty("classificationType", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public PayClassificationsClassificationType ClassificationType { get; set; }
     
        /// <summary>
       /// The pay group associated with the pay classification (e.g. 2014, 2016, 48, 35, etc.).
       /// </summary>
       [JsonProperty("payGroup", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string PayGroup { get; set; }
     
        /// <summary>
       /// The status of the pay classification (e.g. active or inactive).
       /// </summary>
       [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public PayClassificationsStatus Status { get; set; }
         
     }      
}          
