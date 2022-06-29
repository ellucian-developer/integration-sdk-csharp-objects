// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;

using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// This is DTO for person filter for v8
    /// </summary>
    [DataContract]
    public class PersonFilter : BaseModel2
    {
        //to support old filters
        /// <summary>
        ///title
        /// </summary>
        [DataMember(Name = "title")]
        [FilterProperty("criteria", Ignore=true)]
        public string Title { get; set; }


        /// <summary>
        /// firstname
        /// </summary>
        [DataMember(Name = "firstName")]
        [FilterProperty("criteria", Ignore = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// middleName
        /// </summary>
        [DataMember(Name = "middleName")]
        [FilterProperty("criteria", Ignore = true)]
        public string MiddleName { get; set; }

        /// <summary>
        /// lastNamePrefix
        /// </summary>
        [DataMember(Name = "lastNamePrefix")]
        [FilterProperty("criteria", Ignore = true)]
        public string LastNamePrefix { get; set; }

        /// <summary>
        /// lastname
        /// </summary>
        [DataMember(Name = "lastName")]
        [FilterProperty("criteria", Ignore = true)]
        public string LastName { get; set; }

        /// <summary>
        /// pedigree
        /// </summary>
        [DataMember(Name = "pedigree")]
        [FilterProperty("criteria", Ignore = true)]
        public string Pedigree { get; set; }

        /// <summary>
        /// preferredName
        /// </summary>
        [DataMember(Name = "preferredName")]
        [FilterProperty("criteria", Ignore = true)]
        public string PreferredName { get; set; }

        /// <summary>
        /// role
        /// </summary>
        [DataMember(Name = "role")]
        [FilterProperty("criteria", Ignore = true)]
        public PersonRoleType? Role { get; set; }

        /// <summary>
        /// credentialType
        /// </summary>
        [DataMember(Name = "credentialType")]
        [FilterProperty("criteria", Ignore = true)]
        public CredentialType2? CredentialType { get; set; }

        /// <summary>
        /// credentialValue
        /// </summary>
        [DataMember(Name = "credentialValue")]
        [FilterProperty("criteria", Ignore = true)]
        public string CredentialValue { get; set; }

        /// <summary>
        /// personFilter
        /// </summary>
        [DataMember(Name = "personFilter")]
        [FilterProperty("criteria", Ignore = true)]
        public string PersonFilterFilter { get; set; }

        //support new filter format

        /// <summary>
        /// <see cref="PersonNameDtoProperty">Names</see> of the person
        /// </summary>
        [JsonProperty("names")]
        public IEnumerable<PersonNameDtoProperty> PersonNames { get; set; }

        /// <summary>
        /// <see cref="PersonRoleDtoProperty">Roles</see> of the person
        /// </summary>
        [JsonProperty("roles", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<PersonRoleDtoProperty> Roles { get; set; }

        /// <summary>
        /// <see cref="PersonCredentials_V6_0">Credentials</see> of the person
        /// </summary>
        [JsonProperty("credentials", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<CredentialDtoProperty2> Credentials { get; set; }

    }
}