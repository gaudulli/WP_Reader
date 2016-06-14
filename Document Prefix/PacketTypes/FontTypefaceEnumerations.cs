using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public enum FontFamily
{
    ITCBenguiat = 0x0100,
    TimesRoman = 0x0900,
    ITCGaramond = 0x1100,
    CenturySchoolbook = 0x1900,
    Bodoni = 0x2100,
    ITCLubalinGraph = 0x2900,
    Albertus = 0x3100,
    Courier = 0x3900,
    Helvetica = 0x4100,
    ITCRonda = 0x4900,
    Microstyle = 0x5100,
    Optima = 0x5900,
    LetterGothic = 0x6100,
    Brush = 0x6900,
    ParkAvenue = 0x7100,
    SignetRoundhand = 0x7900,
    Tekton = 0x8100,
    Uncial = 0x8900,
    OldEnglish = 0x9100,
    ITCZapfDingbats = 0x9900,
    Broadway = 0xA100,
    Computer = 0xA900,
    PTBarnum = 0xB100,
    Ponderosa = 0xB900,
    Madrone = 0xC100,
    Hobo = 0xC900,
    Revue = 0xD100,
    AestheticOrnamented = 0xD900,

}


public enum ITCBenguiatFontFamily
{
    Bellini = 0x0101,
    Erasmus = 0x0102,
    HollandseMediaeval = 0x0103,
    Pastonchi = 0x0104,
    Windsor = 0x0105,
    Kennerley = 0x0106,
    Raleigh = 0x0107,
    SurreyOldStyle = 0x0108,
    Trajanus = 0x0109,
    Verona = 0x010A,
    WorchesterRound = 0x010B,
    DellaRobbia = 0x010C,
    BauerText = 0x010D,
    Cloister = 0x010E,
    Jenson = 0x010F,
    SchneidlerOldStyle = 0x0110,
    Centaur = 0x0111,
    HorleyOldStyle = 0x0112,
    Deepdene = 0x0113,
    Brighton = 0x0114,
    ITCClearface = 0x0115,
    Lutetia = 0x0116,
    Stratford = 0x0117,
    ITCTiffany = 0x0118,
    ITCBenguiat = 0x0119,
    Seagull = 0x011A,
    ITCSouvenir = 0x011B,
    Vendome = 0x011C,
    ItalianOldStyle = 0x011D,
    ITCItalia = 0x011E,
    JensonOldStyle = 0x011F,
    Guardi = 0x0120,
    Cantoria = 0x0121,
    ITCBerkleyOldStyle = 0x0122,
    ITCGiovanni = 0x0123,
    Lavenham = 0x0124,
    ITCVeljovic = 0x0125,
    HampshireOldStyle = 0x0126,
    ITCEsprit = 0x0127,
    Hadriano = 0x0128,
    ITCWeidemann = 0x0129,
    Minion = 0x012A,
    Seneca = 0x012B,
    Carmina = 0x012C,
}

public enum TimesRomanFontFamily
{
    Bembo = 0x0901,
    BernhardModern = 0x0902,
    GoudyOldStyle = 0x0903,
    Plantin = 0x0904,
    Poliphilus = 0x0905,
    Trajan = 0x0906,
    Leamington = 0x0907,
    Missal = 0x0908,
    TrumpMediaeval = 0x0909,
    Berling = 0x090A,
    Hiroshige = 0x090B,
    Albertina = 0x090C,
    Emerson = 0x090D,
    ITCStoneSerif = 0x090E,
    Life = 0x090F,
    Minister = 0x0910,
    TimesRoman = 0x0911,
    Calisto = 0x0912,
    Adroit = 0x0913,
    ITCSlimbach = 0x0914,
    Administer = 0x0915,
    Caxton = 0x0916,
    Eldorado = 0x0917,
    Symposia = 0x0918,
    Artcraft = 0x0919,
    ZAntiqua = 0x091A,
}

public enum ITCGaramondFontFamily
{
    BinnyOldStyle = 0x1101,
    Bookman = 0x1102,
    Bulmer = 0x1103,
    Caslon540 = 0x1104,
    Amerigo = 0x1105,
    ChiswellOldFace = 0x1106,
    Fontana = 0x1107,
    Granjon = 0x1108,
    Imprint = 0x1109,
    Monticello = 0x110A,
    OldStyleNo2 = 0x110B,
    GarthGraphic = 0x110C,
    Scenario = 0x110D,
    Ehrhardt = 0x110E,
    Galliard = 0x110F,
    Aldus = 0x1110,
    Aster = 0x1111,
    Baskerville = 0x1112,
    RotisSerif = 0x1113,
    Congress = 0x1114,
    Lectura = 0x1115,
    Palatino = 0x1116,
    PopplPontifex = 0x1117,
    TimesEuropa = 0x1118,
    QuadrigaAntiqua = 0x1119,
    Sabon = 0x111A,
    Barbou = 0x111B,
    Fournier = 0x111C,
    Garamond = 0x111D,
    Spectrum = 0x111E,
    Weiss = 0x111F,
    Concorde = 0x1120,
    ITCCushing = 0x1121,
    Dante = 0x1122,
    Gazette = 0x1123,
    ITCIsbell = 0x1124,
    Romulus = 0x1125,
    Rotation = 0x1126,
    VanDijck = 0x1127,
    Janson = 0x1128,
    Roundfunk = 0x1129,
    Charter = 0x112A,
    Criterion = 0x112B,
    Ellington = 0x112C,
    HollandSeminar = 0x112D,
    ITCGamma = 0x112E,
    ITCLeawood = 0x112F,
    Pasquale = 0x1130,
}

public enum CenturySchoolbookFontFamily
{
    Joanna = 0x1901,
    Maximus = 0x1902,
    Breughel = 0x1903,
    Excelsior = 0x1904,
    Perpetua = 0x1905,
    Primer = 0x1906,
    Nofret = 0x1907,
    CenturySchoolBook = 0x1908,
    Nimrod = 0x1909,
    Cheltenham = 0x190A,
    Comenius = 0x190B,
    Sorbonne = 0x190C,
    Bramley = 0x190D,
    GoudyModern = 0x190E,
    Athenaeum = 0x190F,
    Diotima = 0x1910,
    Impressum = 0x1911,
    Melior = 0x1912,
    Dominante = 0x1913,
    Menhart = 0x1914,
    Paragon = 0x1915,
    Cochin = 0x1916,
    Electra = 0x1917,
    Iridium = 0x1918,
    ITCZapfInternational = 0x1919,
    Accolade = 0x191A,
    Cardinal = 0x191B,
    Claridge = 0x191C,
    Else = 0x191D,
    ITCJamille = 0x191E,
    MonoTypeEngravers = 0x191F,
    ITCStoneInformal = 0x1920,
}

public enum BodoniFontFamily
{
    Auriga = 0x2101,
    ITCZapfBook = 0x2102,
    BauerBodoni = 0x2103,
    Corvinus = 0x2104,
    Albion42 = 0x2105,
    Caledonia = 0x2106,
    Fairfield = 0x2107,
    DeVinne = 0x2108,
    Madison = 0x2109,
    Walbaum = 0x210A,
    ITCFenice = 0x210B,
    Modern = 0x210C,
    ScotchRoman = 0x210D,
    Centennial = 0x210E,
    Versailles = 0x210F,
    Wilke = 0x2110,
    Inflex = 0x2111,
    ITCDidi = 0x2112,
}

public enum ITCLubalinGraphFontFamily
{
    ASGallatin = 0x2901,
    Beton = 0x2902,
    Calvert = 0x2903,
    Candida = 0x2904,
    City = 0x2905,
    Glypha = 0x2906,
    ITCLubalinGraph = 0x2907,
    Memphis = 0x2908,
    Rockwell = 0x2909,
    Serifa = 0x290A,
    Stymie = 0x290B,
    AntiqueNo5 = 0x290C,
    ITCPacella = 0x290D,
    SchadowAntiqua = 0x290E,
    Aachen = 0x290F,
    PMNCaecilia = 0x2910,
    available17 = 0x2911,
    Clarendon = 0x2912,
    EgyptienneF = 0x2913,
    Egizio = 0x2914,
    Fortune = 0x2915,
    ITCAmericanTypewriter = 0x2916,
}

public enum AlbertusFontFamily
{
    Albertus = 0x3101,
    Americana = 0x3102,
    Flange = 0x3103,
    FrenchOldStyle = 0x3104,
    ITCFrizQuadrata = 0x3105,
    Icone = 0x3106,
    ITCKorinna = 0x3107,
    ITCNewText = 0x3108,
    ITCNovarese = 0x3109,
    PopplLaudatio = 0x310A,
    ITCQuorum = 0x310B,
    Romana = 0x310C,
    ITCBarcelona = 0x310D,
    Biltmore = 0x310E,
    ITCLSCBook = 0x310F,
    Meridien = 0x3110,
    ITCTiepolo = 0x3111,
    RotisSemiserif = 0x3112,
    ITCSerifGothic = 0x3113,
    available20 = 0x3114,
    available21 = 0x3115,
    available22 = 0x3116,
    Footlight = 0x3117,
    ITCElan = 0x3118,
    ITCUsherwood = 0x3119,
    Copperplate = 0x311A,
}

public enum CourierFontFamily
{
    Courier = 0x3901,
    PrestigeElite = 0x3902,
}

public enum HelveticaFontFamily
{
    Abadi = 0x4101,
    AkzidenzGrotesk = 0x4102,
    AlpinGothic = 0x4103,
    AntiqueOlive = 0x4104,
    Avenir = 0x4105,
    CGSymphony = 0x4106,
    DINSchriften = 0x4107,
    DirectoryGothic = 0x4108,
    Flyer = 0x4109,
    Folio = 0x410A,
    Formata = 0x410B,
    FranklinGothic = 0x410C,
    Frontiera = 0x410D,
    Frutiger = 0x410E,
    Futura = 0x410F,
    GillSans = 0x4110,
    Gothic = 0x4111,
    Grotesque = 0x4112,
    CenturyGothic = 0x4113,
    Harry = 0x4114,
    Headline = 0x4115,
    Helvetica = 0x4116,
    HollandTitle = 0x4117,
    Imago = 0x4118,
    Impact = 0x4119,
    Insignia = 0x411A,
    ITCAvantGardeGothic = 0x411B,
    ITCKabel = 0x411C,
    ITCMixage = 0x411D,
    Ambassador = 0x411E,
    ITCStoneSans = 0x411F,
    TradeGothic = 0x4120,
    Metro = 0x4121,
    NeuzeitS = 0x4122,
    NewsGothic = 0x4123,
    Placard = 0x4124,
    VAGRounded = 0x4125,
    RotisSansSerif = 0x4126,
    Sans = 0x4127,
    SassoonPrimary = 0x4128,
    Syntax = 0x4129,
    Uncia = 0x412A,
}

public enum ITCRondaFontFamily
{
    ITCBauhaus = 0x4901,
    BlippoBlack = 0x4902,
    Churchward70 = 0x4903,
    ITCRonda = 0x4904,
    Wexford = 0x4905,
    ITCBusorama = 0x4906,
}

public enum MicrostyleFontFamily
{
    Doric = 0x5101,
    Heldustry = 0x5102,
    ITCBolt = 0x5103,
    ITCEras = 0x5104,
    available5 = 0x5105,
    MagnumGothic = 0x5106,
    Microstyle = 0x5107,
    Neographik = 0x5108,
    RussellSquare = 0x5109,
    Serpentine = 0x510A,
}

public enum OptimaFontFamily
{
    BakerSignet = 0x5901,
    BlueJack = 0x5902,
    Chelmsford = 0x5903,
    Peignot = 0x5904,
    ITCPanache = 0x5905,
    ITCSymbol = 0x5906,
    Omega = 0x5907,
    Optima = 0x5908,
    Lisbon = 0x5909,
    RotisSemisans = 0x590A,
    Shannon = 0x590B,
    Triplett = 0x590C,
    Video = 0x590D,
}

public enum LetterGothicFontFamily
{
    available1 = 0x6101,
    LetterGothic = 0x6102,
    LinePrinter = 0x6103,
    OCRA = 0x6104,
    OCRB = 0x6105,
    Orator = 0x6106,
    Presentation = 0x6107,
}

public enum BrushFontFamily
{
    AshleyScript = 0x6901,
    BiffoScript = 0x6902,
    BrophyScript = 0x6903,
    BrushScript = 0x6904,
    CascadeScript = 0x6905,
    Chaplin = 0x6906,
    Charme = 0x6907,
    FreeStyleScript = 0x6908,
    Kaufmann = 0x6909,
    MonoLineScript = 0x690A,
    BickleyScript = 0x690B,
    PresentScript = 0x690C,
    Swing = 0x690D,
    Bronx = 0x690E,
}

public enum ParkAvenueFontFamily
{
    AristonLightScript = 0x7101,
    Basilica = 0x7102,
    Bellevue = 0x7103,
    BertholdScript = 0x7104,
    Boulevard = 0x7105,
    Amazone = 0x7106,
    CarmineTango = 0x7107,
    CommercialScript = 0x7108,
    Coronet = 0x7109,
    Corsiva = 0x710A,
    Diskus = 0x710B,
    FloridianScript = 0x710C,
    ITCIsadora = 0x710D,
    ITCZapfChancery = 0x710E,
    Jasper = 0x710F,
    Liberty = 0x7110,
    LisbonCursive = 0x7111,
    MediciScript = 0x7112,
    MurrayHill = 0x7113,
    ParkAvenue = 0x7114,
    Stuyvesant = 0x7115,
    UniversityRoman = 0x7116,
    Musketeer = 0x7117,
    TypoUpright = 0x7118,
}

public enum SignetRoundhandFontFamily
{
    AbelCursive = 0x7901,
    Aristocrat = 0x7902,
    CitadelScript = 0x7903,
    DorchesterScript = 0x7904,
    FlemishScript = 0x7905,
    FlorentineScript = 0x7906,
    FrenchScript = 0x7907,
    Isabella = 0x7908,
    KunstlerScript = 0x7909,
    LinoScript = 0x790A,
    LuciaScript = 0x790B,
    MahoganyScript = 0x790C,
    NuptialScript = 0x790D,
    OldFashionScript = 0x790E,
    OriginalScript = 0x790F,
    PalaceScript = 0x7910,
    PopplResidenz = 0x7911,
    Balmoral = 0x7912,
    ShelleyAllegroScript = 0x7913,
    ShelleyAndanteScript = 0x7914,
    SignetRoundhand = 0x7915,
    VenitianScript = 0x7916,
    Vivaldi = 0x7917,
}

public enum TektonFontFamily
{
    Banco = 0x8101,
    Bison = 0x8102,
    ITCGrizzly = 0x8103,
    DomCasual = 0x8104,
    Hebrastyle = 0x8105,
    Herculanum = 0x8106,
    ITCFlora = 0x8107,
    Forte = 0x8108,
    Klang = 0x8109,
    Lithos = 0x810A,
    Matura = 0x810B,
    Mercurius = 0x810C,
    NewBerolina = 0x810D,
    Mistral = 0x810E,
    Pepita = 0x810F,
    Reporter = 0x8110,
    Tekton = 0x8111,
    Jiffy = 0x8112,
    Visigoth = 0x8113,
}

public enum UncialFontFamily
{
    AbbottOldStyle = 0x8901,
    Amigo = 0x8902,
    Auriol = 0x8903,
    Camelot = 0x8904,
    Carolina = 0x8905,
    Clairvaux = 0x8906,
    AuraScript = 0x8907,
    Euclid = 0x8908,
    Feinen = 0x8909,
    available10 = 0x890A,
    available11 = 0x890B,
    Libra = 0x890C,
    available13 = 0x890D,
    Omnia = 0x890E,
    Ondine = 0x890F,
    available16 = 0x8910,
    PostAntiqua = 0x8911,
    Uncial = 0x8912,
}

public enum OldEnglishFontFamily
{
    Basque = 0x9101,
    CloisterBlack = 0x9102,
    DucDeBerry = 0x9103,
    EngraversText = 0x9104,
    FetteFraktur = 0x9105,
    GoudyText = 0x9106,
    AmericanText = 0x9107,
    LinoText = 0x9108,
    LondonText = 0x9109,
    BlackMoor = 0x910A,
    OldEnglish = 0x910B,
    Agincourt = 0x910C,
    SanMarco = 0x910D,
    WeddingText = 0x910E,
    WilhelmKlingsporGotisch = 0x910F,
    YorkShire = 0x9110,
    AlteSchwabacher = 0x9111,
}

public enum ITCZapfDingbatsFontFamily
{
    BorderPi = 0x9901,
    BundesbahnPi = 0x9902,
    Carta = 0x9903,
    Cheq = 0x9904,
    EuropeanPi = 0x9905,
    HelveticaFractions = 0x9906,
    ITCZapfDingbats = 0x9907,
    LinoTypeDecorationPi = 0x9908,
    LinoTypeGamePi = 0x9909,
    LinoTypeHolidayPi = 0x990A,
    Sonata = 0x990B,
    StarTrekPi = 0x990C,
    Symbol = 0x990D,
    WoodTypeOrnaments = 0x990E,
    LineDraw = 0x990F,
    BarCodes = 0x9910,
    KeyCaps = 0x9911,
    MonoTypeSorts = 0x9912,
    MTExtra = 0x9913,
    Fences = 0x9914,
}

public enum BroadwayFontFamily
{
    Braggadocio = 0xA101,
    Brittanic = 0xA102,
    Broadway = 0xA103,
    Falstaff = 0xA104,
    Annlie = 0xA105,
    GlobeGothic = 0xA106,
    ITCBernase = 0xA107,
    ITCFatFace = 0xA108,
    ITCFirenze = 0xA109,
    ITCLSCManhattan = 0xA10A,
    ITCTomsRoman = 0xA10B,
    McCollough = 0xA10C,
    Binner = 0xA10D,
    Normande = 0xA10E,
    Parisian = 0xA10F,
    Stencil = 0xA110,
    Trooper = 0xA111,
    Bremen = 0xA112,
}

public enum ComputerFontFamily
{
    Computer = 0xA901,
    Countdown = 0xA902,
    Data70 = 0xA903,
    Digital = 0xA904,
    ITCMachine = 0xA905,
    Amelia = 0xA906,
    PrinterNo1 = 0xA907,
    PrinterNo2 = 0xA908,
    Zeitgeist = 0xA909,
    LCD = 0xA90A,
    OrbitB = 0xA90B,
}

public enum PTBarnumFontFamily
{
    Playbill = 0xB101,
    BrandingIron = 0xB102,
    available3 = 0xB103,
    available4 = 0xB104,
    Figaro = 0xB105,
    Hidalgo = 0xB106,
    PTBarnum = 0xB107,
}

public enum PonderosaFontFamily
{
    AldousVertical = 0xB901,
    Arcadia = 0xB902,
    Birch = 0xB903,
    Compacta = 0xB904,
    Eccentric = 0xB905,
    Industria = 0xB906,
    Ironwood = 0xB907,
    ITCLSCCondensed = 0xB908,
    Juniper = 0xB909,
    Lafayette = 0xB90A,
    LatinExtraCondensed = 0xB90B,
    Mesquite = 0xB90C,
    Onyx = 0xB90D,
    Ponderosa = 0xB90E,
    Runic = 0xB90F,
    TipTop = 0xB910,
    Willow = 0xB911,
}

public enum MadroneFontFamily
{
    BlackOak = 0xC101,
    Madrone = 0xC102,
    Poplar = 0xC103,
    Thunderbird = 0xC104,
}

public enum HoboFontFamily
{
    AntikvaMargaret = 0xC901,
    ArnoldBocklin = 0xC902,
    Belwe = 0xC903,
    BlackfriarsRoman = 0xC904,
    BrynMawr = 0xC905,
    Charleston = 0xC906,
    Columbus = 0xC907,
    CooperBlack = 0xC908,
    Cottonwood = 0xC909,
    Croydon = 0xC90A,
    Eckmann = 0xC90B,
    Hobo = 0xC90C,
    Hogarth = 0xC90D,
    ITCGorilla = 0xC90E,
    ITCGrouch = 0xC90F,
    ITCHonda = 0xC910,
    KochAntiqua = 0xC911,
    Milton = 0xC912,
    Neptune = 0xC913,
    Packard = 0xC914,
    Pretorian = 0xC915,
    Raphael = 0xC916,
    Richmond = 0xC917,
    Skyjald = 0xC918,
    Tango = 0xC919,
    Thalia = 0xC91A,
    Belshaw = 0xC91B,
    LoType = 0xC91C,
    Parsons = 0xC91D,
    Romic = 0xC91E,
    BitstreamArrus = 0xC91F,
}

public enum RevueFontFamily
{
    AdLib = 0xD101,
    Becket = 0xD102,
    Kino = 0xD103,
    MotterTektura = 0xD104,
    Neuland = 0xD105,
    Octopuss = 0xD106,
    Othello = 0xD107,
    Pump = 0xD108,
    Revue = 0xD109,
    Sintex1 = 0xD10A,
    Stop = 0xD10B,
    Tabasco = 0xD10C,
    Balloon = 0xD10D,
}

public enum AestheticOrnamentedFontFamily
{
    Abramesque = 0xD901,
    AestheticOrnamented = 0xD902,
    BedRock = 0xD903,
    BlockUp = 0xD904,
    Chevalier = 0xD905,
    Fatima = 0xD906,
    Flintstones = 0xD907,
    Flirt = 0xD908,
    Florist = 0xD909,
    Fontanesi = 0xD90A,
    FrysOrnamented = 0xD90B,
    Gallia = 0xD90C,
    GoodVibrations = 0xD90D,
    ITCNeon = 0xD90E,
    Karnak = 0xD90F,
    Kismet = 0xD910,
    LettresOrnees = 0xD911,
    Lexington = 0xD912,
    Lilith = 0xD913,
    Nymphic = 0xD914,
    OldGlory = 0xD915,
    Picadilly = 0xD916,
    Pinball = 0xD917,
    Quentin = 0xD918,
    RaffiaInitials = 0xD919,
    RayShaded = 0xD91A,
    RomantiquesNo5 = 0xD91B,
    Sapphire = 0xD91C,
    Sinaloa = 0xD91D,
    SnowCap = 0xD91E,
    TalbotsRockyMountian = 0xD91F,
    Tonal = 0xD920,
    Trocadero = 0xD921,
    UncleSam = 0xD922,
    ViaFaceDonBlack = 0xD923,
    Zip = 0xD924,
    Shadows = 0xD925,
    Cameos = 0xD926,
    StripedPatterns = 0xD927,
    HatchPatterns = 0xD928,
    Engraved = 0xD929,
    Outlines = 0xD92A,
    BabyTeeth = 0xD92B,
    Bottleneck = 0xD92C,
    Davida = 0xD92D,
    OldDreadfulNo7 = 0xD92E,
    Shotgun = 0xD92F,

}


public enum FontScriptingSystem
{
    none,
    European_Classification = 1

}


public enum FontWidth
{
    dont_know,
    ultra_condensed,
    extra_compressed,
    compressed,
    extra_condensed,
    condensed,
    semi_condensed,
    normal,
    semi_expanded,
    expanded,
    extra_expanded,
    ultra_expanded,
    double_wide,
    triple_wide, 
    reserved
}


public enum FontWeight
{
    dont_know,
    ultra_thin,
    ultra_light,
    extra_thin,
    thin,
    extra_light,
    light,
    demi_light,
    semi_light,
    book,
    regular,
    Roman,
    medium,
    demi_bold,
    semi_bold,
    bold,
    extra_bold,
    heavy,
    extra_heavy,
    black,
    extra_black,
    ultra_heavy,
    ultra_black,
    max_weight,
    reserved
}

[Flags()]
public enum FontAttributes
{
    none = 0,
    italic = 1,
    outline = 2,
    shadow = 4,
    small_caps = 8
}

public struct FontGeneralCharacteristics
{
    public FGC_UsageCategory usageCategory {get; set;}
    public FGC_GeneralSerif generalSerif { get; set; }
    public FGC_Spacing spacing { get; set; }

}


public enum FGC_UsageCategory
{
    dont_know,
    text,
    display,
    both

}


public enum FGC_GeneralSerif
{
    dont_know,
    sans_serif,
    serif,
    script
}


public enum FGC_Spacing
{
    dont_know,
    proportional,
    monospace
}


public enum FontClassification
{
    dont_know,
    bracket,
    cupped,
    round_bracket,
    line,
    slab,
    wedge,
    half,
    sans_square,
    sans_round,
    sans_flare,
    nonconnect,
    joining,
    black_serif,
    swash
}


public struct FontType
{
    public FontType_PRS_File? PRS_File { get; set; }
    public FontType_DRS_File? DRS_File { get; set; }
    public FontSourceFileType sourceFileType { get; set; }

}

public enum FontType_PRS_File
{
    none,
    built_in,
    cartridge_slot,
    memory_units_in_kilobytes,
    memory_units_in_font_slots,
    print_wheel

}

public enum FontType_DRS_File
{
    none,
    wp_greeked_font = 128,
    wp_menu,
    wp_vector,
    wp_outline,
    reserved1,
    reserved2,
    Speedo,
    bullet,
    ATM = 138,
    TrueType1,
    reserved3,
    TrueType2,
    reserved4,
    reserved5,
    no_soft_font_driver_loaded = 255


}

public enum FontSourceFileType
{
    none,
    PRS_file_type = 16,
    DRS_file_type = 20
}

public struct FontTypefaceName
{
    public string typefaceFamily { get; set; }
    public string attributes { get; set; }
    public string namePrefix { get; set; }
    public string nameExtension { get; set; }
}





