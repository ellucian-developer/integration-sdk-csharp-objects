// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A country specific postal region.  Postal regions are expressed as a hierarchy of country, 
    /// region, and sub-region, and as a locality with postal automation codes
    /// </summary>
    [DataContract]
    public class AddressCountry
    {
       
        /// <summary>
        /// The ISO 3166-1 alpha-3 country code.
        /// </summary>
        [DataMember(Name = "code")]
        public IsoCode? Code { get; set; }

        /// <summary>
        /// The name of the country, as used in everyday speech.
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// The name of the country when mail is being addressed from an international sender.
        /// </summary>
        [DataMember(Name = "postalTitle")]
        public string PostalTitle { get; set; }

        /// <summary>
        /// The code of a region within the country
        /// </summary>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public AddressRegion Region { get; set; }

        /// <summary>
        ///  A subregion within the country and region
        /// </summary>
        [DataMember(Name = "subRegion", EmitDefaultValue = false)]
        public AddressSubRegion SubRegion { get; set; }

        /// <summary>
        /// The name of the city or town
        /// </summary>
        [DataMember(Name = "locality", EmitDefaultValue = false)]
        public string Locality { get; set; }

        /// <summary>
        /// The mailing postal code
        /// </summary>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// A specific set of digits between 00 and 99 assigned to every address. When combined with the 
        /// ZIP + 4 code, the delivery point provides a unique identifier for every deliverable address 
        /// served by the US Postal Service
        /// </summary>
        [DataMember(Name = "deliveryPoint", EmitDefaultValue = false)]
        public string DeliveryPoint { get; set; }

        /// <summary>
        /// A subdivision of a US zipcode
        /// </summary>
        [DataMember(Name = "carrierRoute", EmitDefaultValue = false)]
        public string CarrierRoute { get; set; }

        /// <summary>
        /// A number used to check for errors in a US ZIP code, delivery point, or carrier route
        /// </summary>
        [DataMember(Name = "correctionDigit", EmitDefaultValue = false)]
        public string CorrectionDigit { get; set; }

    }
}