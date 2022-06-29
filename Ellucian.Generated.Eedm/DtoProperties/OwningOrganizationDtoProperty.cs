// Copyright 2015-2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Academic Levels DTO property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class OwningOrganizationDtoProperty //: BaseCodeTitleDetailDtoProperty
    {
        /// <summary>
        /// Organization's percentage of responsibility
        /// </summary>
        [JsonProperty("ownershipPercentage", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? OwnershipPercentage { get; set; }

        /// <summary>
        /// Id of the owningInstitutionUnits code (department)
        /// </summary>
        [JsonProperty("institutionUnit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// Type of owningInstitutionUnits (department)
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public EducationalInstitutionUnitType Type { get; set; }

        /// <summary>
        /// Code of the owningInstitutionUnits
        /// </summary>
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Title of the owningInstitutionUnits
        /// </summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public OwningOrganizationDtoProperty() : base() { }
    }
}
