// Copyright 2017-2019 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Person language codes based on the ISO 639-3 alpha-3 language code
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonLanguageCode
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// aar
        /// </summary>
        [EnumMember(Value = "aar")]
        aar,

        /// <summary>
        /// abk
        /// </summary>
        [EnumMember(Value = "abk")]
        abk,

        /// <summary>
        /// ace
        /// </summary>
        [EnumMember(Value = "ace")]
        ace,

        /// <summary>
        /// ach
        /// </summary>
        [EnumMember(Value = "ach")]
        ach,

        /// <summary>
        /// ada
        /// </summary>
        [EnumMember(Value = "ada")]
        ada,

        /// <summary>
        /// ady
        /// </summary>
        [EnumMember(Value = "ady")]
        ady,

        /// <summary>
        /// afa
        /// </summary>
        [EnumMember(Value = "afa")]
        afa,

        /// <summary>
        /// afh
        /// </summary>
        [EnumMember(Value = "afh")]
        afh,

        /// <summary>
        /// afr
        /// </summary>
        [EnumMember(Value = "afr")]
        afr,

        /// <summary>
        /// ain
        /// </summary>
        [EnumMember(Value = "ain")]
        ain,

        /// <summary>
        /// aka
        /// </summary>
        [EnumMember(Value = "aka")]
        aka,

        /// <summary>
        /// akk
        /// </summary>
        [EnumMember(Value = "akk")]
        akk,

        /// <summary>
        /// alb
        /// </summary>
        [EnumMember(Value = "alb")]
        alb,

        /// <summary>
        /// ale
        /// </summary>
        [EnumMember(Value = "ale")]
        ale,

        /// <summary>
        /// alg
        /// </summary>
        [EnumMember(Value = "alg")]
        alg,

        /// <summary>
        /// alt
        /// </summary>
        [EnumMember(Value = "alt")]
        alt,

        /// <summary>
        /// amh
        /// </summary>
        [EnumMember(Value = "amh")]
        amh,

        /// <summary>
        /// ang
        /// </summary>
        [EnumMember(Value = "ang")]
        ang,

        /// <summary>
        /// anp
        /// </summary>
        [EnumMember(Value = "anp")]
        anp,

        /// <summary>
        /// apa
        /// </summary>
        [EnumMember(Value = "apa")]
        apa,

        /// <summary>
        /// ara
        /// </summary>
        [EnumMember(Value = "ara")]
        ara,

        /// <summary>
        /// arc
        /// </summary>
        [EnumMember(Value = "arc")]
        arc,

        /// <summary>
        /// arg
        /// </summary>
        [EnumMember(Value = "arg")]
        arg,

        /// <summary>
        /// arm
        /// </summary>
        [EnumMember(Value = "arm")]
        arm,

        /// <summary>
        /// arn
        /// </summary>
        [EnumMember(Value = "arn")]
        arn,

        /// <summary>
        /// arp
        /// </summary>
        [EnumMember(Value = "arp")]
        arp,

        /// <summary>
        /// art
        /// </summary>
        [EnumMember(Value = "art")]
        art,

        /// <summary>
        /// arw
        /// </summary>
        [EnumMember(Value = "arw")]
        arw,

        /// <summary>
        /// asm
        /// </summary>
        [EnumMember(Value = "asm")]
        asm,

        /// <summary>
        /// ast
        /// </summary>
        [EnumMember(Value = "ast")]
        ast,

        /// <summary>
        /// ath
        /// </summary>
        [EnumMember(Value = "ath")]
        ath,

        /// <summary>
        /// aus
        /// </summary>
        [EnumMember(Value = "aus")]
        aus,

        /// <summary>
        /// ava
        /// </summary>
        [EnumMember(Value = "ava")]
        ava,

        /// <summary>
        /// ave
        /// </summary>
        [EnumMember(Value = "ave")]
        ave,

        /// <summary>
        /// awa
        /// </summary>
        [EnumMember(Value = "awa")]
        awa,

        /// <summary>
        /// aym
        /// </summary>
        [EnumMember(Value = "aym")]
        aym,

        /// <summary>
        /// aze
        /// </summary>
        [EnumMember(Value = "aze")]
        aze,

        /// <summary>
        /// bad
        /// </summary>
        [EnumMember(Value = "bad")]
        bad,

        /// <summary>
        /// bai
        /// </summary>
        [EnumMember(Value = "bai")]
        bai,

        /// <summary>
        /// bak
        /// </summary>
        [EnumMember(Value = "bak")]
        bak,

        /// <summary>
        /// bal
        /// </summary>
        [EnumMember(Value = "bal")]
        bal,

        /// <summary>
        /// bam
        /// </summary>
        [EnumMember(Value = "bam")]
        bam,

        /// <summary>
        /// ban
        /// </summary>
        [EnumMember(Value = "ban")]
        ban,

        /// <summary>
        /// baq
        /// </summary>
        [EnumMember(Value = "baq")]
        baq,

        /// <summary>
        /// bas
        /// </summary>
        [EnumMember(Value = "bas")]
        bas,

        /// <summary>
        /// bat
        /// </summary>
        [EnumMember(Value = "bat")]
        bat,

        /// <summary>
        /// bej
        /// </summary>
        [EnumMember(Value = "bej")]
        bej,

        /// <summary>
        /// bel
        /// </summary>
        [EnumMember(Value = "bel")]
        bel,

        /// <summary>
        /// bem
        /// </summary>
        [EnumMember(Value = "bem")]
        bem,

        /// <summary>
        /// ben
        /// </summary>
        [EnumMember(Value = "ben")]
        ben,

        /// <summary>
        /// ber
        /// </summary>
        [EnumMember(Value = "ber")]
        ber,

        /// <summary>
        /// bho
        /// </summary>
        [EnumMember(Value = "bho")]
        bho,

        /// <summary>
        /// bih
        /// </summary>
        [EnumMember(Value = "bih")]
        bih,

        /// <summary>
        /// bik
        /// </summary>
        [EnumMember(Value = "bik")]
        bik,

        /// <summary>
        /// bin
        /// </summary>
        [EnumMember(Value = "bin")]
        bin,

        /// <summary>
        /// bis
        /// </summary>
        [EnumMember(Value = "bis")]
        bis,

        /// <summary>
        /// bla
        /// </summary>
        [EnumMember(Value = "bla")]
        bla,

        /// <summary>
        /// bnt
        /// </summary>
        [EnumMember(Value = "bnt")]
        bnt,

        /// <summary>
        /// bos
        /// </summary>
        [EnumMember(Value = "bos")]
        bos,

        /// <summary>
        /// bra
        /// </summary>
        [EnumMember(Value = "bra")]
        bra,

        /// <summary>
        /// bre
        /// </summary>
        [EnumMember(Value = "bre")]
        bre,

        /// <summary>
        /// btk
        /// </summary>
        [EnumMember(Value = "btk")]
        btk,

        /// <summary>
        /// bua
        /// </summary>
        [EnumMember(Value = "bua")]
        bua,

        /// <summary>
        /// bug
        /// </summary>
        [EnumMember(Value = "bug")]
        bug,

        /// <summary>
        /// bul
        /// </summary>
        [EnumMember(Value = "bul")]
        bul,

        /// <summary>
        /// bur
        /// </summary>
        [EnumMember(Value = "bur")]
        bur,

        /// <summary>
        /// byn
        /// </summary>
        [EnumMember(Value = "byn")]
        byn,

        /// <summary>
        /// cad
        /// </summary>
        [EnumMember(Value = "cad")]
        cad,

        /// <summary>
        /// cai
        /// </summary>
        [EnumMember(Value = "cai")]
        cai,

        /// <summary>
        /// car
        /// </summary>
        [EnumMember(Value = "car")]
        car,

        /// <summary>
        /// cat
        /// </summary>
        [EnumMember(Value = "cat")]
        cat,

        /// <summary>
        /// cau
        /// </summary>
        [EnumMember(Value = "cau")]
        cau,

        /// <summary>
        /// ceb
        /// </summary>
        [EnumMember(Value = "ceb")]
        ceb,

        /// <summary>
        /// cel
        /// </summary>
        [EnumMember(Value = "cel")]
        cel,

        /// <summary>
        /// cha
        /// </summary>
        [EnumMember(Value = "cha")]
        cha,

        /// <summary>
        /// chb
        /// </summary>
        [EnumMember(Value = "chb")]
        chb,

        /// <summary>
        /// che
        /// </summary>
        [EnumMember(Value = "che")]
        che,

        /// <summary>
        /// chg
        /// </summary>
        [EnumMember(Value = "chg")]
        chg,

        /// <summary>
        /// chi
        /// </summary>
        [EnumMember(Value = "chi")]
        chi,

        /// <summary>
        /// chk
        /// </summary>
        [EnumMember(Value = "chk")]
        chk,

        /// <summary>
        /// chm
        /// </summary>
        [EnumMember(Value = "chm")]
        chm,

        /// <summary>
        /// chn
        /// </summary>
        [EnumMember(Value = "chn")]
        chn,

        /// <summary>
        /// cho
        /// </summary>
        [EnumMember(Value = "cho")]
        cho,

        /// <summary>
        /// chp
        /// </summary>
        [EnumMember(Value = "chp")]
        chp,

        /// <summary>
        /// chr
        /// </summary>
        [EnumMember(Value = "chr")]
        chr,

        /// <summary>
        /// chu
        /// </summary>
        [EnumMember(Value = "chu")]
        chu,

        /// <summary>
        /// chv
        /// </summary>
        [EnumMember(Value = "chv")]
        chv,

        /// <summary>
        /// chy
        /// </summary>
        [EnumMember(Value = "chy")]
        chy,

        /// <summary>
        /// cmc
        /// </summary>
        [EnumMember(Value = "cmc")]
        cmc,

        /// <summary>
        /// cnr
        /// </summary>
        [EnumMember(Value = "cnr")]
        cnr,

        /// <summary>
        /// cop
        /// </summary>
        [EnumMember(Value = "cop")]
        cop,

        /// <summary>
        /// cor
        /// </summary>
        [EnumMember(Value = "cor")]
        cor,

        /// <summary>
        /// cos
        /// </summary>
        [EnumMember(Value = "cos")]
        cos,

        /// <summary>
        /// cpe
        /// </summary>
        [EnumMember(Value = "cpe")]
        cpe,

        /// <summary>
        /// cpf
        /// </summary>
        [EnumMember(Value = "cpf")]
        cpf,

        /// <summary>
        /// cpp
        /// </summary>
        [EnumMember(Value = "cpp")]
        cpp,

        /// <summary>
        /// cre
        /// </summary>
        [EnumMember(Value = "cre")]
        cre,

        /// <summary>
        /// crh
        /// </summary>
        [EnumMember(Value = "crh")]
        crh,

        /// <summary>
        /// crp
        /// </summary>
        [EnumMember(Value = "crp")]
        crp,

        /// <summary>
        /// csb
        /// </summary>
        [EnumMember(Value = "csb")]
        csb,

        /// <summary>
        /// cus
        /// </summary>
        [EnumMember(Value = "cus")]
        cus,

        /// <summary>
        /// cze
        /// </summary>
        [EnumMember(Value = "cze")]
        cze,

        /// <summary>
        /// dak
        /// </summary>
        [EnumMember(Value = "dak")]
        dak,

        /// <summary>
        /// dan
        /// </summary>
        [EnumMember(Value = "dan")]
        dan,

        /// <summary>
        /// dar
        /// </summary>
        [EnumMember(Value = "dar")]
        dar,

        /// <summary>
        /// day
        /// </summary>
        [EnumMember(Value = "day")]
        day,

        /// <summary>
        /// del
        /// </summary>
        [EnumMember(Value = "del")]
        del,

        /// <summary>
        /// den
        /// </summary>
        [EnumMember(Value = "den")]
        den,

        /// <summary>
        /// dgr
        /// </summary>
        [EnumMember(Value = "dgr")]
        dgr,

        /// <summary>
        /// din
        /// </summary>
        [EnumMember(Value = "din")]
        din,

        /// <summary>
        /// div
        /// </summary>
        [EnumMember(Value = "div")]
        div,

        /// <summary>
        /// doi
        /// </summary>
        [EnumMember(Value = "doi")]
        doi,

        /// <summary>
        /// dra
        /// </summary>
        [EnumMember(Value = "dra")]
        dra,

        /// <summary>
        /// dsb
        /// </summary>
        [EnumMember(Value = "dsb")]
        dsb,

        /// <summary>
        /// dua
        /// </summary>
        [EnumMember(Value = "dua")]
        dua,

        /// <summary>
        /// dum
        /// </summary>
        [EnumMember(Value = "dum")]
        dum,

        /// <summary>
        /// dut
        /// </summary>
        [EnumMember(Value = "dut")]
        dut,

        /// <summary>
        /// dyu
        /// </summary>
        [EnumMember(Value = "dyu")]
        dyu,

        /// <summary>
        /// dzo
        /// </summary>
        [EnumMember(Value = "dzo")]
        dzo,

        /// <summary>
        /// efi
        /// </summary>
        [EnumMember(Value = "efi")]
        efi,

        /// <summary>
        /// egy
        /// </summary>
        [EnumMember(Value = "egy")]
        egy,

        /// <summary>
        /// eka
        /// </summary>
        [EnumMember(Value = "eka")]
        eka,

        /// <summary>
        /// elx
        /// </summary>
        [EnumMember(Value = "elx")]
        elx,

        /// <summary>
        /// eng
        /// </summary>
        [EnumMember(Value = "eng")]
        eng,

        /// <summary>
        /// enm
        /// </summary>
        [EnumMember(Value = "enm")]
        enm,

        /// <summary>
        /// epo
        /// </summary>
        [EnumMember(Value = "epo")]
        epo,

        /// <summary>
        /// est
        /// </summary>
        [EnumMember(Value = "est")]
        est,

        /// <summary>
        /// ewe
        /// </summary>
        [EnumMember(Value = "ewe")]
        ewe,

        /// <summary>
        /// ewo
        /// </summary>
        [EnumMember(Value = "ewo")]
        ewo,

        /// <summary>
        /// fan
        /// </summary>
        [EnumMember(Value = "fan")]
        fan,

        /// <summary>
        /// fao
        /// </summary>
        [EnumMember(Value = "fao")]
        fao,

        /// <summary>
        /// fat
        /// </summary>
        [EnumMember(Value = "fat")]
        fat,

        /// <summary>
        /// fij
        /// </summary>
        [EnumMember(Value = "fij")]
        fij,

        /// <summary>
        /// fil
        /// </summary>
        [EnumMember(Value = "fil")]
        fil,

        /// <summary>
        /// fin
        /// </summary>
        [EnumMember(Value = "fin")]
        fin,

        /// <summary>
        /// fiu
        /// </summary>
        [EnumMember(Value = "fiu")]
        fiu,

        /// <summary>
        /// fon
        /// </summary>
        [EnumMember(Value = "fon")]
        fon,

        /// <summary>
        /// fre
        /// </summary>
        [EnumMember(Value = "fre")]
        fre,

        /// <summary>
        /// frm
        /// </summary>
        [EnumMember(Value = "frm")]
        frm,

        /// <summary>
        /// fro
        /// </summary>
        [EnumMember(Value = "fro")]
        fro,

        /// <summary>
        /// frr
        /// </summary>
        [EnumMember(Value = "frr")]
        frr,

        /// <summary>
        /// frs
        /// </summary>
        [EnumMember(Value = "frs")]
        frs,

        /// <summary>
        /// fry
        /// </summary>
        [EnumMember(Value = "fry")]
        fry,

        /// <summary>
        /// ful
        /// </summary>
        [EnumMember(Value = "ful")]
        ful,

        /// <summary>
        /// fur
        /// </summary>
        [EnumMember(Value = "fur")]
        fur,

        /// <summary>
        /// gaa
        /// </summary>
        [EnumMember(Value = "gaa")]
        gaa,

        /// <summary>
        /// gay
        /// </summary>
        [EnumMember(Value = "gay")]
        gay,

        /// <summary>
        /// gba
        /// </summary>
        [EnumMember(Value = "gba")]
        gba,

        /// <summary>
        /// gem
        /// </summary>
        [EnumMember(Value = "gem")]
        gem,

        /// <summary>
        /// geo
        /// </summary>
        [EnumMember(Value = "geo")]
        geo,

        /// <summary>
        /// ger
        /// </summary>
        [EnumMember(Value = "ger")]
        ger,

        /// <summary>
        /// gez
        /// </summary>
        [EnumMember(Value = "gez")]
        gez,

        /// <summary>
        /// gil
        /// </summary>
        [EnumMember(Value = "gil")]
        gil,

        /// <summary>
        /// gla
        /// </summary>
        [EnumMember(Value = "gla")]
        gla,

        /// <summary>
        /// gle
        /// </summary>
        [EnumMember(Value = "gle")]
        gle,

        /// <summary>
        /// glg
        /// </summary>
        [EnumMember(Value = "glg")]
        glg,

        /// <summary>
        /// glv
        /// </summary>
        [EnumMember(Value = "glv")]
        glv,

        /// <summary>
        /// gmh
        /// </summary>
        [EnumMember(Value = "gmh")]
        gmh,

        /// <summary>
        /// goh
        /// </summary>
        [EnumMember(Value = "goh")]
        goh,

        /// <summary>
        /// gon
        /// </summary>
        [EnumMember(Value = "gon")]
        gon,

        /// <summary>
        /// gor
        /// </summary>
        [EnumMember(Value = "gor")]
        gor,

        /// <summary>
        /// got
        /// </summary>
        [EnumMember(Value = "got")]
        got,

        /// <summary>
        /// grb
        /// </summary>
        [EnumMember(Value = "grb")]
        grb,

        /// <summary>
        /// grc
        /// </summary>
        [EnumMember(Value = "grc")]
        grc,

        /// <summary>
        /// gre
        /// </summary>
        [EnumMember(Value = "gre")]
        gre,

        /// <summary>
        /// grn
        /// </summary>
        [EnumMember(Value = "grn")]
        grn,

        /// <summary>
        /// gsw
        /// </summary>
        [EnumMember(Value = "gsw")]
        gsw,

        /// <summary>
        /// guj
        /// </summary>
        [EnumMember(Value = "guj")]
        guj,

        /// <summary>
        /// gwi
        /// </summary>
        [EnumMember(Value = "gwi")]
        gwi,

        /// <summary>
        /// hai
        /// </summary>
        [EnumMember(Value = "hai")]
        hai,

        /// <summary>
        /// hat
        /// </summary>
        [EnumMember(Value = "hat")]
        hat,

        /// <summary>
        /// hau
        /// </summary>
        [EnumMember(Value = "hau")]
        hau,

        /// <summary>
        /// haw
        /// </summary>
        [EnumMember(Value = "haw")]
        haw,

        /// <summary>
        /// heb
        /// </summary>
        [EnumMember(Value = "heb")]
        heb,

        /// <summary>
        /// her
        /// </summary>
        [EnumMember(Value = "her")]
        her,

        /// <summary>
        /// hil
        /// </summary>
        [EnumMember(Value = "hil")]
        hil,

        /// <summary>
        /// him
        /// </summary>
        [EnumMember(Value = "him")]
        him,

        /// <summary>
        /// hin
        /// </summary>
        [EnumMember(Value = "hin")]
        hin,

        /// <summary>
        /// hit
        /// </summary>
        [EnumMember(Value = "hit")]
        hit,

        /// <summary>
        /// hmn
        /// </summary>
        [EnumMember(Value = "hmn")]
        hmn,

        /// <summary>
        /// hmo
        /// </summary>
        [EnumMember(Value = "hmo")]
        hmo,

        /// <summary>
        /// hrv
        /// </summary>
        [EnumMember(Value = "hrv")]
        hrv,

        /// <summary>
        /// hsb
        /// </summary>
        [EnumMember(Value = "hsb")]
        hsb,

        /// <summary>
        /// hun
        /// </summary>
        [EnumMember(Value = "hun")]
        hun,

        /// <summary>
        /// hup
        /// </summary>
        [EnumMember(Value = "hup")]
        hup,

        /// <summary>
        /// iba
        /// </summary>
        [EnumMember(Value = "iba")]
        iba,

        /// <summary>
        /// ibo
        /// </summary>
        [EnumMember(Value = "ibo")]
        ibo,

        /// <summary>
        /// ice
        /// </summary>
        [EnumMember(Value = "ice")]
        ice,

        /// <summary>
        /// ido
        /// </summary>
        [EnumMember(Value = "ido")]
        ido,

        /// <summary>
        /// iii
        /// </summary>
        [EnumMember(Value = "iii")]
        iii,

        /// <summary>
        /// ijo
        /// </summary>
        [EnumMember(Value = "ijo")]
        ijo,

        /// <summary>
        /// iku
        /// </summary>
        [EnumMember(Value = "iku")]
        iku,

        /// <summary>
        /// ile
        /// </summary>
        [EnumMember(Value = "ile")]
        ile,

        /// <summary>
        /// ilo
        /// </summary>
        [EnumMember(Value = "ilo")]
        ilo,

        /// <summary>
        /// ina
        /// </summary>
        [EnumMember(Value = "ina")]
        ina,

        /// <summary>
        /// inc
        /// </summary>
        [EnumMember(Value = "inc")]
        inc,

        /// <summary>
        /// ind
        /// </summary>
        [EnumMember(Value = "ind")]
        ind,

        /// <summary>
        /// ine
        /// </summary>
        [EnumMember(Value = "ine")]
        ine,

        /// <summary>
        /// inh
        /// </summary>
        [EnumMember(Value = "inh")]
        inh,

        /// <summary>
        /// ipk
        /// </summary>
        [EnumMember(Value = "ipk")]
        ipk,

        /// <summary>
        /// ira
        /// </summary>
        [EnumMember(Value = "ira")]
        ira,

        /// <summary>
        /// iro
        /// </summary>
        [EnumMember(Value = "iro")]
        iro,

        /// <summary>
        /// ita
        /// </summary>
        [EnumMember(Value = "ita")]
        ita,

        /// <summary>
        /// jav
        /// </summary>
        [EnumMember(Value = "jav")]
        jav,

        /// <summary>
        /// jbo
        /// </summary>
        [EnumMember(Value = "jbo")]
        jbo,

        /// <summary>
        /// jpn
        /// </summary>
        [EnumMember(Value = "jpn")]
        jpn,

        /// <summary>
        /// jpr
        /// </summary>
        [EnumMember(Value = "jpr")]
        jpr,

        /// <summary>
        /// jrb
        /// </summary>
        [EnumMember(Value = "jrb")]
        jrb,

        /// <summary>
        /// kaa
        /// </summary>
        [EnumMember(Value = "kaa")]
        kaa,

        /// <summary>
        /// kab
        /// </summary>
        [EnumMember(Value = "kab")]
        kab,

        /// <summary>
        /// kac
        /// </summary>
        [EnumMember(Value = "kac")]
        kac,

        /// <summary>
        /// kal
        /// </summary>
        [EnumMember(Value = "kal")]
        kal,

        /// <summary>
        /// kam
        /// </summary>
        [EnumMember(Value = "kam")]
        kam,

        /// <summary>
        /// kan
        /// </summary>
        [EnumMember(Value = "kan")]
        kan,

        /// <summary>
        /// kar
        /// </summary>
        [EnumMember(Value = "kar")]
        kar,

        /// <summary>
        /// kas
        /// </summary>
        [EnumMember(Value = "kas")]
        kas,

        /// <summary>
        /// kau
        /// </summary>
        [EnumMember(Value = "kau")]
        kau,

        /// <summary>
        /// kaw
        /// </summary>
        [EnumMember(Value = "kaw")]
        kaw,

        /// <summary>
        /// kaz
        /// </summary>
        [EnumMember(Value = "kaz")]
        kaz,

        /// <summary>
        /// kbd
        /// </summary>
        [EnumMember(Value = "kbd")]
        kbd,

        /// <summary>
        /// kha
        /// </summary>
        [EnumMember(Value = "kha")]
        kha,

        /// <summary>
        /// khi
        /// </summary>
        [EnumMember(Value = "khi")]
        khi,

        /// <summary>
        /// khm
        /// </summary>
        [EnumMember(Value = "khm")]
        khm,

        /// <summary>
        /// kho
        /// </summary>
        [EnumMember(Value = "kho")]
        kho,

        /// <summary>
        /// kik
        /// </summary>
        [EnumMember(Value = "kik")]
        kik,

        /// <summary>
        /// kin
        /// </summary>
        [EnumMember(Value = "kin")]
        kin,

        /// <summary>
        /// kir
        /// </summary>
        [EnumMember(Value = "kir")]
        kir,

        /// <summary>
        /// kmb
        /// </summary>
        [EnumMember(Value = "kmb")]
        kmb,

        /// <summary>
        /// kok
        /// </summary>
        [EnumMember(Value = "kok")]
        kok,

        /// <summary>
        /// kom
        /// </summary>
        [EnumMember(Value = "kom")]
        kom,

        /// <summary>
        /// kon
        /// </summary>
        [EnumMember(Value = "kon")]
        kon,

        /// <summary>
        /// kor
        /// </summary>
        [EnumMember(Value = "kor")]
        kor,

        /// <summary>
        /// kos
        /// </summary>
        [EnumMember(Value = "kos")]
        kos,

        /// <summary>
        /// kpe
        /// </summary>
        [EnumMember(Value = "kpe")]
        kpe,

        /// <summary>
        /// krc
        /// </summary>
        [EnumMember(Value = "krc")]
        krc,

        /// <summary>
        /// krl
        /// </summary>
        [EnumMember(Value = "krl")]
        krl,

        /// <summary>
        /// kro
        /// </summary>
        [EnumMember(Value = "kro")]
        kro,

        /// <summary>
        /// kru
        /// </summary>
        [EnumMember(Value = "kru")]
        kru,

        /// <summary>
        /// kua
        /// </summary>
        [EnumMember(Value = "kua")]
        kua,

        /// <summary>
        /// kum
        /// </summary>
        [EnumMember(Value = "kum")]
        kum,

        /// <summary>
        /// kur
        /// </summary>
        [EnumMember(Value = "kur")]
        kur,

        /// <summary>
        /// kut
        /// </summary>
        [EnumMember(Value = "kut")]
        kut,

        /// <summary>
        /// lad
        /// </summary>
        [EnumMember(Value = "lad")]
        lad,

        /// <summary>
        /// lah
        /// </summary>
        [EnumMember(Value = "lah")]
        lah,

        /// <summary>
        /// lam
        /// </summary>
        [EnumMember(Value = "lam")]
        lam,

        /// <summary>
        /// lao
        /// </summary>
        [EnumMember(Value = "lao")]
        lao,

        /// <summary>
        /// lat
        /// </summary>
        [EnumMember(Value = "lat")]
        lat,

        /// <summary>
        /// lav
        /// </summary>
        [EnumMember(Value = "lav")]
        lav,

        /// <summary>
        /// lez
        /// </summary>
        [EnumMember(Value = "lez")]
        lez,

        /// <summary>
        /// lim
        /// </summary>
        [EnumMember(Value = "lim")]
        lim,

        /// <summary>
        /// lin
        /// </summary>
        [EnumMember(Value = "lin")]
        lin,

        /// <summary>
        /// lit
        /// </summary>
        [EnumMember(Value = "lit")]
        lit,

        /// <summary>
        /// lol
        /// </summary>
        [EnumMember(Value = "lol")]
        lol,

        /// <summary>
        /// loz
        /// </summary>
        [EnumMember(Value = "loz")]
        loz,

        /// <summary>
        /// ltz
        /// </summary>
        [EnumMember(Value = "ltz")]
        ltz,

        /// <summary>
        /// lua
        /// </summary>
        [EnumMember(Value = "lua")]
        lua,

        /// <summary>
        /// lub
        /// </summary>
        [EnumMember(Value = "lub")]
        lub,

        /// <summary>
        /// lug
        /// </summary>
        [EnumMember(Value = "lug")]
        lug,

        /// <summary>
        /// lui
        /// </summary>
        [EnumMember(Value = "lui")]
        lui,

        /// <summary>
        /// lun
        /// </summary>
        [EnumMember(Value = "lun")]
        lun,

        /// <summary>
        /// luo
        /// </summary>
        [EnumMember(Value = "luo")]
        luo,

        /// <summary>
        /// lus
        /// </summary>
        [EnumMember(Value = "lus")]
        lus,

        /// <summary>
        /// mac
        /// </summary>
        [EnumMember(Value = "mac")]
        mac,

        /// <summary>
        /// mad
        /// </summary>
        [EnumMember(Value = "mad")]
        mad,

        /// <summary>
        /// mag
        /// </summary>
        [EnumMember(Value = "mag")]
        mag,

        /// <summary>
        /// mah
        /// </summary>
        [EnumMember(Value = "mah")]
        mah,

        /// <summary>
        /// mai
        /// </summary>
        [EnumMember(Value = "mai")]
        mai,

        /// <summary>
        /// mak
        /// </summary>
        [EnumMember(Value = "mak")]
        mak,

        /// <summary>
        /// mal
        /// </summary>
        [EnumMember(Value = "mal")]
        mal,

        /// <summary>
        /// man
        /// </summary>
        [EnumMember(Value = "man")]
        man,

        /// <summary>
        /// mao
        /// </summary>
        [EnumMember(Value = "mao")]
        mao,

        /// <summary>
        /// map
        /// </summary>
        [EnumMember(Value = "map")]
        map,

        /// <summary>
        /// mar
        /// </summary>
        [EnumMember(Value = "mar")]
        mar,

        /// <summary>
        /// mas
        /// </summary>
        [EnumMember(Value = "mas")]
        mas,

        /// <summary>
        /// may
        /// </summary>
        [EnumMember(Value = "may")]
        may,

        /// <summary>
        /// mdf
        /// </summary>
        [EnumMember(Value = "mdf")]
        mdf,

        /// <summary>
        /// mdr
        /// </summary>
        [EnumMember(Value = "mdr")]
        mdr,

        /// <summary>
        /// men
        /// </summary>
        [EnumMember(Value = "men")]
        men,

        /// <summary>
        /// mga
        /// </summary>
        [EnumMember(Value = "mga")]
        mga,

        /// <summary>
        /// mic
        /// </summary>
        [EnumMember(Value = "mic")]
        mic,

        /// <summary>
        /// min
        /// </summary>
        [EnumMember(Value = "min")]
        min,

        /// <summary>
        /// mis
        /// </summary>
        [EnumMember(Value = "mis")]
        mis,

        /// <summary>
        /// mkh
        /// </summary>
        [EnumMember(Value = "mkh")]
        mkh,

        /// <summary>
        /// mlg
        /// </summary>
        [EnumMember(Value = "mlg")]
        mlg,

        /// <summary>
        /// mlt
        /// </summary>
        [EnumMember(Value = "mlt")]
        mlt,

        /// <summary>
        /// mnc
        /// </summary>
        [EnumMember(Value = "mnc")]
        mnc,

        /// <summary>
        /// mni
        /// </summary>
        [EnumMember(Value = "mni")]
        mni,

        /// <summary>
        /// mno
        /// </summary>
        [EnumMember(Value = "mno")]
        mno,

        /// <summary>
        /// moh
        /// </summary>
        [EnumMember(Value = "moh")]
        moh,

        /// <summary>
        /// mon
        /// </summary>
        [EnumMember(Value = "mon")]
        mon,

        /// <summary>
        /// mos
        /// </summary>
        [EnumMember(Value = "mos")]
        mos,

        /// <summary>
        /// mul
        /// </summary>
        [EnumMember(Value = "mul")]
        mul,

        /// <summary>
        /// mun
        /// </summary>
        [EnumMember(Value = "mun")]
        mun,

        /// <summary>
        /// mus
        /// </summary>
        [EnumMember(Value = "mus")]
        mus,

        /// <summary>
        /// mwl
        /// </summary>
        [EnumMember(Value = "mwl")]
        mwl,

        /// <summary>
        /// mwr
        /// </summary>
        [EnumMember(Value = "mwr")]
        mwr,

        /// <summary>
        /// myn
        /// </summary>
        [EnumMember(Value = "myn")]
        myn,

        /// <summary>
        /// myv
        /// </summary>
        [EnumMember(Value = "myv")]
        myv,

        /// <summary>
        /// nah
        /// </summary>
        [EnumMember(Value = "nah")]
        nah,

        /// <summary>
        /// nai
        /// </summary>
        [EnumMember(Value = "nai")]
        nai,

        /// <summary>
        /// nap
        /// </summary>
        [EnumMember(Value = "nap")]
        nap,

        /// <summary>
        /// nau
        /// </summary>
        [EnumMember(Value = "nau")]
        nau,

        /// <summary>
        /// nav
        /// </summary>
        [EnumMember(Value = "nav")]
        nav,

        /// <summary>
        /// nbl
        /// </summary>
        [EnumMember(Value = "nbl")]
        nbl,

        /// <summary>
        /// nde
        /// </summary>
        [EnumMember(Value = "nde")]
        nde,

        /// <summary>
        /// ndo
        /// </summary>
        [EnumMember(Value = "ndo")]
        ndo,

        /// <summary>
        /// nds
        /// </summary>
        [EnumMember(Value = "nds")]
        nds,

        /// <summary>
        /// nep
        /// </summary>
        [EnumMember(Value = "nep")]
        nep,

        /// <summary>
        /// new
        /// </summary>
        [EnumMember(Value = "new")]
        @new,

        /// <summary>
        /// nia
        /// </summary>
        [EnumMember(Value = "nia")]
        nia,

        /// <summary>
        /// nic
        /// </summary>
        [EnumMember(Value = "nic")]
        nic,

        /// <summary>
        /// niu
        /// </summary>
        [EnumMember(Value = "niu")]
        niu,

        /// <summary>
        /// nno
        /// </summary>
        [EnumMember(Value = "nno")]
        nno,

        /// <summary>
        /// nob
        /// </summary>
        [EnumMember(Value = "nob")]
        nob,

        /// <summary>
        /// nog
        /// </summary>
        [EnumMember(Value = "nog")]
        nog,

        /// <summary>
        /// non
        /// </summary>
        [EnumMember(Value = "non")]
        non,

        /// <summary>
        /// nor
        /// </summary>
        [EnumMember(Value = "nor")]
        nor,

        /// <summary>
        /// nqo
        /// </summary>
        [EnumMember(Value = "nqo")]
        nqo,

        /// <summary>
        /// nso
        /// </summary>
        [EnumMember(Value = "nso")]
        nso,

        /// <summary>
        /// nub
        /// </summary>
        [EnumMember(Value = "nub")]
        nub,

        /// <summary>
        /// nwc
        /// </summary>
        [EnumMember(Value = "nwc")]
        nwc,

        /// <summary>
        /// nya
        /// </summary>
        [EnumMember(Value = "nya")]
        nya,

        /// <summary>
        /// nym
        /// </summary>
        [EnumMember(Value = "nym")]
        nym,

        /// <summary>
        /// nyn
        /// </summary>
        [EnumMember(Value = "nyn")]
        nyn,

        /// <summary>
        /// nyo
        /// </summary>
        [EnumMember(Value = "nyo")]
        nyo,

        /// <summary>
        /// nzi
        /// </summary>
        [EnumMember(Value = "nzi")]
        nzi,

        /// <summary>
        /// oci
        /// </summary>
        [EnumMember(Value = "oci")]
        oci,

        /// <summary>
        /// oji
        /// </summary>
        [EnumMember(Value = "oji")]
        oji,

        /// <summary>
        /// ori
        /// </summary>
        [EnumMember(Value = "ori")]
        ori,

        /// <summary>
        /// orm
        /// </summary>
        [EnumMember(Value = "orm")]
        orm,

        /// <summary>
        /// osa
        /// </summary>
        [EnumMember(Value = "osa")]
        osa,

        /// <summary>
        /// oss
        /// </summary>
        [EnumMember(Value = "oss")]
        oss,

        /// <summary>
        /// ota
        /// </summary>
        [EnumMember(Value = "ota")]
        ota,

        /// <summary>
        /// oto
        /// </summary>
        [EnumMember(Value = "oto")]
        oto,

        /// <summary>
        /// paa
        /// </summary>
        [EnumMember(Value = "paa")]
        paa,

        /// <summary>
        /// pag
        /// </summary>
        [EnumMember(Value = "pag")]
        pag,

        /// <summary>
        /// pal
        /// </summary>
        [EnumMember(Value = "pal")]
        pal,

        /// <summary>
        /// pam
        /// </summary>
        [EnumMember(Value = "pam")]
        pam,

        /// <summary>
        /// pan
        /// </summary>
        [EnumMember(Value = "pan")]
        pan,

        /// <summary>
        /// pap
        /// </summary>
        [EnumMember(Value = "pap")]
        pap,

        /// <summary>
        /// pau
        /// </summary>
        [EnumMember(Value = "pau")]
        pau,

        /// <summary>
        /// peo
        /// </summary>
        [EnumMember(Value = "peo")]
        peo,

        /// <summary>
        /// per
        /// </summary>
        [EnumMember(Value = "per")]
        per,

        /// <summary>
        /// phi
        /// </summary>
        [EnumMember(Value = "phi")]
        phi,

        /// <summary>
        /// phn
        /// </summary>
        [EnumMember(Value = "phn")]
        phn,

        /// <summary>
        /// pli
        /// </summary>
        [EnumMember(Value = "pli")]
        pli,

        /// <summary>
        /// pol
        /// </summary>
        [EnumMember(Value = "pol")]
        pol,

        /// <summary>
        /// pon
        /// </summary>
        [EnumMember(Value = "pon")]
        pon,

        /// <summary>
        /// por
        /// </summary>
        [EnumMember(Value = "por")]
        por,

        /// <summary>
        /// pra
        /// </summary>
        [EnumMember(Value = "pra")]
        pra,

        /// <summary>
        /// pro
        /// </summary>
        [EnumMember(Value = "pro")]
        pro,

        /// <summary>
        /// pus
        /// </summary>
        [EnumMember(Value = "pus")]
        pus,

        /// <summary>
        /// que
        /// </summary>
        [EnumMember(Value = "que")]
        que,

        /// <summary>
        /// raj
        /// </summary>
        [EnumMember(Value = "raj")]
        raj,

        /// <summary>
        /// rap
        /// </summary>
        [EnumMember(Value = "rap")]
        rap,

        /// <summary>
        /// rar
        /// </summary>
        [EnumMember(Value = "rar")]
        rar,

        /// <summary>
        /// roa
        /// </summary>
        [EnumMember(Value = "roa")]
        roa,

        /// <summary>
        /// roh
        /// </summary>
        [EnumMember(Value = "roh")]
        roh,

        /// <summary>
        /// rom
        /// </summary>
        [EnumMember(Value = "rom")]
        rom,

        /// <summary>
        /// rum
        /// </summary>
        [EnumMember(Value = "rum")]
        rum,

        /// <summary>
        /// run
        /// </summary>
        [EnumMember(Value = "run")]
        run,

        /// <summary>
        /// rup
        /// </summary>
        [EnumMember(Value = "rup")]
        rup,

        /// <summary>
        /// rus
        /// </summary>
        [EnumMember(Value = "rus")]
        rus,

        /// <summary>
        /// sad
        /// </summary>
        [EnumMember(Value = "sad")]
        sad,

        /// <summary>
        /// sag
        /// </summary>
        [EnumMember(Value = "sag")]
        sag,

        /// <summary>
        /// sah
        /// </summary>
        [EnumMember(Value = "sah")]
        sah,

        /// <summary>
        /// sai
        /// </summary>
        [EnumMember(Value = "sai")]
        sai,

        /// <summary>
        /// sal
        /// </summary>
        [EnumMember(Value = "sal")]
        sal,

        /// <summary>
        /// sam
        /// </summary>
        [EnumMember(Value = "sam")]
        sam,

        /// <summary>
        /// san
        /// </summary>
        [EnumMember(Value = "san")]
        san,

        /// <summary>
        /// sas
        /// </summary>
        [EnumMember(Value = "sas")]
        sas,

        /// <summary>
        /// sat
        /// </summary>
        [EnumMember(Value = "sat")]
        sat,

        /// <summary>
        /// scn
        /// </summary>
        [EnumMember(Value = "scn")]
        scn,

        /// <summary>
        /// sco
        /// </summary>
        [EnumMember(Value = "sco")]
        sco,

        /// <summary>
        /// sel
        /// </summary>
        [EnumMember(Value = "sel")]
        sel,

        /// <summary>
        /// sem
        /// </summary>
        [EnumMember(Value = "sem")]
        sem,

        /// <summary>
        /// sga
        /// </summary>
        [EnumMember(Value = "sga")]
        sga,

        /// <summary>
        /// sgn
        /// </summary>
        [EnumMember(Value = "sgn")]
        sgn,

        /// <summary>
        /// shn
        /// </summary>
        [EnumMember(Value = "shn")]
        shn,

        /// <summary>
        /// sid
        /// </summary>
        [EnumMember(Value = "sid")]
        sid,

        /// <summary>
        /// sin
        /// </summary>
        [EnumMember(Value = "sin")]
        sin,

        /// <summary>
        /// sio
        /// </summary>
        [EnumMember(Value = "sio")]
        sio,

        /// <summary>
        /// sit
        /// </summary>
        [EnumMember(Value = "sit")]
        sit,

        /// <summary>
        /// sla
        /// </summary>
        [EnumMember(Value = "sla")]
        sla,

        /// <summary>
        /// slo
        /// </summary>
        [EnumMember(Value = "slo")]
        slo,

        /// <summary>
        /// slv
        /// </summary>
        [EnumMember(Value = "slv")]
        slv,

        /// <summary>
        /// sma
        /// </summary>
        [EnumMember(Value = "sma")]
        sma,

        /// <summary>
        /// sme
        /// </summary>
        [EnumMember(Value = "sme")]
        sme,

        /// <summary>
        /// smi
        /// </summary>
        [EnumMember(Value = "smi")]
        smi,

        /// <summary>
        /// smj
        /// </summary>
        [EnumMember(Value = "smj")]
        smj,

        /// <summary>
        /// smn
        /// </summary>
        [EnumMember(Value = "smn")]
        smn,

        /// <summary>
        /// smo
        /// </summary>
        [EnumMember(Value = "smo")]
        smo,

        /// <summary>
        /// sms
        /// </summary>
        [EnumMember(Value = "sms")]
        sms,

        /// <summary>
        /// sna
        /// </summary>
        [EnumMember(Value = "sna")]
        sna,

        /// <summary>
        /// snd
        /// </summary>
        [EnumMember(Value = "snd")]
        snd,

        /// <summary>
        /// snk
        /// </summary>
        [EnumMember(Value = "snk")]
        snk,

        /// <summary>
        /// sog
        /// </summary>
        [EnumMember(Value = "sog")]
        sog,

        /// <summary>
        /// som
        /// </summary>
        [EnumMember(Value = "som")]
        som,

        /// <summary>
        /// son
        /// </summary>
        [EnumMember(Value = "son")]
        son,

        /// <summary>
        /// sot
        /// </summary>
        [EnumMember(Value = "sot")]
        sot,

        /// <summary>
        /// spa
        /// </summary>
        [EnumMember(Value = "spa")]
        spa,

        /// <summary>
        /// srd
        /// </summary>
        [EnumMember(Value = "srd")]
        srd,

        /// <summary>
        /// srn
        /// </summary>
        [EnumMember(Value = "srn")]
        srn,

        /// <summary>
        /// srp
        /// </summary>
        [EnumMember(Value = "srp")]
        srp,

        /// <summary>
        /// srr
        /// </summary>
        [EnumMember(Value = "srr")]
        srr,

        /// <summary>
        /// ssa
        /// </summary>
        [EnumMember(Value = "ssa")]
        ssa,

        /// <summary>
        /// ssw
        /// </summary>
        [EnumMember(Value = "ssw")]
        ssw,

        /// <summary>
        /// suk
        /// </summary>
        [EnumMember(Value = "suk")]
        suk,

        /// <summary>
        /// sun
        /// </summary>
        [EnumMember(Value = "sun")]
        sun,

        /// <summary>
        /// sus
        /// </summary>
        [EnumMember(Value = "sus")]
        sus,

        /// <summary>
        /// sux
        /// </summary>
        [EnumMember(Value = "sux")]
        sux,

        /// <summary>
        /// swa
        /// </summary>
        [EnumMember(Value = "swa")]
        swa,

        /// <summary>
        /// swe
        /// </summary>
        [EnumMember(Value = "swe")]
        swe,

        /// <summary>
        /// syc
        /// </summary>
        [EnumMember(Value = "syc")]
        syc,

        /// <summary>
        /// syr
        /// </summary>
        [EnumMember(Value = "syr")]
        syr,

        /// <summary>
        /// tah
        /// </summary>
        [EnumMember(Value = "tah")]
        tah,

        /// <summary>
        /// tai
        /// </summary>
        [EnumMember(Value = "tai")]
        tai,

        /// <summary>
        /// tam
        /// </summary>
        [EnumMember(Value = "tam")]
        tam,

        /// <summary>
        /// tat
        /// </summary>
        [EnumMember(Value = "tat")]
        tat,

        /// <summary>
        /// tel
        /// </summary>
        [EnumMember(Value = "tel")]
        tel,

        /// <summary>
        /// tem
        /// </summary>
        [EnumMember(Value = "tem")]
        tem,

        /// <summary>
        /// ter
        /// </summary>
        [EnumMember(Value = "ter")]
        ter,

        /// <summary>
        /// tet
        /// </summary>
        [EnumMember(Value = "tet")]
        tet,

        /// <summary>
        /// tgk
        /// </summary>
        [EnumMember(Value = "tgk")]
        tgk,

        /// <summary>
        /// tgl
        /// </summary>
        [EnumMember(Value = "tgl")]
        tgl,

        /// <summary>
        /// tha
        /// </summary>
        [EnumMember(Value = "tha")]
        tha,

        /// <summary>
        /// tib
        /// </summary>
        [EnumMember(Value = "tib")]
        tib,

        /// <summary>
        /// tig
        /// </summary>
        [EnumMember(Value = "tig")]
        tig,

        /// <summary>
        /// tir
        /// </summary>
        [EnumMember(Value = "tir")]
        tir,

        /// <summary>
        /// tiv
        /// </summary>
        [EnumMember(Value = "tiv")]
        tiv,

        /// <summary>
        /// tkl
        /// </summary>
        [EnumMember(Value = "tkl")]
        tkl,

        /// <summary>
        /// tlh
        /// </summary>
        [EnumMember(Value = "tlh")]
        tlh,

        /// <summary>
        /// tli
        /// </summary>
        [EnumMember(Value = "tli")]
        tli,

        /// <summary>
        /// tmh
        /// </summary>
        [EnumMember(Value = "tmh")]
        tmh,

        /// <summary>
        /// tog
        /// </summary>
        [EnumMember(Value = "tog")]
        tog,

        /// <summary>
        /// ton
        /// </summary>
        [EnumMember(Value = "ton")]
        ton,

        /// <summary>
        /// tpi
        /// </summary>
        [EnumMember(Value = "tpi")]
        tpi,

        /// <summary>
        /// tsi
        /// </summary>
        [EnumMember(Value = "tsi")]
        tsi,

        /// <summary>
        /// tsn
        /// </summary>
        [EnumMember(Value = "tsn")]
        tsn,

        /// <summary>
        /// tso
        /// </summary>
        [EnumMember(Value = "tso")]
        tso,

        /// <summary>
        /// tuk
        /// </summary>
        [EnumMember(Value = "tuk")]
        tuk,

        /// <summary>
        /// tum
        /// </summary>
        [EnumMember(Value = "tum")]
        tum,

        /// <summary>
        /// tup
        /// </summary>
        [EnumMember(Value = "tup")]
        tup,

        /// <summary>
        /// tur
        /// </summary>
        [EnumMember(Value = "tur")]
        tur,

        /// <summary>
        /// tut
        /// </summary>
        [EnumMember(Value = "tut")]
        tut,

        /// <summary>
        /// tvl
        /// </summary>
        [EnumMember(Value = "tvl")]
        tvl,

        /// <summary>
        /// twi
        /// </summary>
        [EnumMember(Value = "twi")]
        twi,

        /// <summary>
        /// tyv
        /// </summary>
        [EnumMember(Value = "tyv")]
        tyv,

        /// <summary>
        /// udm
        /// </summary>
        [EnumMember(Value = "udm")]
        udm,

        /// <summary>
        /// uga
        /// </summary>
        [EnumMember(Value = "uga")]
        uga,

        /// <summary>
        /// uig
        /// </summary>
        [EnumMember(Value = "uig")]
        uig,

        /// <summary>
        /// ukr
        /// </summary>
        [EnumMember(Value = "ukr")]
        ukr,

        /// <summary>
        /// umb
        /// </summary>
        [EnumMember(Value = "umb")]
        umb,

        /// <summary>
        /// und
        /// </summary>
        [EnumMember(Value = "und")]
        und,

        /// <summary>
        /// urd
        /// </summary>
        [EnumMember(Value = "urd")]
        urd,

        /// <summary>
        /// uzb
        /// </summary>
        [EnumMember(Value = "uzb")]
        uzb,

        /// <summary>
        /// vai
        /// </summary>
        [EnumMember(Value = "vai")]
        vai,

        /// <summary>
        /// ven
        /// </summary>
        [EnumMember(Value = "ven")]
        ven,

        /// <summary>
        /// vie
        /// </summary>
        [EnumMember(Value = "vie")]
        vie,

        /// <summary>
        /// vol
        /// </summary>
        [EnumMember(Value = "vol")]
        vol,

        /// <summary>
        /// vot
        /// </summary>
        [EnumMember(Value = "vot")]
        vot,

        /// <summary>
        /// wak
        /// </summary>
        [EnumMember(Value = "wak")]
        wak,

        /// <summary>
        /// wal
        /// </summary>
        [EnumMember(Value = "wal")]
        wal,

        /// <summary>
        /// war
        /// </summary>
        [EnumMember(Value = "war")]
        war,

        /// <summary>
        /// was
        /// </summary>
        [EnumMember(Value = "was")]
        was,

        /// <summary>
        /// wel
        /// </summary>
        [EnumMember(Value = "wel")]
        wel,

        /// <summary>
        /// wen
        /// </summary>
        [EnumMember(Value = "wen")]
        wen,

        /// <summary>
        /// wln
        /// </summary>
        [EnumMember(Value = "wln")]
        wln,

        /// <summary>
        /// wol
        /// </summary>
        [EnumMember(Value = "wol")]
        wol,

        /// <summary>
        /// xal
        /// </summary>
        [EnumMember(Value = "xal")]
        xal,

        /// <summary>
        /// xho
        /// </summary>
        [EnumMember(Value = "xho")]
        xho,

        /// <summary>
        /// yao
        /// </summary>
        [EnumMember(Value = "yao")]
        yao,

        /// <summary>
        /// yap
        /// </summary>
        [EnumMember(Value = "yap")]
        yap,

        /// <summary>
        /// yid
        /// </summary>
        [EnumMember(Value = "yid")]
        yid,

        /// <summary>
        /// yor
        /// </summary>
        [EnumMember(Value = "yor")]
        yor,

        /// <summary>
        /// ypk
        /// </summary>
        [EnumMember(Value = "ypk")]
        ypk,

        /// <summary>
        /// zap
        /// </summary>
        [EnumMember(Value = "zap")]
        zap,

        /// <summary>
        /// zbl
        /// </summary>
        [EnumMember(Value = "zbl")]
        zbl,

        /// <summary>
        /// zen
        /// </summary>
        [EnumMember(Value = "zen")]
        zen,

        /// <summary>
        /// zgh
        /// </summary>
        [EnumMember(Value = "zgh")]
        zgh,

        /// <summary>
        /// zha
        /// </summary>
        [EnumMember(Value = "zha")]
        zha,

        /// <summary>
        /// znd
        /// </summary>
        [EnumMember(Value = "znd")]
        znd,

        /// <summary>
        /// zul
        /// </summary>
        [EnumMember(Value = "zul")]
        zul,

        /// <summary>
        /// zun
        /// </summary>
        [EnumMember(Value = "zun")]
        zun,

        /// <summary>
        /// zxx
        /// </summary>
        [EnumMember(Value = "zxx")]
        zxx,

        /// <summary>
        /// zza
        /// </summary>
        [EnumMember(Value = "zza")]
        zza,


    }
}
