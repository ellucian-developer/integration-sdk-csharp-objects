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
    /// The destinations where purchases may be shipped. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ShipToDestinations_V10_0 : CodeItem2
    {    
       /// <summary>
       /// The address lines of the destination's location, such as a street address or post office box number, city, region, and postal code.
       /// </summary>
         
       [JsonProperty("addressLines", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public List<string> AddressLines { get; set; }
     
       /// <summary>
       /// A country specific postal region. Postal regions are expressed as a hierarchy of country, region, and sub-region, and as a locality with postal automation codes.
       /// </summary>
         
       [JsonProperty("place", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public AddressPlace Place { get; set; }
     
       /// <summary>
       /// The contact specified for the destination.
       /// </summary>
         
       [JsonProperty("contact", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public ShipToDestinationsContact Contact { get; set; }
     
       /// <summary>
       /// The default tax code associated with the destination.
       /// </summary>
         
       [JsonProperty("taxCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 TaxCode { get; set; }
         
     }      
}          
