//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The individuals, or organizations, designated as the recipient of funds or other benefits upon a person's death. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonBeneficiaries : BaseModel2
    {    
        /// <summary>
       /// The deduction agreement associated with the benefit.
       /// </summary>
         
       [JsonProperty("deductionArrangement", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 DeductionArrangement { get; set; }
     
        /// <summary>
       /// The person or organization who is designated to receive the financial benefit.
       /// </summary>
         
       [JsonProperty("beneficiary", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public PersonBeneficiariesBeneficiary Beneficiary { get; set; }
     
        /// <summary>
       /// The beneficiary preference at the time of distribution (e.g. primary, secondary, etc.).
       /// </summary>
         
       [JsonProperty("preference", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 Preference { get; set; }
     
        /// <summary>
       /// The amount or percentage of the allocation of the benefit to the beneficiary.
       /// </summary>
         
       [JsonProperty("designation", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public PersonBeneficiariesDesignation Designation { get; set; }

       /// <summary>
       /// The first date when a beneficiary is applicable to a person's benefit.
       /// </summary>

       [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public DateTime? StartOn { get; set; }

       /// <summary>
       /// The last date when a beneficiary is applicable to a person's benefit.
       /// </summary>

       [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public DateTime? EndOn { get; set; }
     }      
}          
