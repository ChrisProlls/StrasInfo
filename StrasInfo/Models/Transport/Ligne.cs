using System;
using System.Collections.Generic;
using System.Text;

namespace StrasInfo.Models.Transport
{
    using Windows.UI;
    using Windows.UI.Xaml.Media;

    public class Ligne
    {
        public string Id { get; set; }

        public string Number { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public List<Arret> Arrets { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this.Type, this.Number);
            }
        }

        public static List<Ligne> GetAllLignes()
        {
            return new List<Ligne>() {
    new Ligne() {
        Id = "04-26",
        Name = "Wolfisheim / Poteries - Reichstett",
        Number = "4",
        Color = "CC071E",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "ALOUE_02",
                Code = "20B",
                Name = "Alouettes",
                Coordonnee = new GeoCoordinate(48.6435077445333, 7.75363326072693)
            },
            new Arret() {
                Id = "WOLSD_01",
                Code = "671A",
                Name = "Wolfisheim Stade",
                Coordonnee = new GeoCoordinate(48.5790169784543, 7.66661435365677)
            },
            new Arret() {
                Id = "BARRR_02",
                Code = "43B",
                Name = "Barr",
                Coordonnee = new GeoCoordinate(48.6017291939684, 7.74518698453903)
            },
            new Arret() {
                Id = "RUGAR_02",
                Code = "562B",
                Name = "Rue de la Gare",
                Coordonnee = new GeoCoordinate(48.6109170935248, 7.75095373392105)
            },
            new Arret() {
                Id = "FAPIE_02",
                Code = "195B",
                Name = "Faubourg de Pierre",
                Coordonnee = new GeoCoordinate(48.5874904566728, 7.7463510632515)
            },
            new Arret() {
                Id = "RTWOL_02",
                Code = "554B",
                Name = "Route de Wolfisheim",
                Coordonnee = new GeoCoordinate(48.5843189462735, 7.67882913351059)
            },
            new Arret() {
                Id = "PAWOD_02",
                Code = "467B",
                Name = "Parc Wodli",
                Coordonnee = new GeoCoordinate(48.6172654422678, 7.75424212217331)
            },
            new Arret() {
                Id = "LHPPA_02",
                Code = "341B",
                Name = "Les Halles - Pont de Paris",
                Coordonnee = new GeoCoordinate(48.585251346629, 7.74349316954613)
            },
            new Arret() {
                Id = "STMAR_02",
                Code = "613B",
                Name = "Sainte Marguerite",
                Coordonnee = new GeoCoordinate(48.5813095977136, 7.73704648017883)
            },
            new Arret() {
                Id = "SCHMA_02",
                Code = "574B",
                Name = "Schiltigheim Mairie",
                Coordonnee = new GeoCoordinate(48.6048242334265, 7.74776592850685)
            },
            new Arret() {
                Id = "RADOR_02",
                Code = "523B",
                Name = "Raisin d'Or",
                Coordonnee = new GeoCoordinate(48.6329156763779, 7.75407314300537)
            },
            new Arret() {
                Id = "FOCHH_02",
                Code = "215B",
                Name = "Foch",
                Coordonnee = new GeoCoordinate(48.6278528182016, 7.75384649634361)
            },
            new Arret() {
                Id = "HEFRE_02",
                Code = "265B",
                Name = "Henri Frenay",
                Coordonnee = new GeoCoordinate(48.5797631558114, 7.69776687026024)
            },
            new Arret() {
                Id = "PLPIE_04",
                Code = "485B",
                Name = "Place de Pierre",
                Coordonnee = new GeoCoordinate(48.590856919168, 7.74445205926895)
            },
            new Arret() {
                Id = "JAROS_02",
                Code = "297B",
                Name = "Jardin des Roses",
                Coordonnee = new GeoCoordinate(48.5805279539906, 7.69043773412704)
            },
            new Arret() {
                Id = "MAARM_02",
                Code = "375B",
                Name = "Musée d'Art Moderne",
                Coordonnee = new GeoCoordinate(48.5782716773525, 7.73402899503708)
            },
            new Arret() {
                Id = "WOLMA_02",
                Code = "670B",
                Name = "Wolfisheim Mairie",
                Coordonnee = new GeoCoordinate(48.5838469730281, 7.66648560762405)
            },
            new Arret() {
                Id = "POPIE_01",
                Code = "497A",
                Name = "Pont de Pierre",
                Coordonnee = new GeoCoordinate(48.5864214802992, 7.74627596139908)
            },
            new Arret() {
                Id = "CHBLA_02",
                Code = "87B",
                Name = "Cheval Blanc",
                Coordonnee = new GeoCoordinate(48.6144061242096, 7.75238871574402)
            },
            new Arret() {
                Id = "HOMAI_02",
                Code = "281B",
                Name = "Hoenheim Mairie",
                Coordonnee = new GeoCoordinate(48.6213648455118, 7.7553029358387)
            },
            new Arret() {
                Id = "RTWAN_02",
                Code = "553B",
                Name = "Route de La Wantzenau",
                Coordonnee = new GeoCoordinate(48.623925917014, 7.75498777627945)
            },
            new Arret() {
                Id = "JAVIG_02",
                Code = "299B",
                Name = "Jardin des Vignes",
                Coordonnee = new GeoCoordinate(48.5823529534728, 7.68293291330338)
            },
            new Arret() {
                Id = "SCHNO_02",
                Code = "575B",
                Name = "Schnokeloch",
                Coordonnee = new GeoCoordinate(48.579054243221, 7.71253377199173)
            },
            new Arret() {
                Id = "STHEL_02",
                Code = "610B",
                Name = "Sainte Hélène",
                Coordonnee = new GeoCoordinate(48.596815761897, 7.7420112490654)
            },
            new Arret() {
                Id = "MOZAR_02",
                Code = "411B",
                Name = "Mozart",
                Coordonnee = new GeoCoordinate(48.6300873810824, 7.75375530123711)
            },
            new Arret() {
                Id = "EMAIL_03",
                Code = "679C",
                Name = "Emailleries",
                Coordonnee = new GeoCoordinate(48.6259544881153, 7.75595644470513)
            },
            new Arret() {
                Id = "ROMAI_02",
                Code = "542B",
                Name = "Romains",
                Coordonnee = new GeoCoordinate(48.5784819598476, 7.70079374313354)
            },
            new Arret() {
                Id = "CHARM_02",
                Code = "85B",
                Name = "Charmille",
                Coordonnee = new GeoCoordinate(48.5797392002291, 7.71686285734177)
            },
            new Arret() {
                Id = "OCTRO_02",
                Code = "441B",
                Name = "Octroi",
                Coordonnee = new GeoCoordinate(48.5804853669253, 7.69513830542564)
            },
            new Arret() {
                Id = "POKUS_02",
                Code = "492B",
                Name = "Pont Kuss",
                Coordonnee = new GeoCoordinate(48.5834708107441, 7.73981720209122)
            },
            new Arret() {
                Id = "GRUBE_02",
                Code = "252B",
                Name = "Grüber",
                Coordonnee = new GeoCoordinate(48.578631020327, 7.7100245654583)
            },
            new Arret() {
                Id = "JARDI_02",
                Code = "296B",
                Name = "Jardins",
                Coordonnee = new GeoCoordinate(48.5868863325547, 7.67089247703552)
            },
            new Arret() {
                Id = "CAPUC_02",
                Code = "79B",
                Name = "Capucins",
                Coordonnee = new GeoCoordinate(48.5780587321622, 7.70583629608154)
            },
            new Arret() {
                Id = "STGAL_02",
                Code = "599B",
                Name = "Saint Gall",
                Coordonnee = new GeoCoordinate(48.5802360544268, 7.72036045789719)
            },
            new Arret() {
                Id = "BOROU_02",
                Code = "60B",
                Name = "Boeuf Rouge",
                Coordonnee = new GeoCoordinate(48.5870291584386, 7.6681150496006)
            },
            new Arret() {
                Id = "HIRON_02",
                Code = "269B",
                Name = "Hirondelles",
                Coordonnee = new GeoCoordinate(48.6462103508552, 7.7536815404892)
            },
            new Arret() {
                Id = "MOULI_02",
                Code = "400B",
                Name = "Moulin",
                Coordonnee = new GeoCoordinate(48.5814338078619, 7.66638368368149)
            },
            new Arret() {
                Id = "MAROU_02",
                Code = "386B",
                Name = "Maison Rouge",
                Coordonnee = new GeoCoordinate(48.6078853867408, 7.74993851780891)
            },
            new Arret() {
                Id = "HOEGA_03",
                Code = "274B",
                Name = "Hoenheim Gare",
                Coordonnee = new GeoCoordinate(48.6281535850505, 7.75892859636463)
            },
            new Arret() {
                Id = "ECCEN_02",
                Code = "160B",
                Name = "Eckbolsheim Centre",
                Coordonnee = new GeoCoordinate(48.5803442970149, 7.68740683794022)
            },
            new Arret() {
                Id = "REMAI_01",
                Code = "525A",
                Name = "Reichstett Mairie",
                Coordonnee = new GeoCoordinate(48.6485282742091, 7.75337845087051)
            },
            new Arret() {
                Id = "OBLYO_02",
                Code = "436B",
                Name = "Obernai-Lyon",
                Coordonnee = new GeoCoordinate(48.5784038803734, 7.73164317011833)
            },
            new Arret() {
                Id = "HAYYY_01",
                Code = "263A",
                Name = "Hay",
                Coordonnee = new GeoCoordinate(48.6485902966885, 7.75178924202919)
            },
            new Arret() {
                Id = "PLROM_01",
                Code = "486A",
                Name = "Place des Romains",
                Coordonnee = new GeoCoordinate(48.5799450404178, 7.70384073257446)
            },
            new Arret() {
                Id = "POTER_03",
                Code = "725C",
                Name = "Poteries",
                Coordonnee = new GeoCoordinate(48.584148935449, 7.69341831350327)
            },
            new Arret() {
                Id = "HORAC_01",
                Code = "285A",
                Name = "Horace",
                Coordonnee = new GeoCoordinate(48.5832011077606, 7.69954383373261)
            },
            new Arret() {
                Id = "VIRGI_01",
                Code = "652A",
                Name = "Virgile",
                Coordonnee = new GeoCoordinate(48.5814355822903, 7.69978255033493)
            },
            new Arret() {
                Id = "BOSCO_01",
                Code = "61A",
                Name = "Bosco",
                Coordonnee = new GeoCoordinate(48.5818206317968, 7.70286172628403)
            }
        }
    },
    new Ligne() {
        Id = "06-26",
        Name = "Pont Phario - Niederhausbergen / Hoenheim",
        Number = "6",
        Color = "7D5D9F",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "REPUB_01",
                Code = "527A",
                Name = "République",
                Coordonnee = new GeoCoordinate(48.5865918083395, 7.75383979082108)
            },
            new Arret() {
                Id = "WILSO_03",
                Code = "667B",
                Name = "Wilson",
                Coordonnee = new GeoCoordinate(48.5879047343827, 7.73896962404251)
            },
            new Arret() {
                Id = "TRFON_01",
                Code = "635A",
                Name = "Tribunal - Fonderie",
                Coordonnee = new GeoCoordinate(48.5868739128935, 7.74958312511444)
            },
            new Arret() {
                Id = "GAERT_01",
                Code = "231A",
                Name = "Gaertel",
                Coordonnee = new GeoCoordinate(48.6325141762343, 7.72821128368378)
            },
            new Arret() {
                Id = "PAPET_01",
                Code = "459A",
                Name = "Papeterie",
                Coordonnee = new GeoCoordinate(48.6116025053672, 7.78041243553162)
            },
            new Arret() {
                Id = "SOECO_01",
                Code = "586A",
                Name = "Souffelweyersheim Ecole",
                Coordonnee = new GeoCoordinate(48.633509500755, 7.74140238761902)
            },
            new Arret() {
                Id = "LASOU_01",
                Code = "331A",
                Name = "La Souffel",
                Coordonnee = new GeoCoordinate(48.6284821577019, 7.72922784090042)
            },
            new Arret() {
                Id = "ORANG_01",
                Code = "443A",
                Name = "Orangerie",
                Coordonnee = new GeoCoordinate(48.5917776674777, 7.76958703994751)
            },
            new Arret() {
                Id = "POINC_01",
                Code = "491A",
                Name = "Poincaré",
                Coordonnee = new GeoCoordinate(48.6140674283668, 7.73281127214432)
            },
            new Arret() {
                Id = "HOEGA_04",
                Code = "274C",
                Name = "Hoenheim Gare",
                Coordonnee = new GeoCoordinate(48.6282564066389, 7.7589232319466)
            },
            new Arret() {
                Id = "BRUNI_02",
                Code = "69A",
                Name = "Brant Université",
                Coordonnee = new GeoCoordinate(48.5855911228818, 7.76167184114456)
            },
            new Arret() {
                Id = "EMBRA_01",
                Code = "678A",
                Name = "Embranchement",
                Coordonnee = new GeoCoordinate(48.5997461406377, 7.73971661925316)
            },
            new Arret() {
                Id = "BAILL_01",
                Code = "39A",
                Name = "Baillis",
                Coordonnee = new GeoCoordinate(48.6069986290889, 7.77991890907288)
            },
            new Arret() {
                Id = "ROEGL_01",
                Code = "539A",
                Name = "Robertsau Eglise",
                Coordonnee = new GeoCoordinate(48.6029725535281, 7.78336018323898)
            },
            new Arret() {
                Id = "WISSE_01",
                Code = "668A",
                Name = "Wissembourg",
                Coordonnee = new GeoCoordinate(48.5899716366678, 7.74107247591019)
            },
            new Arret() {
                Id = "HECHN_01",
                Code = "264A",
                Name = "Hechner",
                Coordonnee = new GeoCoordinate(48.6123198281074, 7.77682095766068)
            },
            new Arret() {
                Id = "LHPPA_02",
                Code = "341B",
                Name = "Les Halles - Pont de Paris",
                Coordonnee = new GeoCoordinate(48.585251346629, 7.74349316954613)
            },
            new Arret() {
                Id = "BOUVR_01",
                Code = "64A",
                Name = "Bouvreuil",
                Coordonnee = new GeoCoordinate(48.6349692154498, 7.73131459951401)
            },
            new Arret() {
                Id = "DRHOM_05",
                Code = "156A",
                Name = "Droits de l'Homme",
                Coordonnee = new GeoCoordinate(48.5960618536765, 7.7753672003746)
            },
            new Arret() {
                Id = "RADOR_02",
                Code = "523B",
                Name = "Raisin d'Or",
                Coordonnee = new GeoCoordinate(48.6329156763779, 7.75407314300537)
            },
            new Arret() {
                Id = "FODES_01",
                Code = "216A",
                Name = "Fort Desaix",
                Coordonnee = new GeoCoordinate(48.6346581322528, 7.72774457931519)
            },
            new Arret() {
                Id = "MASEG_01",
                Code = "388A",
                Name = "Marc Seguin",
                Coordonnee = new GeoCoordinate(48.6155622834784, 7.73231104016304)
            },
            new Arret() {
                Id = "FOCHH_02",
                Code = "215B",
                Name = "Foch",
                Coordonnee = new GeoCoordinate(48.6278528182016, 7.75384649634361)
            },
            new Arret() {
                Id = "POPHA_07",
                Code = "496A",
                Name = "Pont Phario",
                Coordonnee = new GeoCoordinate(48.6132197921628, 7.76918202638626)
            },
            new Arret() {
                Id = "DAUPH_01",
                Code = "145A",
                Name = "Dauphiné",
                Coordonnee = new GeoCoordinate(48.6337815940676, 7.744912058115)
            },
            new Arret() {
                Id = "POPIE_01",
                Code = "497A",
                Name = "Pont de Pierre",
                Coordonnee = new GeoCoordinate(48.5864214802992, 7.74627596139908)
            },
            new Arret() {
                Id = "ECRIV_01",
                Code = "169A",
                Name = "Ecrivains",
                Coordonnee = new GeoCoordinate(48.609602992021, 7.73433074355125)
            },
            new Arret() {
                Id = "SOCEN_01",
                Code = "585A",
                Name = "Souffelweyersheim Centre",
                Coordonnee = new GeoCoordinate(48.6342805757104, 7.73777335882187)
            },
            new Arret() {
                Id = "MOZAR_02",
                Code = "411B",
                Name = "Mozart",
                Coordonnee = new GeoCoordinate(48.6300873810824, 7.75375530123711)
            },
            new Arret() {
                Id = "EMAIL_03",
                Code = "679C",
                Name = "Emailleries",
                Coordonnee = new GeoCoordinate(48.6259544881153, 7.75595644470513)
            },
            new Arret() {
                Id = "SCHOT_01",
                Code = "576A",
                Name = "Schott",
                Coordonnee = new GeoCoordinate(48.6003944550999, 7.78052374720573)
            },
            new Arret() {
                Id = "CINOR_01",
                Code = "111A",
                Name = "Cimetière Nord",
                Coordonnee = new GeoCoordinate(48.6091223876536, 7.77977809309959)
            },
            new Arret() {
                Id = "MOSER_01",
                Code = "399A",
                Name = "Moser",
                Coordonnee = new GeoCoordinate(48.6032483588119, 7.73793295025826)
            },
            new Arret() {
                Id = "COEUR_01",
                Code = "453A",
                Name = "Conseil de l'Europe",
                Coordonnee = new GeoCoordinate(48.5939777088863, 7.77222325959394)
            },
            new Arret() {
                Id = "SOCAN_02",
                Code = "584B",
                Name = "Souffelweyersheim Canal",
                Coordonnee = new GeoCoordinate(48.6341653583625, 7.75171011686325)
            },
            new Arret() {
                Id = "TREPI_01",
                Code = "634A",
                Name = "Trois Epis",
                Coordonnee = new GeoCoordinate(48.6068372375213, 7.73593604564667)
            },
            new Arret() {
                Id = "ROBOE_02",
                Code = "535B",
                Name = "Robertsau Boecklin",
                Coordonnee = new GeoCoordinate(48.5981532560897, 7.77742981910706)
            },
            new Arret() {
                Id = "LERCH_01",
                Code = "339A",
                Name = "Lerchenberg",
                Coordonnee = new GeoCoordinate(48.6199011910871, 7.73129984736443)
            },
            new Arret() {
                Id = "CIILL_01",
                Code = "99A",
                Name = "Cité de l'Ill",
                Coordonnee = new GeoCoordinate(48.612942268012, 7.7736009657383)
            },
            new Arret() {
                Id = "STHEL_03",
                Code = "610C",
                Name = "Sainte Hélène",
                Coordonnee = new GeoCoordinate(48.5973443778922, 7.74105370044708)
            },
            new Arret() {
                Id = "VIHUG_01",
                Code = "650A",
                Name = "Victor Hugo",
                Coordonnee = new GeoCoordinate(48.6226706624844, 7.73056894540787)
            },
            new Arret() {
                Id = "CLORA_01",
                Code = "116A",
                Name = "Clinique de l'Orangerie",
                Coordonnee = new GeoCoordinate(48.5879490893966, 7.76533037424088)
            },
            new Arret() {
                Id = "DORDO_03",
                Code = "154A",
                Name = "Dordogne",
                Coordonnee = new GeoCoordinate(48.5890348879957, 7.76659101247787)
            },
            new Arret() {
                Id = "FASAV_01",
                Code = "197A",
                Name = "Faubourg de Saverne",
                Coordonnee = new GeoCoordinate(48.5857925035514, 7.73995533585548)
            },
            new Arret() {
                Id = "LIBER_01",
                Code = "343A",
                Name = "Liberté",
                Coordonnee = new GeoCoordinate(48.5859956576868, 7.75812596082687)
            },
            new Arret() {
                Id = "ESEUE_05",
                Code = "182E",
                Name = "Espace Européen de l' Entreprise",
                Coordonnee = new GeoCoordinate(48.616467, 7.719799)
            },
            new Arret() {
                Id = "NIMAI_01",
                Code = "431A",
                Name = "Niederhausbergen Mairie",
                Coordonnee = new GeoCoordinate(48.6232530831927, 7.6999931037426)
            },
            new Arret() {
                Id = "RUHOE_01",
                Code = "563A",
                Name = "Rue de Hoenheim",
                Coordonnee = new GeoCoordinate(48.6242982322696, 7.7055761218071)
            },
            new Arret() {
                Id = "GEBUR_01",
                Code = "235A",
                Name = "Georges Burger",
                Coordonnee = new GeoCoordinate(48.6151677382377, 7.72918224334717)
            },
            new Arret() {
                Id = "NITER_01",
                Code = "680A",
                Name = "Niederhausbergen Ouest",
                Coordonnee = new GeoCoordinate(48.6269238633009, 7.7014696598053)
            },
            new Arret() {
                Id = "NORDD_01",
                Code = "433A",
                Name = "Nord",
                Coordonnee = new GeoCoordinate(48.6231848241879, 7.71177873015404)
            },
            new Arret() {
                Id = "NIOUE_01",
                Code = "432A",
                Name = "Niederhausbergen Centre",
                Coordonnee = new GeoCoordinate(48.6248487219363, 7.70005613565445)
            },
            new Arret() {
                Id = "FONTA_02",
                Code = "219B",
                Name = "Fontaine",
                Coordonnee = new GeoCoordinate(48.6237840819084, 7.75197967886925)
            },
            new Arret() {
                Id = "RTWAN_01",
                Code = "553A",
                Name = "Route de La Wantzenau",
                Coordonnee = new GeoCoordinate(48.6242751842621, 7.7546551823616)
            },
            new Arret() {
                Id = "HOCIG_01",
                Code = "271A",
                Name = "Hoenheim Cigognes",
                Coordonnee = new GeoCoordinate(48.6232016673276, 7.74681240320206)
            },
            new Arret() {
                Id = "ZACMA_01",
                Code = "674A",
                Name = "ZAC des Maréchaux",
                Coordonnee = new GeoCoordinate(48.6341547229017, 7.71530717611313)
            }
        }
    },
    new Ligne() {
        Id = "17-26",
        Name = "Rotonde / Mittelhausbergen",
        Number = "17",
        Color = "F7DDDD",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "MITMI_01",
                Code = "394A",
                Name = "Mittelhausbergen Mittelberg",
                Coordonnee = new GeoCoordinate(48.6122666277596, 7.6970399916172)
            },
            new Arret() {
                Id = "BETHL_02",
                Code = "50B",
                Name = "Bethel",
                Coordonnee = new GeoCoordinate(48.6118826969211, 7.68697902560234)
            },
            new Arret() {
                Id = "MIEGL_02",
                Code = "393B",
                Name = "Mittelhausbergen Eglise",
                Coordonnee = new GeoCoordinate(48.6143121407742, 7.6940144598484)
            },
            new Arret() {
                Id = "OBEES_02",
                Code = "434B",
                Name = "Oberhausbergen Est",
                Coordonnee = new GeoCoordinate(48.6018072374088, 7.69552320241928)
            },
            new Arret() {
                Id = "JACOB_02",
                Code = "295B",
                Name = "Jacob",
                Coordonnee = new GeoCoordinate(48.5923409300893, 7.71759912371635)
            },
            new Arret() {
                Id = "BANLI_02",
                Code = "42B",
                Name = "Banlieue",
                Coordonnee = new GeoCoordinate(48.6007873420311, 7.69812226295471)
            },
            new Arret() {
                Id = "OBHEG_02",
                Code = "435B",
                Name = "Oberhausbergen Eglise",
                Coordonnee = new GeoCoordinate(48.6099692059314, 7.68467634916306)
            },
            new Arret() {
                Id = "ROTON_11",
                Code = "550C",
                Name = "Rotonde",
                Coordonnee = new GeoCoordinate(48.591908, 7.72554)
            },
            new Arret() {
                Id = "ETDOR_02",
                Code = "187B",
                Name = "Etoile d'Or",
                Coordonnee = new GeoCoordinate(48.594838724525, 7.71047383546829)
            },
            new Arret() {
                Id = "CATHE_02",
                Code = "80B",
                Name = "Catherine",
                Coordonnee = new GeoCoordinate(48.5966844939805, 7.70597442984581)
            },
            new Arret() {
                Id = "VOSGE_02",
                Code = "656B",
                Name = "Vosges",
                Coordonnee = new GeoCoordinate(48.6039675738661, 7.69020169973373)
            },
            new Arret() {
                Id = "OBHMA_02",
                Code = "682B",
                Name = "Oberhausbergen Mairie",
                Coordonnee = new GeoCoordinate(48.605799707986, 7.68610194325447)
            },
            new Arret() {
                Id = "RODIN_02",
                Code = "538B",
                Name = "Rodin",
                Coordonnee = new GeoCoordinate(48.61319319247, 7.68869161605835)
            },
            new Arret() {
                Id = "DUNTZ_02",
                Code = "159B",
                Name = "Duntzenheim",
                Coordonnee = new GeoCoordinate(48.5987155607139, 7.70213350653648)
            },
            new Arret() {
                Id = "NEUVE_02",
                Code = "428B",
                Name = "Neuve",
                Coordonnee = new GeoCoordinate(48.5915080088238, 7.72193491458893)
            }
        }
    },
    new Ligne() {
        Id = "19-26",
        Name = "Rotonde - Cronenbourg Arago - Chambre de Métiers",
        Number = "19",
        Color = "F7C9E3",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "CRARA_02",
                Code = "136B",
                Name = "Arago",
                Coordonnee = new GeoCoordinate(48.6046167209536, 7.71678507328033)
            },
            new Arret() {
                Id = "CHMAN_02",
                Code = "91B",
                Name = "Champ de Manoeuvre",
                Coordonnee = new GeoCoordinate(48.6016413949538, 7.71052211523056)
            },
            new Arret() {
                Id = "VILVE_02",
                Code = "711B",
                Name = "Villa Vénitienne",
                Coordonnee = new GeoCoordinate(48.5946976946768, 7.72591933608055)
            },
            new Arret() {
                Id = "STFLO_06",
                Code = "710B",
                Name = "Eglise Saint Florent",
                Coordonnee = new GeoCoordinate(48.595814, 7.722023)
            },
            new Arret() {
                Id = "HALDE_02",
                Code = "258B",
                Name = "Haldenbourg",
                Coordonnee = new GeoCoordinate(48.6031454862777, 7.7130688726902)
            },
            new Arret() {
                Id = "ROTON_11",
                Code = "550C",
                Name = "Rotonde",
                Coordonnee = new GeoCoordinate(48.591908, 7.72554)
            },
            new Arret() {
                Id = "BERST_02",
                Code = "49B",
                Name = "Berstett",
                Coordonnee = new GeoCoordinate(48.600142580155, 7.71170228719711)
            },
            new Arret() {
                Id = "MAZEL_04",
                Code = "709B",
                Name = "Mathieu Zell",
                Coordonnee = new GeoCoordinate(48.5952622551934, 7.71833337843418)
            },
            new Arret() {
                Id = "STUTZ_02",
                Code = "622B",
                Name = "Stutzheim",
                Coordonnee = new GeoCoordinate(48.5983217707506, 7.71400898694992)
            }
        }
    },
    new Ligne() {
        Id = "G-26",
        Name = "Gare Centrale - Espace Européen de l'Entreprise",
        Number = "G",
        Color = "000099",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "LONDR_02",
                Code = "721B",
                Name = "Londres",
                Coordonnee = new GeoCoordinate(48.6104283401256, 7.7122631978035)
            },
            new Arret() {
                Id = "ESEUE_04",
                Code = "182D",
                Name = "Espace Européen de l' Entreprise",
                Coordonnee = new GeoCoordinate(48.616492, 7.719622)
            },
            new Arret() {
                Id = "CHMET_06",
                Code = "92F",
                Name = "Chambre de Métiers",
                Coordonnee = new GeoCoordinate(48.6155011070026, 7.71948739886284)
            },
            new Arret() {
                Id = "WILSO_07",
                Code = "667F",
                Name = "Wilson",
                Coordonnee = new GeoCoordinate(48.587801, 7.738422)
            },
            new Arret() {
                Id = "GACEN_06",
                Code = "230",
                Name = "Gare Centrale",
                Coordonnee = new GeoCoordinate(48.5854618669315, 7.73556604370358)
            },
            new Arret() {
                Id = "CRARA_04",
                Code = "136D",
                Name = "Arago",
                Coordonnee = new GeoCoordinate(48.604773, 7.716071)
            },
            new Arret() {
                Id = "VIENN_02",
                Code = "722B",
                Name = "Vienne",
                Coordonnee = new GeoCoordinate(48.613632, 7.716521)
            },
            new Arret() {
                Id = "HOCHF_02",
                Code = "733B",
                Name = "Hochfelden",
                Coordonnee = new GeoCoordinate(48.595662, 7.727769)
            },
            new Arret() {
                Id = "LAVOI_02",
                Code = "719B",
                Name = "Lavoisier",
                Coordonnee = new GeoCoordinate(48.6025931388838, 7.71937742829323)
            },
            new Arret() {
                Id = "GAMAR_02",
                Code = "718B",
                Name = "Gare aux Marchandises",
                Coordonnee = new GeoCoordinate(48.591811, 7.732639)
            },
            new Arret() {
                Id = "COPEN_02",
                Code = "720B",
                Name = "Copenhague",
                Coordonnee = new GeoCoordinate(48.607767, 7.717841)
            },
            new Arret() {
                Id = "RIETH_04",
                Code = "533D",
                Name = "Rieth",
                Coordonnee = new GeoCoordinate(48.601623, 7.722782)
            }
        }
    },
    new Ligne() {
        Id = "A-698",
        Name = "Parc des Sports - Illkirch Lixenbuhl",
        Number = "A",
        Color = "E2001A",
        Type = "Tram",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "DANTE_02",
                Code = "143B",
                Name = "Dante",
                Coordonnee = new GeoCoordinate(48.5911833520877, 7.70266324281693)
            },
            new Arret() {
                Id = "LEGAL_02",
                Code = "731B",
                Name = "Le Galet",
                Coordonnee = new GeoCoordinate(48.596238, 7.698486)
            },
            new Arret() {
                Id = "CERVA_02",
                Code = "730B",
                Name = "Cervantès",
                Coordonnee = new GeoCoordinate(48.593286, 7.69883)
            },
            new Arret() {
                Id = "PASPO_02",
                Code = "715B",
                Name = "Parc des sports",
                Coordonnee = new GeoCoordinate(48.598572, 7.694146)
            },
            new Arret() {
                Id = "HOHAU_02",
                Code = "277B",
                Name = "Hôpital de Hautepierre",
                Coordonnee = new GeoCoordinate(48.5916109050589, 7.70674556493759)
            },
            new Arret() {
                Id = "STFLO_04",
                Code = "597D",
                Name = "Saint Florent",
                Coordonnee = new GeoCoordinate(48.5915807458393, 7.72014319896698)
            },
            new Arret() {
                Id = "ROTON_06",
                Code = "550F",
                Name = "Rotonde",
                Coordonnee = new GeoCoordinate(48.5919089481437, 7.72474050521851)
            },
            new Arret() {
                Id = "DUALS_02",
                Code = "157B",
                Name = "Ducs d'Alsace",
                Coordonnee = new GeoCoordinate(48.5901490492332, 7.71509259939194)
            },
            new Arret() {
                Id = "LECLE_01",
                Code = "335A",
                Name = "Leclerc",
                Coordonnee = new GeoCoordinate(48.5343434006038, 7.73443400859833)
            },
            new Arret() {
                Id = "PTHOP_03",
                Code = "520A",
                Name = "Porte de l'Hôpital",
                Coordonnee = new GeoCoordinate(48.5780374375939, 7.75028854608536)
            },
            new Arret() {
                Id = "COLON_03",
                Code = "128C",
                Name = "Colonne",
                Coordonnee = new GeoCoordinate(48.5379478287399, 7.73359179496765)
            },
            new Arret() {
                Id = "LAGRR_01",
                Code = "322A",
                Name = "Langstross/Grand Rue",
                Coordonnee = new GeoCoordinate(48.5813495224374, 7.74629607796669)
            },
            new Arret() {
                Id = "ANSYN_01",
                Code = "30A",
                Name = "Ancienne Synagogue / Les Halles",
                Coordonnee = new GeoCoordinate(48.5853285283805, 7.74237737059593)
            },
            new Arret() {
                Id = "CAILL_03",
                Code = "75B",
                Name = "Campus d'Illkirch",
                Coordonnee = new GeoCoordinate(48.5293541431868, 7.73277908563614)
            },
            new Arret() {
                Id = "EMMAT_03",
                Code = "176C",
                Name = "Emile Mathis",
                Coordonnee = new GeoCoordinate(48.5530553954264, 7.74414092302322)
            },
            new Arret() {
                Id = "GACEN_09",
                Code = "230",
                Name = "Gare Centrale",
                Coordonnee = new GeoCoordinate(48.5851584131568, 7.73551616808811)
            },
            new Arret() {
                Id = "ILLIX_05",
                Code = "290E",
                Name = "Illkirch Lixenbuhl",
                Coordonnee = new GeoCoordinate(48.5299056676849, 7.72441327571869)
            },
            new Arret() {
                Id = "BAGGE_03",
                Code = "38C",
                Name = "Baggersee",
                Coordonnee = new GeoCoordinate(48.5449250734092, 7.73784913122654)
            },
            new Arret() {
                Id = "ETOIL_01",
                Code = "186E",
                Name = "Etoile Bourse",
                Coordonnee = new GeoCoordinate(48.5746239797845, 7.75348171591759)
            },
            new Arret() {
                Id = "HOFER_11",
                Code = "275A",
                Name = "Homme de Fer",
                Coordonnee = new GeoCoordinate(48.5839729512805, 7.74460762739182)
            },
            new Arret() {
                Id = "LYCOU_03",
                Code = "366C",
                Name = "Lycée Couffignal",
                Coordonnee = new GeoCoordinate(48.5587532995628, 7.74907886981964)
            },
            new Arret() {
                Id = "SCHLU_01",
                Code = "573A",
                Name = "Schluthfeld",
                Coordonnee = new GeoCoordinate(48.5684876943625, 7.75166183710098)
            },
            new Arret() {
                Id = "HOHWA_01",
                Code = "280C",
                Name = "Hohwart",
                Coordonnee = new GeoCoordinate(48.5492034653118, 7.74152040481567)
            },
            new Arret() {
                Id = "KRIMM_03",
                Code = "319A",
                Name = "Krimmeri",
                Coordonnee = new GeoCoordinate(48.5629959083714, 7.75263279676437)
            }
        }
    },
    new Ligne() {
        Id = "D-698",
        Name = "Poteries - A. Briand",
        Number = "D",
        Color = "009932",
        Type = "Tram",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "DUALS_01",
                Code = "157A",
                Name = "Ducs d'Alsace",
                Coordonnee = new GeoCoordinate(48.5902031599416, 7.7154466509819)
            },
            new Arret() {
                Id = "HOHAU_01",
                Code = "277A",
                Name = "Hôpital de Hautepierre",
                Coordonnee = new GeoCoordinate(48.5915310717913, 7.70709693431854)
            },
            new Arret() {
                Id = "LANDS_05",
                Code = "329A",
                Name = "Landsberg",
                Coordonnee = new GeoCoordinate(48.569340518424, 7.76409119367599)
            },
            new Arret() {
                Id = "ROTON_05",
                Code = "550E",
                Name = "Rotonde",
                Coordonnee = new GeoCoordinate(48.5918362116006, 7.72519111633301)
            },
            new Arret() {
                Id = "PTHOP_03",
                Code = "520A",
                Name = "Porte de l'Hôpital",
                Coordonnee = new GeoCoordinate(48.5780374375939, 7.75028854608536)
            },
            new Arret() {
                Id = "LAGRR_01",
                Code = "322A",
                Name = "Langstross/Grand Rue",
                Coordonnee = new GeoCoordinate(48.5813495224374, 7.74629607796669)
            },
            new Arret() {
                Id = "ANSYN_01",
                Code = "30A",
                Name = "Ancienne Synagogue / Les Halles",
                Coordonnee = new GeoCoordinate(48.5853285283805, 7.74237737059593)
            },
            new Arret() {
                Id = "PAELU_03",
                Code = "452C",
                Name = "Paul Eluard",
                Coordonnee = new GeoCoordinate(48.590197, 7.697824)
            },
            new Arret() {
                Id = "DANTE_01",
                Code = "143A",
                Name = "Dante",
                Coordonnee = new GeoCoordinate(48.5914104346142, 7.70304679870605)
            },
            new Arret() {
                Id = "JAURE_01",
                Code = "298A",
                Name = "Jean Jaures",
                Coordonnee = new GeoCoordinate(48.5672079875706, 7.77221292257309)
            },
            new Arret() {
                Id = "MARUD_01",
                Code = "732A",
                Name = "Marcel Rudloff",
                Coordonnee = new GeoCoordinate(48.587447, 7.69766)
            },
            new Arret() {
                Id = "POTER_05",
                Code = "725B",
                Name = "Poteries",
                Coordonnee = new GeoCoordinate(48.584278935449, 7.69291831350326)
            },
            new Arret() {
                Id = "STFLO_03",
                Code = "597C",
                Name = "Saint Florent",
                Coordonnee = new GeoCoordinate(48.5916126791301, 7.72041410207748)
            },
            new Arret() {
                Id = "GACEN_09",
                Code = "230",
                Name = "Gare Centrale",
                Coordonnee = new GeoCoordinate(48.5851584131568, 7.73551616808811)
            },
            new Arret() {
                Id = "ARBRI_05",
                Code = "32D",
                Name = "Aristide Briand",
                Coordonnee = new GeoCoordinate(48.5685311789758, 7.7768611907959)
            },
            new Arret() {
                Id = "ETOIL_01",
                Code = "186E",
                Name = "Etoile Bourse",
                Coordonnee = new GeoCoordinate(48.5746239797845, 7.75348171591759)
            },
            new Arret() {
                Id = "HOFER_11",
                Code = "275A",
                Name = "Homme de Fer",
                Coordonnee = new GeoCoordinate(48.5839729512805, 7.74460762739182)
            },
            new Arret() {
                Id = "ETPOL_02",
                Code = "189B",
                Name = "Etoile Polygone",
                Coordonnee = new GeoCoordinate(48.5715279774413, 7.75567978620529)
            }
        }
    },
    new Ligne() {
        Id = "02-26",
        Name = "Campus d'Illkirch - Pont du Rhin",
        Number = "2",
        Color = "E2001A",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "NICIG_01",
                Code = "429A",
                Name = "Nid de Cigognes",
                Coordonnee = new GeoCoordinate(48.5723008865819, 7.71461516618729)
            },
            new Arret() {
                Id = "CLEME_01",
                Code = "115A",
                Name = "Clémenceau",
                Coordonnee = new GeoCoordinate(48.592157316038, 7.75464445352554)
            },
            new Arret() {
                Id = "STAUR_01",
                Code = "595A",
                Name = "Sainte Aurélie",
                Coordonnee = new GeoCoordinate(48.581756752819, 7.73215144872665)
            },
            new Arret() {
                Id = "BETHS_01",
                Code = "51A",
                Name = "Bethesda",
                Coordonnee = new GeoCoordinate(48.592316093445, 7.76137948036194)
            },
            new Arret() {
                Id = "COOPE_01",
                Code = "129A",
                Name = "Coopérative",
                Coordonnee = new GeoCoordinate(48.5747340090534, 7.7930711209774)
            },
            new Arret() {
                Id = "PRRHI_01",
                Code = "517A",
                Name = "Port du Rhin",
                Coordonnee = new GeoCoordinate(48.5765973715944, 7.78784483671188)
            },
            new Arret() {
                Id = "OSHVI_06",
                Code = "448B",
                Name = "Ostwald Hôtel de Ville",
                Coordonnee = new GeoCoordinate(48.5504276989032, 7.71053820848465)
            },
            new Arret() {
                Id = "BALEE_01",
                Code = "40A",
                Name = "Bâle",
                Coordonnee = new GeoCoordinate(48.5371690666655, 7.70989716053009)
            },
            new Arret() {
                Id = "LYKLE_01",
                Code = "368A",
                Name = "Lycée Kléber",
                Coordonnee = new GeoCoordinate(48.5933618830061, 7.75761768221855)
            },
            new Arret() {
                Id = "RULIN_01",
                Code = "565A",
                Name = "Rue de Lingolsheim",
                Coordonnee = new GeoCoordinate(48.5490880538009, 7.70960748195648)
            },
            new Arret() {
                Id = "WIHRE_03",
                Code = "665A",
                Name = "Wihrel",
                Coordonnee = new GeoCoordinate(48.5555293890102, 7.71277517080307)
            },
            new Arret() {
                Id = "23NOV_01",
                Code = "704A",
                Name = "23 Novembre",
                Coordonnee = new GeoCoordinate(48.5331765019212, 7.70643778145313)
            },
            new Arret() {
                Id = "GACEN_01",
                Code = "230",
                Name = "Gare Centrale",
                Coordonnee = new GeoCoordinate(48.585440308639, 7.73563697934151)
            },
            new Arret() {
                Id = "LAITE_01",
                Code = "323A",
                Name = "Laiterie",
                Coordonnee = new GeoCoordinate(48.5755299394556, 7.73083448410034)
            },
            new Arret() {
                Id = "MARNE_01",
                Code = "385A",
                Name = "Marne",
                Coordonnee = new GeoCoordinate(48.5836899433585, 7.77315840125084)
            },
            new Arret() {
                Id = "STMAU_01",
                Code = "614A",
                Name = "Saint Maurice",
                Coordonnee = new GeoCoordinate(48.5857295167321, 7.77215391397476)
            },
            new Arret() {
                Id = "MURHO_01",
                Code = "417A",
                Name = "Murhof",
                Coordonnee = new GeoCoordinate(48.5590932539266, 7.71189674735069)
            },
            new Arret() {
                Id = "GLIES_01",
                Code = "246A",
                Name = "Gliesberg",
                Coordonnee = new GeoCoordinate(48.5679002046966, 7.7092319726944)
            },
            new Arret() {
                Id = "ROETH_01",
                Code = "540A",
                Name = "Roethig",
                Coordonnee = new GeoCoordinate(48.5644993751298, 7.70677506923676)
            },
            new Arret() {
                Id = "DORDO_01",
                Code = "154C",
                Name = "Dordogne",
                Coordonnee = new GeoCoordinate(48.5899964744645, 7.76694774627686)
            },
            new Arret() {
                Id = "DUNKE_01",
                Code = "158A",
                Name = "Dunkerque",
                Coordonnee = new GeoCoordinate(48.5779451610274, 7.78429895639419)
            },
            new Arret() {
                Id = "PARHI_F1",
                Code = "463",
                Name = "Jardin des deux Rives",
                Coordonnee = new GeoCoordinate(48.5727046403902, 7.79530674219131)
            },
            new Arret() {
                Id = "MOVER_01",
                Code = "410A",
                Name = "Montagne Verte",
                Coordonnee = new GeoCoordinate(48.5746727831188, 7.72701770067215)
            },
            new Arret() {
                Id = "OSBEL_01",
                Code = "447A",
                Name = "Ostwald Bellevue",
                Coordonnee = new GeoCoordinate(48.5398747027895, 7.7102592587471)
            },
            new Arret() {
                Id = "PORHI_02",
                Code = "498",
                Name = "Pont du Rhin",
                Coordonnee = new GeoCoordinate(48.5735263359851, 7.79789239168167)
            },
            new Arret() {
                Id = "OBLYO_03",
                Code = "436C",
                Name = "Obernai-Lyon",
                Coordonnee = new GeoCoordinate(48.5781474594339, 7.7311147749424)
            },
            new Arret() {
                Id = "PIGEO_01",
                Code = "476A",
                Name = "Pigeons",
                Coordonnee = new GeoCoordinate(48.5347829787501, 7.70850509405136)
            },
            new Arret() {
                Id = "CAMPI_01",
                Code = "36A",
                Name = "Camping",
                Coordonnee = new GeoCoordinate(48.5733036098807, 7.71833673119545)
            },
            new Arret() {
                Id = "TAULE_03",
                Code = "626B",
                Name = "Tauler",
                Coordonnee = new GeoCoordinate(48.5887137637155, 7.76942074298859)
            },
            new Arret() {
                Id = "VERMA_01",
                Code = "647A",
                Name = "Vernois Mangold",
                Coordonnee = new GeoCoordinate(48.545579418239, 7.70965576171875)
            },
            new Arret() {
                Id = "PLPIE_01",
                Code = "485C",
                Name = "Place de Pierre",
                Coordonnee = new GeoCoordinate(48.5907291839732, 7.74494558572769)
            },
            new Arret() {
                Id = "BRUCH_01",
                Code = "68A",
                Name = "Bruche",
                Coordonnee = new GeoCoordinate(48.5700850637794, 7.71105453372002)
            },
            new Arret() {
                Id = "TRAVA_02",
                Code = "633B",
                Name = "Travail",
                Coordonnee = new GeoCoordinate(48.5899734107966, 7.74207830429077)
            },
            new Arret() {
                Id = "OSMAI_01",
                Code = "449A",
                Name = "Ostwald Eglise",
                Coordonnee = new GeoCoordinate(48.5431599870938, 7.70933523774147)
            },
            new Arret() {
                Id = "OBSER_F4",
                Code = "438B",
                Name = "Observatoire",
                Coordonnee = new GeoCoordinate(48.5815473711589, 7.77050971984863)
            },
            new Arret() {
                Id = "WILSO_01",
                Code = "667C",
                Name = "Wilson",
                Coordonnee = new GeoCoordinate(48.588121186482, 7.73901253938675)
            },
            new Arret() {
                Id = "ILMAI_09",
                Code = "291E",
                Name = "Illkirch Mairie",
                Coordonnee = new GeoCoordinate(48.5292582252697, 7.71107330918312)
            },
            new Arret() {
                Id = "PLISL_03",
                Code = "706C",
                Name = "Place d'Islande",
                Coordonnee = new GeoCoordinate(48.5807879117576, 7.77681156992912)
            },
            new Arret() {
                Id = "ELMER_01",
                Code = "174A",
                Name = "Elmerforst",
                Coordonnee = new GeoCoordinate(48.5625476997753, 7.71026596426964)
            },
            new Arret() {
                Id = "PHALS_01",
                Code = "474A",
                Name = "Phalsbourg",
                Coordonnee = new GeoCoordinate(48.5915452643814, 7.74911642074585)
            },
            new Arret() {
                Id = "DECLE_01",
                Code = "146",
                Name = "Deux Clés",
                Coordonnee = new GeoCoordinate(48.5317467035537, 7.7150671184063)
            },
            new Arret() {
                Id = "CAILL_06",
                Code = "75A",
                Name = "Campus d'Illkirch",
                Coordonnee = new GeoCoordinate(48.5291978324138, 7.7328810095787)
            },
            new Arret() {
                Id = "NIEDE_01",
                Code = "430B",
                Name = "Niederbourg",
                Coordonnee = new GeoCoordinate(48.5330139865008, 7.72078156471252)
            },
            new Arret() {
                Id = "ILLIX_02",
                Code = "290A",
                Name = "Illkirch Lixenbuhl",
                Coordonnee = new GeoCoordinate(48.5300095774251, 7.72450715303421)
            }
        }
    },
    new Ligne() {
        Id = "10-26",
        Name = "GARE CENTRALE (INTERIEUR-EXTERIEUR)",
        Number = "10",
        Color = "FABB00",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "STGUI_02",
                Code = "600B",
                Name = "Saint Guillaume",
                Coordonnee = new GeoCoordinate(48.5828009865384, 7.75762304663658)
            },
            new Arret() {
                Id = "STAUR_01",
                Code = "595A",
                Name = "Sainte Aurélie",
                Coordonnee = new GeoCoordinate(48.581756752819, 7.73215144872665)
            },
            new Arret() {
                Id = "STTHO_02",
                Code = "620B",
                Name = "Saint Thomas Finkwiller",
                Coordonnee = new GeoCoordinate(48.5788803407416, 7.74372786283493)
            },
            new Arret() {
                Id = "VOOBE_02",
                Code = "655B",
                Name = "Vosges Oberlin",
                Coordonnee = new GeoCoordinate(48.5896930976836, 7.75127291679382)
            },
            new Arret() {
                Id = "BRUNI_01",
                Code = "69C",
                Name = "Brant Université",
                Coordonnee = new GeoCoordinate(48.5858475060617, 7.76143044233322)
            },
            new Arret() {
                Id = "CORBE_02",
                Code = "132B",
                Name = "Corbeau",
                Coordonnee = new GeoCoordinate(48.5794943202921, 7.75139763951302)
            },
            new Arret() {
                Id = "GALLI_02",
                Code = "233D",
                Name = "Gallia",
                Coordonnee = new GeoCoordinate(48.5844582307687, 7.75923237204552)
            },
            new Arret() {
                Id = "PAFET_02",
                Code = "454B",
                Name = "Palais des Fêtes",
                Coordonnee = new GeoCoordinate(48.5903637176044, 7.74887904524803)
            },
            new Arret() {
                Id = "STNIC_02",
                Code = "616B",
                Name = "Saint Nicolas",
                Coordonnee = new GeoCoordinate(48.5783852477538, 7.74801939725876)
            },
            new Arret() {
                Id = "MAARM_03",
                Code = "375E",
                Name = "Musée d'Art Moderne",
                Coordonnee = new GeoCoordinate(48.5782122302438, 7.73380905389786)
            },
            new Arret() {
                Id = "BATEL_02",
                Code = "45B",
                Name = "Bateliers",
                Coordonnee = new GeoCoordinate(48.5807683927908, 7.75396719574928)
            },
            new Arret() {
                Id = "POVOS_02",
                Code = "512B",
                Name = "Pont des Vosges",
                Coordonnee = new GeoCoordinate(48.587748604424, 7.75820374488831)
            },
            new Arret() {
                Id = "PLPIE_01",
                Code = "485C",
                Name = "Place de Pierre",
                Coordonnee = new GeoCoordinate(48.5907291839732, 7.74494558572769)
            },
            new Arret() {
                Id = "HODEP_02",
                Code = "273B",
                Name = "Hôtel du Département",
                Coordonnee = new GeoCoordinate(48.5787117612364, 7.7397608757019)
            },
            new Arret() {
                Id = "TRAVA_02",
                Code = "633B",
                Name = "Travail",
                Coordonnee = new GeoCoordinate(48.5899734107966, 7.74207830429077)
            },
            new Arret() {
                Id = "GACEN_03",
                Code = "230",
                Name = "Gare Centrale",
                Coordonnee = new GeoCoordinate(48.5850419794455, 7.73522794246674)
            },
            new Arret() {
                Id = "LAMEY_02",
                Code = "326B",
                Name = "Lamey",
                Coordonnee = new GeoCoordinate(48.5882897346059, 7.75629803538322)
            },
            new Arret() {
                Id = "WILSO_01",
                Code = "667C",
                Name = "Wilson",
                Coordonnee = new GeoCoordinate(48.588121186482, 7.73901253938675)
            },
            new Arret() {
                Id = "OBLYO_02",
                Code = "436B",
                Name = "Obernai-Lyon",
                Coordonnee = new GeoCoordinate(48.5784038803734, 7.73164317011833)
            }
        }
    },
    new Ligne() {
        Id = "13-26",
        Name = "Montagne Verte - Lingolsheim Gare",
        Number = "13",
        Color = "F7C9E3",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "RUECK_02",
                Code = "559B",
                Name = "Rue d'Eckbolsheim",
                Coordonnee = new GeoCoordinate(48.5639988161896, 7.69055843353271)
            },
            new Arret() {
                Id = "BRUCH_02",
                Code = "68B",
                Name = "Bruche",
                Coordonnee = new GeoCoordinate(48.5702341490171, 7.71127179265022)
            },
            new Arret() {
                Id = "CAMPI_02",
                Code = "36B",
                Name = "Camping",
                Coordonnee = new GeoCoordinate(48.5733714926419, 7.71924868226051)
            },
            new Arret() {
                Id = "BLAES_02",
                Code = "55B",
                Name = "Blaesheim",
                Coordonnee = new GeoCoordinate(48.5660950955601, 7.70350143313408)
            },
            new Arret() {
                Id = "SPORT_02",
                Code = "590B",
                Name = "Sports",
                Coordonnee = new GeoCoordinate(48.5641798699952, 7.69403457641602)
            },
            new Arret() {
                Id = "MAALE_02",
                Code = "374B",
                Name = "Maxime Alexandre",
                Coordonnee = new GeoCoordinate(48.5617391391735, 7.68245950341225)
            },
            new Arret() {
                Id = "LNGAR_01",
                Code = "352A",
                Name = "Lingolsheim Gare",
                Coordonnee = new GeoCoordinate(48.5595974118053, 7.67813846468925)
            },
            new Arret() {
                Id = "GLIES_02",
                Code = "246B",
                Name = "Gliesberg",
                Coordonnee = new GeoCoordinate(48.5676588172363, 7.70915418863297)
            },
            new Arret() {
                Id = "NICIG_02",
                Code = "429B",
                Name = "Nid de Cigognes",
                Coordonnee = new GeoCoordinate(48.5724934464926, 7.7155002951622)
            },
            new Arret() {
                Id = "MOVER_02",
                Code = "410B",
                Name = "Montagne Verte",
                Coordonnee = new GeoCoordinate(48.5745822750797, 7.7270545810461)
            },
            new Arret() {
                Id = "TOURA_02",
                Code = "632B",
                Name = "Touraine",
                Coordonnee = new GeoCoordinate(48.5630793368598, 7.68835365772247)
            },
            new Arret() {
                Id = "AVENI_02",
                Code = "37B",
                Name = "Avenir",
                Coordonnee = new GeoCoordinate(48.5649280413481, 7.69846692681313)
            }
        }
    },
    new Ligne() {
        Id = "12-26",
        Name = "Entzheim Ouest - Lingolsheim Alouettes",
        Number = "12",
        Color = "89CCCF",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "LNCHA_01",
                Code = "351A",
                Name = "Lingolsheim Château",
                Coordonnee = new GeoCoordinate(48.5537220629423, 7.67982020974159)
            },
            new Arret() {
                Id = "ENCEN_01",
                Code = "177A",
                Name = "Entzheim centre",
                Coordonnee = new GeoCoordinate(48.5328763364198, 7.63523519039154)
            },
            new Arret() {
                Id = "ANFOR_01",
                Code = "28A",
                Name = "Ancienne Forge",
                Coordonnee = new GeoCoordinate(48.5314856055792, 7.63135001063347)
            },
            new Arret() {
                Id = "ICARE_01",
                Code = "288A",
                Name = "Icare",
                Coordonnee = new GeoCoordinate(48.5434307915573, 7.65506610274315)
            },
            new Arret() {
                Id = "AEROP_03",
                Code = "16B",
                Name = "Aeroparc",
                Coordonnee = new GeoCoordinate(48.5419471204747, 7.65205666422844)
            },
            new Arret() {
                Id = "FAANS_01",
                Code = "192A",
                Name = "Faisans",
                Coordonnee = new GeoCoordinate(48.5525023476652, 7.67354652285576)
            },
            new Arret() {
                Id = "PARCC_01",
                Code = "462A",
                Name = "Parc",
                Coordonnee = new GeoCoordinate(48.5350325153531, 7.63954818248749)
            },
            new Arret() {
                Id = "ENOUE_01",
                Code = "179A",
                Name = "Entzheim Ouest",
                Coordonnee = new GeoCoordinate(48.5313168680767, 7.6291760802269)
            },
            new Arret() {
                Id = "TECHA_01",
                Code = "708A",
                Name = "Terres de la chapelle",
                Coordonnee = new GeoCoordinate(48.5389752080406, 7.64609277248383)
            },
            new Arret() {
                Id = "ALOUT_04",
                Code = "681B",
                Name = "Lingolsheim Alouettes",
                Coordonnee = new GeoCoordinate(48.551524, 7.692538)
            },
            new Arret() {
                Id = "CERIS_01",
                Code = "81A",
                Name = "Cerisiers",
                Coordonnee = new GeoCoordinate(48.5347643300578, 7.64288350939751)
            },
            new Arret() {
                Id = "FLORA_01",
                Code = "214A",
                Name = "Floralies",
                Coordonnee = new GeoCoordinate(48.5368751408073, 7.64302030205727)
            },
            new Arret() {
                Id = "PENEI_01",
                Code = "469A",
                Name = "Perce-neige",
                Coordonnee = new GeoCoordinate(48.5524206771786, 7.68321990966797)
            },
            new Arret() {
                Id = "COGAL_04",
                Code = "123D",
                Name = "Collège Galilée",
                Coordonnee = new GeoCoordinate(48.5510304832412, 7.68714398145676)
            },
            new Arret() {
                Id = "CROIX_02",
                Code = "141A",
                Name = "Croix",
                Coordonnee = new GeoCoordinate(48.5552595369589, 7.6788130402565)
            },
            new Arret() {
                Id = "RUJUI_01",
                Code = "564A",
                Name = "Rue des Juifs",
                Coordonnee = new GeoCoordinate(48.5545227625154, 7.67992615699768)
            }
        }
    },
    new Ligne() {
        Id = "22-26",
        Name = "Holtzheim Ouest - Lingolsheim Alouettes",
        Number = "22",
        Color = "89CCCF",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "HOCEN_01",
                Code = "270A",
                Name = "Holtzheim Centre",
                Coordonnee = new GeoCoordinate(48.5587390977642, 7.64308333396912)
            },
            new Arret() {
                Id = "HOOUE_02",
                Code = "283B",
                Name = "Holtzheim Ouest",
                Coordonnee = new GeoCoordinate(48.562328, 7.636233)
            },
            new Arret() {
                Id = "HANGE_01",
                Code = "260A",
                Name = "Hangenbieten",
                Coordonnee = new GeoCoordinate(48.5594349812064, 7.63632953166962)
            },
            new Arret() {
                Id = "ABATT_01",
                Code = "10A",
                Name = "Abattoirs",
                Coordonnee = new GeoCoordinate(48.5570929935336, 7.65066862106323)
            },
            new Arret() {
                Id = "ALOUT_04",
                Code = "681B",
                Name = "Lingolsheim Alouettes",
                Coordonnee = new GeoCoordinate(48.551524, 7.692538)
            },
            new Arret() {
                Id = "CROIX_02",
                Code = "141A",
                Name = "Croix",
                Coordonnee = new GeoCoordinate(48.5552595369589, 7.6788130402565)
            },
            new Arret() {
                Id = "COGAL_03",
                Code = "123C",
                Name = "Collège Galilée",
                Coordonnee = new GeoCoordinate(48.5512435422617, 7.68586724996567)
            },
            new Arret() {
                Id = "RUJUI_01",
                Code = "564A",
                Name = "Rue des Juifs",
                Coordonnee = new GeoCoordinate(48.5545227625154, 7.67992615699768)
            },
            new Arret() {
                Id = "PAGAU_01",
                Code = "455A",
                Name = "Parc de Gaulle",
                Coordonnee = new GeoCoordinate(48.5590444355553, 7.63908952474594)
            },
            new Arret() {
                Id = "PENEI_02",
                Code = "469B",
                Name = "Perce-neige",
                Coordonnee = new GeoCoordinate(48.5520540460873, 7.68421098589897)
            },
            new Arret() {
                Id = "ALAIG_01",
                Code = "17A",
                Name = "A l'Aigle",
                Coordonnee = new GeoCoordinate(48.5571023137677, 7.64597475528717)
            },
            new Arret() {
                Id = "LNCHA_01",
                Code = "351A",
                Name = "Lingolsheim Château",
                Coordonnee = new GeoCoordinate(48.5537220629423, 7.67982020974159)
            }
        }
    },
    new Ligne() {
        Id = "25-26",
        Name = "Sainte Anne - République",
        Number = "15a",
        Color = "89CCCF",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "REPUB_01",
                Code = "527A",
                Name = "République",
                Coordonnee = new GeoCoordinate(48.5865918083395, 7.75383979082108)
            },
            new Arret() {
                Id = "GOLBE_02",
                Code = "248B",
                Name = "Golbery",
                Coordonnee = new GeoCoordinate(48.5871258539942, 7.76605322957039)
            },
            new Arret() {
                Id = "YPRES_02",
                Code = "673B",
                Name = "Ypres",
                Coordonnee = new GeoCoordinate(48.5861642128999, 7.78073966503143)
            },
            new Arret() {
                Id = "ROEGL_04",
                Code = "539D",
                Name = "Robertsau Eglise",
                Coordonnee = new GeoCoordinate(48.6033077546712, 7.78366620734027)
            },
            new Arret() {
                Id = "ROSTA_03",
                Code = "549A",
                Name = "Robertsau Sainte Anne",
                Coordonnee = new GeoCoordinate(48.6169205594691, 7.78810769319534)
            },
            new Arret() {
                Id = "BRUNI_02",
                Code = "69A",
                Name = "Brant Université",
                Coordonnee = new GeoCoordinate(48.5855911228818, 7.76167184114456)
            },
            new Arret() {
                Id = "QUQUI_02",
                Code = "522B",
                Name = "Quartier des Quinze",
                Coordonnee = new GeoCoordinate(48.5892788346347, 7.78272449970245)
            },
            new Arret() {
                Id = "BAILL_01",
                Code = "39A",
                Name = "Baillis",
                Coordonnee = new GeoCoordinate(48.6069986290889, 7.77991890907288)
            },
            new Arret() {
                Id = "CLSTA_02",
                Code = "117B",
                Name = "Clinique Sainte Anne",
                Coordonnee = new GeoCoordinate(48.6153424024662, 7.78605312108994)
            },
            new Arret() {
                Id = "WAGNE_02",
                Code = "701B",
                Name = "Wagner",
                Coordonnee = new GeoCoordinate(48.5872234364774, 7.77595996856689)
            },
            new Arret() {
                Id = "BREME_02",
                Code = "65B",
                Name = "Brême",
                Coordonnee = new GeoCoordinate(48.5988113469976, 7.79103398323059)
            },
            new Arret() {
                Id = "CAHAU_02",
                Code = "74B",
                Name = "Carpe Haute",
                Coordonnee = new GeoCoordinate(48.5960813667369, 7.78829008340836)
            },
            new Arret() {
                Id = "VERDN_02",
                Code = "644B",
                Name = "Verdun",
                Coordonnee = new GeoCoordinate(48.5881336058367, 7.77295723557472)
            },
            new Arret() {
                Id = "TAULE_04",
                Code = "626D",
                Name = "Tauler",
                Coordonnee = new GeoCoordinate(48.5881353800299, 7.76981234550476)
            },
            new Arret() {
                Id = "COQUI_02",
                Code = "131B",
                Name = "Conseil des Quinze",
                Coordonnee = new GeoCoordinate(48.5873600516373, 7.7823731303215)
            },
            new Arret() {
                Id = "CINOR_01",
                Code = "111A",
                Name = "Cimetière Nord",
                Coordonnee = new GeoCoordinate(48.6091223876536, 7.77977809309959)
            },
            new Arret() {
                Id = "PAPET_04",
                Code = "459D",
                Name = "Papeterie",
                Coordonnee = new GeoCoordinate(48.6116734400848, 7.78172671794891)
            },
            new Arret() {
                Id = "LAMPR_02",
                Code = "327B",
                Name = "Lamproie",
                Coordonnee = new GeoCoordinate(48.6017708762755, 7.79277071356773)
            },
            new Arret() {
                Id = "STFRA_02",
                Code = "598B",
                Name = "Saint François",
                Coordonnee = new GeoCoordinate(48.6036855647449, 7.78738081455231)
            },
            new Arret() {
                Id = "BOISF_02",
                Code = "59B",
                Name = "Bois Fleuri",
                Coordonnee = new GeoCoordinate(48.6034204037889, 7.79058873653412)
            },
            new Arret() {
                Id = "LIBER_01",
                Code = "343A",
                Name = "Liberté",
                Coordonnee = new GeoCoordinate(48.5859956576868, 7.75812596082687)
            }
        }
    },
    new Ligne() {
        Id = "40-26",
        Name = "Neuhof Ganzau - Unterelsau",
        Number = "40",
        Color = "FFDD00",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "LEFEB_01",
                Code = "336A",
                Name = "Lefèbvre",
                Coordonnee = new GeoCoordinate(48.5595157527716, 7.74581998586655)
            },
            new Arret() {
                Id = "FEDER_01",
                Code = "199A",
                Name = "Fédération",
                Coordonnee = new GeoCoordinate(48.5642464337314, 7.73860886693001)
            },
            new Arret() {
                Id = "JESUI_04",
                Code = "308B",
                Name = "Jésuites",
                Coordonnee = new GeoCoordinate(48.5389361378177, 7.76093691587448)
            },
            new Arret() {
                Id = "BOURG_01",
                Code = "63A",
                Name = "Bourgogne",
                Coordonnee = new GeoCoordinate(48.547836265888, 7.74789869785309)
            },
            new Arret() {
                Id = "MIANG_01",
                Code = "392A",
                Name = "Michel Ange",
                Coordonnee = new GeoCoordinate(48.5642064955002, 7.7202907204628)
            },
            new Arret() {
                Id = "PFIST_01",
                Code = "473A",
                Name = "Pfister",
                Coordonnee = new GeoCoordinate(48.5546896473052, 7.75327384471893)
            },
            new Arret() {
                Id = "LYCOU_01",
                Code = "366A",
                Name = "Lycée Couffignal",
                Coordonnee = new GeoCoordinate(48.5586725267802, 7.74807840585709)
            },
            new Arret() {
                Id = "STIGN_01",
                Code = "611A",
                Name = "Saint Ignace",
                Coordonnee = new GeoCoordinate(48.5314412010278, 7.76165306568146)
            },
            new Arret() {
                Id = "PLBOU_01",
                Code = "477A",
                Name = "Plaine des Bouchers",
                Coordonnee = new GeoCoordinate(48.5622237445548, 7.73961067199707)
            },
            new Arret() {
                Id = "ABEPE_01",
                Code = "12A",
                Name = "Abbé de l'Epée",
                Coordonnee = new GeoCoordinate(48.5454515686252, 7.76069819927216)
            },
            new Arret() {
                Id = "WEEBE_01",
                Code = "661A",
                Name = "Weeber",
                Coordonnee = new GeoCoordinate(48.5460988039739, 7.75181069970131)
            },
            new Arret() {
                Id = "TITIE_01",
                Code = "630A",
                Name = "Titien",
                Coordonnee = new GeoCoordinate(48.5645579508522, 7.72573694586754)
            },
            new Arret() {
                Id = "FRCOM_02",
                Code = "223B",
                Name = "Franche Comté",
                Coordonnee = new GeoCoordinate(48.5517309113976, 7.75151699781418)
            },
            new Arret() {
                Id = "UNELS_01",
                Code = "637A",
                Name = "Unterelsau",
                Coordonnee = new GeoCoordinate(48.5621829171743, 7.72987425327301)
            },
            new Arret() {
                Id = "MSCHO_03",
                Code = "412C",
                Name = "Martin Schongauer",
                Coordonnee = new GeoCoordinate(48.5661217200568, 7.72027194499969)
            },
            new Arret() {
                Id = "REMBR_02",
                Code = "526B",
                Name = "Rembrandt",
                Coordonnee = new GeoCoordinate(48.5665707844561, 7.72369176149368)
            },
            new Arret() {
                Id = "DOUBS_01",
                Code = "155A",
                Name = "Doubs",
                Coordonnee = new GeoCoordinate(48.5684104868956, 7.73913994431496)
            },
            new Arret() {
                Id = "NEHGA_01",
                Code = "424A",
                Name = "Neuhof Ganzau",
                Coordonnee = new GeoCoordinate(48.5273016377336, 7.7601845562458)
            },
            new Arret() {
                Id = "ILDFR_01",
                Code = "289A",
                Name = "Ile de France",
                Coordonnee = new GeoCoordinate(48.5494076542633, 7.75012493133545)
            },
            new Arret() {
                Id = "FARIE_01",
                Code = "196A",
                Name = "Faisanderie",
                Coordonnee = new GeoCoordinate(48.5344286524214, 7.76037365198135)
            },
            new Arret() {
                Id = "TINTO_01",
                Code = "629A",
                Name = "Tintoret",
                Coordonnee = new GeoCoordinate(48.5650079166394, 7.72807314991951)
            },
            new Arret() {
                Id = "CISUD_01",
                Code = "113A",
                Name = "Cimetière Sud",
                Coordonnee = new GeoCoordinate(48.5458795084249, 7.75684118270874)
            },
            new Arret() {
                Id = "GLAUB_01",
                Code = "245A",
                Name = "Glaubitz",
                Coordonnee = new GeoCoordinate(48.5430880682879, 7.76424944400787)
            },
            new Arret() {
                Id = "ROREU_04",
                Code = "546B",
                Name = "Neuhof Rodolphe Reuss",
                Coordonnee = new GeoCoordinate(48.5456033900056, 7.76559054851532)
            },
            new Arret() {
                Id = "ELSAU_01",
                Code = "175A",
                Name = "Elsau",
                Coordonnee = new GeoCoordinate(48.5676845534542, 7.72611111402512)
            },
            new Arret() {
                Id = "POSCH_04",
                Code = "499B",
                Name = "Pont Schuhansen",
                Coordonnee = new GeoCoordinate(48.5413690896273, 7.76243090629578)
            }
        }
    },
    new Ligne() {
        Id = "50-26",
        Name = "Montagne Verte - Wacken",
        Number = "50",
        Color = "FFDD00",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "MOVER_01",
                Code = "410A",
                Name = "Montagne Verte",
                Coordonnee = new GeoCoordinate(48.5746727831188, 7.72701770067215)
            },
            new Arret() {
                Id = "ABLEM_02",
                Code = "13B",
                Name = "Abbé Lemire",
                Coordonnee = new GeoCoordinate(48.5781394739858, 7.72471770644188)
            },
            new Arret() {
                Id = "CHARM_01",
                Code = "85A",
                Name = "Charmille",
                Coordonnee = new GeoCoordinate(48.57986518872, 7.71729469299316)
            },
            new Arret() {
                Id = "STGAL_01",
                Code = "599A",
                Name = "Saint Gall",
                Coordonnee = new GeoCoordinate(48.5802369416621, 7.71990448236465)
            },
            new Arret() {
                Id = "GRUBE_01",
                Code = "252A",
                Name = "Grüber",
                Coordonnee = new GeoCoordinate(48.5786576382234, 7.70959675312042)
            },
            new Arret() {
                Id = "SCHNO_01",
                Code = "575A",
                Name = "Schnokeloch",
                Coordonnee = new GeoCoordinate(48.579054243221, 7.71219044923782)
            },
            new Arret() {
                Id = "ENGEL_02",
                Code = "178B",
                Name = "Engelbreit",
                Coordonnee = new GeoCoordinate(48.5805341646013, 7.70775675773621)
            },
            new Arret() {
                Id = "CUIVR_01",
                Code = "741A",
                Name = "Cuivre",
                Coordonnee = new GeoCoordinate(48.58305, 7.707489)
            },
            new Arret() {
                Id = "FORGE_03",
                Code = "728A",
                Name = "Forges",
                Coordonnee = new GeoCoordinate(48.585174, 7.706875)
            },
            new Arret() {
                Id = "JANET_02",
                Code = "727B",
                Name = "Jacobi Netter",
                Coordonnee = new GeoCoordinate(48.586764, 7.704944)
            },
            new Arret() {
                Id = "DANTE_05",
                Code = "143D",
                Name = "Dante",
                Coordonnee = new GeoCoordinate(48.5914104346142, 7.70304679870605)
            },
            new Arret() {
                Id = "SHAKE_02",
                Code = "729B",
                Name = "Shakespeare",
                Coordonnee = new GeoCoordinate(48.5944928015543, 7.70390510559082)
            },
            new Arret() {
                Id = "STANT_02",
                Code = "592B",
                Name = "Saint Antoine",
                Coordonnee = new GeoCoordinate(48.5977293061935, 7.70958065986633)
            },
            new Arret() {
                Id = "BERST_01",
                Code = "49A",
                Name = "Berstett",
                Coordonnee = new GeoCoordinate(48.6001957932762, 7.71179348230362)
            },
            new Arret() {
                Id = "COPER_02",
                Code = "130B",
                Name = "Copernic",
                Coordonnee = new GeoCoordinate(48.6009008618395, 7.71557807922363)
            },
            new Arret() {
                Id = "LAVOI_03",
                Code = "719C",
                Name = "Lavoisier",
                Coordonnee = new GeoCoordinate(48.6019131388838, 7.71907742829323)
            },
            new Arret() {
                Id = "RIETH_05",
                Code = "533E",
                Name = "Rieth",
                Coordonnee = new GeoCoordinate(48.602058, 7.722658)
            },
            new Arret() {
                Id = "KEPLE_01",
                Code = "726A",
                Name = "Kepler",
                Coordonnee = new GeoCoordinate(48.605208, 7.720754)
            },
            new Arret() {
                Id = "STJUN_02",
                Code = "612B",
                Name = "Saint Junien",
                Coordonnee = new GeoCoordinate(48.6072894873148, 7.72318214178085)
            },
            new Arret() {
                Id = "PAIXX_02",
                Code = "457B",
                Name = "Paix",
                Coordonnee = new GeoCoordinate(48.606241325727, 7.72958591580391)
            },
            new Arret() {
                Id = "COLEC_02",
                Code = "124B",
                Name = "Collège Leclerc",
                Coordonnee = new GeoCoordinate(48.6087171512655, 7.73170351982117)
            },
            new Arret() {
                Id = "ECRIV_04",
                Code = "169D",
                Name = "Ecrivains",
                Coordonnee = new GeoCoordinate(48.6106945321804, 7.73483365774155)
            },
            new Arret() {
                Id = "LAMAR_02",
                Code = "325B",
                Name = "Lamartine",
                Coordonnee = new GeoCoordinate(48.6109880292053, 7.73759767413139)
            },
            new Arret() {
                Id = "FONDE_02",
                Code = "218B",
                Name = "Fondeur",
                Coordonnee = new GeoCoordinate(48.6087242451471, 7.74415701627731)
            },
            new Arret() {
                Id = "LAUTE_02",
                Code = "332B",
                Name = "Lauterbourg",
                Coordonnee = new GeoCoordinate(48.6094903784929, 7.74235859513283)
            },
            new Arret() {
                Id = "MARRO_01",
                Code = "386C",
                Name = "Maison Rouge",
                Coordonnee = new GeoCoordinate(48.6070686835098, 7.74888038635254)
            },
            new Arret() {
                Id = "SCHMA_01",
                Code = "574A",
                Name = "Schiltigheim Mairie",
                Coordonnee = new GeoCoordinate(48.6052383690183, 7.74794965982437)
            },
            new Arret() {
                Id = "SQCHA_02",
                Code = "591B",
                Name = "Square du Château",
                Coordonnee = new GeoCoordinate(48.6033485706481, 7.75004982948303)
            },
            new Arret() {
                Id = "CMCOO_02",
                Code = "118B",
                Name = "CMCO",
                Coordonnee = new GeoCoordinate(48.6008902193683, 7.7497735619545)
            },
            new Arret() {
                Id = "RIAAR_02",
                Code = "530D",
                Name = "Rives de l'Aar",
                Coordonnee = new GeoCoordinate(48.6001931326214, 7.75445938110352)
            },
            new Arret() {
                Id = "WACKE_04",
                Code = "657D",
                Name = "Wacken",
                Coordonnee = new GeoCoordinate(48.5984565820746, 7.76196822524071)
            },
            new Arret() {
                Id = "LEMAR_01",
                Code = "338C",
                Name = "Le Marais",
                Coordonnee = new GeoCoordinate(48.6092878269967, 7.76586949825187)
            },
            new Arret() {
                Id = "SCHLE_01",
                Code = "572A",
                Name = "Schiltigheim le Marais",
                Coordonnee = new GeoCoordinate(48.608714, 7.767612)
            },
            new Arret() {
                Id = "ZORNN_01",
                Code = "677A",
                Name = "Zorn",
                Coordonnee = new GeoCoordinate(48.609305940046, 7.75762975215912)
            },
            new Arret() {
                Id = "BITCH_04",
                Code = "54A",
                Name = "Bitche",
                Coordonnee = new GeoCoordinate(48.6098140308699, 7.75301232933998)
            }
        }
    },
    new Ligne() {
        Id = "B-482",
        Name = "Lingolsheim Tiergaertel - Hoenheim Gare",
        Number = "B",
        Color = "009EE0",
        Type = "Tram",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "REPUB_05",
                Code = "527C",
                Name = "République",
                Coordonnee = new GeoCoordinate(48.5864569653549, 7.7537003159523)
            },
            new Arret() {
                Id = "BROGL_02",
                Code = "67B",
                Name = "Broglie",
                Coordonnee = new GeoCoordinate(48.5846631645828, 7.74907350540161)
            },
            new Arret() {
                Id = "LAITE_04",
                Code = "323D",
                Name = "Laiterie",
                Coordonnee = new GeoCoordinate(48.575864457189, 7.73136958479881)
            },
            new Arret() {
                Id = "MSCHO_02",
                Code = "412B",
                Name = "Martin Schongauer",
                Coordonnee = new GeoCoordinate(48.5661004204606, 7.72006809711456)
            },
            new Arret() {
                Id = "RIAAR_04",
                Code = "530B",
                Name = "Rives de l'Aar",
                Coordonnee = new GeoCoordinate(48.6006614056952, 7.75459349155426)
            },
            new Arret() {
                Id = "MOVER_04",
                Code = "410D",
                Name = "Montagne Verte",
                Coordonnee = new GeoCoordinate(48.5747526430187, 7.72707268595696)
            },
            new Arret() {
                Id = "OSHVI_02",
                Code = "448D",
                Name = "Ostwald Hôtel de Ville",
                Coordonnee = new GeoCoordinate(48.5510304832412, 7.7102056145668)
            },
            new Arret() {
                Id = "LYKLE_06",
                Code = "368D",
                Name = "Lycée Kléber",
                Coordonnee = new GeoCoordinate(48.5939632687268, 7.75777593255043)
            },
            new Arret() {
                Id = "WACKE_06",
                Code = "657B",
                Name = "Wacken",
                Coordonnee = new GeoCoordinate(48.5985133446297, 7.76055872440338)
            },
            new Arret() {
                Id = "ELMER_04",
                Code = "174D",
                Name = "Elmerforst",
                Coordonnee = new GeoCoordinate(48.5629550816142, 7.71140053868294)
            },
            new Arret() {
                Id = "PACON_02",
                Code = "451B",
                Name = "Parc du Contades",
                Coordonnee = new GeoCoordinate(48.590201385821, 7.75588497519493)
            },
            new Arret() {
                Id = "BORIE_02",
                Code = "58B",
                Name = "Bohrie",
                Coordonnee = new GeoCoordinate(48.5498169174635, 7.7027490735054)
            },
            new Arret() {
                Id = "WIHRE_02",
                Code = "665D",
                Name = "Wihrel",
                Coordonnee = new GeoCoordinate(48.554613306459, 7.71275371313095)
            },
            new Arret() {
                Id = "FUGLA_02",
                Code = "228B",
                Name = "Futura Glacière",
                Coordonnee = new GeoCoordinate(48.6049794238213, 7.75921493768692)
            },
            new Arret() {
                Id = "LITIE_01",
                Code = "348A",
                Name = "Lingolsheim Tiergaertel",
                Coordonnee = new GeoCoordinate(48.5537895281402, 7.68942385911942)
            },
            new Arret() {
                Id = "LYMAB_02",
                Code = "369B",
                Name = "Lycée Marc Bloch",
                Coordonnee = new GeoCoordinate(48.6164160865557, 7.76785165071487)
            },
            new Arret() {
                Id = "POPHA_04",
                Code = "496C",
                Name = "Pont Phario",
                Coordonnee = new GeoCoordinate(48.6128580351405, 7.76713952422142)
            },
            new Arret() {
                Id = "LERIE_02",
                Code = "340B",
                Name = "Le Ried",
                Coordonnee = new GeoCoordinate(48.6213338175421, 7.76788786053658)
            },
            new Arret() {
                Id = "ALWIN_02",
                Code = "24B",
                Name = "Alt Winmärik-Vieux Marché aux Vins",
                Coordonnee = new GeoCoordinate(48.5833084568179, 7.74004921317101)
            },
            new Arret() {
                Id = "GEGAU_02",
                Code = "238B",
                Name = "Général de Gaulle",
                Coordonnee = new GeoCoordinate(48.6216245931952, 7.76415690779686)
            },
            new Arret() {
                Id = "MAARM_05",
                Code = "375D",
                Name = "Musée d'Art Moderne",
                Coordonnee = new GeoCoordinate(48.5778111822511, 7.73386672139168)
            },
            new Arret() {
                Id = "LEMAR_04",
                Code = "338B",
                Name = "Le Marais",
                Coordonnee = new GeoCoordinate(48.6098530463588, 7.76556372642517)
            },
            new Arret() {
                Id = "ALOUT_02",
                Code = "681E",
                Name = "Lingolsheim Alouettes",
                Coordonnee = new GeoCoordinate(48.5513589488565, 7.6926827430725)
            },
            new Arret() {
                Id = "HOFER_05",
                Code = "275D",
                Name = "Homme de Fer",
                Coordonnee = new GeoCoordinate(48.5843863706631, 7.74468272924423)
            },
            new Arret() {
                Id = "FANAG_02",
                Code = "193B",
                Name = "Faubourg National-Gare",
                Coordonnee = new GeoCoordinate(48.5824194932881, 7.73642152547836)
            },
            new Arret() {
                Id = "HOGAR_06",
                Code = "276B",
                Name = "Hoenheim Gare",
                Coordonnee = new GeoCoordinate(48.6278900469539, 7.75861948728561)
            },
            new Arret() {
                Id = "ELSAU_04",
                Code = "175D",
                Name = "Elsau",
                Coordonnee = new GeoCoordinate(48.5678904427261, 7.72613927721977)
            }
        }
    },
    new Ligne() {
        Id = "F-482",
        Name = "Elsau - Place d'Islande",
        Number = "F",
        Color = "B1C800",
        Type = "Tram",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "PLISL_01",
                Code = "706A",
                Name = "Place d'Islande",
                Coordonnee = new GeoCoordinate(48.5804046288487, 7.77545839548111)
            },
            new Arret() {
                Id = "GALLI_03",
                Code = "233A",
                Name = "Gallia",
                Coordonnee = new GeoCoordinate(48.5842949928503, 7.75853097438812)
            },
            new Arret() {
                Id = "MOVER_03",
                Code = "410C",
                Name = "Montagne Verte",
                Coordonnee = new GeoCoordinate(48.5744678087982, 7.72738516330719)
            },
            new Arret() {
                Id = "HOFER_04",
                Code = "275C",
                Name = "Homme de Fer",
                Coordonnee = new GeoCoordinate(48.5843508841535, 7.74499118328094)
            },
            new Arret() {
                Id = "MAARM_04",
                Code = "375C",
                Name = "Musée d'Art Moderne",
                Coordonnee = new GeoCoordinate(48.5779859756833, 7.73414835333824)
            },
            new Arret() {
                Id = "LAITE_03",
                Code = "323C",
                Name = "Laiterie",
                Coordonnee = new GeoCoordinate(48.5759895680272, 7.73160830140114)
            },
            new Arret() {
                Id = "ALWIN_01",
                Code = "24A",
                Name = "Alt Winmärik-Vieux Marché aux Vins",
                Coordonnee = new GeoCoordinate(48.5834495184556, 7.74032413959503)
            },
            new Arret() {
                Id = "BROGL_01",
                Code = "67A",
                Name = "Broglie",
                Coordonnee = new GeoCoordinate(48.5848264013121, 7.74951338768005)
            },
            new Arret() {
                Id = "OBSER_05",
                Code = "438E",
                Name = "Observatoire",
                Coordonnee = new GeoCoordinate(48.5813024999816, 7.76911497116089)
            },
            new Arret() {
                Id = "ELSAU_03",
                Code = "175C",
                Name = "Elsau",
                Coordonnee = new GeoCoordinate(48.5677750738408, 7.72640481591225)
            },
            new Arret() {
                Id = "REPUB_07",
                Code = "527E",
                Name = "République",
                Coordonnee = new GeoCoordinate(48.5858448446513, 7.75518625974655)
            },
            new Arret() {
                Id = "UNIVE_01",
                Code = "638A",
                Name = "Université",
                Coordonnee = new GeoCoordinate(48.5826847644811, 7.76406437158585)
            },
            new Arret() {
                Id = "FANAG_01",
                Code = "193A",
                Name = "Faubourg National-Gare",
                Coordonnee = new GeoCoordinate(48.5824230420758, 7.73686274886131)
            }
        }
    },
    new Ligne() {
        Id = "07-26",
        Name = "Kibitzenau - Illkirch Fort Uhrich",
        Number = "7",
        Color = "009036",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "COLON_02",
                Code = "128B",
                Name = "Colonne",
                Coordonnee = new GeoCoordinate(48.5381405194454, 7.73310765624046)
            },
            new Arret() {
                Id = "ROSEA_02",
                Code = "547B",
                Name = "Roseaux",
                Coordonnee = new GeoCoordinate(48.5182957421018, 7.71903812885284)
            },
            new Arret() {
                Id = "ALSAC_02",
                Code = "22B",
                Name = "Alsace",
                Coordonnee = new GeoCoordinate(48.5322333723753, 7.72726446390152)
            },
            new Arret() {
                Id = "CHATE_02",
                Code = "86B",
                Name = "Chateaubriand",
                Coordonnee = new GeoCoordinate(48.5236911222996, 7.72145345807076)
            },
            new Arret() {
                Id = "ORMES_02",
                Code = "445B",
                Name = "Ormes",
                Coordonnee = new GeoCoordinate(48.5159736152965, 7.72225677967072)
            },
            new Arret() {
                Id = "EMMAT_02",
                Code = "176B",
                Name = "Emile Mathis",
                Coordonnee = new GeoCoordinate(48.5528423440352, 7.74419322609901)
            },
            new Arret() {
                Id = "CETRA_01",
                Code = "83A",
                Name = "Centre de Traumatologie",
                Coordonnee = new GeoCoordinate(48.5375269257541, 7.72818848490715)
            },
            new Arret() {
                Id = "RHTOR_02",
                Code = "529B",
                Name = "Rhin Tortu",
                Coordonnee = new GeoCoordinate(48.5532462532025, 7.75797307491302)
            },
            new Arret() {
                Id = "DIETT_02",
                Code = "149B",
                Name = "Dietterlin",
                Coordonnee = new GeoCoordinate(48.5526727899953, 7.74944365024567)
            },
            new Arret() {
                Id = "ILLIX_06",
                Code = "290F",
                Name = "Illkirch Lixenbuhl",
                Coordonnee = new GeoCoordinate(48.5300095774251, 7.72450715303421)
            },
            new Arret() {
                Id = "BAGGE_02",
                Code = "38B",
                Name = "Baggersee",
                Coordonnee = new GeoCoordinate(48.5448620356722, 7.7380134165287)
            },
            new Arret() {
                Id = "KIBIT_07",
                Code = "316D",
                Name = "Kibitzenau",
                Coordonnee = new GeoCoordinate(48.5547730894936, 7.76699870824814)
            },
            new Arret() {
                Id = "FRCOM_02",
                Code = "223B",
                Name = "Franche Comté",
                Coordonnee = new GeoCoordinate(48.5517309113976, 7.75151699781418)
            },
            new Arret() {
                Id = "BERGE_02",
                Code = "47B",
                Name = "Bergerac",
                Coordonnee = new GeoCoordinate(48.5543043911613, 7.76300489902496)
            },
            new Arret() {
                Id = "HOHWA_05",
                Code = "280A",
                Name = "Hohwart",
                Coordonnee = new GeoCoordinate(48.5493055598905, 7.74178192019463)
            },
            new Arret() {
                Id = "LOLOU_04",
                Code = "356D",
                Name = "Louis Loucheur",
                Coordonnee = new GeoCoordinate(48.5494085420395, 7.75814071297646)
            },
            new Arret() {
                Id = "FOUHR_01",
                Code = "221A",
                Name = "Illkirch Fort Uhrich",
                Coordonnee = new GeoCoordinate(48.5144802556355, 7.72325858473778)
            },
            new Arret() {
                Id = "VISCO_03",
                Code = "653C",
                Name = "Vincent Scotto",
                Coordonnee = new GeoCoordinate(48.5272439070394, 7.7215701341629)
            },
            new Arret() {
                Id = "SCHUL_01",
                Code = "577A",
                Name = "Schulmeister",
                Coordonnee = new GeoCoordinate(48.5498763979568, 7.75263011455536)
            },
            new Arret() {
                Id = "VANNE_02",
                Code = "640B",
                Name = "Vanneaux",
                Coordonnee = new GeoCoordinate(48.5543026157805, 7.76038974523544)
            },
            new Arret() {
                Id = "MALRA_02",
                Code = "379B",
                Name = "Malraux",
                Coordonnee = new GeoCoordinate(48.5216952361462, 7.7205964922905)
            },
            new Arret() {
                Id = "CIMEI_04",
                Code = "100D",
                Name = "Cité Meinau",
                Coordonnee = new GeoCoordinate(48.5481052697324, 7.75559663772583)
            }
        }
    },
    new Ligne() {
        Id = "14-26",
        Name = "Ancienne Douane - Neuhof Lorient",
        Number = "14",
        Color = "89CCCF",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "COREU_03",
                Code = "133B",
                Name = "Neuhof Corps Européen",
                Coordonnee = new GeoCoordinate(48.5439342176438, 7.78117820620537)
            },
            new Arret() {
                Id = "PTHOP_01",
                Code = "520C",
                Name = "Porte de l'Hôpital",
                Coordonnee = new GeoCoordinate(48.5780676048964, 7.75046288967133)
            },
            new Arret() {
                Id = "STCHR_03",
                Code = "596C",
                Name = "Saint Christophe",
                Coordonnee = new GeoCoordinate(48.551449498462, 7.76700139045715)
            },
            new Arret() {
                Id = "MULHO_01",
                Code = "415A",
                Name = "Mulhouse",
                Coordonnee = new GeoCoordinate(48.5681158550194, 7.7575358748436)
            },
            new Arret() {
                Id = "ETPOL_03",
                Code = "189C",
                Name = "Etoile Polygone",
                Coordonnee = new GeoCoordinate(48.571634463903, 7.75563150644302)
            },
            new Arret() {
                Id = "ETBOU_1B",
                Code = "186D",
                Name = "Etoile Bourse",
                Coordonnee = new GeoCoordinate(48.5743249474167, 7.75365471839905)
            },
            new Arret() {
                Id = "ANDOU_01",
                Code = "26A",
                Name = "Ancienne Douane",
                Coordonnee = new GeoCoordinate(48.5796833038262, 7.74987146258354)
            },
            new Arret() {
                Id = "NEHJM_01",
                Code = "425A",
                Name = "Jean Moulin",
                Coordonnee = new GeoCoordinate(48.5414374592115, 7.77547851204872)
            },
            new Arret() {
                Id = "KLEBS_01",
                Code = "318A",
                Name = "Klebsau",
                Coordonnee = new GeoCoordinate(48.5443595066792, 7.77343869209289)
            },
            new Arret() {
                Id = "NEDMA_01",
                Code = "421A",
                Name = "Neudorf Marché",
                Coordonnee = new GeoCoordinate(48.5660533838204, 7.75888100266457)
            },
            new Arret() {
                Id = "KIEFE_01",
                Code = "317A",
                Name = "Kiefer",
                Coordonnee = new GeoCoordinate(48.5474438550752, 7.77023613452911)
            },
            new Arret() {
                Id = "KIBIT_05",
                Code = "316G",
                Name = "Kibitzenau",
                Coordonnee = new GeoCoordinate(48.5549630531115, 7.76634156703949)
            },
            new Arret() {
                Id = "NEHLO_03",
                Code = "426A",
                Name = "Neuhof Lorient",
                Coordonnee = new GeoCoordinate(48.5439111329593, 7.78879836201668)
            },
            new Arret() {
                Id = "INGOL_01",
                Code = "293A",
                Name = "Ingold",
                Coordonnee = new GeoCoordinate(48.545579418239, 7.7721780538559)
            },
            new Arret() {
                Id = "HAUTE_03",
                Code = "262A",
                Name = "Hautefort",
                Coordonnee = new GeoCoordinate(48.549410317592, 7.76918202638626)
            },
            new Arret() {
                Id = "POLYG_01",
                Code = "700A",
                Name = "Polygone",
                Coordonnee = new GeoCoordinate(48.5575798625094, 7.76612967252731)
            },
            new Arret() {
                Id = "NEDGR_01",
                Code = "420A",
                Name = "Neudorf Gravière",
                Coordonnee = new GeoCoordinate(48.561300682685, 7.76382699608803)
            },
            new Arret() {
                Id = "LAZAR_01",
                Code = "334A",
                Name = "Lazaret",
                Coordonnee = new GeoCoordinate(48.5635177779302, 7.76145055890083)
            },
            new Arret() {
                Id = "LAROC_02",
                Code = "330B",
                Name = "La Rochelle",
                Coordonnee = new GeoCoordinate(48.5362686358332, 7.78688460588455)
            },
            new Arret() {
                Id = "BOULO_01",
                Code = "739A",
                Name = "Boulogne",
                Coordonnee = new GeoCoordinate(48.539912, 7.787929)
            }
        }
    },
    new Ligne() {
        Id = "24-26",
        Name = "Ancienne Douane - Neuhof Stéphanie",
        Number = "24",
        Color = "89CCCF",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "WELSC_01",
                Code = "662A",
                Name = "Welsch",
                Coordonnee = new GeoCoordinate(48.5335992171837, 7.76840150356293)
            },
            new Arret() {
                Id = "NEHEG_01",
                Code = "423A",
                Name = "Neuhof Eglise",
                Coordonnee = new GeoCoordinate(48.5368564928856, 7.77059823274612)
            },
            new Arret() {
                Id = "PTHOP_01",
                Code = "520C",
                Name = "Porte de l'Hôpital",
                Coordonnee = new GeoCoordinate(48.5780676048964, 7.75046288967133)
            },
            new Arret() {
                Id = "COLOM_01",
                Code = "127A",
                Name = "Colombes",
                Coordonnee = new GeoCoordinate(48.5302245011684, 7.76847526431084)
            },
            new Arret() {
                Id = "MULHO_01",
                Code = "415A",
                Name = "Mulhouse",
                Coordonnee = new GeoCoordinate(48.5681158550194, 7.7575358748436)
            },
            new Arret() {
                Id = "ETPOL_03",
                Code = "189C",
                Name = "Etoile Polygone",
                Coordonnee = new GeoCoordinate(48.571634463903, 7.75563150644302)
            },
            new Arret() {
                Id = "ETBOU_1B",
                Code = "186D",
                Name = "Etoile Bourse",
                Coordonnee = new GeoCoordinate(48.5743249474167, 7.75365471839905)
            },
            new Arret() {
                Id = "ANDOU_01",
                Code = "26A",
                Name = "Ancienne Douane",
                Coordonnee = new GeoCoordinate(48.5796833038262, 7.74987146258354)
            },
            new Arret() {
                Id = "NEDMA_01",
                Code = "421A",
                Name = "Neudorf Marché",
                Coordonnee = new GeoCoordinate(48.5660533838204, 7.75888100266457)
            },
            new Arret() {
                Id = "NEHST_01",
                Code = "427A",
                Name = "Neuhof Stéphanie",
                Coordonnee = new GeoCoordinate(48.5276675599875, 7.76947036385536)
            },
            new Arret() {
                Id = "RIEHL_01",
                Code = "532A",
                Name = "Riehl",
                Coordonnee = new GeoCoordinate(48.5428447866314, 7.766073346138)
            },
            new Arret() {
                Id = "KIBIT_05",
                Code = "316G",
                Name = "Kibitzenau",
                Coordonnee = new GeoCoordinate(48.5549630531115, 7.76634156703949)
            },
            new Arret() {
                Id = "STCHR_05",
                Code = "596E",
                Name = "Saint Christophe",
                Coordonnee = new GeoCoordinate(48.5513127862501, 7.7659660577774)
            },
            new Arret() {
                Id = "ROREU_04",
                Code = "546B",
                Name = "Neuhof Rodolphe Reuss",
                Coordonnee = new GeoCoordinate(48.5456033900056, 7.76559054851532)
            },
            new Arret() {
                Id = "POLYG_01",
                Code = "700A",
                Name = "Polygone",
                Coordonnee = new GeoCoordinate(48.5575798625094, 7.76612967252731)
            },
            new Arret() {
                Id = "DALIS_01",
                Code = "142A",
                Name = "Dalis",
                Coordonnee = new GeoCoordinate(48.5396092069892, 7.76809841394424)
            },
            new Arret() {
                Id = "NEDGR_01",
                Code = "420A",
                Name = "Neudorf Gravière",
                Coordonnee = new GeoCoordinate(48.561300682685, 7.76382699608803)
            },
            new Arret() {
                Id = "LAZAR_01",
                Code = "334A",
                Name = "Lazaret",
                Coordonnee = new GeoCoordinate(48.5635177779302, 7.76145055890083)
            },
            new Arret() {
                Id = "COBOI_01",
                Code = "119A",
                Name = "Coucou des Bois",
                Coordonnee = new GeoCoordinate(48.5307147370371, 7.77382627129555)
            },
            new Arret() {
                Id = "GOLDS_01",
                Code = "249A",
                Name = "Goldschmidt",
                Coordonnee = new GeoCoordinate(48.5335192922996, 7.77148872613907)
            },
            new Arret() {
                Id = "BOUGU_01",
                Code = "62A",
                Name = "Bouguer",
                Coordonnee = new GeoCoordinate(48.5403959229358, 7.76902377605438)
            },
            new Arret() {
                Id = "KLEBS_01",
                Code = "318A",
                Name = "Klebsau",
                Coordonnee = new GeoCoordinate(48.5443595066792, 7.77343869209289)
            },
            new Arret() {
                Id = "KIEFE_01",
                Code = "317A",
                Name = "Kiefer",
                Coordonnee = new GeoCoordinate(48.5474438550752, 7.77023613452911)
            },
            new Arret() {
                Id = "SDMWA_02",
                Code = "579B",
                Name = "Stade Michel Walter",
                Coordonnee = new GeoCoordinate(48.5430134857146, 7.77166306972504)
            },
            new Arret() {
                Id = "INGOL_01",
                Code = "293A",
                Name = "Ingold",
                Coordonnee = new GeoCoordinate(48.545579418239, 7.7721780538559)
            },
            new Arret() {
                Id = "HAUTE_03",
                Code = "262A",
                Name = "Hautefort",
                Coordonnee = new GeoCoordinate(48.549410317592, 7.76918202638626)
            },
            new Arret() {
                Id = "PLCOL_01",
                Code = "478A",
                Name = "Place des Colombes",
                Coordonnee = new GeoCoordinate(48.5309696222892, 7.770666629076)
            }
        }
    },
    new Ligne() {
        Id = "62-26",
        Name = "Baggersee - Graffenstaden / Geispolsheim",
        Number = "62",
        Color = "F7C9E3",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "COLON_02",
                Code = "128B",
                Name = "Colonne",
                Coordonnee = new GeoCoordinate(48.5381405194454, 7.73310765624046)
            },
            new Arret() {
                Id = "DECLE_02",
                Code = "146A",
                Name = "Deux Clés",
                Coordonnee = new GeoCoordinate(48.5319118872913, 7.71602466702461)
            },
            new Arret() {
                Id = "BROCH_02",
                Code = "66B",
                Name = "Brochet",
                Coordonnee = new GeoCoordinate(48.5242427084733, 7.70789355039597)
            },
            new Arret() {
                Id = "CETRA_01",
                Code = "83A",
                Name = "Centre de Traumatologie",
                Coordonnee = new GeoCoordinate(48.5375269257541, 7.72818848490715)
            },
            new Arret() {
                Id = "DIGUE_02",
                Code = "150B",
                Name = "Graffenstaden Digue",
                Coordonnee = new GeoCoordinate(48.5202615604408, 7.70524889230728)
            },
            new Arret() {
                Id = "BAGGE_08",
                Code = "38G",
                Name = "Baggersee",
                Coordonnee = new GeoCoordinate(48.544928027837, 7.73703529204602)
            },
            new Arret() {
                Id = "GRUSI_01",
                Code = "254A",
                Name = "Graffenstaden Usine",
                Coordonnee = new GeoCoordinate(48.5275836290246, 7.70999170839787)
            },
            new Arret() {
                Id = "NIEDE_02",
                Code = "430A",
                Name = "Niederbourg",
                Coordonnee = new GeoCoordinate(48.5331019047438, 7.72117048501968)
            },
            new Arret() {
                Id = "ILMAI_03",
                Code = "291C",
                Name = "Illkirch Mairie",
                Coordonnee = new GeoCoordinate(48.5292084181932, 7.71103170496292)
            },
            new Arret() {
                Id = "GECEN_02",
                Code = "236A",
                Name = "Geispolsheim Centre Commercial",
                Coordonnee = new GeoCoordinate(48.5247534310557, 7.69009441137314)
            },
            new Arret() {
                Id = "POPEA_02",
                Code = "495B",
                Name = "Pont du Péage",
                Coordonnee = new GeoCoordinate(48.5188074129628, 7.70340085029602)
            },
            new Arret() {
                Id = "RUFOR_02",
                Code = "561B",
                Name = "Rue du Fort",
                Coordonnee = new GeoCoordinate(48.5222663856105, 7.69239574670792)
            }
        }
    },
    new Ligne() {
        Id = "65-26",
        Name = "Lipsheim Gare - Baggersee",
        Number = "65",
        Color = "F7C9E3",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "CRAMM_01",
                Code = "135A",
                Name = "C.R.A.M.",
                Coordonnee = new GeoCoordinate(48.5001849511034, 7.71766752004623)
            },
            new Arret() {
                Id = "COLON_01",
                Code = "128A",
                Name = "Colonne",
                Coordonnee = new GeoCoordinate(48.5384539732656, 7.7332592010498)
            },
            new Arret() {
                Id = "CESPO_01",
                Code = "82A",
                Name = "Centre Sportif",
                Coordonnee = new GeoCoordinate(48.4912515598869, 7.68379256129265)
            },
            new Arret() {
                Id = "DECLE_01",
                Code = "146",
                Name = "Deux Clés",
                Coordonnee = new GeoCoordinate(48.5317467035537, 7.7150671184063)
            },
            new Arret() {
                Id = "FEMAI_02",
                Code = "210B",
                Name = "Fegersheim Mairie",
                Coordonnee = new GeoCoordinate(48.4904996328212, 7.67983227968216)
            },
            new Arret() {
                Id = "BAGGE_07",
                Code = "38F",
                Name = "Baggersee",
                Coordonnee = new GeoCoordinate(48.5449250734092, 7.73695796728134)
            },
            new Arret() {
                Id = "CETRA_02",
                Code = "83B",
                Name = "Centre de Traumatologie",
                Coordonnee = new GeoCoordinate(48.5375109420274, 7.72796854376793)
            },
            new Arret() {
                Id = "DEGAU_01",
                Code = "147A",
                Name = "De Gaulle",
                Coordonnee = new GeoCoordinate(48.4886882071795, 7.7094130218029)
            },
            new Arret() {
                Id = "COCHA_01",
                Code = "120A",
                Name = "Cor de chasse",
                Coordonnee = new GeoCoordinate(48.5131885217699, 7.71227493882179)
            },
            new Arret() {
                Id = "GRUSI_02",
                Code = "254B",
                Name = "Graffenstaden Usine",
                Coordonnee = new GeoCoordinate(48.5269681310463, 7.70948946475983)
            },
            new Arret() {
                Id = "GRZOI_01",
                Code = "255A",
                Name = "Graffenstaden Z.I",
                Coordonnee = new GeoCoordinate(48.5106005129562, 7.71373808383942)
            },
            new Arret() {
                Id = "HIESE_01",
                Code = "268A",
                Name = "Hieselrain",
                Coordonnee = new GeoCoordinate(48.4885788796164, 7.71559953689575)
            },
            new Arret() {
                Id = "OHEGL_01",
                Code = "442A",
                Name = "Ohnheim Eglise",
                Coordonnee = new GeoCoordinate(48.4895637080249, 7.69966319203377)
            },
            new Arret() {
                Id = "LIGAR_01",
                Code = "346A",
                Name = "Lipsheim Gare",
                Coordonnee = new GeoCoordinate(48.4907547204395, 7.6749050617218)
            },
            new Arret() {
                Id = "NIEDE_01",
                Code = "430B",
                Name = "Niederbourg",
                Coordonnee = new GeoCoordinate(48.5330139865008, 7.72078156471252)
            },
            new Arret() {
                Id = "ACACI_01",
                Code = "14A",
                Name = "Acacias",
                Coordonnee = new GeoCoordinate(48.515908320598, 7.71100893616676)
            },
            new Arret() {
                Id = "ABBAT_01",
                Code = "11A",
                Name = "Abbatiale",
                Coordonnee = new GeoCoordinate(48.4915515276794, 7.71593414247036)
            },
            new Arret() {
                Id = "ILMAI_01",
                Code = "291A",
                Name = "Illkirch Mairie",
                Coordonnee = new GeoCoordinate(48.5295015722239, 7.71102905273438)
            },
            new Arret() {
                Id = "CRCHA_01",
                Code = "139A",
                Name = "Cressier Château d'eau",
                Coordonnee = new GeoCoordinate(48.4903947532191, 7.69482046365738)
            },
            new Arret() {
                Id = "FAPAI_01",
                Code = "194A",
                Name = "Faubourg de la Paix",
                Coordonnee = new GeoCoordinate(48.5198120849812, 7.70921185612679)
            },
            new Arret() {
                Id = "ALSCH_01",
                Code = "23A",
                Name = "Albert Schweitzer",
                Coordonnee = new GeoCoordinate(48.4914222084487, 7.68757715821266)
            },
            new Arret() {
                Id = "BALLA_01",
                Code = "41A",
                Name = "Ballastière",
                Coordonnee = new GeoCoordinate(48.5067773387619, 7.71716728806496)
            },
            new Arret() {
                Id = "DIGUE_01",
                Code = "150A",
                Name = "Graffenstaden Digue",
                Coordonnee = new GeoCoordinate(48.5208691454339, 7.70515367388725)
            },
            new Arret() {
                Id = "LIEST_01",
                Code = "345A",
                Name = "Lipsheim Est",
                Coordonnee = new GeoCoordinate(48.4916417398685, 7.66995772719383)
            },
            new Arret() {
                Id = "ERMIT_01",
                Code = "180A",
                Name = "Ermitage",
                Coordonnee = new GeoCoordinate(48.4959975088772, 7.71722093224525)
            },
            new Arret() {
                Id = "BROCH_01",
                Code = "66A",
                Name = "Brochet",
                Coordonnee = new GeoCoordinate(48.5244869677422, 7.70797401666641)
            },
            new Arret() {
                Id = "LICEN_01",
                Code = "344A",
                Name = "Lipsheim Centre",
                Coordonnee = new GeoCoordinate(48.4903325364035, 7.66497150063515)
            }
        }
    },
    new Ligne() {
        Id = "63-26",
        Name = "Blaesheim / Geispolsheim -  Plobsheim",
        Number = "63",
        Color = "F7C9DD",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "VERDU_02",
                Code = "646B",
                Name = "Geispolsheim Verdun",
                Coordonnee = new GeoCoordinate(48.5235374587369, 7.68316224217415)
            },
            new Arret() {
                Id = "VIMOU_02",
                Code = "651B",
                Name = "Vieux Moulin",
                Coordonnee = new GeoCoordinate(48.51783203592, 7.67958015203476)
            },
            new Arret() {
                Id = "STPAU_02",
                Code = "619B",
                Name = "Saint Paul",
                Coordonnee = new GeoCoordinate(48.4693113276787, 7.7286833524704)
            },
            new Arret() {
                Id = "COFON_02",
                Code = "122B",
                Name = "Collège La Fontaine",
                Coordonnee = new GeoCoordinate(48.5167758004385, 7.65027835965157)
            },
            new Arret() {
                Id = "DECLE_02",
                Code = "146A",
                Name = "Deux Clés",
                Coordonnee = new GeoCoordinate(48.5319118872913, 7.71602466702461)
            },
            new Arret() {
                Id = "TOSTI_02",
                Code = "631B",
                Name = "Tobias Stimmer",
                Coordonnee = new GeoCoordinate(48.5222095374299, 7.74087131023407)
            },
            new Arret() {
                Id = "GEZOI_02",
                Code = "244B",
                Name = "Geispolsheim ZI",
                Coordonnee = new GeoCoordinate(48.5288390263142, 7.68560975790024)
            },
            new Arret() {
                Id = "GRUND_02",
                Code = "253B",
                Name = "Grundgrübe",
                Coordonnee = new GeoCoordinate(48.488312226035, 7.72219106554985)
            },
            new Arret() {
                Id = "PLOMA_02",
                Code = "484B",
                Name = "Plobsheim Mairie",
                Coordonnee = new GeoCoordinate(48.4702058354742, 7.72602528333664)
            },
            new Arret() {
                Id = "GEMAI_02",
                Code = "241B",
                Name = "Geispolsheim Mairie",
                Coordonnee = new GeoCoordinate(48.5149626484888, 7.64211371541023)
            },
            new Arret() {
                Id = "HETZL_02",
                Code = "267B",
                Name = "Hetzlader",
                Coordonnee = new GeoCoordinate(48.48883219922, 7.7285224199295)
            },
            new Arret() {
                Id = "ESMAI_02",
                Code = "183B",
                Name = "Eschau Mairie",
                Coordonnee = new GeoCoordinate(48.4840091322108, 7.71386280655861)
            },
            new Arret() {
                Id = "STATI_02",
                Code = "594B",
                Name = "Station de Pompage",
                Coordonnee = new GeoCoordinate(48.5084344087745, 7.61100679636002)
            },
            new Arret() {
                Id = "ILLIX_01",
                Code = "290C",
                Name = "Illkirch Lixenbuhl",
                Coordonnee = new GeoCoordinate(48.5299101082765, 7.72471100091934)
            },
            new Arret() {
                Id = "POAPI_02",
                Code = "735B",
                Name = "Pôle API",
                Coordonnee = new GeoCoordinate(48.526352181497, 7.73523598909378)
            },
            new Arret() {
                Id = "WALDH_02",
                Code = "658B",
                Name = "Waldhorn",
                Coordonnee = new GeoCoordinate(48.5099821431912, 7.7295309305191)
            },
            new Arret() {
                Id = "RHINN_02",
                Code = "528B",
                Name = "Rhin",
                Coordonnee = new GeoCoordinate(48.4668838065919, 7.73158550262451)
            },
            new Arret() {
                Id = "LOEBB_02",
                Code = "354B",
                Name = "Loeb",
                Coordonnee = new GeoCoordinate(48.4757050225112, 7.70999506115913)
            },
            new Arret() {
                Id = "ECOLE_01",
                Code = "168A",
                Name = "Ecole",
                Coordonnee = new GeoCoordinate(48.5051122175883, 7.60863304138184)
            },
            new Arret() {
                Id = "GLOEC_02",
                Code = "247A",
                Name = "Gloeckelsberg",
                Coordonnee = new GeoCoordinate(48.5045853028553, 7.60429188609123)
            },
            new Arret() {
                Id = "LAVIG_02",
                Code = "333B",
                Name = "La Vigie",
                Coordonnee = new GeoCoordinate(48.5336400676313, 7.69418746232986)
            },
            new Arret() {
                Id = "SENEE_02",
                Code = "581B",
                Name = "Séné",
                Coordonnee = new GeoCoordinate(48.5167304946394, 7.65344202518463)
            },
            new Arret() {
                Id = "BLOUE_02",
                Code = "737A",
                Name = "Blaesheim Ouest",
                Coordonnee = new GeoCoordinate(48.504345, 7.600308)
            },
            new Arret() {
                Id = "RATHS_02",
                Code = "524B",
                Name = "Rathsamhausen",
                Coordonnee = new GeoCoordinate(48.4811556090247, 7.71221190690994)
            },
            new Arret() {
                Id = "GEGAR_02",
                Code = "237B",
                Name = "Geispolsheim Gare",
                Coordonnee = new GeoCoordinate(48.5187825401932, 7.68384754657745)
            },
            new Arret() {
                Id = "NIEDE_02",
                Code = "430A",
                Name = "Niederbourg",
                Coordonnee = new GeoCoordinate(48.5331019047438, 7.72117048501968)
            },
            new Arret() {
                Id = "ILMAI_08",
                Code = "291E",
                Name = "Illkirch Mairie",
                Coordonnee = new GeoCoordinate(48.5305602066777, 7.71083995699883)
            },
            new Arret() {
                Id = "SCHEI_02",
                Code = "571B",
                Name = "Scheidstein",
                Coordonnee = new GeoCoordinate(48.4977820129676, 7.73103296756744)
            },
            new Arret() {
                Id = "CAILL_08",
                Code = "75E",
                Name = "Campus d'Illkirch",
                Coordonnee = new GeoCoordinate(48.5295211109797, 7.73309156298637)
            },
            new Arret() {
                Id = "PLOCA_02",
                Code = "481B",
                Name = "Plobsheim Canal",
                Coordonnee = new GeoCoordinate(48.4708246904863, 7.71848559379578)
            },
            new Arret() {
                Id = "PLOST_01",
                Code = "483A",
                Name = "Plobsheim Est",
                Coordonnee = new GeoCoordinate(48.465594416673, 7.7358689904213)
            },
            new Arret() {
                Id = "CHOPI_02",
                Code = "93B",
                Name = "Chopin",
                Coordonnee = new GeoCoordinate(48.5254933035058, 7.68383681774139)
            },
            new Arret() {
                Id = "23NOV_04",
                Code = "704D",
                Name = "23 Novembre",
                Coordonnee = new GeoCoordinate(48.5326028112772, 7.70433023571968)
            },
            new Arret() {
                Id = "PULVE_02",
                Code = "521B",
                Name = "Pulverlaechel",
                Coordonnee = new GeoCoordinate(48.4886757634037, 7.72557467222214)
            },
            new Arret() {
                Id = "DNIED_02",
                Code = "151B",
                Name = "d'Niedergass",
                Coordonnee = new GeoCoordinate(48.488033127118, 7.71875783801079)
            },
            new Arret() {
                Id = "EHNNN_02",
                Code = "172B",
                Name = "Ehn",
                Coordonnee = new GeoCoordinate(48.5171346920041, 7.67326086759567)
            },
            new Arret() {
                Id = "PLOEG_02",
                Code = "482B",
                Name = "Plobsheim Eglise",
                Coordonnee = new GeoCoordinate(48.4702938627252, 7.72316336631775)
            },
            new Arret() {
                Id = "SCHAA_02",
                Code = "570B",
                Name = "Schaal",
                Coordonnee = new GeoCoordinate(48.4878153577878, 7.71547079086304)
            },
            new Arret() {
                Id = "FOURR_02",
                Code = "222B",
                Name = "Four",
                Coordonnee = new GeoCoordinate(48.5155125529716, 7.64527201652527)
            },
            new Arret() {
                Id = "FUMAR_02",
                Code = "229B",
                Name = "Fusiliers Marins",
                Coordonnee = new GeoCoordinate(48.4913555489226, 7.72989973425865)
            },
            new Arret() {
                Id = "STOSK_02",
                Code = "618B",
                Name = "Stoskopf",
                Coordonnee = new GeoCoordinate(48.4793180684725, 7.70784795284271)
            },
            new Arret() {
                Id = "ILPAI_02",
                Code = "736B",
                Name = "Illkirch Parc d'Innovation",
                Coordonnee = new GeoCoordinate(48.519377, 7.735706)
            },
            new Arret() {
                Id = "WICHA_02",
                Code = "663B",
                Name = "Wibolsheim Chapelle",
                Coordonnee = new GeoCoordinate(48.4770732805718, 7.70699232816696)
            },
            new Arret() {
                Id = "GEOUE_01",
                Code = "243A",
                Name = "Geispolsheim Ouest",
                Coordonnee = new GeoCoordinate(48.5150603702385, 7.64060229063034)
            },
            new Arret() {
                Id = "PERDR_03",
                Code = "703A",
                Name = "Perdrix",
                Coordonnee = new GeoCoordinate(48.4671256747071, 7.73744612932205)
            },
            new Arret() {
                Id = "ESPER_01",
                Code = "184A",
                Name = "Espérance",
                Coordonnee = new GeoCoordinate(48.4677018852785, 7.73510187864304)
            }
        }
    },
    new Ligne() {
        Id = "30-26",
        Name = "Robertsau - Wattwiller",
        Number = "30",
        Color = "FFDD00",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "PLWAT_01",
                Code = "488A",
                Name = "Place de Wattwiller",
                Coordonnee = new GeoCoordinate(48.5608000920878, 7.78398245573044)
            },
            new Arret() {
                Id = "GAFOR_02",
                Code = "232B",
                Name = "Gardes Forestiers",
                Coordonnee = new GeoCoordinate(48.6212602368522, 7.78721183538437)
            },
            new Arret() {
                Id = "MUSAU_01",
                Code = "418A",
                Name = "Musau",
                Coordonnee = new GeoCoordinate(48.5611941744622, 7.78133377432823)
            },
            new Arret() {
                Id = "SOULT_01",
                Code = "589A",
                Name = "Soultz",
                Coordonnee = new GeoCoordinate(48.5652581917352, 7.77844235301018)
            },
            new Arret() {
                Id = "FISCH_01",
                Code = "213A",
                Name = "Fischacker",
                Coordonnee = new GeoCoordinate(48.6188151693103, 7.78802052140236)
            },
            new Arret() {
                Id = "STGUI_01",
                Code = "600A",
                Name = "Saint Guillaume",
                Coordonnee = new GeoCoordinate(48.5828346997569, 7.75751978158951)
            },
            new Arret() {
                Id = "DORDO_04",
                Code = "154B",
                Name = "Dordogne",
                Coordonnee = new GeoCoordinate(48.5894660074392, 7.76673585176468)
            },
            new Arret() {
                Id = "PAPET_03",
                Code = "459C",
                Name = "Papeterie",
                Coordonnee = new GeoCoordinate(48.6117106807716, 7.78164088726044)
            },
            new Arret() {
                Id = "ARIBR_01",
                Code = "32H",
                Name = "Aristide Briand",
                Coordonnee = new GeoCoordinate(48.5682699939702, 7.77624163631515)
            },
            new Arret() {
                Id = "ORANG_02",
                Code = "443B",
                Name = "Orangerie",
                Coordonnee = new GeoCoordinate(48.5921768306065, 7.76961922645569)
            },
            new Arret() {
                Id = "CIADM_02",
                Code = "96B",
                Name = "Cité Administrative",
                Coordonnee = new GeoCoordinate(48.5779593574332, 7.76183277368546)
            },
            new Arret() {
                Id = "ANKAR_03",
                Code = "29A",
                Name = "Ankara",
                Coordonnee = new GeoCoordinate(48.5753906303567, 7.77144312858582)
            },
            new Arret() {
                Id = "ROMEE_02",
                Code = "543B",
                Name = "Rome",
                Coordonnee = new GeoCoordinate(48.5771918585254, 7.76816010475159)
            },
            new Arret() {
                Id = "FOLOU_02",
                Code = "217B",
                Name = "Fort Louis",
                Coordonnee = new GeoCoordinate(48.605172746046, 7.77788579463959)
            },
            new Arret() {
                Id = "KRUTE_02",
                Code = "320B",
                Name = "Krutenau",
                Coordonnee = new GeoCoordinate(48.5801766096283, 7.75771155953407)
            },
            new Arret() {
                Id = "CLSTA_01",
                Code = "117A",
                Name = "Clinique Sainte Anne",
                Coordonnee = new GeoCoordinate(48.6154080122233, 7.78535306453705)
            },
            new Arret() {
                Id = "DANUB_01",
                Code = "144A",
                Name = "Danube",
                Coordonnee = new GeoCoordinate(48.5729096218589, 7.77077659964561)
            },
            new Arret() {
                Id = "DRHOM_06",
                Code = "156B",
                Name = "Droits de l'Homme",
                Coordonnee = new GeoCoordinate(48.5961416797853, 7.77499705553055)
            },
            new Arret() {
                Id = "GALLI_01",
                Code = "233C",
                Name = "Gallia",
                Coordonnee = new GeoCoordinate(48.5844209699859, 7.75900036096573)
            },
            new Arret() {
                Id = "ROCHA_01",
                Code = "536A",
                Name = "Robertsau Chasseurs",
                Coordonnee = new GeoCoordinate(48.6234915457444, 7.78652250766754)
            },
            new Arret() {
                Id = "WATTW_F1",
                Code = "660B",
                Name = "Wattwiller",
                Coordonnee = new GeoCoordinate(48.5611820392572, 7.78588100041623)
            },
            new Arret() {
                Id = "ROBOE_04",
                Code = "535E",
                Name = "Robertsau Boecklin",
                Coordonnee = new GeoCoordinate(48.5975235384342, 7.77614235877991)
            },
            new Arret() {
                Id = "CLORA_02",
                Code = "116B",
                Name = "Clinique de l'Orangerie",
                Coordonnee = new GeoCoordinate(48.587663442425, 7.76461690664291)
            },
            new Arret() {
                Id = "COEUR_02",
                Code = "453B",
                Name = "Conseil de l'Europe",
                Coordonnee = new GeoCoordinate(48.5939570597663, 7.77198493480682)
            },
            new Arret() {
                Id = "BRUNI_03",
                Code = "69B",
                Name = "Brant Université",
                Coordonnee = new GeoCoordinate(48.5856345927859, 7.76131644845009)
            },
            new Arret() {
                Id = "ROSTA_01",
                Code = "549B",
                Name = "Robertsau Sainte Anne",
                Coordonnee = new GeoCoordinate(48.6172982459075, 7.78824180364609)
            },
            new Arret() {
                Id = "ARBRI_12",
                Code = "32A",
                Name = "Aristide briand",
                Coordonnee = new GeoCoordinate(48.5682374352486, 7.7761772274971)
            },
            new Arret() {
                Id = "CIUNI_02",
                Code = "114B",
                Name = "Cité Universitaire",
                Coordonnee = new GeoCoordinate(48.6018365036679, 7.77541682124138)
            },
            new Arret() {
                Id = "CINOR_02",
                Code = "111B",
                Name = "Cimetière Nord",
                Coordonnee = new GeoCoordinate(48.6089707569132, 7.77958229184151)
            },
            new Arret() {
                Id = "PALER_02",
                Code = "458B",
                Name = "Palerme",
                Coordonnee = new GeoCoordinate(48.5775041831864, 7.76517882943153)
            }
        }
    },
    new Ligne() {
        Id = "15-26",
        Name = "Lingolsheim Alouettes - Robertsau Boecklin",
        Number = "15",
        Color = "004A99",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "NICIG_01",
                Code = "429A",
                Name = "Nid de Cigognes",
                Coordonnee = new GeoCoordinate(48.5723008865819, 7.71461516618729)
            },
            new Arret() {
                Id = "TANNE_01",
                Code = "624A",
                Name = "Tanneries",
                Coordonnee = new GeoCoordinate(48.56151192333, 7.6947695016861)
            },
            new Arret() {
                Id = "COQUI_01",
                Code = "131A",
                Name = "Conseil des Quinze",
                Coordonnee = new GeoCoordinate(48.5874097297858, 7.78229802846909)
            },
            new Arret() {
                Id = "BOISF_01",
                Code = "59A",
                Name = "Bois Fleuri",
                Coordonnee = new GeoCoordinate(48.603368080894, 7.79056191444397)
            },
            new Arret() {
                Id = "BREME_01",
                Code = "65A",
                Name = "Brême",
                Coordonnee = new GeoCoordinate(48.5986960486709, 7.79097765684128)
            },
            new Arret() {
                Id = "ROEGL_01",
                Code = "539A",
                Name = "Robertsau Eglise",
                Coordonnee = new GeoCoordinate(48.6029725535281, 7.78336018323898)
            },
            new Arret() {
                Id = "CAHAU_01",
                Code = "74A",
                Name = "Carpe Haute",
                Coordonnee = new GeoCoordinate(48.5961399058731, 7.78821498155594)
            },
            new Arret() {
                Id = "ROMEE_01",
                Code = "543A",
                Name = "Rome",
                Coordonnee = new GeoCoordinate(48.5772584051348, 7.76839345693588)
            },
            new Arret() {
                Id = "LYPAS_01",
                Code = "373A",
                Name = "Lycée Pasteur",
                Coordonnee = new GeoCoordinate(48.5745077389258, 7.73854583501816)
            },
            new Arret() {
                Id = "OBSER_10",
                Code = "438D",
                Name = "Observatoire",
                Coordonnee = new GeoCoordinate(48.5814888151157, 7.77031391859055)
            },
            new Arret() {
                Id = "LAITE_01",
                Code = "323A",
                Name = "Laiterie",
                Coordonnee = new GeoCoordinate(48.5755299394556, 7.73083448410034)
            },
            new Arret() {
                Id = "COGAL_02",
                Code = "123B",
                Name = "Collège Galilée",
                Coordonnee = new GeoCoordinate(48.5504942807367, 7.68710643053055)
            },
            new Arret() {
                Id = "GLIES_01",
                Code = "246A",
                Name = "Gliesberg",
                Coordonnee = new GeoCoordinate(48.5679002046966, 7.7092319726944)
            },
            new Arret() {
                Id = "MARNE_02",
                Code = "385B",
                Name = "Marne",
                Coordonnee = new GeoCoordinate(48.5838052759318, 7.77286738157272)
            },
            new Arret() {
                Id = "CIMET_01",
                Code = "110A",
                Name = "Cimetière",
                Coordonnee = new GeoCoordinate(48.551110380479, 7.6802895963192)
            },
            new Arret() {
                Id = "ESPLA_01",
                Code = "185A",
                Name = "Esplanade",
                Coordonnee = new GeoCoordinate(48.5782202156804, 7.76927188038826)
            },
            new Arret() {
                Id = "ETBOU_04",
                Code = "186A",
                Name = "Etoile Bourse",
                Coordonnee = new GeoCoordinate(48.5751528279507, 7.75264084339142)
            },
            new Arret() {
                Id = "YPRES_01",
                Code = "673A",
                Name = "Ypres",
                Coordonnee = new GeoCoordinate(48.5862316348277, 7.78067797422409)
            },
            new Arret() {
                Id = "MOVER_01",
                Code = "410A",
                Name = "Montagne Verte",
                Coordonnee = new GeoCoordinate(48.5746727831188, 7.72701770067215)
            },
            new Arret() {
                Id = "KASTL_02",
                Code = "311B",
                Name = "Kastler",
                Coordonnee = new GeoCoordinate(48.5488368109092, 7.6843236386776)
            },
            new Arret() {
                Id = "PRESS_02",
                Code = "513B",
                Name = "Prés",
                Coordonnee = new GeoCoordinate(48.5599196086629, 7.69157499074936)
            },
            new Arret() {
                Id = "LAMPR_01",
                Code = "327A",
                Name = "Lamproie",
                Coordonnee = new GeoCoordinate(48.6019531251076, 7.79259838163853)
            },
            new Arret() {
                Id = "LNCEN_02",
                Code = "350B",
                Name = "Lingolsheim Centre",
                Coordonnee = new GeoCoordinate(48.5584657123643, 7.68615156412125)
            },
            new Arret() {
                Id = "ROBOE_05",
                Code = "535C",
                Name = "Robertsau Boecklin",
                Coordonnee = new GeoCoordinate(48.5981993759475, 7.77905523777008)
            },
            new Arret() {
                Id = "CIADM_01",
                Code = "96A",
                Name = "Cité Administrative",
                Coordonnee = new GeoCoordinate(48.5783941204307, 7.76051312685013)
            },
            new Arret() {
                Id = "BRUXE_01",
                Code = "70A",
                Name = "Bruxelles",
                Coordonnee = new GeoCoordinate(48.5841858715565, 7.7751499414444)
            },
            new Arret() {
                Id = "CAMPI_01",
                Code = "36A",
                Name = "Camping",
                Coordonnee = new GeoCoordinate(48.5733036098807, 7.71833673119545)
            },
            new Arret() {
                Id = "PALER_01",
                Code = "458A",
                Name = "Palerme",
                Coordonnee = new GeoCoordinate(48.5777428618113, 7.76416629552841)
            },
            new Arret() {
                Id = "SESOC_01",
                Code = "583A",
                Name = "Sécurité Sociale",
                Coordonnee = new GeoCoordinate(48.5761918742595, 7.75681704282761)
            },
            new Arret() {
                Id = "HOPOL_01",
                Code = "284A",
                Name = "Hôtel de Police",
                Coordonnee = new GeoCoordinate(48.5745237109681, 7.74886697530746)
            },
            new Arret() {
                Id = "BRUCH_01",
                Code = "68A",
                Name = "Bruche",
                Coordonnee = new GeoCoordinate(48.5700850637794, 7.71105453372002)
            },
            new Arret() {
                Id = "ALOUT_03",
                Code = "681A",
                Name = "Lingolsheim Alouettes",
                Coordonnee = new GeoCoordinate(48.551607, 7.692828)
            },
            new Arret() {
                Id = "MOLKE_02",
                Code = "396B",
                Name = "Molkenbronn",
                Coordonnee = new GeoCoordinate(48.562799762128, 7.70025596022606)
            },
            new Arret() {
                Id = "STFRA_01",
                Code = "598A",
                Name = "Saint François",
                Coordonnee = new GeoCoordinate(48.6035330308533, 7.7872171998024)
            },
            new Arret() {
                Id = "RUJUI_02",
                Code = "564B",
                Name = "Rue des Juifs",
                Coordonnee = new GeoCoordinate(48.5542387020329, 7.6799476146698)
            },
            new Arret() {
                Id = "SCHOT_03",
                Code = "576C",
                Name = "Schott",
                Coordonnee = new GeoCoordinate(48.6003917944556, 7.78107762336731)
            },
            new Arret() {
                Id = "CIRUS_02",
                Code = "112B",
                Name = "Cité Russi",
                Coordonnee = new GeoCoordinate(48.5593595351224, 7.68968001008034)
            },
            new Arret() {
                Id = "QUQUI_01",
                Code = "522A",
                Name = "Quartier des Quinze",
                Coordonnee = new GeoCoordinate(48.5892069813833, 7.78267219662666)
            },
            new Arret() {
                Id = "LNMAI_02",
                Code = "353B",
                Name = "Lingolsheim Mairie",
                Coordonnee = new GeoCoordinate(48.5574342905081, 7.68278941512108)
            },
            new Arret() {
                Id = "HOCIV_01",
                Code = "272A",
                Name = "Hôpital Civil",
                Coordonnee = new GeoCoordinate(48.5741776489236, 7.74225533008575)
            },
            new Arret() {
                Id = "ROETH_06",
                Code = "540D",
                Name = "Roethig",
                Coordonnee = new GeoCoordinate(48.5645632759146, 7.70583629608154)
            },
            new Arret() {
                Id = "LYOPA_01",
                Code = "372A",
                Name = "Lyon-Pasteur",
                Coordonnee = new GeoCoordinate(48.5748963905207, 7.73435354232788)
            }
        }
    },
    new Ligne() {
        Id = "E-482",
        Name = "Boecklin - Baggersee",
        Number = "E",
        Color = "9085BA",
        Type = "Tram",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "DRHOM_04",
                Code = "156D",
                Name = "Droits de l'Homme",
                Coordonnee = new GeoCoordinate(48.5960538710586, 7.77423530817032)
            },
            new Arret() {
                Id = "LYKLE_05",
                Code = "368C",
                Name = "Lycée Kléber",
                Coordonnee = new GeoCoordinate(48.5941876777886, 7.75780409574509)
            },
            new Arret() {
                Id = "REPUB_06",
                Code = "527D",
                Name = "République",
                Coordonnee = new GeoCoordinate(48.58660422807, 7.75479197502136)
            },
            new Arret() {
                Id = "WICHU_02",
                Code = "664B",
                Name = "Winston Churchill",
                Coordonnee = new GeoCoordinate(48.5740764918787, 7.76681631803513)
            },
            new Arret() {
                Id = "ESPLA_04",
                Code = "185D",
                Name = "Esplanade",
                Coordonnee = new GeoCoordinate(48.5784642145231, 7.76948913931847)
            },
            new Arret() {
                Id = "LANDS_07",
                Code = "329B",
                Name = "Landsberg",
                Coordonnee = new GeoCoordinate(48.5702261623191, 7.76354402303696)
            },
            new Arret() {
                Id = "OBSER_06",
                Code = "438F",
                Name = "Observatoire",
                Coordonnee = new GeoCoordinate(48.581511882656, 7.76879847049713)
            },
            new Arret() {
                Id = "BOECK_02",
                Code = "57B",
                Name = "Robertsau Boecklin",
                Coordonnee = new GeoCoordinate(48.5979726144905, 7.77825279797787)
            },
            new Arret() {
                Id = "PARLE_02",
                Code = "464B",
                Name = "Parlement Européen",
                Coordonnee = new GeoCoordinate(48.5994321796177, 7.76726424694061)
            },
            new Arret() {
                Id = "GALLI_04",
                Code = "233B",
                Name = "Gallia",
                Coordonnee = new GeoCoordinate(48.5844520206402, 7.75822922587395)
            },
            new Arret() {
                Id = "PACON_01",
                Code = "451A",
                Name = "Parc du Contades",
                Coordonnee = new GeoCoordinate(48.59040807046, 7.75606334209442)
            },
            new Arret() {
                Id = "WACKE_05",
                Code = "657A",
                Name = "Wacken",
                Coordonnee = new GeoCoordinate(48.5986747627972, 7.76072233915329)
            },
            new Arret() {
                Id = "UNIVE_02",
                Code = "638B",
                Name = "Université",
                Coordonnee = new GeoCoordinate(48.5828551051151, 7.76384979486465)
            },
            new Arret() {
                Id = "EMMAT_03",
                Code = "176C",
                Name = "Emile Mathis",
                Coordonnee = new GeoCoordinate(48.5530553954264, 7.74414092302322)
            },
            new Arret() {
                Id = "BAGGE_03",
                Code = "38C",
                Name = "Baggersee",
                Coordonnee = new GeoCoordinate(48.5449250734092, 7.73784913122654)
            },
            new Arret() {
                Id = "LYCOU_03",
                Code = "366C",
                Name = "Lycée Couffignal",
                Coordonnee = new GeoCoordinate(48.5587532995628, 7.74907886981964)
            },
            new Arret() {
                Id = "SCHLU_01",
                Code = "573A",
                Name = "Schluthfeld",
                Coordonnee = new GeoCoordinate(48.5684876943625, 7.75166183710098)
            },
            new Arret() {
                Id = "ETPOL_01",
                Code = "189A",
                Name = "Etoile Polygone",
                Coordonnee = new GeoCoordinate(48.5716255900397, 7.75525599718094)
            },
            new Arret() {
                Id = "HOHWA_01",
                Code = "280C",
                Name = "Hohwart",
                Coordonnee = new GeoCoordinate(48.5492034653118, 7.74152040481567)
            },
            new Arret() {
                Id = "KRIMM_03",
                Code = "319A",
                Name = "Krimmeri",
                Coordonnee = new GeoCoordinate(48.5629959083714, 7.75263279676437)
            }
        }
    },
    new Ligne() {
        Id = "C-482",
        Name = "Gare Centrale - Rodolphe Reuss",
        Number = "C",
        Color = "F29400",
        Type = "Tram",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "LYJMO_01",
                Code = "367A",
                Name = "Lycée Jean Monnet",
                Coordonnee = new GeoCoordinate(48.56440884888, 7.76939257979393)
            },
            new Arret() {
                Id = "GALLI_03",
                Code = "233A",
                Name = "Gallia",
                Coordonnee = new GeoCoordinate(48.5842949928503, 7.75853097438812)
            },
            new Arret() {
                Id = "HOFER_04",
                Code = "275C",
                Name = "Homme de Fer",
                Coordonnee = new GeoCoordinate(48.5843508841535, 7.74499118328094)
            },
            new Arret() {
                Id = "LANDS_05",
                Code = "329A",
                Name = "Landsberg",
                Coordonnee = new GeoCoordinate(48.569340518424, 7.76409119367599)
            },
            new Arret() {
                Id = "WICHU_01",
                Code = "664A",
                Name = "Winston Churchill",
                Coordonnee = new GeoCoordinate(48.5739096710466, 7.76661515235901)
            },
            new Arret() {
                Id = "BROGL_01",
                Code = "67A",
                Name = "Broglie",
                Coordonnee = new GeoCoordinate(48.5848264013121, 7.74951338768005)
            },
            new Arret() {
                Id = "OBSER_05",
                Code = "438E",
                Name = "Observatoire",
                Coordonnee = new GeoCoordinate(48.5813024999816, 7.76911497116089)
            },
            new Arret() {
                Id = "GACEN_11",
                Code = "230",
                Name = "Gare Centrale",
                Coordonnee = new GeoCoordinate(48.5858155691275, 7.73598834872246)
            },
            new Arret() {
                Id = "ESPLA_03",
                Code = "185C",
                Name = "Esplanade",
                Coordonnee = new GeoCoordinate(48.5782335247385, 7.76939526200294)
            },
            new Arret() {
                Id = "KIBIT_01",
                Code = "316E",
                Name = "Kibitzenau",
                Coordonnee = new GeoCoordinate(48.555094429402, 7.7671891450882)
            },
            new Arret() {
                Id = "JAURE_01",
                Code = "298A",
                Name = "Jean Jaures",
                Coordonnee = new GeoCoordinate(48.5672079875706, 7.77221292257309)
            },
            new Arret() {
                Id = "REPUB_07",
                Code = "527E",
                Name = "République",
                Coordonnee = new GeoCoordinate(48.5858448446513, 7.75518625974655)
            },
            new Arret() {
                Id = "GRAVI_01",
                Code = "420A",
                Name = "Gravière",
                Coordonnee = new GeoCoordinate(48.5613051205227, 7.76423871517181)
            },
            new Arret() {
                Id = "ROREU_01",
                Code = "546C",
                Name = "Neuhof Rodolphe Reuss",
                Coordonnee = new GeoCoordinate(48.5461079731717, 7.76690168942685)
            },
            new Arret() {
                Id = "UNIVE_01",
                Code = "638A",
                Name = "Université",
                Coordonnee = new GeoCoordinate(48.5826847644811, 7.76406437158585)
            },
            new Arret() {
                Id = "STCHR_01",
                Code = "596A",
                Name = "Saint Christophe",
                Coordonnee = new GeoCoordinate(48.551060666657, 7.76629328727722)
            },
            new Arret() {
                Id = "FASAV_05",
                Code = "197D",
                Name = "Faubourg de Saverne",
                Coordonnee = new GeoCoordinate(48.5859033956479, 7.73998215794563)
            },
            new Arret() {
                Id = "PLISL_01",
                Code = "706A",
                Name = "Place d'Islande",
                Coordonnee = new GeoCoordinate(48.5804046288487, 7.77545839548111)
            }
        }
    },
    new Ligne() {
        Id = "21-537",
        Name = "Kehl Stadthalle - Jean Jaurès",
        Number = "21",
        Color = "89CCCF",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "PARKE_01",
                Code = "463C",
                Name = "Jardins Des Deux Rives de Kehl",
                Coordonnee = new GeoCoordinate(48.5725857330101, 7.79488027095795)
            },
            new Arret() {
                Id = "KEBAH_02",
                Code = "313B",
                Name = "Kehl Bahnhof",
                Coordonnee = new GeoCoordinate(48.5758664053588, 7.8067004152298)
            },
            new Arret() {
                Id = "PERHI_02",
                Code = "471D",
                Name = "Petit Rhin",
                Coordonnee = new GeoCoordinate(48.5709786812147, 7.78594985604286)
            },
            new Arret() {
                Id = "ARBRI_04",
                Code = "32B",
                Name = "Aristide Briand",
                Coordonnee = new GeoCoordinate(48.5685927468816, 7.77642593498763)
            },
            new Arret() {
                Id = "JEJAU_04",
                Code = "298A",
                Name = "Jean Jaures",
                Coordonnee = new GeoCoordinate(48.5671674549488, 7.77202202643628)
            },
            new Arret() {
                Id = "KEMAR_01",
                Code = "315A",
                Name = "Kehl Stadthalle",
                Coordonnee = new GeoCoordinate(48.5719468228967, 7.81203299760818)
            },
            new Arret() {
                Id = "KELAG_01",
                Code = "314A",
                Name = "Kehl Am Läger",
                Coordonnee = new GeoCoordinate(48.5754101514001, 7.81314477324486)
            },
            new Arret() {
                Id = "POVAU_02",
                Code = "510B",
                Name = "Pont Vauban",
                Coordonnee = new GeoCoordinate(48.5698099648654, 7.78171867132187)
            }
        }
    },
    new Ligne() {
        Id = "31-538",
        Name = "Kibitzenau - Wattwiller",
        Number = "31",
        Color = "F7C9E3",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "KIBIT_04",
                Code = "316B",
                Name = "Kibitzenau",
                Coordonnee = new GeoCoordinate(48.5547926184966, 7.76727497577667)
            },
            new Arret() {
                Id = "JEJAU_02",
                Code = "298D",
                Name = "Jean Jaures",
                Coordonnee = new GeoCoordinate(48.5664145885956, 7.77312755584717)
            },
            new Arret() {
                Id = "ARBRI_10",
                Code = "32B",
                Name = "Aristide Briand",
                Coordonnee = new GeoCoordinate(48.5685927468816, 7.77642593498763)
            },
            new Arret() {
                Id = "WATTW_01",
                Code = "660A",
                Name = "Wattwiller",
                Coordonnee = new GeoCoordinate(48.561200387448, 7.78589621186256)
            },
            new Arret() {
                Id = "PLWAT_02",
                Code = "488B",
                Name = "Place de Wattwiller",
                Coordonnee = new GeoCoordinate(48.5605764223474, 7.7844250202179)
            },
            new Arret() {
                Id = "SOULT_02",
                Code = "589B",
                Name = "Soultz",
                Coordonnee = new GeoCoordinate(48.5654383535375, 7.77853891253471)
            },
            new Arret() {
                Id = "ORBEY_02",
                Code = "444B",
                Name = "Orbey",
                Coordonnee = new GeoCoordinate(48.562551249958, 7.77348428964615)
            },
            new Arret() {
                Id = "MUSAU_02",
                Code = "418B",
                Name = "Musau",
                Coordonnee = new GeoCoordinate(48.5613193216009, 7.78066053986549)
            }
        }
    },
    new Ligne() {
        Id = "72-26",
        Name = "La Wantzenau - Le Golf - République",
        Number = "72",
        Color = "F7C9DD",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "HECHN_02",
                Code = "264B",
                Name = "Hechner",
                Coordonnee = new GeoCoordinate(48.6123340148574, 7.77626305818558)
            },
            new Arret() {
                Id = "LWATI_01",
                Code = "364A",
                Name = "La Wantzenau Le Tilleul",
                Coordonnee = new GeoCoordinate(48.6607106828805, 7.82360404729843)
            },
            new Arret() {
                Id = "LWAEG_01",
                Code = "359A",
                Name = "La Wantzenau Eglise",
                Coordonnee = new GeoCoordinate(48.6628118086115, 7.8222481906414)
            },
            new Arret() {
                Id = "BELZW_01",
                Code = "46A",
                Name = "Beltzwoerth",
                Coordonnee = new GeoCoordinate(48.6192912486716, 7.79301077127457)
            },
            new Arret() {
                Id = "GELEC_01",
                Code = "239A",
                Name = "Général Leclerc",
                Coordonnee = new GeoCoordinate(48.655072111199, 7.83129528164864)
            },
            new Arret() {
                Id = "LWECO_01",
                Code = "358A",
                Name = "La Wantzenau Ecole",
                Coordonnee = new GeoCoordinate(48.6597132375626, 7.82528445124626)
            },
            new Arret() {
                Id = "CLSTA_02",
                Code = "117B",
                Name = "Clinique Sainte Anne",
                Coordonnee = new GeoCoordinate(48.6153424024662, 7.78605312108994)
            },
            new Arret() {
                Id = "POPHA_07",
                Code = "496A",
                Name = "Pont Phario",
                Coordonnee = new GeoCoordinate(48.6132197921628, 7.76918202638626)
            },
            new Arret() {
                Id = "RUCHA_01",
                Code = "558A",
                Name = "Rue des Champs",
                Coordonnee = new GeoCoordinate(48.6441563832587, 7.82151460647583)
            },
            new Arret() {
                Id = "ROCHE_01",
                Code = "537A",
                Name = "Rochechouart",
                Coordonnee = new GeoCoordinate(48.6495649256319, 7.82318294048309)
            },
            new Arret() {
                Id = "CIILL_02",
                Code = "99B",
                Name = "Cité de l'Ill",
                Coordonnee = new GeoCoordinate(48.6128979349392, 7.77336224913597)
            },
            new Arret() {
                Id = "FAALE_01",
                Code = "191A",
                Name = "Faubourg d'Alençon",
                Coordonnee = new GeoCoordinate(48.6535110942679, 7.82868281006813)
            },
            new Arret() {
                Id = "FUAMB_01",
                Code = "227A",
                Name = "Fuchs am Buckel",
                Coordonnee = new GeoCoordinate(48.6260498500429, 7.80403465032578)
            },
            new Arret() {
                Id = "UNJAE_01",
                Code = "639A",
                Name = "Unterjaegerhof",
                Coordonnee = new GeoCoordinate(48.6316393734665, 7.80474007129669)
            },
            new Arret() {
                Id = "HONAU_01",
                Code = "282A",
                Name = "Honau",
                Coordonnee = new GeoCoordinate(48.6403388649371, 7.80844420194626)
            },
            new Arret() {
                Id = "ROSTA_02",
                Code = "549C",
                Name = "Robertsau Sainte Anne",
                Coordonnee = new GeoCoordinate(48.6175890448079, 7.78856366872787)
            },
            new Arret() {
                Id = "LWAGO_01",
                Code = "361A",
                Name = "La Wantzenau Le Golf",
                Coordonnee = new GeoCoordinate(48.6759064378769, 7.8154394030571)
            },
            new Arret() {
                Id = "BUSSI_01",
                Code = "72A",
                Name = "Bussière",
                Coordonnee = new GeoCoordinate(48.6212921513815, 7.79787227511406)
            },
            new Arret() {
                Id = "PAPET_04",
                Code = "459D",
                Name = "Papeterie",
                Coordonnee = new GeoCoordinate(48.6116734400848, 7.78172671794891)
            },
            new Arret() {
                Id = "STYRI_01",
                Code = "623A",
                Name = "Saint Yrieix",
                Coordonnee = new GeoCoordinate(48.6521830401115, 7.82522410154343)
            },
            new Arret() {
                Id = "PATRO_01",
                Code = "466A",
                Name = "Patronage",
                Coordonnee = new GeoCoordinate(48.6571646131244, 7.82986834645271)
            },
            new Arret() {
                Id = "LWAMA_01",
                Code = "362A",
                Name = "La Wantzenau Mairie",
                Coordonnee = new GeoCoordinate(48.6580265710894, 7.82793983817101)
            },
            new Arret() {
                Id = "LWGAR_01",
                Code = "360A",
                Name = "La Wantzenau Gare",
                Coordonnee = new GeoCoordinate(48.6644956577015, 7.82377168536186)
            },
            new Arret() {
                Id = "REPUB_01",
                Code = "527A",
                Name = "République",
                Coordonnee = new GeoCoordinate(48.5865918083395, 7.75383979082108)
            },
            new Arret() {
                Id = "ORANG_01",
                Code = "443A",
                Name = "Orangerie",
                Coordonnee = new GeoCoordinate(48.5917776674777, 7.76958703994751)
            },
            new Arret() {
                Id = "BRUNI_02",
                Code = "69A",
                Name = "Brant Université",
                Coordonnee = new GeoCoordinate(48.5855911228818, 7.76167184114456)
            },
            new Arret() {
                Id = "ROEGL_01",
                Code = "539A",
                Name = "Robertsau Eglise",
                Coordonnee = new GeoCoordinate(48.6029725535281, 7.78336018323898)
            },
            new Arret() {
                Id = "PAEUR_01",
                Code = "453A",
                Name = "Conseil de l'Europe",
                Coordonnee = new GeoCoordinate(48.593927788942, 7.7721431851387)
            },
            new Arret() {
                Id = "ROBOE_02",
                Code = "535B",
                Name = "Robertsau Boecklin",
                Coordonnee = new GeoCoordinate(48.5981532560897, 7.77742981910706)
            },
            new Arret() {
                Id = "CLORA_01",
                Code = "116A",
                Name = "Clinique de l'Orangerie",
                Coordonnee = new GeoCoordinate(48.5879490893966, 7.76533037424088)
            },
            new Arret() {
                Id = "DORDO_03",
                Code = "154A",
                Name = "Dordogne",
                Coordonnee = new GeoCoordinate(48.5890348879957, 7.76659101247787)
            }
        }
    },
    new Ligne() {
        Id = "71-26",
        Name = "ECKWERSHEIM - LES HALLES SEBASTOPOL",
        Number = "71",
        Color = "89CCCF",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "ECCIM_02",
                Code = "163B",
                Name = "Eckwersheim Cimetière",
                Coordonnee = new GeoCoordinate(48.6832905382035, 7.69471317529678)
            },
            new Arret() {
                Id = "NIOUE_02",
                Code = "432B",
                Name = "Niederhausbergen Centre",
                Coordonnee = new GeoCoordinate(48.6251208619529, 7.70021170377731)
            },
            new Arret() {
                Id = "VEMAI_01",
                Code = "643A",
                Name = "Vendenheim Mairie",
                Coordonnee = new GeoCoordinate(48.6655762676699, 7.71140322089195)
            },
            new Arret() {
                Id = "VEGAR_02",
                Code = "642B",
                Name = "Vendenheim Gare",
                Coordonnee = new GeoCoordinate(48.6663937957175, 7.71758303046227)
            },
            new Arret() {
                Id = "CANAL_02",
                Code = "76B",
                Name = "Canal",
                Coordonnee = new GeoCoordinate(48.6784611987209, 7.69707888364792)
            },
            new Arret() {
                Id = "TRAVA_03",
                Code = "633C",
                Name = "Travail",
                Coordonnee = new GeoCoordinate(48.5895866492586, 7.74228751659393)
            },
            new Arret() {
                Id = "NIMAI_02",
                Code = "431B",
                Name = "Niederhausbergen Mairie",
                Coordonnee = new GeoCoordinate(48.6231653215982, 7.70020365715027)
            },
            new Arret() {
                Id = "ECHIP_01",
                Code = "164A",
                Name = "Eckwersheim Hippodrome",
                Coordonnee = new GeoCoordinate(48.6851596357028, 7.69814640283585)
            },
            new Arret() {
                Id = "HOHLL_02",
                Code = "279B",
                Name = "Hohl",
                Coordonnee = new GeoCoordinate(48.6704661809708, 7.70441204309464)
            },
            new Arret() {
                Id = "ARANS_02",
                Code = "31B",
                Name = "Artisans",
                Coordonnee = new GeoCoordinate(48.659722095956, 7.72121608257294)
            },
            new Arret() {
                Id = "PETIT_02",
                Code = "472B",
                Name = "Petite",
                Coordonnee = new GeoCoordinate(48.6410619825109, 7.71006345748901)
            },
            new Arret() {
                Id = "ECMAI_02",
                Code = "166B",
                Name = "Eckwersheim Mairie",
                Coordonnee = new GeoCoordinate(48.6805801793437, 7.69440606236458)
            },
            new Arret() {
                Id = "COLLE_02",
                Code = "126B",
                Name = "Collège",
                Coordonnee = new GeoCoordinate(48.642626043272, 7.70854666829109)
            },
            new Arret() {
                Id = "LHSEB_01",
                Code = "342A",
                Name = "Les Halles Sébastopol",
                Coordonnee = new GeoCoordinate(48.5862311912627, 7.74301305413246)
            },
            new Arret() {
                Id = "VETIL_02",
                Code = "648B",
                Name = "Vendenheim au Tilleul",
                Coordonnee = new GeoCoordinate(48.6687010487382, 7.71037191152573)
            },
            new Arret() {
                Id = "CHEAU_02",
                Code = "88B",
                Name = "Château d'Eau",
                Coordonnee = new GeoCoordinate(48.6725084494843, 7.7039560675621)
            },
            new Arret() {
                Id = "NORDD_02",
                Code = "433B",
                Name = "Nord",
                Coordonnee = new GeoCoordinate(48.6231369541815, 7.71205365657806)
            },
            new Arret() {
                Id = "ZOCOM_02",
                Code = "676B",
                Name = "Zone Commerciale",
                Coordonnee = new GeoCoordinate(48.6565320878319, 7.72191882133484)
            },
            new Arret() {
                Id = "RUHOE_02",
                Code = "563B",
                Name = "Rue de Hoenheim",
                Coordonnee = new GeoCoordinate(48.6238904582749, 7.70679116249084)
            },
            new Arret() {
                Id = "POSNC_02",
                Code = "500B",
                Name = "Pont S.N.C.F.",
                Coordonnee = new GeoCoordinate(48.6677923313673, 7.71690845489502)
            },
            new Arret() {
                Id = "ESEUE_06",
                Code = "182F",
                Name = "Espace Européen de l' Entreprise",
                Coordonnee = new GeoCoordinate(48.616467, 7.719799)
            },
            new Arret() {
                Id = "LAEGL_02",
                Code = "321B",
                Name = "Lampertheim Eglise",
                Coordonnee = new GeoCoordinate(48.6509267165243, 7.70095199346542)
            },
            new Arret() {
                Id = "BERLI_04",
                Code = "48C",
                Name = "Berlioz",
                Coordonnee = new GeoCoordinate(48.6370622247514, 7.70980933743442)
            },
            new Arret() {
                Id = "RUMUN_02",
                Code = "566B",
                Name = "Rue de Mundolsheim",
                Coordonnee = new GeoCoordinate(48.6477645054237, 7.70219922065735)
            },
            new Arret() {
                Id = "PERDR_02",
                Code = "470B",
                Name = "Perdrix",
                Coordonnee = new GeoCoordinate(48.6639721735582, 7.71987095475197)
            },
            new Arret() {
                Id = "TEMPL_02",
                Code = "627B",
                Name = "Temple",
                Coordonnee = new GeoCoordinate(48.6693670767941, 7.7077728509903)
            },
            new Arret() {
                Id = "WILSO_08",
                Code = "667G",
                Name = "Wilson",
                Coordonnee = new GeoCoordinate(48.587987, 7.73951)
            },
            new Arret() {
                Id = "FASAV_06",
                Code = "197E",
                Name = "Faubourg de Saverne",
                Coordonnee = new GeoCoordinate(48.585982, 7.740858)
            },
            new Arret() {
                Id = "WISSE_02",
                Code = "668B",
                Name = "Wissembourg",
                Coordonnee = new GeoCoordinate(48.5899893779524, 7.74136751890183)
            },
            new Arret() {
                Id = "ANEMO_02",
                Code = "27B",
                Name = "Anémones",
                Coordonnee = new GeoCoordinate(48.6432401343223, 7.72372126579285)
            },
            new Arret() {
                Id = "AUTO4_05",
                Code = "999C",
                Name = "Autoroute A4 fictif SAE",
                Coordonnee = new GeoCoordinate(48.6444028476226, 7.73247796149254)
            },
            new Arret() {
                Id = "MUMAI_02",
                Code = "416B",
                Name = "Mundolsheim Mairie",
                Coordonnee = new GeoCoordinate(48.6417416681317, 7.7153554558754)
            },
            new Arret() {
                Id = "LAMRI_02",
                Code = "328B",
                Name = "Lampertheim Mairie",
                Coordonnee = new GeoCoordinate(48.6506697776615, 7.70007625222206)
            },
            new Arret() {
                Id = "LALOR_01",
                Code = "324A",
                Name = "Lampertheim Lorraine",
                Coordonnee = new GeoCoordinate(48.651527416757, 7.69164875149727)
            },
            new Arret() {
                Id = "BOUNE_02",
                Code = "702B",
                Name = "Bourgogne",
                Coordonnee = new GeoCoordinate(48.6512722529307, 7.69677713513374)
            }
        }
    },
    new Ligne() {
        Id = "ROST-564",
        Name = "Navette Robertsau",
        Number = "ROST",
        Color = "D0AACC",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "GELEJ_02",
                Code = "240B",
                Name = "Général Lejeune",
                Coordonnee = new GeoCoordinate(48.6129076882186, 7.78830617666245)
            },
            new Arret() {
                Id = "ROBOE_08",
                Code = "535C",
                Name = "Robertsau Boecklin",
                Coordonnee = new GeoCoordinate(48.598352, 7.778287)
            },
            new Arret() {
                Id = "ROEGL_01",
                Code = "539A",
                Name = "Robertsau Eglise",
                Coordonnee = new GeoCoordinate(48.6029725535281, 7.78336018323898)
            },
            new Arret() {
                Id = "KEMPF_2",
                Code = "999",
                Name = "Kempf",
                Coordonnee = new GeoCoordinate(48.608859, 7.78953)
            },
            new Arret() {
                Id = "ROREN_03",
                Code = "545A",
                Name = "Robertsau Renaissance",
                Coordonnee = new GeoCoordinate(48.614956, 7.790047)
            },
            new Arret() {
                Id = "SCHOT_01",
                Code = "576A",
                Name = "Schott",
                Coordonnee = new GeoCoordinate(48.6003944550999, 7.78052374720573)
            },
            new Arret() {
                Id = "ANGLE_02",
                Code = "999",
                Name = "Angle",
                Coordonnee = new GeoCoordinate(48.611576, 7.788651)
            },
            new Arret() {
                Id = "STFRA_01",
                Code = "598A",
                Name = "Saint François",
                Coordonnee = new GeoCoordinate(48.6035330308533, 7.7872171998024)
            }
        }
    },
    new Ligne() {
        Id = "87-681",
        Name = "Substitution A/D",
        Number = "87",
        Color = "808080",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "COLON_01",
                Code = "128A",
                Name = "Colonne",
                Coordonnee = new GeoCoordinate(48.5384539732656, 7.7332592010498)
            },
            new Arret() {
                Id = "BAGGE_01",
                Code = "38A",
                Name = "Baggersee",
                Coordonnee = new GeoCoordinate(48.5451639058132, 7.73791618645191)
            },
            new Arret() {
                Id = "LYCOU_05",
                Code = "366",
                Name = "Lycée Couffignal",
                Coordonnee = new GeoCoordinate(48.5587532995628, 7.74907886981964)
            },
            new Arret() {
                Id = "CAILL_10",
                Code = "75F",
                Name = "Campus d'Illkirch",
                Coordonnee = new GeoCoordinate(48.5291978324138, 7.7328810095787)
            },
            new Arret() {
                Id = "ETBOU_1B",
                Code = "186D",
                Name = "Etoile Bourse",
                Coordonnee = new GeoCoordinate(48.5743249474167, 7.75365471839905)
            },
            new Arret() {
                Id = "EMMAT_01",
                Code = "176A",
                Name = "Emile Mathis",
                Coordonnee = new GeoCoordinate(48.5535569503679, 7.7453975379467)
            },
            new Arret() {
                Id = "KRIMM_05",
                Code = "319C",
                Name = "Krimmeri",
                Coordonnee = new GeoCoordinate(48.5629959083714, 7.75263279676437)
            },
            new Arret() {
                Id = "HOHWA_06",
                Code = "280B",
                Name = "Hohwart",
                Coordonnee = new GeoCoordinate(48.5494032153818, 7.74146273732185)
            },
            new Arret() {
                Id = "SCHLU_03",
                Code = "573",
                Name = "Schluthfeld",
                Coordonnee = new GeoCoordinate(48.568674, 7.752431)
            },
            new Arret() {
                Id = "ILLIX_02",
                Code = "290A",
                Name = "Illkirch Lixenbuhl",
                Coordonnee = new GeoCoordinate(48.5300095774251, 7.72450715303421)
            },
            new Arret() {
                Id = "LECLE_03",
                Code = "335",
                Name = "Leclerc",
                Coordonnee = new GeoCoordinate(48.5343434006038, 7.73443400859833)
            }
        }
    },
    new Ligne() {
        Id = "29-26",
        Name = "Schnokeloch - Schiltigheim Campus",
        Number = "29",
        Color = "9FC204",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "MADRI_01",
                Code = "717A",
                Name = "Madrid",
                Coordonnee = new GeoCoordinate(48.6090802928692, 7.70685712994575)
            },
            new Arret() {
                Id = "MAZEL_05",
                Code = "709C",
                Name = "Mathieu Zell",
                Coordonnee = new GeoCoordinate(48.594754, 7.71768)
            },
            new Arret() {
                Id = "SCCAM_01",
                Code = "713A",
                Name = "Schiltigheim Campus",
                Coordonnee = new GeoCoordinate(48.610088, 7.705189)
            },
            new Arret() {
                Id = "GEROL_01",
                Code = "712A",
                Name = "Geroldseck",
                Coordonnee = new GeoCoordinate(48.581864, 7.71503)
            },
            new Arret() {
                Id = "DUALS_05",
                Code = "175C",
                Name = "Duscs d'Alsace",
                Coordonnee = new GeoCoordinate(48.5905490492332, 7.71579259939194)
            },
            new Arret() {
                Id = "SCHNO_04",
                Code = "575D",
                Name = "Schnokeloch",
                Coordonnee = new GeoCoordinate(48.579554243221, 7.71283377199173)
            },
            new Arret() {
                Id = "CHMAN_03",
                Code = "91C",
                Name = "Champ de Manoeuvre",
                Coordonnee = new GeoCoordinate(48.6015402928692, 7.70956712994576)
            },
            new Arret() {
                Id = "IUTPA_02",
                Code = "294B",
                Name = "I.U.T. Pasteur",
                Coordonnee = new GeoCoordinate(48.60652864122, 7.70956993103027)
            },
            new Arret() {
                Id = "STUTZ_01",
                Code = "622A",
                Name = "Stutzheim",
                Coordonnee = new GeoCoordinate(48.5983625689524, 7.71411627531052)
            },
            new Arret() {
                Id = "BERST_01",
                Code = "49A",
                Name = "Berstett",
                Coordonnee = new GeoCoordinate(48.6001957932762, 7.71179348230362)
            },
            new Arret() {
                Id = "HERRA_01",
                Code = "714A",
                Name = "Herrade",
                Coordonnee = new GeoCoordinate(48.583554243221, 7.71468377199173)
            },
            new Arret() {
                Id = "ALEUR_02",
                Code = "19B",
                Name = "Allée de l'Euro",
                Coordonnee = new GeoCoordinate(48.6046131737244, 7.70577996969223)
            },
            new Arret() {
                Id = "ATHEN_01",
                Code = "716A",
                Name = "Athènes",
                Coordonnee = new GeoCoordinate(48.6081802928692, 7.70976712994575)
            },
            new Arret() {
                Id = "DUALS_06",
                Code = "157D",
                Name = "Ducs d'Alsace",
                Coordonnee = new GeoCoordinate(48.590724, 7.716031)
            }
        }
    },
    new Ligne() {
        Id = "70-26",
        Name = "Oberschaeffolsheim - Eckbolsheim - Robertsau",
        Number = "70",
        Color = "FABB00",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "HECHN_02",
                Code = "264B",
                Name = "Hechner",
                Coordonnee = new GeoCoordinate(48.6123340148574, 7.77626305818558)
            },
            new Arret() {
                Id = "GELEJ_02",
                Code = "240B",
                Name = "Général Lejeune",
                Coordonnee = new GeoCoordinate(48.6129076882186, 7.78830617666245)
            },
            new Arret() {
                Id = "OBSST_01",
                Code = "440A",
                Name = "Oberschaeffolsheim Stade (départ 70)",
                Coordonnee = new GeoCoordinate(48.5821347022637, 7.6472219824791)
            },
            new Arret() {
                Id = "OBSMA_02",
                Code = "439B",
                Name = "Oberschaeffolsheim Mairie",
                Coordonnee = new GeoCoordinate(48.5862547002034, 7.64928191900253)
            },
            new Arret() {
                Id = "PAPOT_02",
                Code = "460B",
                Name = "Poteries",
                Coordonnee = new GeoCoordinate(48.5832153026903, 7.69053429365158)
            },
            new Arret() {
                Id = "MARGU_02",
                Code = "384B",
                Name = "Marguerite",
                Coordonnee = new GeoCoordinate(48.6142296834651, 7.75970444083214)
            },
            new Arret() {
                Id = "ROREN_02",
                Code = "545A",
                Name = "Robertsau Renaissance",
                Coordonnee = new GeoCoordinate(48.61467, 7.790165)
            },
            new Arret() {
                Id = "VIENN_01",
                Code = "722A",
                Name = "Vienne",
                Coordonnee = new GeoCoordinate(48.613501, 7.716661)
            },
            new Arret() {
                Id = "RTWOL_02",
                Code = "554B",
                Name = "Route de Wolfisheim",
                Coordonnee = new GeoCoordinate(48.5843189462735, 7.67882913351059)
            },
            new Arret() {
                Id = "JACQU_02",
                Code = "724B",
                Name = "Jacqueline",
                Coordonnee = new GeoCoordinate(48.593558, 7.694935)
            },
            new Arret() {
                Id = "PASPO_03",
                Code = "715C",
                Name = "Parc des sports",
                Coordonnee = new GeoCoordinate(48.598784, 7.695257)
            },
            new Arret() {
                Id = "FRLUM_02",
                Code = "225B",
                Name = "Frères Lumière",
                Coordonnee = new GeoCoordinate(48.6144770549885, 7.7382829785347)
            },
            new Arret() {
                Id = "DONON_02",
                Code = "153B",
                Name = "Donon",
                Coordonnee = new GeoCoordinate(48.5869076233952, 7.66551464796066)
            },
            new Arret() {
                Id = "VOLTA_02",
                Code = "654B",
                Name = "Voltaire",
                Coordonnee = new GeoCoordinate(48.614182691605, 7.74893671274185)
            },
            new Arret() {
                Id = "MASEG_04",
                Code = "388E",
                Name = "Marc Seguin",
                Coordonnee = new GeoCoordinate(48.6160676515298, 7.73274689912796)
            },
            new Arret() {
                Id = "CHBLA_04",
                Code = "87D",
                Name = "Cheval Blanc",
                Coordonnee = new GeoCoordinate(48.6140496955375, 7.75166451931)
            },
            new Arret() {
                Id = "COURO_02",
                Code = "134B",
                Name = "Couronne",
                Coordonnee = new GeoCoordinate(48.5867940721418, 7.65229940414429)
            },
            new Arret() {
                Id = "MAPAG_02",
                Code = "381B",
                Name = "Marcel Pagnol",
                Coordonnee = new GeoCoordinate(48.6024741491633, 7.7028389275074)
            },
            new Arret() {
                Id = "WASSE_02",
                Code = "659B",
                Name = "Wasselonne",
                Coordonnee = new GeoCoordinate(48.5844591179299, 7.68787354230881)
            },
            new Arret() {
                Id = "BANLI_02",
                Code = "42B",
                Name = "Banlieue",
                Coordonnee = new GeoCoordinate(48.6007873420311, 7.69812226295471)
            },
            new Arret() {
                Id = "JEMON_02",
                Code = "300B",
                Name = "Jean Monnet",
                Coordonnee = new GeoCoordinate(48.587566747898, 7.68746986985207)
            },
            new Arret() {
                Id = "POPHA_02",
                Code = "496E",
                Name = "Pont Phario",
                Coordonnee = new GeoCoordinate(48.6126204090194, 7.76799783110619)
            },
            new Arret() {
                Id = "JAROS_02",
                Code = "297B",
                Name = "Jardin des Roses",
                Coordonnee = new GeoCoordinate(48.5805279539906, 7.69043773412704)
            },
            new Arret() {
                Id = "EDROS_02",
                Code = "723B",
                Name = "Edmond Rostand",
                Coordonnee = new GeoCoordinate(48.591752, 7.692795)
            },
            new Arret() {
                Id = "MALTE_02",
                Code = "380B",
                Name = "Malterie",
                Coordonnee = new GeoCoordinate(48.6136462719898, 7.75640666484833)
            },
            new Arret() {
                Id = "CIILL_02",
                Code = "99B",
                Name = "Cité de l'Ill",
                Coordonnee = new GeoCoordinate(48.6128979349392, 7.77336224913597)
            },
            new Arret() {
                Id = "BIGAR_02",
                Code = "52B",
                Name = "Bischheim Gare",
                Coordonnee = new GeoCoordinate(48.6143937113131, 7.74514004588127)
            },
            new Arret() {
                Id = "IUTPA_02",
                Code = "294B",
                Name = "I.U.T. Pasteur",
                Coordonnee = new GeoCoordinate(48.60652864122, 7.70956993103027)
            },
            new Arret() {
                Id = "JAVIG_02",
                Code = "299B",
                Name = "Jardin des Vignes",
                Coordonnee = new GeoCoordinate(48.5823529534728, 7.68293291330338)
            },
            new Arret() {
                Id = "BUGAT_02",
                Code = "71B",
                Name = "Bugatti",
                Coordonnee = new GeoCoordinate(48.5895032645024, 7.6885923743248)
            },
            new Arret() {
                Id = "CHMET_04",
                Code = "92D",
                Name = "Chambre de Métiers",
                Coordonnee = new GeoCoordinate(48.6155011070026, 7.71948739886284)
            },
            new Arret() {
                Id = "ESCAL_02",
                Code = "181B",
                Name = "l'Escale",
                Coordonnee = new GeoCoordinate(48.6107645814743, 7.7821384370327)
            },
            new Arret() {
                Id = "OBSCA_02",
                Code = "437B",
                Name = "Oberschaeffolsheim Canal",
                Coordonnee = new GeoCoordinate(48.5847793820909, 7.64687865972519)
            },
            new Arret() {
                Id = "OCTRO_02",
                Code = "441B",
                Name = "Octroi",
                Coordonnee = new GeoCoordinate(48.5804853669253, 7.69513830542564)
            },
            new Arret() {
                Id = "KARIN_04",
                Code = "310D",
                Name = "Karine",
                Coordonnee = new GeoCoordinate(48.5962483401256, 7.6960631978035)
            },
            new Arret() {
                Id = "JARDI_02",
                Code = "296B",
                Name = "Jardins",
                Coordonnee = new GeoCoordinate(48.5868863325547, 7.67089247703552)
            },
            new Arret() {
                Id = "ALEUR_02",
                Code = "19B",
                Name = "Allée de l'Euro",
                Coordonnee = new GeoCoordinate(48.6046131737244, 7.70577996969223)
            },
            new Arret() {
                Id = "BOROU_02",
                Code = "60B",
                Name = "Boeuf Rouge",
                Coordonnee = new GeoCoordinate(48.5870291584386, 7.6681150496006)
            },
            new Arret() {
                Id = "PAPET_02",
                Code = "459B",
                Name = "Papeterie",
                Coordonnee = new GeoCoordinate(48.6115191569466, 7.78042048215866)
            },
            new Arret() {
                Id = "COEHO_02",
                Code = "121B",
                Name = "Coehorn",
                Coordonnee = new GeoCoordinate(48.6106457636273, 7.78629183769226)
            },
            new Arret() {
                Id = "GEBUR_02",
                Code = "235B",
                Name = "Georges Burger",
                Coordonnee = new GeoCoordinate(48.6151437994385, 7.72971332073212)
            },
            new Arret() {
                Id = "MUHLB_02",
                Code = "414B",
                Name = "Mühlbach",
                Coordonnee = new GeoCoordinate(48.5867497161141, 7.65489846467972)
            },
            new Arret() {
                Id = "ECCEN_02",
                Code = "160B",
                Name = "Eckbolsheim Centre",
                Coordonnee = new GeoCoordinate(48.5803442970149, 7.68740683794022)
            },
            new Arret() {
                Id = "MASCH_02",
                Code = "387B",
                Name = "Maires Schaub",
                Coordonnee = new GeoCoordinate(48.6130265007429, 7.76462629437447)
            },
            new Arret() {
                Id = "LONDR_05",
                Code = "721E",
                Name = "Londres",
                Coordonnee = new GeoCoordinate(48.6104283401256, 7.7122631978035)
            },
            new Arret() {
                Id = "HERRE_02",
                Code = "266B",
                Name = "Herrenwasser",
                Coordonnee = new GeoCoordinate(48.58701496458, 7.66242474317551)
            },
            new Arret() {
                Id = "PRUNE_02",
                Code = "518B",
                Name = "Prunelliers",
                Coordonnee = new GeoCoordinate(48.6147164456313, 7.73453056812286)
            },
            new Arret() {
                Id = "JPERR_01",
                Code = "309A",
                Name = "Jean Perrin",
                Coordonnee = new GeoCoordinate(48.5879011859799, 7.6834425330162)
            },
            new Arret() {
                Id = "ECKPA_02",
                Code = "165A",
                Name = "Eckbolsheim Parc d'Activités",
                Coordonnee = new GeoCoordinate(48.5905180653739, 7.68352299928665)
            }
        }
    },
    new Ligne() {
        Id = "66-26",
        Name = "Lipsheim Gare - Baggersee",
        Number = "66",
        Color = "D0AACC",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "COLON_01",
                Code = "128A",
                Name = "Colonne",
                Coordonnee = new GeoCoordinate(48.5384539732656, 7.7332592010498)
            },
            new Arret() {
                Id = "DECLE_01",
                Code = "146",
                Name = "Deux Clés",
                Coordonnee = new GeoCoordinate(48.5317467035537, 7.7150671184063)
            },
            new Arret() {
                Id = "FEMAI_02",
                Code = "210B",
                Name = "Fegersheim Mairie",
                Coordonnee = new GeoCoordinate(48.4904996328212, 7.67983227968216)
            },
            new Arret() {
                Id = "BAGGE_07",
                Code = "38F",
                Name = "Baggersee",
                Coordonnee = new GeoCoordinate(48.5449250734092, 7.73695796728134)
            },
            new Arret() {
                Id = "CETRA_02",
                Code = "83B",
                Name = "Centre de Traumatologie",
                Coordonnee = new GeoCoordinate(48.5375109420274, 7.72796854376793)
            },
            new Arret() {
                Id = "ELISA_01",
                Code = "173A",
                Name = "Elisa",
                Coordonnee = new GeoCoordinate(48.5150967937515, 7.69765824079514)
            },
            new Arret() {
                Id = "GRUSI_02",
                Code = "254B",
                Name = "Graffenstaden Usine",
                Coordonnee = new GeoCoordinate(48.5269681310463, 7.70948946475983)
            },
            new Arret() {
                Id = "LIGAR_01",
                Code = "346A",
                Name = "Lipsheim Gare",
                Coordonnee = new GeoCoordinate(48.4907547204395, 7.6749050617218)
            },
            new Arret() {
                Id = "POPEA_01",
                Code = "495A",
                Name = "Pont du Péage",
                Coordonnee = new GeoCoordinate(48.5183970107033, 7.70252779126167)
            },
            new Arret() {
                Id = "NIEDE_01",
                Code = "430B",
                Name = "Niederbourg",
                Coordonnee = new GeoCoordinate(48.5330139865008, 7.72078156471252)
            },
            new Arret() {
                Id = "ILMAI_01",
                Code = "291A",
                Name = "Illkirch Mairie",
                Coordonnee = new GeoCoordinate(48.5295015722239, 7.71102905273438)
            },
            new Arret() {
                Id = "RUETA_01",
                Code = "560A",
                Name = "Rue de l'Etang",
                Coordonnee = new GeoCoordinate(48.4960694945707, 7.68701255321503)
            },
            new Arret() {
                Id = "DIGUE_01",
                Code = "150A",
                Name = "Graffenstaden Digue",
                Coordonnee = new GeoCoordinate(48.5208691454339, 7.70515367388725)
            },
            new Arret() {
                Id = "LIEST_01",
                Code = "345A",
                Name = "Lipsheim Est",
                Coordonnee = new GeoCoordinate(48.4916417398685, 7.66995772719383)
            },
            new Arret() {
                Id = "BROCH_01",
                Code = "66A",
                Name = "Brochet",
                Coordonnee = new GeoCoordinate(48.5244869677422, 7.70797401666641)
            },
            new Arret() {
                Id = "LICEN_01",
                Code = "344A",
                Name = "Lipsheim Centre",
                Coordonnee = new GeoCoordinate(48.4903325364035, 7.66497150063515)
            },
            new Arret() {
                Id = "DELAT_01",
                Code = "148A",
                Name = "De Lattre de Tassigny",
                Coordonnee = new GeoCoordinate(48.4933677392131, 7.68386632204056)
            }
        }
    },
    new Ligne() {
        Id = "27-677",
        Name = "BAGGERSEE - LORIENT - PORT AUTONOME SUD",
        Number = "27",
        Color = "9FC204",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "ILDFR_02",
                Code = "289B",
                Name = "Ile de France",
                Coordonnee = new GeoCoordinate(48.5498710713482, 7.75092288851738)
            },
            new Arret() {
                Id = "BARTI_01",
                Code = "44A",
                Name = "Bartischgut",
                Coordonnee = new GeoCoordinate(48.5546967487734, 7.73955434560776)
            },
            new Arret() {
                Id = "NEHLO_04",
                Code = "426B",
                Name = "Neuhof Lorient",
                Coordonnee = new GeoCoordinate(48.5446516133619, 7.78758734464645)
            },
            new Arret() {
                Id = "COREU_03",
                Code = "133B",
                Name = "Neuhof Corps Européen",
                Coordonnee = new GeoCoordinate(48.5439342176438, 7.78117820620537)
            },
            new Arret() {
                Id = "CANAR_01",
                Code = "77A",
                Name = "Canardière",
                Coordonnee = new GeoCoordinate(48.5501640339826, 7.74597018957138)
            },
            new Arret() {
                Id = "CRAVV_01",
                Code = "137A",
                Name = "CRAV",
                Coordonnee = new GeoCoordinate(48.5513163372213, 7.73342147469521)
            },
            new Arret() {
                Id = "PROVE_05",
                Code = "707A",
                Name = "Provence",
                Coordonnee = new GeoCoordinate(48.5464237502872, 7.75815010070801)
            },
            new Arret() {
                Id = "ABEPE_01",
                Code = "12A",
                Name = "Abbé de l'Epée",
                Coordonnee = new GeoCoordinate(48.5454515686252, 7.76069819927216)
            },
            new Arret() {
                Id = "NEHJM_01",
                Code = "425A",
                Name = "Jean Moulin",
                Coordonnee = new GeoCoordinate(48.5414374592115, 7.77547851204872)
            },
            new Arret() {
                Id = "KLEBS_01",
                Code = "318A",
                Name = "Klebsau",
                Coordonnee = new GeoCoordinate(48.5443595066792, 7.77343869209289)
            },
            new Arret() {
                Id = "VERDO_02",
                Code = "645B",
                Name = "Verdon",
                Coordonnee = new GeoCoordinate(48.5497201505414, 7.7356168627739)
            },
            new Arret() {
                Id = "ROREU_05",
                Code = "546E",
                Name = "Neuhof Rodolphe Reuss",
                Coordonnee = new GeoCoordinate(48.5465098695888, 7.76697725057602)
            },
            new Arret() {
                Id = "FREBE_01",
                Code = "224A",
                Name = "Frères Eberts",
                Coordonnee = new GeoCoordinate(48.5552258053513, 7.73506298661232)
            },
            new Arret() {
                Id = "HOHWA_04",
                Code = "280F",
                Name = "Hohwart",
                Coordonnee = new GeoCoordinate(48.5491759441293, 7.74093300104141)
            },
            new Arret() {
                Id = "SCHUL_01",
                Code = "577A",
                Name = "Schulmeister",
                Coordonnee = new GeoCoordinate(48.5498763979568, 7.75263011455536)
            },
            new Arret() {
                Id = "INGOL_01",
                Code = "293A",
                Name = "Ingold",
                Coordonnee = new GeoCoordinate(48.545579418239, 7.7721780538559)
            },
            new Arret() {
                Id = "BAGGE_06",
                Code = "38E",
                Name = "Baggersee",
                Coordonnee = new GeoCoordinate(48.5448207503512, 7.73740321397781)
            },
            new Arret() {
                Id = "EMMAT_05",
                Code = "176E",
                Name = "Emile Mathis",
                Coordonnee = new GeoCoordinate(48.5529533084134, 7.74355620145798)
            },
            new Arret() {
                Id = "CIMEI_01",
                Code = "100A",
                Name = "Cité Meinau",
                Coordonnee = new GeoCoordinate(48.547981865506, 7.75637984275818)
            },
            new Arret() {
                Id = "STNAZ_02",
                Code = "615B",
                Name = "Saint Nazaire",
                Coordonnee = new GeoCoordinate(48.5306454648654, 7.78017103672028)
            },
            new Arret() {
                Id = "LAROC_02",
                Code = "330B",
                Name = "La Rochelle",
                Coordonnee = new GeoCoordinate(48.5362686358332, 7.78688460588455)
            },
            new Arret() {
                Id = "BOULO_02",
                Code = "739B",
                Name = "Boulogne",
                Coordonnee = new GeoCoordinate(48.539756, 7.787817)
            },
            new Arret() {
                Id = "CHERB_02",
                Code = "90B",
                Name = "Cherbourg",
                Coordonnee = new GeoCoordinate(48.5334944267544, 7.78293639421463)
            },
            new Arret() {
                Id = "EUROF_04",
                Code = "190D",
                Name = "Eurofret",
                Coordonnee = new GeoCoordinate(48.5252147002539, 7.77883215512509)
            },
            new Arret() {
                Id = "ROCHF_01",
                Code = "740",
                Name = "Rochefort",
                Coordonnee = new GeoCoordinate(48.521231, 7.782139)
            },
            new Arret() {
                Id = "POAUT_01",
                Code = "738A",
                Name = "Port Autonome Sud",
                Coordonnee = new GeoCoordinate(48.5160153683249, 7.77537658810616)
            }
        }
    },
    new Ligne() {
        Id = "88-359",
        Name = "Substitution B/F",
        Number = "88",
        Color = "808080",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "REPUB_01",
                Code = "527A",
                Name = "République",
                Coordonnee = new GeoCoordinate(48.5865918083395, 7.75383979082108)
            },
            new Arret() {
                Id = "UNIVE_03",
                Code = "638",
                Name = "Université",
                Coordonnee = new GeoCoordinate(48.5828551051151, 7.76384979486465)
            },
            new Arret() {
                Id = "OBSER_07",
                Code = "438F",
                Name = "Observatoire",
                Coordonnee = new GeoCoordinate(48.581511882656, 7.76879847049713)
            },
            new Arret() {
                Id = "GALLI_05",
                Code = "233",
                Name = "Gallia",
                Coordonnee = new GeoCoordinate(48.5844520206402, 7.75822922587395)
            },
            new Arret() {
                Id = "ESPLA_01",
                Code = "185A",
                Name = "Esplanade",
                Coordonnee = new GeoCoordinate(48.5782202156804, 7.76927188038826)
            }
        }
    },
    new Ligne() {
        Id = "N1-726",
        Name = "Ligne de nuit - N1 //  Boecklin <> Corbeau",
        Number = "N1",
        Color = "E2001A",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "ROBOE_05",
                Code = "535C",
                Name = "Robertsau Boecklin",
                Coordonnee = new GeoCoordinate(48.5981993759475, 7.77905523777008)
            },
            new Arret() {
                Id = "CIUNI_01",
                Code = "114A",
                Name = "Cité Universitaire",
                Coordonnee = new GeoCoordinate(48.6021525139793, 7.77559741105313)
            },
            new Arret() {
                Id = "CINOR_01",
                Code = "111A",
                Name = "Cimetière Nord",
                Coordonnee = new GeoCoordinate(48.6091223876536, 7.77977809309959)
            },
            new Arret() {
                Id = "PAPET_01",
                Code = "459A",
                Name = "Papeterie",
                Coordonnee = new GeoCoordinate(48.6116025053672, 7.78041243553162)
            },
            new Arret() {
                Id = "CIILL_01",
                Code = "99A",
                Name = "Cité de l'Ill",
                Coordonnee = new GeoCoordinate(48.612942268012, 7.7736009657383)
            },
            new Arret() {
                Id = "POPHA_01",
                Code = "496D",
                Name = "Pont Phario",
                Coordonnee = new GeoCoordinate(48.6129325147393, 7.76866570115089)
            },
            new Arret() {
                Id = "MARGU_01",
                Code = "384A",
                Name = "Marguerite",
                Coordonnee = new GeoCoordinate(48.6142057442211, 7.76011884212494)
            },
            new Arret() {
                Id = "CHBLA_01",
                Code = "87A",
                Name = "Cheval Blanc",
                Coordonnee = new GeoCoordinate(48.6135957329884, 7.75186836719513)
            },
            new Arret() {
                Id = "MAROU_01",
                Code = "386A",
                Name = "Maison Rouge",
                Coordonnee = new GeoCoordinate(48.6072903740751, 7.74948924779892)
            },
            new Arret() {
                Id = "SCHMA_01",
                Code = "574A",
                Name = "Schiltigheim Mairie",
                Coordonnee = new GeoCoordinate(48.6052383690183, 7.74794965982437)
            },
            new Arret() {
                Id = "STHEL_01",
                Code = "610A",
                Name = "Sainte Hélène",
                Coordonnee = new GeoCoordinate(48.5971935987259, 7.74184226989746)
            },
            new Arret() {
                Id = "PLPIE_03",
                Code = "485A",
                Name = "Place de Pierre",
                Coordonnee = new GeoCoordinate(48.5907238616664, 7.74445205926895)
            },
            new Arret() {
                Id = "LHPPA_01",
                Code = "341A",
                Name = "Les Halles - Pont de Paris",
                Coordonnee = new GeoCoordinate(48.5858892014731, 7.74376004934311)
            },
            new Arret() {
                Id = "POKUS_01",
                Code = "492A",
                Name = "Pont Kuss",
                Coordonnee = new GeoCoordinate(48.5832099795922, 7.73844927549362)
            },
            new Arret() {
                Id = "STMAR_01",
                Code = "613A",
                Name = "Sainte Marguerite",
                Coordonnee = new GeoCoordinate(48.5813610562406, 7.7365180850029)
            },
            new Arret() {
                Id = "MAARM_06",
                Code = "375B",
                Name = "Musée d'Art Moderne",
                Coordonnee = new GeoCoordinate(48.5780111822511, 7.73496672139168)
            },
            new Arret() {
                Id = "STTHO_02",
                Code = "620B",
                Name = "Saint Thomas Finkwiller",
                Coordonnee = new GeoCoordinate(48.5788803407416, 7.74372786283493)
            },
            new Arret() {
                Id = "STNIC_02",
                Code = "616B",
                Name = "Saint Nicolas",
                Coordonnee = new GeoCoordinate(48.5783852477538, 7.74801939725876)
            },
            new Arret() {
                Id = "CORBE_06",
                Code = "132C",
                Name = "Corbeau",
                Coordonnee = new GeoCoordinate(48.579292, 7.751066)
            }
        }
    },
    new Ligne() {
        Id = "N2-726",
        Name = "Ligne de Nuit - N2 // Corbeau <> Campus d'Illkirch",
        Number = "N2",
        Color = "004A99",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "BATEL_02",
                Code = "45B",
                Name = "Bateliers",
                Coordonnee = new GeoCoordinate(48.5807683927908, 7.75396719574928)
            },
            new Arret() {
                Id = "CORBE_04",
                Code = "132A",
                Name = "Corbeau",
                Coordonnee = new GeoCoordinate(48.5796132114242, 7.7514123916626)
            },
            new Arret() {
                Id = "STGUI_02",
                Code = "600B",
                Name = "Saint Guillaume",
                Coordonnee = new GeoCoordinate(48.5828009865384, 7.75762304663658)
            },
            new Arret() {
                Id = "UNIVE_03",
                Code = "638",
                Name = "Université",
                Coordonnee = new GeoCoordinate(48.5828551051151, 7.76384979486465)
            },
            new Arret() {
                Id = "OBSER_07",
                Code = "438F",
                Name = "Observatoire",
                Coordonnee = new GeoCoordinate(48.581511882656, 7.76879847049713)
            },
            new Arret() {
                Id = "ESPLA_05",
                Code = "185B",
                Name = "Esplanade",
                Coordonnee = new GeoCoordinate(48.578520112274, 7.76962324976921)
            },
            new Arret() {
                Id = "ARBRI_10",
                Code = "32B",
                Name = "Aristide Briand",
                Coordonnee = new GeoCoordinate(48.5685927468816, 7.77642593498763)
            },
            new Arret() {
                Id = "JEJAU_04",
                Code = "298A",
                Name = "Jean Jaures",
                Coordonnee = new GeoCoordinate(48.5671674549488, 7.77202202643628)
            },
            new Arret() {
                Id = "LANDS_10",
                Code = "329E",
                Name = "Landsberg",
                Coordonnee = new GeoCoordinate(48.5702261623191, 7.76354402303696)
            },
            new Arret() {
                Id = "NEDMA_04",
                Code = "421B",
                Name = "Neudorf Marché",
                Coordonnee = new GeoCoordinate(48.5659593104088, 7.75918275117874)
            },
            new Arret() {
                Id = "KRMEI_01",
                Code = "319A",
                Name = "Krimmeri Meinau",
                Coordonnee = new GeoCoordinate(48.5629959083714, 7.75263279676437)
            },
            new Arret() {
                Id = "LYCOU_07",
                Code = "366D",
                Name = "Lycée Couffignal",
                Coordonnee = new GeoCoordinate(48.5588988677685, 7.74928942322731)
            },
            new Arret() {
                Id = "EMMAT_01",
                Code = "176A",
                Name = "Emile Mathis",
                Coordonnee = new GeoCoordinate(48.5535569503679, 7.7453975379467)
            },
            new Arret() {
                Id = "HOHWA_06",
                Code = "280B",
                Name = "Hohwart",
                Coordonnee = new GeoCoordinate(48.5494032153818, 7.74146273732185)
            },
            new Arret() {
                Id = "BAGGE_01",
                Code = "38A",
                Name = "Baggersee",
                Coordonnee = new GeoCoordinate(48.5451639058132, 7.73791618645191)
            },
            new Arret() {
                Id = "COLON_01",
                Code = "128A",
                Name = "Colonne",
                Coordonnee = new GeoCoordinate(48.5384539732656, 7.7332592010498)
            },
            new Arret() {
                Id = "CAILL_06",
                Code = "75A",
                Name = "Campus d'Illkirch",
                Coordonnee = new GeoCoordinate(48.5291978324138, 7.7328810095787)
            }
        }
    },
    new Ligne() {
        Id = "N3-726",
        Name = "Ligne de nuit - N3 //  Mathieu Zell <> Corbeau",
        Number = "N3",
        Color = "FABB00",
        Type = "Bus",
        Arrets = new List < Arret > () {
            new Arret() {
                Id = "MAZEL_06",
                Code = "709D",
                Name = "Mathieu Zell",
                Coordonnee = new GeoCoordinate(48.594794, 7.717616)
            },
            new Arret() {
                Id = "ETDOR_01",
                Code = "187A",
                Name = "Etoile d'Or",
                Coordonnee = new GeoCoordinate(48.5947455916505, 7.71091774106026)
            },
            new Arret() {
                Id = "SHAKE_01",
                Code = "729A",
                Name = "Shakespeare",
                Coordonnee = new GeoCoordinate(48.594623188183, 7.70393192768097)
            },
            new Arret() {
                Id = "DANTE_03",
                Code = "143C",
                Name = "Dante",
                Coordonnee = new GeoCoordinate(48.5911833520877, 7.70266324281693)
            },
            new Arret() {
                Id = "MARUD_06",
                Code = "732A",
                Name = "Marcel Rudloff",
                Coordonnee = new GeoCoordinate(48.5853178826286, 7.69454151391983)
            },
            new Arret() {
                Id = "HEFRE_02",
                Code = "265B",
                Name = "Henri Frenay",
                Coordonnee = new GeoCoordinate(48.5797631558114, 7.69776687026024)
            },
            new Arret() {
                Id = "CAPUC_02",
                Code = "79B",
                Name = "Capucins",
                Coordonnee = new GeoCoordinate(48.5780587321622, 7.70583629608154)
            },
            new Arret() {
                Id = "SCHNO_02",
                Code = "575B",
                Name = "Schnokeloch",
                Coordonnee = new GeoCoordinate(48.579054243221, 7.71253377199173)
            },
            new Arret() {
                Id = "NICIG_02",
                Code = "429B",
                Name = "Nid de Cigognes",
                Coordonnee = new GeoCoordinate(48.5724934464926, 7.7155002951622)
            },
            new Arret() {
                Id = "CAMPI_02",
                Code = "36B",
                Name = "Camping",
                Coordonnee = new GeoCoordinate(48.5733714926419, 7.71924868226051)
            },
            new Arret() {
                Id = "MOVER_06",
                Code = "410A",
                Name = "Montagne Verte",
                Coordonnee = new GeoCoordinate(48.5745822750797, 7.7270545810461)
            },
            new Arret() {
                Id = "LAITE_02",
                Code = "323B",
                Name = "Laiterie",
                Coordonnee = new GeoCoordinate(48.5760108634582, 7.73255243897438)
            },
            new Arret() {
                Id = "MAARM_02",
                Code = "375B",
                Name = "Musée d'Art Moderne",
                Coordonnee = new GeoCoordinate(48.5782716773525, 7.73402899503708)
            },
            new Arret() {
                Id = "STTHO_02",
                Code = "620B",
                Name = "Saint Thomas Finkwiller",
                Coordonnee = new GeoCoordinate(48.5788803407416, 7.74372786283493)
            },
            new Arret() {
                Id = "STNIC_02",
                Code = "616B",
                Name = "Saint Nicolas",
                Coordonnee = new GeoCoordinate(48.5783852477538, 7.74801939725876)
            },
            new Arret() {
                Id = "CORBE_04",
                Code = "132A",
                Name = "Corbeau",
                Coordonnee = new GeoCoordinate(48.5796132114242, 7.7514123916626)
            },
            new Arret() {
                Id = "STANT_02",
                Code = "592B",
                Name = "Saint Antoine",
                Coordonnee = new GeoCoordinate(48.5977293061935, 7.70958065986633)
            },
            new Arret() {
                Id = "STUTZ_02",
                Code = "622B",
                Name = "Stutzheim",
                Coordonnee = new GeoCoordinate(48.5983217707506, 7.71400898694992)
            }
        }
    },
};

        }
    }


}
