//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Operational units of an educational institution, such as a department. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class EducationalInstitutionUnits_V12_0 : CodeItem2
    {
        /// <summary>
        /// The type of the unit (e.g., school, division, department, etc.)
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty(new string[] { "criteria", "type" })]
        public EducationalInstitutionUnitType Type { get; set; }

        /// <summary>
        /// The parent institution and upper-level unit of the institution
        /// </summary>
        [JsonProperty("parents", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public EducationalInstitutionUnitParentDtoProperty Parents { get; set; }

        /// <summary>
        /// The physical locations where the unit resides or may be contacted by mail
        /// </summary>
        [JsonProperty("addresses", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<PersonAddressDtoProperty> Addresses { get; set; }

        /// <summary>
        /// The phones and phone-connected devices at which the unit can be contacted
        /// </summary>
        [JsonProperty("phones", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<PersonPhoneDtoProperty> Phone { get; set; }

        /// <summary>
        /// The email addresses at which the unit can be contacted
        /// </summary>
        [JsonProperty("emails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<PersonEmail2DtoProperty> Email { get; set; }

        /// <summary>
        /// The social media account at which the unit can be contacted.
        /// </summary>
        [JsonProperty("socialMedia", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<PersonSocialMediaDtoProperty> SocialMedia { get; set; }

    }
}