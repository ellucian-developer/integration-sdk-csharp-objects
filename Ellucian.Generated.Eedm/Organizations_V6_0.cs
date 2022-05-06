// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An organized body of people with a particular purpose, especially a business, society, association, etc.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Organizations_V6_0 : BaseModel2
    {
        /// <summary>
        /// The human-readable name of a Organization.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The human-readable description of a Organization.
        /// </summary>
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The roles the organization plays with respect to the home educational institution
        /// </summary>
        [JsonProperty("roles", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<OrganizationRoleDtoProperty> Roles { get; set; }

        /// <summary>
        /// Information that identifies a user to a system such as a network or computer
        /// </summary>
        [JsonProperty("credentials", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<CredentialDtoProperty> Credentials { get; set; }

        /// <summary>
        /// The physical locations where the organization resides or may be contacted by mail.
        /// </summary>
        [JsonProperty("addresses", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<PersonAddressDtoProperty> Addresses { get; set; }

        /// <summary>
        /// The phones and phone-connected devices at which the organization can be contacted.
        /// </summary>
        [JsonProperty("phones", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<PersonPhoneDtoProperty> Phones { get; set; }

        /// <summary>
        /// The email addresses at which the organization can be contacted.
        /// </summary>
        [JsonProperty("emails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<PersonEmailDtoProperty> EmailAddresses { get; set; }

        /// <summary>
        /// The social media account at which the organization can be contacted.
        /// </summary>
        [JsonProperty("socialMedia", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<PersonSocialMediaDtoProperty> SocialMedia { get; set; }
    }
}
