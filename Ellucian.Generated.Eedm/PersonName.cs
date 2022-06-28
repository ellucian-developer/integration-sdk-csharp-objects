// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A person's name.
    /// </summary>
    [DataContract]
    public class PersonName
    {
        /// <summary>
        /// The <see cref="PersonNameType">type</see> of the person's name
        /// </summary>
        [DataMember(Name="nameType")]
        public PersonNameType? NameType { get; set; }

        /// <summary>
        /// Person's title/prefix
        /// </summary>
        [DataMember(Name="title")]
        public string Title { get; set; }

        /// <summary>
        /// Person's first name
        /// </summary>
        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Person's middle name
        /// </summary>
        [DataMember(Name = "middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Person's last name prefix
        /// </summary>
        [DataMember(Name = "lastNamePrefix")]
        public string LastNamePrefix { get; set; }

        /// <summary>
        /// Person's last name
        /// </summary>
        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Person's pedigree/suffix
        /// </summary>
        [DataMember(Name = "pedigree")]
        public string Pedigree { get; set; }

        /// <summary>
        /// Person's preferred, short-hand name/nickname
        /// </summary>
        [DataMember(Name = "preferredName")]
        public string PreferredName { get; set; }
    }
}