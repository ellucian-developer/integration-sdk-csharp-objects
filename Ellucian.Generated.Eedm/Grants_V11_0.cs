//Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about grants that are offered by various sponsors to help fund research efforts. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Grants_V11_0 : BaseModel2
    {    
        /// <summary>
       /// The full name of the grant.
       /// </summary>         
       [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string Title { get; set; }
     
        /// <summary>
       /// The reference code used to identify the grant or project.
       /// </summary>         
       [JsonProperty("referenceCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string ReferenceCode { get; set; }
     
        /// <summary>
       /// The reference code used by the sponsor.
       /// </summary>         
       [JsonProperty("sponsorReferenceCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string SponsorReferenceCode { get; set; }
     
        /// <summary>
       /// The segment of the educational institution used for reporting purposes.
       /// </summary>         
       [JsonProperty("reportingSegment", DefaultValueHandling = DefaultValueHandling.Ignore)]
       [FilterProperty("criteria")]
       public string ReportingSegment { get; set; }
     
        /// <summary>
       /// The first date when transactions can be processed for the grant or project.
       /// </summary>
       [JsonConverter(typeof(DateOnlyConverter))]  
       [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public DateTime StartOn { get; set; }
     
        /// <summary>
       /// The last date when transactions can be processed for the grant or project.
       /// </summary>
       [JsonConverter(typeof(DateOnlyConverter))]  
       [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public DateTime? EndOn { get; set; }
     
        /// <summary>
       /// The status of the grant.
       /// </summary>         
       [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GrantsStatus Status { get; set; }
     
        /// <summary>
       /// The formatted accounting strings associated with the grant.
       /// </summary>         
       [JsonProperty("accountingStrings", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public IEnumerable<string> AccountingStrings { get; set; }
     
        /// <summary>
       /// The total amount budgeted for the grant or project.
       /// </summary>         
       [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public AmountDtoProperty Amount { get; set; }
     
        /// <summary>
       /// The category of the grant. (For example, research grant, construction project, etc.)
       /// </summary>         
       [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string Category { get; set; }
     
        /// <summary>
       /// The reporting periods associated with the grant.
       /// </summary>         
       [JsonProperty("reportingPeriods", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public IEnumerable<GrantsReportingPeriodProperty> ReportingPeriods { get; set; }
     
       /// <summary>
       /// The principal investigator associated with the grant or project.
       /// </summary>         
       [JsonProperty("principalInvestigator", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 PrincipalInvestigator { get; set; }         
     }      
}          
