// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Attributes;

using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A person's name.
    /// </summary>
    [DataContract]
    public class PersonName2DtoProperty
    {
        /// <summary>
        /// The <see cref="PersonNameType">type</see> of the person's name
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonNameTypeDtoProperty NameType { get; set; }

        /// <summary>
        /// Person's fullName
        /// </summary>
        [JsonProperty("fullName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FullName { get; set; }

        /// <summary>
        /// Person's title/prefix
        /// </summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string Title { get; set; }

        /// <summary>
        /// Person's first name
        /// </summary>
        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string FirstName { get; set; }

        /// <summary>
        /// Person's middle name
        /// </summary>
        [JsonProperty("middleName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Person's last name prefix
        /// </summary>
        [JsonProperty("lastNamePrefix", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string LastNamePrefix { get; set; }

        /// <summary>
        /// Person's last name
        /// </summary>
        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string LastName { get; set; }

        /// <summary>
        /// Person's pedigree/suffix
        /// </summary>
        [JsonProperty("pedigree", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Pedigree { get; set; }

        /// <summary>
        /// Person's post-nominal professional abbreviation, reflecting an earned degree or honor.  For example, "M.D." or "Ph.D.".
        /// </summary>
        [JsonProperty("professionalAbbreviations", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<string> ProfessionalAbbreviation { get; set; }

        /// <summary>
        /// Person's preferred designation
        /// </summary>
        [JsonProperty("preference", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonNamePreference? Preference { get; set; }
    }
}