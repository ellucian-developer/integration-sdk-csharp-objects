//Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Details about assets for long-term use that are not likely to be converted quickly into cash (for example land, buildings, or equipment). 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class FixedAssets_V12_0 : BaseModel2
    {    
        /// <summary>
       /// The description of the fixed asset.
       /// </summary>
         
       [JsonProperty("description")]
       public string Description { get; set; }
     
        /// <summary>
       /// A unique user defined or system generated number, usually visible on the tag of the asset.
       /// </summary>
         
       [JsonProperty("tag")]
       public string Tag { get; set; }
     
        /// <summary>
       /// A code which describes an asset type for depreciation purposes (e.g. office equipment, athletic equipment, classroom furniture).
       /// </summary>
         
       [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 Type { get; set; }
     
        /// <summary>
       /// The category associated with the fixed asset (e.g. equipment).
       /// </summary>
         
       [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 Category { get; set; }
     
        /// <summary>
       /// The capitalization status of the fixed asset.
       /// </summary>
         
       [JsonProperty("capitalizationStatus")]
       public FixedAssetsCapitalizationStatus CapitalizationStatus { get; set; }
     
        /// <summary>
       /// The acquisition method associated with the fixed asset.
       /// </summary>
         
       [JsonProperty("acquisitionMethod")]
       public FixedAssetsAcquisitionMethod AcquisitionMethod { get; set; }
     
        /// <summary>
       /// A status indicating whether the asset has been disposed of or written off.
       /// </summary>
         
       [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public FixedAssetsStatus Status { get; set; }
     
        /// <summary>
       /// The condition of the fixed asset.
       /// </summary>
         
       [JsonProperty("condition", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string Condition { get; set; }
     
        /// <summary>
       /// The location associated with the fixed asset.
       /// </summary>
         
       [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string Location { get; set; }
     
        /// <summary>
       /// The building with which the fixed asset is associated.
       /// </summary>
         
       [JsonProperty("building", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 Building { get; set; }
     
        /// <summary>
       /// The room with which the fixed asset is associated.
       /// </summary>
         
       [JsonProperty("room", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 Room { get; set; }
     
        /// <summary>
       /// The insured value of the fixed asset.
       /// </summary>
         
       [JsonProperty("insuredValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public Amount2DtoProperty InsuredValue { get; set; }
     
        /// <summary>
       /// The market value of the fixed asset.
       /// </summary>
         
       [JsonProperty("marketValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public Amount2DtoProperty MarketValue { get; set; }
     
       /// <summary>
       /// The acquisition cost of the fixed asset.
       /// </summary>
         
       [JsonProperty("acquisitionCost", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public Amount2DtoProperty AcquisitionCost { get; set; }
     
        /// <summary>
       /// The amount of accumulated depreciation associated with the fixed asset.
       /// </summary>
         
       [JsonProperty("accumulatedDepreciation", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public Amount2DtoProperty AccumulatedDepreciation { get; set; }
     
        /// <summary>
       /// The depreciation method associated with the fixed asset.
       /// </summary>
         
       [JsonProperty("depreciationMethod", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string DepreciationMethod { get; set; }
     
        /// <summary>
       /// The salvage value of the fixed asset.
       /// </summary>
         
       [JsonProperty("salvageValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public Amount2DtoProperty SalvageValue { get; set; }
     
        /// <summary>
       /// The fixed asset's useful life in years.
       /// </summary>
         
       [JsonProperty("usefulLife", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public int? UsefulLife { get; set; }
     
        /// <summary>
       /// The depreciation expense account associated with the fixed asset.
       /// </summary>
         
       [JsonProperty("depreciationExpenseAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 DepreciationExpenseAccount { get; set; }
     
        /// <summary>
       /// The fixed asset's net renewal cost.
       /// </summary>
         
       [JsonProperty("renewalCost", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public Amount2DtoProperty RenewalCost { get; set; }
     
        /// <summary>
       /// The responsible person(s) associated with the fixed asset.
       /// </summary>
         
       [JsonProperty("responsiblePersons", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public IEnumerable<GuidObject2> ResponsiblePersons { get; set; }
         
     }      
} 
