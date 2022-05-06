// Copyright 2015 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Instructor Name DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class InstructorNameDtoProperty2
    {
        /// <summary>
        /// The <see cref="PersonNameType">type</see> of the person's name
        /// </summary>
        [JsonProperty("type")]
        public InstructorNameTypeDtoProperty NameType { get; set; }

        /// <summary>
        /// Person's title/prefix
        /// </summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Person's first name
        /// </summary>
        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// Person's middle name
        /// </summary>
        [JsonProperty("middleName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Person's last name prefix
        /// </summary>
        [JsonProperty("lastNamePrefix", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastNamePrefix { get; set; }

        /// <summary>
        /// Person's last name
        /// </summary>
        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// Person's last name
        /// </summary>
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// Person's pedigree/suffix
        /// </summary>
        [JsonProperty("pedigree", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Pedigree { get; set; }

        /// <summary>
        /// Person's preferred, short-hand name/nickname
        /// </summary>
        [JsonProperty("preferredName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PreferredName { get; set; }

        /// <summary>
        /// Indicates the preferred name for the person. Only one name should be set to preferred for a person.
        /// </summary>
        [JsonProperty("preference", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonNamePreference? Preference { get; set; }

        /// <summary>
        /// Person's post-nominal professional abbreviation, reflecting an earned degree or honor.  For example, "M.D." or "Ph.D.".
        /// </summary>
        [JsonProperty("professionalAbbreviations", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<string> ProfessionalAbbreviation { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        [JsonConstructor]
        public InstructorNameDtoProperty2()
        {

        }
    }
}
