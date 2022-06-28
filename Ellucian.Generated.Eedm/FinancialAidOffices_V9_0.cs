// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Financial Aid Office
    /// </summary>
    [DataContract]
    public class FinancialAidOffices_V9_0 : CodeItem2
    {
        /// <summary>
        /// The human-readable name of a resource.
        /// </summary>
        //[DataMember(Name = "title", EmitDefaultValue = false)]
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        new public string Title { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        //[DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Address Lines
        /// </summary>
        //[DataMember(Name = "addressLines", EmitDefaultValue = false)]
        [JsonProperty("addressLines", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> AddressLines { get; set; }

        /// <summary>
        /// City
        /// </summary>
        //[DataMember(Name = "city", EmitDefaultValue = false)]
        [JsonProperty("city", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// State
        /// </summary>
        //[DataMember(Name = "state", EmitDefaultValue = false)]
        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// Postal Code
        /// </summary>
        //[DataMember(Name = "postalCode", EmitDefaultValue = false)]
        [JsonProperty("postalCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Aid Administrator
        /// </summary>
        //[DataMember(Name = "aidAdministrator", EmitDefaultValue = false)]
        [JsonProperty("aidAdministrator", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AidAdministrator { get; set; }

        /// <summary>
        /// Phone Number
        /// </summary>
        //[DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public NumberDtoProperty PhoneNumber { get; set; }

        /// <summary>
        /// Fax Number
        /// </summary>
        //[DataMember(Name = "faxNumber", EmitDefaultValue = true)]
        [JsonProperty("fax", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public NumberDtoProperty FaxNumber { get; set; }

        /// <summary>
        /// Email Address
        /// </summary>
        //[DataMember(Name = "emailAddress", EmitDefaultValue = true)]
        [JsonProperty("emailAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string EmailAddress { get; set; }
    }
}
