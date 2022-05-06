// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The ISO 4217 currency code
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LedgerActivitiesCurrency
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// AED
        /// </summary>
        [EnumMember(Value = "AED")]
        AED,

        /// <summary>
        /// AFN
        /// </summary>
        [EnumMember(Value = "AFN")]
        AFN,

        /// <summary>
        /// ALL
        /// </summary>
        [EnumMember(Value = "ALL")]
        ALL,

        /// <summary>
        /// AMD
        /// </summary>
        [EnumMember(Value = "AMD")]
        AMD,

        /// <summary>
        /// ANG
        /// </summary>
        [EnumMember(Value = "ANG")]
        ANG,

        /// <summary>
        /// AOA
        /// </summary>
        [EnumMember(Value = "AOA")]
        AOA,

        /// <summary>
        /// ARS
        /// </summary>
        [EnumMember(Value = "ARS")]
        ARS,

        /// <summary>
        /// AUD
        /// </summary>
        [EnumMember(Value = "AUD")]
        AUD,

        /// <summary>
        /// AWG
        /// </summary>
        [EnumMember(Value = "AWG")]
        AWG,

        /// <summary>
        /// AZN
        /// </summary>
        [EnumMember(Value = "AZN")]
        AZN,

        /// <summary>
        /// BAM
        /// </summary>
        [EnumMember(Value = "BAM")]
        BAM,

        /// <summary>
        /// BBD
        /// </summary>
        [EnumMember(Value = "BBD")]
        BBD,

        /// <summary>
        /// BDT
        /// </summary>
        [EnumMember(Value = "BDT")]
        BDT,

        /// <summary>
        /// BGN
        /// </summary>
        [EnumMember(Value = "BGN")]
        BGN,

        /// <summary>
        /// BHD
        /// </summary>
        [EnumMember(Value = "BHD")]
        BHD,

        /// <summary>
        /// BIF
        /// </summary>
        [EnumMember(Value = "BIF")]
        BIF,

        /// <summary>
        /// BMD
        /// </summary>
        [EnumMember(Value = "BMD")]
        BMD,

        /// <summary>
        /// BND
        /// </summary>
        [EnumMember(Value = "BND")]
        BND,

        /// <summary>
        /// BOB
        /// </summary>
        [EnumMember(Value = "BOB")]
        BOB,

        /// <summary>
        /// BRL
        /// </summary>
        [EnumMember(Value = "BRL")]
        BRL,

        /// <summary>
        /// BSD
        /// </summary>
        [EnumMember(Value = "BSD")]
        BSD,

        /// <summary>
        /// BTN
        /// </summary>
        [EnumMember(Value = "BTN")]
        BTN,

        /// <summary>
        /// BWP
        /// </summary>
        [EnumMember(Value = "BWP")]
        BWP,

        /// <summary>
        /// BYR
        /// </summary>
        [EnumMember(Value = "BYR")]
        BYR,

        /// <summary>
        /// BZD
        /// </summary>
        [EnumMember(Value = "BZD")]
        BZD,

        /// <summary>
        /// CAD
        /// </summary>
        [EnumMember(Value = "CAD")]
        CAD,

        /// <summary>
        /// CDF
        /// </summary>
        [EnumMember(Value = "CDF")]
        CDF,

        /// <summary>
        /// CHF
        /// </summary>
        [EnumMember(Value = "CHF")]
        CHF,

        /// <summary>
        /// CLP
        /// </summary>
        [EnumMember(Value = "CLP")]
        CLP,

        /// <summary>
        /// CNY
        /// </summary>
        [EnumMember(Value = "CNY")]
        CNY,

        /// <summary>
        /// COP
        /// </summary>
        [EnumMember(Value = "COP")]
        COP,

        /// <summary>
        /// CRC
        /// </summary>
        [EnumMember(Value = "CRC")]
        CRC,

        /// <summary>
        /// CUC
        /// </summary>
        [EnumMember(Value = "CUC")]
        CUC,

        /// <summary>
        /// CUP
        /// </summary>
        [EnumMember(Value = "CUP")]
        CUP,

        /// <summary>
        /// CVE
        /// </summary>
        [EnumMember(Value = "CVE")]
        CVE,

        /// <summary>
        /// CZK
        /// </summary>
        [EnumMember(Value = "CZK")]
        CZK,

        /// <summary>
        /// DJF
        /// </summary>
        [EnumMember(Value = "DJF")]
        DJF,

        /// <summary>
        /// DKK
        /// </summary>
        [EnumMember(Value = "DKK")]
        DKK,

        /// <summary>
        /// DOP
        /// </summary>
        [EnumMember(Value = "DOP")]
        DOP,

        /// <summary>
        /// DZD
        /// </summary>
        [EnumMember(Value = "DZD")]
        DZD,

        /// <summary>
        /// EGP
        /// </summary>
        [EnumMember(Value = "EGP")]
        EGP,

        /// <summary>
        /// ERN
        /// </summary>
        [EnumMember(Value = "ERN")]
        ERN,

        /// <summary>
        /// ETB
        /// </summary>
        [EnumMember(Value = "ETB")]
        ETB,

        /// <summary>
        /// EUR
        /// </summary>
        [EnumMember(Value = "EUR")]
        EUR,

        /// <summary>
        /// FJD
        /// </summary>
        [EnumMember(Value = "FJD")]
        FJD,

        /// <summary>
        /// FKP
        /// </summary>
        [EnumMember(Value = "FKP")]
        FKP,

        /// <summary>
        /// GBP
        /// </summary>
        [EnumMember(Value = "GBP")]
        GBP,

        /// <summary>
        /// GEL
        /// </summary>
        [EnumMember(Value = "GEL")]
        GEL,

        /// <summary>
        /// GHS
        /// </summary>
        [EnumMember(Value = "GHS")]
        GHS,

        /// <summary>
        /// GIP
        /// </summary>
        [EnumMember(Value = "GIP")]
        GIP,

        /// <summary>
        /// GMD
        /// </summary>
        [EnumMember(Value = "GMD")]
        GMD,

        /// <summary>
        /// GNF
        /// </summary>
        [EnumMember(Value = "GNF")]
        GNF,

        /// <summary>
        /// GTQ
        /// </summary>
        [EnumMember(Value = "GTQ")]
        GTQ,

        /// <summary>
        /// GYD
        /// </summary>
        [EnumMember(Value = "GYD")]
        GYD,

        /// <summary>
        /// HKD
        /// </summary>
        [EnumMember(Value = "HKD")]
        HKD,

        /// <summary>
        /// HNL
        /// </summary>
        [EnumMember(Value = "HNL")]
        HNL,

        /// <summary>
        /// HRK
        /// </summary>
        [EnumMember(Value = "HRK")]
        HRK,

        /// <summary>
        /// HTG
        /// </summary>
        [EnumMember(Value = "HTG")]
        HTG,

        /// <summary>
        /// HUF
        /// </summary>
        [EnumMember(Value = "HUF")]
        HUF,

        /// <summary>
        /// IDR
        /// </summary>
        [EnumMember(Value = "IDR")]
        IDR,

        /// <summary>
        /// ILS
        /// </summary>
        [EnumMember(Value = "ILS")]
        ILS,

        /// <summary>
        /// INR
        /// </summary>
        [EnumMember(Value = "INR")]
        INR,

        /// <summary>
        /// IQD
        /// </summary>
        [EnumMember(Value = "IQD")]
        IQD,

        /// <summary>
        /// IRR
        /// </summary>
        [EnumMember(Value = "IRR")]
        IRR,

        /// <summary>
        /// ISK
        /// </summary>
        [EnumMember(Value = "ISK")]
        ISK,

        /// <summary>
        /// JMD
        /// </summary>
        [EnumMember(Value = "JMD")]
        JMD,

        /// <summary>
        /// JOD
        /// </summary>
        [EnumMember(Value = "JOD")]
        JOD,

        /// <summary>
        /// JPY
        /// </summary>
        [EnumMember(Value = "JPY")]
        JPY,

        /// <summary>
        /// KES
        /// </summary>
        [EnumMember(Value = "KES")]
        KES,

        /// <summary>
        /// KGS
        /// </summary>
        [EnumMember(Value = "KGS")]
        KGS,

        /// <summary>
        /// KHR
        /// </summary>
        [EnumMember(Value = "KHR")]
        KHR,

        /// <summary>
        /// KMF
        /// </summary>
        [EnumMember(Value = "KMF")]
        KMF,

        /// <summary>
        /// KPW
        /// </summary>
        [EnumMember(Value = "KPW")]
        KPW,

        /// <summary>
        /// KRW
        /// </summary>
        [EnumMember(Value = "KRW")]
        KRW,

        /// <summary>
        /// KWD
        /// </summary>
        [EnumMember(Value = "KWD")]
        KWD,

        /// <summary>
        /// KYD
        /// </summary>
        [EnumMember(Value = "KYD")]
        KYD,

        /// <summary>
        /// KZT
        /// </summary>
        [EnumMember(Value = "KZT")]
        KZT,

        /// <summary>
        /// LAK
        /// </summary>
        [EnumMember(Value = "LAK")]
        LAK,

        /// <summary>
        /// LBP
        /// </summary>
        [EnumMember(Value = "LBP")]
        LBP,

        /// <summary>
        /// LKR
        /// </summary>
        [EnumMember(Value = "LKR")]
        LKR,

        /// <summary>
        /// LRD
        /// </summary>
        [EnumMember(Value = "LRD")]
        LRD,

        /// <summary>
        /// LSL
        /// </summary>
        [EnumMember(Value = "LSL")]
        LSL,

        /// <summary>
        /// LYD
        /// </summary>
        [EnumMember(Value = "LYD")]
        LYD,

        /// <summary>
        /// MAD
        /// </summary>
        [EnumMember(Value = "MAD")]
        MAD,

        /// <summary>
        /// MDL
        /// </summary>
        [EnumMember(Value = "MDL")]
        MDL,

        /// <summary>
        /// MGA
        /// </summary>
        [EnumMember(Value = "MGA")]
        MGA,

        /// <summary>
        /// MKD
        /// </summary>
        [EnumMember(Value = "MKD")]
        MKD,

        /// <summary>
        /// MMK
        /// </summary>
        [EnumMember(Value = "MMK")]
        MMK,

        /// <summary>
        /// MNT
        /// </summary>
        [EnumMember(Value = "MNT")]
        MNT,

        /// <summary>
        /// MOP
        /// </summary>
        [EnumMember(Value = "MOP")]
        MOP,

        /// <summary>
        /// MRO
        /// </summary>
        [EnumMember(Value = "MRO")]
        MRO,

        /// <summary>
        /// MUR
        /// </summary>
        [EnumMember(Value = "MUR")]
        MUR,

        /// <summary>
        /// MVR
        /// </summary>
        [EnumMember(Value = "MVR")]
        MVR,

        /// <summary>
        /// MWK
        /// </summary>
        [EnumMember(Value = "MWK")]
        MWK,

        /// <summary>
        /// MXN
        /// </summary>
        [EnumMember(Value = "MXN")]
        MXN,

        /// <summary>
        /// MYR
        /// </summary>
        [EnumMember(Value = "MYR")]
        MYR,

        /// <summary>
        /// MZN
        /// </summary>
        [EnumMember(Value = "MZN")]
        MZN,

        /// <summary>
        /// NAD
        /// </summary>
        [EnumMember(Value = "NAD")]
        NAD,

        /// <summary>
        /// NGN
        /// </summary>
        [EnumMember(Value = "NGN")]
        NGN,

        /// <summary>
        /// NIO
        /// </summary>
        [EnumMember(Value = "NIO")]
        NIO,

        /// <summary>
        /// NOK
        /// </summary>
        [EnumMember(Value = "NOK")]
        NOK,

        /// <summary>
        /// NPR
        /// </summary>
        [EnumMember(Value = "NPR")]
        NPR,

        /// <summary>
        /// NZD
        /// </summary>
        [EnumMember(Value = "NZD")]
        NZD,

        /// <summary>
        /// OMR
        /// </summary>
        [EnumMember(Value = "OMR")]
        OMR,

        /// <summary>
        /// PAB
        /// </summary>
        [EnumMember(Value = "PAB")]
        PAB,

        /// <summary>
        /// PEN
        /// </summary>
        [EnumMember(Value = "PEN")]
        PEN,

        /// <summary>
        /// PGK
        /// </summary>
        [EnumMember(Value = "PGK")]
        PGK,

        /// <summary>
        /// PHP
        /// </summary>
        [EnumMember(Value = "PHP")]
        PHP,

        /// <summary>
        /// PKR
        /// </summary>
        [EnumMember(Value = "PKR")]
        PKR,

        /// <summary>
        /// PLN
        /// </summary>
        [EnumMember(Value = "PLN")]
        PLN,

        /// <summary>
        /// PYG
        /// </summary>
        [EnumMember(Value = "PYG")]
        PYG,

        /// <summary>
        /// QAR
        /// </summary>
        [EnumMember(Value = "QAR")]
        QAR,

        /// <summary>
        /// RON
        /// </summary>
        [EnumMember(Value = "RON")]
        RON,

        /// <summary>
        /// RSD
        /// </summary>
        [EnumMember(Value = "RSD")]
        RSD,

        /// <summary>
        /// RUB
        /// </summary>
        [EnumMember(Value = "RUB")]
        RUB,

        /// <summary>
        /// RWF
        /// </summary>
        [EnumMember(Value = "RWF")]
        RWF,

        /// <summary>
        /// SAR
        /// </summary>
        [EnumMember(Value = "SAR")]
        SAR,

        /// <summary>
        /// SBD
        /// </summary>
        [EnumMember(Value = "SBD")]
        SBD,

        /// <summary>
        /// SCR
        /// </summary>
        [EnumMember(Value = "SCR")]
        SCR,

        /// <summary>
        /// SDG
        /// </summary>
        [EnumMember(Value = "SDG")]
        SDG,

        /// <summary>
        /// SEK
        /// </summary>
        [EnumMember(Value = "SEK")]
        SEK,

        /// <summary>
        /// SGD
        /// </summary>
        [EnumMember(Value = "SGD")]
        SGD,

        /// <summary>
        /// SHP
        /// </summary>
        [EnumMember(Value = "SHP")]
        SHP,

        /// <summary>
        /// SLL
        /// </summary>
        [EnumMember(Value = "SLL")]
        SLL,

        /// <summary>
        /// SOS
        /// </summary>
        [EnumMember(Value = "SOS")]
        SOS,

        /// <summary>
        /// SRD
        /// </summary>
        [EnumMember(Value = "SRD")]
        SRD,

        /// <summary>
        /// SSP
        /// </summary>
        [EnumMember(Value = "SSP")]
        SSP,

        /// <summary>
        /// STD
        /// </summary>
        [EnumMember(Value = "STD")]
        STD,

        /// <summary>
        /// SVC
        /// </summary>
        [EnumMember(Value = "SVC")]
        SVC,

        /// <summary>
        /// SYP
        /// </summary>
        [EnumMember(Value = "SYP")]
        SYP,

        /// <summary>
        /// SZL
        /// </summary>
        [EnumMember(Value = "SZL")]
        SZL,

        /// <summary>
        /// THB
        /// </summary>
        [EnumMember(Value = "THB")]
        THB,

        /// <summary>
        /// TJS
        /// </summary>
        [EnumMember(Value = "TJS")]
        TJS,

        /// <summary>
        /// TMT
        /// </summary>
        [EnumMember(Value = "TMT")]
        TMT,

        /// <summary>
        /// TND
        /// </summary>
        [EnumMember(Value = "TND")]
        TND,

        /// <summary>
        /// TOP
        /// </summary>
        [EnumMember(Value = "TOP")]
        TOP,

        /// <summary>
        /// TRY
        /// </summary>
        [EnumMember(Value = "TRY")]
        TRY,

        /// <summary>
        /// TTD
        /// </summary>
        [EnumMember(Value = "TTD")]
        TTD,

        /// <summary>
        /// TWD
        /// </summary>
        [EnumMember(Value = "TWD")]
        TWD,

        /// <summary>
        /// TZS
        /// </summary>
        [EnumMember(Value = "TZS")]
        TZS,

        /// <summary>
        /// UAH
        /// </summary>
        [EnumMember(Value = "UAH")]
        UAH,

        /// <summary>
        /// UGX
        /// </summary>
        [EnumMember(Value = "UGX")]
        UGX,

        /// <summary>
        /// USD
        /// </summary>
        [EnumMember(Value = "USD")]
        USD,

        /// <summary>
        /// UYU
        /// </summary>
        [EnumMember(Value = "UYU")]
        UYU,

        /// <summary>
        /// UZS
        /// </summary>
        [EnumMember(Value = "UZS")]
        UZS,

        /// <summary>
        /// VEF
        /// </summary>
        [EnumMember(Value = "VEF")]
        VEF,

        /// <summary>
        /// VND
        /// </summary>
        [EnumMember(Value = "VND")]
        VND,

        /// <summary>
        /// VUV
        /// </summary>
        [EnumMember(Value = "VUV")]
        VUV,

        /// <summary>
        /// WST
        /// </summary>
        [EnumMember(Value = "WST")]
        WST,

        /// <summary>
        /// XAF
        /// </summary>
        [EnumMember(Value = "XAF")]
        XAF,

        /// <summary>
        /// XCD
        /// </summary>
        [EnumMember(Value = "XCD")]
        XCD,

        /// <summary>
        /// XOF
        /// </summary>
        [EnumMember(Value = "XOF")]
        XOF,

        /// <summary>
        /// XPF
        /// </summary>
        [EnumMember(Value = "XPF")]
        XPF,

        /// <summary>
        /// YER
        /// </summary>
        [EnumMember(Value = "YER")]
        YER,

        /// <summary>
        /// ZAR
        /// </summary>
        [EnumMember(Value = "ZAR")]
        ZAR,

        /// <summary>
        /// ZMW
        /// </summary>
        [EnumMember(Value = "ZMW")]
        ZMW,

        /// <summary>
        /// ZWL
        /// </summary>
        [EnumMember(Value = "ZWL")]
        ZWL,
    }
} 


