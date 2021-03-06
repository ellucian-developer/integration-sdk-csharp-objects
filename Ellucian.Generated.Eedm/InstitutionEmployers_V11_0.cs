//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#nullable enable

using Ellucian.Generated.Eedm;

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"

namespace Ellucian.Generated.Eedm.InstitutionEmployers_V11_0
{
    using System = global::System;

    

    /// <summary>
    /// Information about the institution that employs people.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class InstitutionEmployers_V11_0
    {
        /// <summary>
        /// Metadata about the JSON payload
        /// </summary>
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Metadata? Metadata { get; set; } = default!;

        /// <summary>
        /// The global identifier of the institution employer.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The full name of the institution employer.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// A code that may be used to identify the institution employer.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Code { get; set; } = default!;

        /// <summary>
        /// The physical address associated with the institution employer.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address { get; set; } = new Address();

        /// <summary>
        /// The phone number associated with the employer.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneNumber { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Address
    {
        /// <summary>
        /// The address lines of the address, such as a street address, post office box number, or city, region, and postal code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addressLines", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> AddressLines { get; set; } = new System.Collections.ObjectModel.Collection<string>();

        /// <summary>
        /// The city associated with the employer.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City { get; set; } = default!;

        /// <summary>
        /// The state associated with the employer.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State { get; set; } = default!;

        /// <summary>
        /// The ISO 3166-1 alpha-3 code of the country associated with the employer.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AddressCountry Country { get; set; } = default!;

        /// <summary>
        /// The postal code associated with the employer.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("postalCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PostalCode { get; set; } = default!;

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum AddressCountry
    {

        [System.Runtime.Serialization.EnumMember(Value = @"AFG")]
        AFG = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"AGO")]
        AGO = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"ALB")]
        ALB = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"AND")]
        AND = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"ARE")]
        ARE = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"ARG")]
        ARG = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"ARM")]
        ARM = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"ATG")]
        ATG = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"AUS")]
        AUS = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"AUT")]
        AUT = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"AZE")]
        AZE = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"BDI")]
        BDI = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"BEL")]
        BEL = 12,

        [System.Runtime.Serialization.EnumMember(Value = @"BEN")]
        BEN = 13,

        [System.Runtime.Serialization.EnumMember(Value = @"BES")]
        BES = 14,

        [System.Runtime.Serialization.EnumMember(Value = @"BFA")]
        BFA = 15,

        [System.Runtime.Serialization.EnumMember(Value = @"BGD")]
        BGD = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"BGR")]
        BGR = 17,

        [System.Runtime.Serialization.EnumMember(Value = @"BHR")]
        BHR = 18,

        [System.Runtime.Serialization.EnumMember(Value = @"BHS")]
        BHS = 19,

        [System.Runtime.Serialization.EnumMember(Value = @"BIH")]
        BIH = 20,

        [System.Runtime.Serialization.EnumMember(Value = @"BLR")]
        BLR = 21,

        [System.Runtime.Serialization.EnumMember(Value = @"BLZ")]
        BLZ = 22,

        [System.Runtime.Serialization.EnumMember(Value = @"BOL")]
        BOL = 23,

        [System.Runtime.Serialization.EnumMember(Value = @"BRA")]
        BRA = 24,

        [System.Runtime.Serialization.EnumMember(Value = @"BRB")]
        BRB = 25,

        [System.Runtime.Serialization.EnumMember(Value = @"BRN")]
        BRN = 26,

        [System.Runtime.Serialization.EnumMember(Value = @"BTN")]
        BTN = 27,

        [System.Runtime.Serialization.EnumMember(Value = @"BWA")]
        BWA = 28,

        [System.Runtime.Serialization.EnumMember(Value = @"CAF")]
        CAF = 29,

        [System.Runtime.Serialization.EnumMember(Value = @"CAN")]
        CAN = 30,

        [System.Runtime.Serialization.EnumMember(Value = @"CHE")]
        CHE = 31,

        [System.Runtime.Serialization.EnumMember(Value = @"CHL")]
        CHL = 32,

        [System.Runtime.Serialization.EnumMember(Value = @"CHN")]
        CHN = 33,

        [System.Runtime.Serialization.EnumMember(Value = @"CIV")]
        CIV = 34,

        [System.Runtime.Serialization.EnumMember(Value = @"CMR")]
        CMR = 35,

        [System.Runtime.Serialization.EnumMember(Value = @"COD")]
        COD = 36,

        [System.Runtime.Serialization.EnumMember(Value = @"COG")]
        COG = 37,

        [System.Runtime.Serialization.EnumMember(Value = @"COL")]
        COL = 38,

        [System.Runtime.Serialization.EnumMember(Value = @"COM")]
        COM = 39,

        [System.Runtime.Serialization.EnumMember(Value = @"CPV")]
        CPV = 40,

        [System.Runtime.Serialization.EnumMember(Value = @"CRI")]
        CRI = 41,

        [System.Runtime.Serialization.EnumMember(Value = @"CUB")]
        CUB = 42,

        [System.Runtime.Serialization.EnumMember(Value = @"CUW")]
        CUW = 43,

        [System.Runtime.Serialization.EnumMember(Value = @"CYP")]
        CYP = 44,

        [System.Runtime.Serialization.EnumMember(Value = @"CZE")]
        CZE = 45,

        [System.Runtime.Serialization.EnumMember(Value = @"DEU")]
        DEU = 46,

        [System.Runtime.Serialization.EnumMember(Value = @"DJI")]
        DJI = 47,

        [System.Runtime.Serialization.EnumMember(Value = @"DMA")]
        DMA = 48,

        [System.Runtime.Serialization.EnumMember(Value = @"DNK")]
        DNK = 49,

        [System.Runtime.Serialization.EnumMember(Value = @"DOM")]
        DOM = 50,

        [System.Runtime.Serialization.EnumMember(Value = @"DZA")]
        DZA = 51,

        [System.Runtime.Serialization.EnumMember(Value = @"ECU")]
        ECU = 52,

        [System.Runtime.Serialization.EnumMember(Value = @"EGY")]
        EGY = 53,

        [System.Runtime.Serialization.EnumMember(Value = @"ERI")]
        ERI = 54,

        [System.Runtime.Serialization.EnumMember(Value = @"ESH")]
        ESH = 55,

        [System.Runtime.Serialization.EnumMember(Value = @"ESP")]
        ESP = 56,

        [System.Runtime.Serialization.EnumMember(Value = @"EST")]
        EST = 57,

        [System.Runtime.Serialization.EnumMember(Value = @"ETH")]
        ETH = 58,

        [System.Runtime.Serialization.EnumMember(Value = @"FIN")]
        FIN = 59,

        [System.Runtime.Serialization.EnumMember(Value = @"FJI")]
        FJI = 60,

        [System.Runtime.Serialization.EnumMember(Value = @"FRA")]
        FRA = 61,

        [System.Runtime.Serialization.EnumMember(Value = @"FSM")]
        FSM = 62,

        [System.Runtime.Serialization.EnumMember(Value = @"GAB")]
        GAB = 63,

        [System.Runtime.Serialization.EnumMember(Value = @"GBR")]
        GBR = 64,

        [System.Runtime.Serialization.EnumMember(Value = @"GEO")]
        GEO = 65,

        [System.Runtime.Serialization.EnumMember(Value = @"GHA")]
        GHA = 66,

        [System.Runtime.Serialization.EnumMember(Value = @"GIN")]
        GIN = 67,

        [System.Runtime.Serialization.EnumMember(Value = @"GLP")]
        GLP = 68,

        [System.Runtime.Serialization.EnumMember(Value = @"GMB")]
        GMB = 69,

        [System.Runtime.Serialization.EnumMember(Value = @"GNB")]
        GNB = 70,

        [System.Runtime.Serialization.EnumMember(Value = @"GNQ")]
        GNQ = 71,

        [System.Runtime.Serialization.EnumMember(Value = @"GRC")]
        GRC = 72,

        [System.Runtime.Serialization.EnumMember(Value = @"GRD")]
        GRD = 73,

        [System.Runtime.Serialization.EnumMember(Value = @"GTM")]
        GTM = 74,

        [System.Runtime.Serialization.EnumMember(Value = @"GUY")]
        GUY = 75,

        [System.Runtime.Serialization.EnumMember(Value = @"HND")]
        HND = 76,

        [System.Runtime.Serialization.EnumMember(Value = @"HRV")]
        HRV = 77,

        [System.Runtime.Serialization.EnumMember(Value = @"HTI")]
        HTI = 78,

        [System.Runtime.Serialization.EnumMember(Value = @"HUN")]
        HUN = 79,

        [System.Runtime.Serialization.EnumMember(Value = @"IDN")]
        IDN = 80,

        [System.Runtime.Serialization.EnumMember(Value = @"IMN")]
        IMN = 81,

        [System.Runtime.Serialization.EnumMember(Value = @"IND")]
        IND = 82,

        [System.Runtime.Serialization.EnumMember(Value = @"IRL")]
        IRL = 83,

        [System.Runtime.Serialization.EnumMember(Value = @"IRN")]
        IRN = 84,

        [System.Runtime.Serialization.EnumMember(Value = @"IRQ")]
        IRQ = 85,

        [System.Runtime.Serialization.EnumMember(Value = @"ISL")]
        ISL = 86,

        [System.Runtime.Serialization.EnumMember(Value = @"ISR")]
        ISR = 87,

        [System.Runtime.Serialization.EnumMember(Value = @"ITA")]
        ITA = 88,

        [System.Runtime.Serialization.EnumMember(Value = @"JAM")]
        JAM = 89,

        [System.Runtime.Serialization.EnumMember(Value = @"JOR")]
        JOR = 90,

        [System.Runtime.Serialization.EnumMember(Value = @"JPN")]
        JPN = 91,

        [System.Runtime.Serialization.EnumMember(Value = @"KAZ")]
        KAZ = 92,

        [System.Runtime.Serialization.EnumMember(Value = @"KEN")]
        KEN = 93,

        [System.Runtime.Serialization.EnumMember(Value = @"KGZ")]
        KGZ = 94,

        [System.Runtime.Serialization.EnumMember(Value = @"KHM")]
        KHM = 95,

        [System.Runtime.Serialization.EnumMember(Value = @"KIR")]
        KIR = 96,

        [System.Runtime.Serialization.EnumMember(Value = @"KNA")]
        KNA = 97,

        [System.Runtime.Serialization.EnumMember(Value = @"KOR")]
        KOR = 98,

        [System.Runtime.Serialization.EnumMember(Value = @"KWT")]
        KWT = 99,

        [System.Runtime.Serialization.EnumMember(Value = @"LAO")]
        LAO = 100,

        [System.Runtime.Serialization.EnumMember(Value = @"LBN")]
        LBN = 101,

        [System.Runtime.Serialization.EnumMember(Value = @"LBR")]
        LBR = 102,

        [System.Runtime.Serialization.EnumMember(Value = @"LBY")]
        LBY = 103,

        [System.Runtime.Serialization.EnumMember(Value = @"LCA")]
        LCA = 104,

        [System.Runtime.Serialization.EnumMember(Value = @"LIE")]
        LIE = 105,

        [System.Runtime.Serialization.EnumMember(Value = @"LKA")]
        LKA = 106,

        [System.Runtime.Serialization.EnumMember(Value = @"LSO")]
        LSO = 107,

        [System.Runtime.Serialization.EnumMember(Value = @"LTU")]
        LTU = 108,

        [System.Runtime.Serialization.EnumMember(Value = @"LUX")]
        LUX = 109,

        [System.Runtime.Serialization.EnumMember(Value = @"LVA")]
        LVA = 110,

        [System.Runtime.Serialization.EnumMember(Value = @"MAR")]
        MAR = 111,

        [System.Runtime.Serialization.EnumMember(Value = @"MCO")]
        MCO = 112,

        [System.Runtime.Serialization.EnumMember(Value = @"MDA")]
        MDA = 113,

        [System.Runtime.Serialization.EnumMember(Value = @"MDG")]
        MDG = 114,

        [System.Runtime.Serialization.EnumMember(Value = @"MDV")]
        MDV = 115,

        [System.Runtime.Serialization.EnumMember(Value = @"MEX")]
        MEX = 116,

        [System.Runtime.Serialization.EnumMember(Value = @"MHL")]
        MHL = 117,

        [System.Runtime.Serialization.EnumMember(Value = @"MKD")]
        MKD = 118,

        [System.Runtime.Serialization.EnumMember(Value = @"MLI")]
        MLI = 119,

        [System.Runtime.Serialization.EnumMember(Value = @"MLT")]
        MLT = 120,

        [System.Runtime.Serialization.EnumMember(Value = @"MMR")]
        MMR = 121,

        [System.Runtime.Serialization.EnumMember(Value = @"MNE")]
        MNE = 122,

        [System.Runtime.Serialization.EnumMember(Value = @"MNG")]
        MNG = 123,

        [System.Runtime.Serialization.EnumMember(Value = @"MNP")]
        MNP = 124,

        [System.Runtime.Serialization.EnumMember(Value = @"MOZ")]
        MOZ = 125,

        [System.Runtime.Serialization.EnumMember(Value = @"MRT")]
        MRT = 126,

        [System.Runtime.Serialization.EnumMember(Value = @"MUS")]
        MUS = 127,

        [System.Runtime.Serialization.EnumMember(Value = @"MWI")]
        MWI = 128,

        [System.Runtime.Serialization.EnumMember(Value = @"MYS")]
        MYS = 129,

        [System.Runtime.Serialization.EnumMember(Value = @"NAM")]
        NAM = 130,

        [System.Runtime.Serialization.EnumMember(Value = @"NER")]
        NER = 131,

        [System.Runtime.Serialization.EnumMember(Value = @"NGA")]
        NGA = 132,

        [System.Runtime.Serialization.EnumMember(Value = @"NIC")]
        NIC = 133,

        [System.Runtime.Serialization.EnumMember(Value = @"NLD")]
        NLD = 134,

        [System.Runtime.Serialization.EnumMember(Value = @"NOR")]
        NOR = 135,

        [System.Runtime.Serialization.EnumMember(Value = @"NPL")]
        NPL = 136,

        [System.Runtime.Serialization.EnumMember(Value = @"NRU")]
        NRU = 137,

        [System.Runtime.Serialization.EnumMember(Value = @"NZL")]
        NZL = 138,

        [System.Runtime.Serialization.EnumMember(Value = @"OMN")]
        OMN = 139,

        [System.Runtime.Serialization.EnumMember(Value = @"PAK")]
        PAK = 140,

        [System.Runtime.Serialization.EnumMember(Value = @"PAN")]
        PAN = 141,

        [System.Runtime.Serialization.EnumMember(Value = @"PCN")]
        PCN = 142,

        [System.Runtime.Serialization.EnumMember(Value = @"PER")]
        PER = 143,

        [System.Runtime.Serialization.EnumMember(Value = @"PHL")]
        PHL = 144,

        [System.Runtime.Serialization.EnumMember(Value = @"PLW")]
        PLW = 145,

        [System.Runtime.Serialization.EnumMember(Value = @"PNG")]
        PNG = 146,

        [System.Runtime.Serialization.EnumMember(Value = @"POL")]
        POL = 147,

        [System.Runtime.Serialization.EnumMember(Value = @"PRI")]
        PRI = 148,

        [System.Runtime.Serialization.EnumMember(Value = @"PRK")]
        PRK = 149,

        [System.Runtime.Serialization.EnumMember(Value = @"PRT")]
        PRT = 150,

        [System.Runtime.Serialization.EnumMember(Value = @"PRY")]
        PRY = 151,

        [System.Runtime.Serialization.EnumMember(Value = @"PSE")]
        PSE = 152,

        [System.Runtime.Serialization.EnumMember(Value = @"QAT")]
        QAT = 153,

        [System.Runtime.Serialization.EnumMember(Value = @"ROU")]
        ROU = 154,

        [System.Runtime.Serialization.EnumMember(Value = @"RUS")]
        RUS = 155,

        [System.Runtime.Serialization.EnumMember(Value = @"RWA")]
        RWA = 156,

        [System.Runtime.Serialization.EnumMember(Value = @"SAU")]
        SAU = 157,

        [System.Runtime.Serialization.EnumMember(Value = @"SDN")]
        SDN = 158,

        [System.Runtime.Serialization.EnumMember(Value = @"SEN")]
        SEN = 159,

        [System.Runtime.Serialization.EnumMember(Value = @"SGP")]
        SGP = 160,

        [System.Runtime.Serialization.EnumMember(Value = @"SLB")]
        SLB = 161,

        [System.Runtime.Serialization.EnumMember(Value = @"SLE")]
        SLE = 162,

        [System.Runtime.Serialization.EnumMember(Value = @"SLV")]
        SLV = 163,

        [System.Runtime.Serialization.EnumMember(Value = @"SMR")]
        SMR = 164,

        [System.Runtime.Serialization.EnumMember(Value = @"SOM")]
        SOM = 165,

        [System.Runtime.Serialization.EnumMember(Value = @"SRB")]
        SRB = 166,

        [System.Runtime.Serialization.EnumMember(Value = @"SSD")]
        SSD = 167,

        [System.Runtime.Serialization.EnumMember(Value = @"STP")]
        STP = 168,

        [System.Runtime.Serialization.EnumMember(Value = @"SUR")]
        SUR = 169,

        [System.Runtime.Serialization.EnumMember(Value = @"SVK")]
        SVK = 170,

        [System.Runtime.Serialization.EnumMember(Value = @"SVN")]
        SVN = 171,

        [System.Runtime.Serialization.EnumMember(Value = @"SWE")]
        SWE = 172,

        [System.Runtime.Serialization.EnumMember(Value = @"SWZ")]
        SWZ = 173,

        [System.Runtime.Serialization.EnumMember(Value = @"SXM")]
        SXM = 174,

        [System.Runtime.Serialization.EnumMember(Value = @"SYC")]
        SYC = 175,

        [System.Runtime.Serialization.EnumMember(Value = @"SYR")]
        SYR = 176,

        [System.Runtime.Serialization.EnumMember(Value = @"TCD")]
        TCD = 177,

        [System.Runtime.Serialization.EnumMember(Value = @"TGO")]
        TGO = 178,

        [System.Runtime.Serialization.EnumMember(Value = @"THA")]
        THA = 179,

        [System.Runtime.Serialization.EnumMember(Value = @"TJK")]
        TJK = 180,

        [System.Runtime.Serialization.EnumMember(Value = @"TKM")]
        TKM = 181,

        [System.Runtime.Serialization.EnumMember(Value = @"TLS")]
        TLS = 182,

        [System.Runtime.Serialization.EnumMember(Value = @"TON")]
        TON = 183,

        [System.Runtime.Serialization.EnumMember(Value = @"TTO")]
        TTO = 184,

        [System.Runtime.Serialization.EnumMember(Value = @"TUN")]
        TUN = 185,

        [System.Runtime.Serialization.EnumMember(Value = @"TUR")]
        TUR = 186,

        [System.Runtime.Serialization.EnumMember(Value = @"TUV")]
        TUV = 187,

        [System.Runtime.Serialization.EnumMember(Value = @"TWN")]
        TWN = 188,

        [System.Runtime.Serialization.EnumMember(Value = @"TZA")]
        TZA = 189,

        [System.Runtime.Serialization.EnumMember(Value = @"UGA")]
        UGA = 190,

        [System.Runtime.Serialization.EnumMember(Value = @"UKR")]
        UKR = 191,

        [System.Runtime.Serialization.EnumMember(Value = @"URY")]
        URY = 192,

        [System.Runtime.Serialization.EnumMember(Value = @"USA")]
        USA = 193,

        [System.Runtime.Serialization.EnumMember(Value = @"UZB")]
        UZB = 194,

        [System.Runtime.Serialization.EnumMember(Value = @"VAT")]
        VAT = 195,

        [System.Runtime.Serialization.EnumMember(Value = @"VCT")]
        VCT = 196,

        [System.Runtime.Serialization.EnumMember(Value = @"VEN")]
        VEN = 197,

        [System.Runtime.Serialization.EnumMember(Value = @"VNM")]
        VNM = 198,

        [System.Runtime.Serialization.EnumMember(Value = @"VUT")]
        VUT = 199,

        [System.Runtime.Serialization.EnumMember(Value = @"WSM")]
        WSM = 200,

        [System.Runtime.Serialization.EnumMember(Value = @"YEM")]
        YEM = 201,

        [System.Runtime.Serialization.EnumMember(Value = @"ZAF")]
        ZAF = 202,

        [System.Runtime.Serialization.EnumMember(Value = @"ZMB")]
        ZMB = 203,

        [System.Runtime.Serialization.EnumMember(Value = @"ZWE")]
        ZWE = 204,

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603