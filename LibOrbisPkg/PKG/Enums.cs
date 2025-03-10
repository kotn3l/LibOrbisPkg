﻿namespace LibOrbisPkg.PKG
{
    public enum AppType : int
    {
        PAID_STANDALONE_FULL = 1,
        UPGRADABLE = 2,
        DEMO = 3,
        FREEMIUM = 4,
    };

    public enum DrmType : int
    {
        NONE = 0x0,
        PS4 = 0xF,
    };

    public enum ContentType : int
    {
        /* pkg_ps4_app, pkg_ps4_patch, pkg_ps4_remaster */
        GD = 0x1A,
        /* pkg_ps4_ac_data, pkg_ps4_sf_theme, pkg_ps4_theme */
        AC = 0x1B,
        /* pkg_ps4_ac_nodata */
        AL = 0x1C,
        /* pkg_ps4_delta_patch */
        DP = 0x1E,
    };

    public enum IROTag : int
    {
        None = 0,
        /* SHAREfactory theme */
        SF_THEME = 0x1,
        /* System Software theme */
        SS_THEME = 0x2,
    };

    [Flags]
    public enum PKGFlags : uint
    {
        Unknown = 0x01,
        VER_1 = 0x01000000,
        VER_2 = 0x02000000,
        INTERNAL = 0x40000000,
        FINALIZED = 0x80000000,
    }

    [Flags]
    public enum ContentFlags : uint
    {
        FIRST_PATCH = 0x00100000,
        PATCHGO = 0x00200000,
        REMASTER = 0x00400000,
        PS_CLOUD = 0x00800000,
        GD_AC = 0x02000000,
        NON_GAME = 0x04000000,
        Unk_x8000000 = 0x08000000, /* has data? */
        SUBSEQUENT_PATCH = 0x40000000,
        DELTA_PATCH = 0x41000000,
        CUMULATIVE_PATCH = 0x60000000,
    }

    public enum EntryId : uint
    {
        DIGESTS = 0x00000001,
        ENTRY_KEYS = 0x00000010,
        IMAGE_KEY = 0x00000020,
        // Found in DP PKG
        UNKNOWN_21 = 0x00000021,
        GENERAL_DIGESTS = 0x00000080,
        // Found in DP PKG
        UNKNOWN_C0 = 0x000000C0,
        METAS = 0x00000100,
        ENTRY_NAMES = 0x00000200,

        LICENSE_DAT = 0x00000400,
        LICENSE_INFO = 0x00000401,
        NPTITLE_DAT = 0x00000402,
        NPBIND_DAT = 0x00000403,
        SELFINFO_DAT = 0x00000404,
        IMAGEINFO_DAT = 0x00000406,
        TARGET_DELTAINFO_DAT = 0x00000407,
        ORIGIN_DELTAINFO_DAT = 0x00000408,
        PSRESERVED_DAT = 0x00000409,
        PARAM_SFO = 0x00001000,
        PLAYGO_CHUNK_DAT = 0x00001001,
        PLAYGO_CHUNK_SHA = 0x00001002,
        PLAYGO_MANIFEST_XML = 0x00001003,
        PRONUNCIATION_XML = 0x00001004,
        PRONUNCIATION_SIG = 0x00001005,
        PIC1_PNG = 0x00001006,
        PUBTOOLINFO_DAT = 0x00001007,
        APP__PLAYGO_CHUNK_DAT = 0x00001008,
        APP__PLAYGO_CHUNK_SHA = 0x00001009,
        APP__PLAYGO_MANIFEST_XML = 0x0000100A,
        SHAREPARAM_JSON = 0x0000100B,
        SHAREOVERLAYIMAGE_PNG = 0x0000100C,
        SAVE_DATA_PNG = 0x0000100D,
        SHAREPRIVACYGUARDIMAGE_PNG = 0x0000100E,
        ICON0_PNG = 0x00001200,
        ICON0_00_PNG = 0x00001201,
        ICON0_01_PNG = 0x00001202,
        ICON0_02_PNG = 0x00001203,
        ICON0_03_PNG = 0x00001204,
        ICON0_04_PNG = 0x00001205,
        ICON0_05_PNG = 0x00001206,
        ICON0_06_PNG = 0x00001207,
        ICON0_07_PNG = 0x00001208,
        ICON0_08_PNG = 0x00001209,
        ICON0_09_PNG = 0x0000120A,
        ICON0_10_PNG = 0x0000120B,
        ICON0_11_PNG = 0x0000120C,
        ICON0_12_PNG = 0x0000120D,
        ICON0_13_PNG = 0x0000120E,
        ICON0_14_PNG = 0x0000120F,
        ICON0_15_PNG = 0x00001210,
        ICON0_16_PNG = 0x00001211,
        ICON0_17_PNG = 0x00001212,
        ICON0_18_PNG = 0x00001213,
        ICON0_19_PNG = 0x00001214,
        ICON0_20_PNG = 0x00001215,
        ICON0_21_PNG = 0x00001216,
        ICON0_22_PNG = 0x00001217,
        ICON0_23_PNG = 0x00001218,
        ICON0_24_PNG = 0x00001219,
        ICON0_25_PNG = 0x0000121A,
        ICON0_26_PNG = 0x0000121B,
        ICON0_27_PNG = 0x0000121C,
        ICON0_28_PNG = 0x0000121D,
        ICON0_29_PNG = 0x0000121E,
        ICON0_30_PNG = 0x0000121F,
        PIC0_PNG = 0x00001220,
        SND0_AT9 = 0x00001240,
        PIC1_00_PNG = 0x00001241,
        PIC1_01_PNG = 0x00001242,
        PIC1_02_PNG = 0x00001243,
        PIC1_03_PNG = 0x00001244,
        PIC1_04_PNG = 0x00001245,
        PIC1_05_PNG = 0x00001246,
        PIC1_06_PNG = 0x00001247,
        PIC1_07_PNG = 0x00001248,
        PIC1_08_PNG = 0x00001249,
        PIC1_09_PNG = 0x0000124A,
        PIC1_10_PNG = 0x0000124B,
        PIC1_11_PNG = 0x0000124C,
        PIC1_12_PNG = 0x0000124D,
        PIC1_13_PNG = 0x0000124E,
        PIC1_14_PNG = 0x0000124F,
        PIC1_15_PNG = 0x00001250,
        PIC1_16_PNG = 0x00001251,
        PIC1_17_PNG = 0x00001252,
        PIC1_18_PNG = 0x00001253,
        PIC1_19_PNG = 0x00001254,
        PIC1_20_PNG = 0x00001255,
        PIC1_21_PNG = 0x00001256,
        PIC1_22_PNG = 0x00001257,
        PIC1_23_PNG = 0x00001258,
        PIC1_24_PNG = 0x00001259,
        PIC1_25_PNG = 0x0000125A,
        PIC1_26_PNG = 0x0000125B,
        PIC1_27_PNG = 0x0000125C,
        PIC1_28_PNG = 0x0000125D,
        PIC1_29_PNG = 0x0000125E,
        PIC1_30_PNG = 0x0000125F,
        CHANGEINFO__CHANGEINFO_XML = 0x00001260,
        CHANGEINFO__CHANGEINFO_00_XML = 0x00001261,
        CHANGEINFO__CHANGEINFO_01_XML = 0x00001262,
        CHANGEINFO__CHANGEINFO_02_XML = 0x00001263,
        CHANGEINFO__CHANGEINFO_03_XML = 0x00001264,
        CHANGEINFO__CHANGEINFO_04_XML = 0x00001265,
        CHANGEINFO__CHANGEINFO_05_XML = 0x00001266,
        CHANGEINFO__CHANGEINFO_06_XML = 0x00001267,
        CHANGEINFO__CHANGEINFO_07_XML = 0x00001268,
        CHANGEINFO__CHANGEINFO_08_XML = 0x00001269,
        CHANGEINFO__CHANGEINFO_09_XML = 0x0000126A,
        CHANGEINFO__CHANGEINFO_10_XML = 0x0000126B,
        CHANGEINFO__CHANGEINFO_11_XML = 0x0000126C,
        CHANGEINFO__CHANGEINFO_12_XML = 0x0000126D,
        CHANGEINFO__CHANGEINFO_13_XML = 0x0000126E,
        CHANGEINFO__CHANGEINFO_14_XML = 0x0000126F,
        CHANGEINFO__CHANGEINFO_15_XML = 0x00001270,
        CHANGEINFO__CHANGEINFO_16_XML = 0x00001271,
        CHANGEINFO__CHANGEINFO_17_XML = 0x00001272,
        CHANGEINFO__CHANGEINFO_18_XML = 0x00001273,
        CHANGEINFO__CHANGEINFO_19_XML = 0x00001274,
        CHANGEINFO__CHANGEINFO_20_XML = 0x00001275,
        CHANGEINFO__CHANGEINFO_21_XML = 0x00001276,
        CHANGEINFO__CHANGEINFO_22_XML = 0x00001277,
        CHANGEINFO__CHANGEINFO_23_XML = 0x00001278,
        CHANGEINFO__CHANGEINFO_24_XML = 0x00001279,
        CHANGEINFO__CHANGEINFO_25_XML = 0x0000127A,
        CHANGEINFO__CHANGEINFO_26_XML = 0x0000127B,
        CHANGEINFO__CHANGEINFO_27_XML = 0x0000127C,
        CHANGEINFO__CHANGEINFO_28_XML = 0x0000127D,
        CHANGEINFO__CHANGEINFO_29_XML = 0x0000127E,
        CHANGEINFO__CHANGEINFO_30_XML = 0x0000127F,
        ICON0_DDS = 0x00001280,
        ICON0_00_DDS = 0x00001281,
        ICON0_01_DDS = 0x00001282,
        ICON0_02_DDS = 0x00001283,
        ICON0_03_DDS = 0x00001284,
        ICON0_04_DDS = 0x00001285,
        ICON0_05_DDS = 0x00001286,
        ICON0_06_DDS = 0x00001287,
        ICON0_07_DDS = 0x00001288,
        ICON0_08_DDS = 0x00001289,
        ICON0_09_DDS = 0x0000128A,
        ICON0_10_DDS = 0x0000128B,
        ICON0_11_DDS = 0x0000128C,
        ICON0_12_DDS = 0x0000128D,
        ICON0_13_DDS = 0x0000128E,
        ICON0_14_DDS = 0x0000128F,
        ICON0_15_DDS = 0x00001290,
        ICON0_16_DDS = 0x00001291,
        ICON0_17_DDS = 0x00001292,
        ICON0_18_DDS = 0x00001293,
        ICON0_19_DDS = 0x00001294,
        ICON0_20_DDS = 0x00001295,
        ICON0_21_DDS = 0x00001296,
        ICON0_22_DDS = 0x00001297,
        ICON0_23_DDS = 0x00001298,
        ICON0_24_DDS = 0x00001299,
        ICON0_25_DDS = 0x0000129A,
        ICON0_26_DDS = 0x0000129B,
        ICON0_27_DDS = 0x0000129C,
        ICON0_28_DDS = 0x0000129D,
        ICON0_29_DDS = 0x0000129E,
        ICON0_30_DDS = 0x0000129F,
        PIC0_DDS = 0x000012A0,
        PIC1_DDS = 0x000012C0,
        PIC1_00_DDS = 0x000012C1,
        PIC1_01_DDS = 0x000012C2,
        PIC1_02_DDS = 0x000012C3,
        PIC1_03_DDS = 0x000012C4,
        PIC1_04_DDS = 0x000012C5,
        PIC1_05_DDS = 0x000012C6,
        PIC1_06_DDS = 0x000012C7,
        PIC1_07_DDS = 0x000012C8,
        PIC1_08_DDS = 0x000012C9,
        PIC1_09_DDS = 0x000012CA,
        PIC1_10_DDS = 0x000012CB,
        PIC1_11_DDS = 0x000012CC,
        PIC1_12_DDS = 0x000012CD,
        PIC1_13_DDS = 0x000012CE,
        PIC1_14_DDS = 0x000012CF,
        PIC1_15_DDS = 0x000012D0,
        PIC1_16_DDS = 0x000012D1,
        PIC1_17_DDS = 0x000012D2,
        PIC1_18_DDS = 0x000012D3,
        PIC1_19_DDS = 0x000012D4,
        PIC1_20_DDS = 0x000012D5,
        PIC1_21_DDS = 0x000012D6,
        PIC1_22_DDS = 0x000012D7,
        PIC1_23_DDS = 0x000012D8,
        PIC1_24_DDS = 0x000012D9,
        PIC1_25_DDS = 0x000012DA,
        PIC1_26_DDS = 0x000012DB,
        PIC1_27_DDS = 0x000012DC,
        PIC1_28_DDS = 0x000012DD,
        PIC1_29_DDS = 0x000012DE,
        PIC1_30_DDS = 0x000012DF,
        TROPHY__TROPHY00_TRP = 0x00001400,
        TROPHY__TROPHY01_TRP = 0x00001401,
        TROPHY__TROPHY02_TRP = 0x00001402,
        TROPHY__TROPHY03_TRP = 0x00001403,
        TROPHY__TROPHY04_TRP = 0x00001404,
        TROPHY__TROPHY05_TRP = 0x00001405,
        TROPHY__TROPHY06_TRP = 0x00001406,
        TROPHY__TROPHY07_TRP = 0x00001407,
        TROPHY__TROPHY08_TRP = 0x00001408,
        TROPHY__TROPHY09_TRP = 0x00001409,
        TROPHY__TROPHY10_TRP = 0x0000140A,
        TROPHY__TROPHY11_TRP = 0x0000140B,
        TROPHY__TROPHY12_TRP = 0x0000140C,
        TROPHY__TROPHY13_TRP = 0x0000140D,
        TROPHY__TROPHY14_TRP = 0x0000140E,
        TROPHY__TROPHY15_TRP = 0x0000140F,
        TROPHY__TROPHY16_TRP = 0x00001410,
        TROPHY__TROPHY17_TRP = 0x00001411,
        TROPHY__TROPHY18_TRP = 0x00001412,
        TROPHY__TROPHY19_TRP = 0x00001413,
        TROPHY__TROPHY20_TRP = 0x00001414,
        TROPHY__TROPHY21_TRP = 0x00001415,
        TROPHY__TROPHY22_TRP = 0x00001416,
        TROPHY__TROPHY23_TRP = 0x00001417,
        TROPHY__TROPHY24_TRP = 0x00001418,
        TROPHY__TROPHY25_TRP = 0x00001419,
        TROPHY__TROPHY26_TRP = 0x0000141A,
        TROPHY__TROPHY27_TRP = 0x0000141B,
        TROPHY__TROPHY28_TRP = 0x0000141C,
        TROPHY__TROPHY29_TRP = 0x0000141D,
        TROPHY__TROPHY30_TRP = 0x0000141E,
        TROPHY__TROPHY31_TRP = 0x0000141F,
        TROPHY__TROPHY32_TRP = 0x00001420,
        TROPHY__TROPHY33_TRP = 0x00001421,
        TROPHY__TROPHY34_TRP = 0x00001422,
        TROPHY__TROPHY35_TRP = 0x00001423,
        TROPHY__TROPHY36_TRP = 0x00001424,
        TROPHY__TROPHY37_TRP = 0x00001425,
        TROPHY__TROPHY38_TRP = 0x00001426,
        TROPHY__TROPHY39_TRP = 0x00001427,
        TROPHY__TROPHY40_TRP = 0x00001428,
        TROPHY__TROPHY41_TRP = 0x00001429,
        TROPHY__TROPHY42_TRP = 0x0000142A,
        TROPHY__TROPHY43_TRP = 0x0000142B,
        TROPHY__TROPHY44_TRP = 0x0000142C,
        TROPHY__TROPHY45_TRP = 0x0000142D,
        TROPHY__TROPHY46_TRP = 0x0000142E,
        TROPHY__TROPHY47_TRP = 0x0000142F,
        TROPHY__TROPHY48_TRP = 0x00001430,
        TROPHY__TROPHY49_TRP = 0x00001431,
        TROPHY__TROPHY50_TRP = 0x00001432,
        TROPHY__TROPHY51_TRP = 0x00001433,
        TROPHY__TROPHY52_TRP = 0x00001434,
        TROPHY__TROPHY53_TRP = 0x00001435,
        TROPHY__TROPHY54_TRP = 0x00001436,
        TROPHY__TROPHY55_TRP = 0x00001437,
        TROPHY__TROPHY56_TRP = 0x00001438,
        TROPHY__TROPHY57_TRP = 0x00001439,
        TROPHY__TROPHY58_TRP = 0x0000143A,
        TROPHY__TROPHY59_TRP = 0x0000143B,
        TROPHY__TROPHY60_TRP = 0x0000143C,
        TROPHY__TROPHY61_TRP = 0x0000143D,
        TROPHY__TROPHY62_TRP = 0x0000143E,
        TROPHY__TROPHY63_TRP = 0x0000143F,
        TROPHY__TROPHY64_TRP = 0x00001440,
        TROPHY__TROPHY65_TRP = 0x00001441,
        TROPHY__TROPHY66_TRP = 0x00001442,
        TROPHY__TROPHY67_TRP = 0x00001443,
        TROPHY__TROPHY68_TRP = 0x00001444,
        TROPHY__TROPHY69_TRP = 0x00001445,
        TROPHY__TROPHY70_TRP = 0x00001446,
        TROPHY__TROPHY71_TRP = 0x00001447,
        TROPHY__TROPHY72_TRP = 0x00001448,
        TROPHY__TROPHY73_TRP = 0x00001449,
        TROPHY__TROPHY74_TRP = 0x0000144A,
        TROPHY__TROPHY75_TRP = 0x0000144B,
        TROPHY__TROPHY76_TRP = 0x0000144C,
        TROPHY__TROPHY77_TRP = 0x0000144D,
        TROPHY__TROPHY78_TRP = 0x0000144E,
        TROPHY__TROPHY79_TRP = 0x0000144F,
        TROPHY__TROPHY80_TRP = 0x00001450,
        TROPHY__TROPHY81_TRP = 0x00001451,
        TROPHY__TROPHY82_TRP = 0x00001452,
        TROPHY__TROPHY83_TRP = 0x00001453,
        TROPHY__TROPHY84_TRP = 0x00001454,
        TROPHY__TROPHY85_TRP = 0x00001455,
        TROPHY__TROPHY86_TRP = 0x00001456,
        TROPHY__TROPHY87_TRP = 0x00001457,
        TROPHY__TROPHY88_TRP = 0x00001458,
        TROPHY__TROPHY89_TRP = 0x00001459,
        TROPHY__TROPHY90_TRP = 0x0000145A,
        TROPHY__TROPHY91_TRP = 0x0000145B,
        TROPHY__TROPHY92_TRP = 0x0000145C,
        TROPHY__TROPHY93_TRP = 0x0000145D,
        TROPHY__TROPHY94_TRP = 0x0000145E,
        TROPHY__TROPHY95_TRP = 0x0000145F,
        TROPHY__TROPHY96_TRP = 0x00001460,
        TROPHY__TROPHY97_TRP = 0x00001461,
        TROPHY__TROPHY98_TRP = 0x00001462,
        TROPHY__TROPHY99_TRP = 0x00001463,
        KEYMAP_RP__001_PNG = 0x00001600,
        KEYMAP_RP__002_PNG = 0x00001601,
        KEYMAP_RP__003_PNG = 0x00001602,
        KEYMAP_RP__004_PNG = 0x00001603,
        KEYMAP_RP__005_PNG = 0x00001604,
        KEYMAP_RP__006_PNG = 0x00001605,
        KEYMAP_RP__007_PNG = 0x00001606,
        KEYMAP_RP__008_PNG = 0x00001607,
        KEYMAP_RP__009_PNG = 0x00001608,
        KEYMAP_RP__010_PNG = 0x00001609,
        KEYMAP_RP__00__001_PNG = 0x00001610,
        KEYMAP_RP__00__002_PNG = 0x00001611,
        KEYMAP_RP__00__003_PNG = 0x00001612,
        KEYMAP_RP__00__004_PNG = 0x00001613,
        KEYMAP_RP__00__005_PNG = 0x00001614,
        KEYMAP_RP__00__006_PNG = 0x00001615,
        KEYMAP_RP__00__007_PNG = 0x00001616,
        KEYMAP_RP__00__008_PNG = 0x00001617,
        KEYMAP_RP__00__009_PNG = 0x00001618,
        KEYMAP_RP__00__010_PNG = 0x00001619,
        KEYMAP_RP__01__001_PNG = 0x00001620,
        KEYMAP_RP__01__002_PNG = 0x00001621,
        KEYMAP_RP__01__003_PNG = 0x00001622,
        KEYMAP_RP__01__004_PNG = 0x00001623,
        KEYMAP_RP__01__005_PNG = 0x00001624,
        KEYMAP_RP__01__006_PNG = 0x00001625,
        KEYMAP_RP__01__007_PNG = 0x00001626,
        KEYMAP_RP__01__008_PNG = 0x00001627,
        KEYMAP_RP__01__009_PNG = 0x00001628,
        KEYMAP_RP__01__010_PNG = 0x00001629,
        KEYMAP_RP__02__001_PNG = 0x00001630,
        KEYMAP_RP__02__002_PNG = 0x00001631,
        KEYMAP_RP__02__003_PNG = 0x00001632,
        KEYMAP_RP__02__004_PNG = 0x00001633,
        KEYMAP_RP__02__005_PNG = 0x00001634,
        KEYMAP_RP__02__006_PNG = 0x00001635,
        KEYMAP_RP__02__007_PNG = 0x00001636,
        KEYMAP_RP__02__008_PNG = 0x00001637,
        KEYMAP_RP__02__009_PNG = 0x00001638,
        KEYMAP_RP__02__010_PNG = 0x00001639,
        KEYMAP_RP__03__001_PNG = 0x00001640,
        KEYMAP_RP__03__002_PNG = 0x00001641,
        KEYMAP_RP__03__003_PNG = 0x00001642,
        KEYMAP_RP__03__004_PNG = 0x00001643,
        KEYMAP_RP__03__005_PNG = 0x00001644,
        KEYMAP_RP__03__006_PNG = 0x00001645,
        KEYMAP_RP__03__007_PNG = 0x00001646,
        KEYMAP_RP__03__008_PNG = 0x00001647,
        KEYMAP_RP__03__009_PNG = 0x00001648,
        KEYMAP_RP__03__010_PNG = 0x00001649,
        KEYMAP_RP__04__001_PNG = 0x00001650,
        KEYMAP_RP__04__002_PNG = 0x00001651,
        KEYMAP_RP__04__003_PNG = 0x00001652,
        KEYMAP_RP__04__004_PNG = 0x00001653,
        KEYMAP_RP__04__005_PNG = 0x00001654,
        KEYMAP_RP__04__006_PNG = 0x00001655,
        KEYMAP_RP__04__007_PNG = 0x00001656,
        KEYMAP_RP__04__008_PNG = 0x00001657,
        KEYMAP_RP__04__009_PNG = 0x00001658,
        KEYMAP_RP__04__010_PNG = 0x00001659,
        KEYMAP_RP__05__001_PNG = 0x00001660,
        KEYMAP_RP__05__002_PNG = 0x00001661,
        KEYMAP_RP__05__003_PNG = 0x00001662,
        KEYMAP_RP__05__004_PNG = 0x00001663,
        KEYMAP_RP__05__005_PNG = 0x00001664,
        KEYMAP_RP__05__006_PNG = 0x00001665,
        KEYMAP_RP__05__007_PNG = 0x00001666,
        KEYMAP_RP__05__008_PNG = 0x00001667,
        KEYMAP_RP__05__009_PNG = 0x00001668,
        KEYMAP_RP__05__010_PNG = 0x00001669,
        KEYMAP_RP__06__001_PNG = 0x00001670,
        KEYMAP_RP__06__002_PNG = 0x00001671,
        KEYMAP_RP__06__003_PNG = 0x00001672,
        KEYMAP_RP__06__004_PNG = 0x00001673,
        KEYMAP_RP__06__005_PNG = 0x00001674,
        KEYMAP_RP__06__006_PNG = 0x00001675,
        KEYMAP_RP__06__007_PNG = 0x00001676,
        KEYMAP_RP__06__008_PNG = 0x00001677,
        KEYMAP_RP__06__009_PNG = 0x00001678,
        KEYMAP_RP__06__010_PNG = 0x00001679,
        KEYMAP_RP__07__001_PNG = 0x00001680,
        KEYMAP_RP__07__002_PNG = 0x00001681,
        KEYMAP_RP__07__003_PNG = 0x00001682,
        KEYMAP_RP__07__004_PNG = 0x00001683,
        KEYMAP_RP__07__005_PNG = 0x00001684,
        KEYMAP_RP__07__006_PNG = 0x00001685,
        KEYMAP_RP__07__007_PNG = 0x00001686,
        KEYMAP_RP__07__008_PNG = 0x00001687,
        KEYMAP_RP__07__009_PNG = 0x00001688,
        KEYMAP_RP__07__010_PNG = 0x00001689,
        KEYMAP_RP__08__001_PNG = 0x00001690,
        KEYMAP_RP__08__002_PNG = 0x00001691,
        KEYMAP_RP__08__003_PNG = 0x00001692,
        KEYMAP_RP__08__004_PNG = 0x00001693,
        KEYMAP_RP__08__005_PNG = 0x00001694,
        KEYMAP_RP__08__006_PNG = 0x00001695,
        KEYMAP_RP__08__007_PNG = 0x00001696,
        KEYMAP_RP__08__008_PNG = 0x00001697,
        KEYMAP_RP__08__009_PNG = 0x00001698,
        KEYMAP_RP__08__010_PNG = 0x00001699,
        KEYMAP_RP__09__001_PNG = 0x000016A0,
        KEYMAP_RP__09__002_PNG = 0x000016A1,
        KEYMAP_RP__09__003_PNG = 0x000016A2,
        KEYMAP_RP__09__004_PNG = 0x000016A3,
        KEYMAP_RP__09__005_PNG = 0x000016A4,
        KEYMAP_RP__09__006_PNG = 0x000016A5,
        KEYMAP_RP__09__007_PNG = 0x000016A6,
        KEYMAP_RP__09__008_PNG = 0x000016A7,
        KEYMAP_RP__09__009_PNG = 0x000016A8,
        KEYMAP_RP__09__010_PNG = 0x000016A9,
        KEYMAP_RP__10__001_PNG = 0x000016B0,
        KEYMAP_RP__10__002_PNG = 0x000016B1,
        KEYMAP_RP__10__003_PNG = 0x000016B2,
        KEYMAP_RP__10__004_PNG = 0x000016B3,
        KEYMAP_RP__10__005_PNG = 0x000016B4,
        KEYMAP_RP__10__006_PNG = 0x000016B5,
        KEYMAP_RP__10__007_PNG = 0x000016B6,
        KEYMAP_RP__10__008_PNG = 0x000016B7,
        KEYMAP_RP__10__009_PNG = 0x000016B8,
        KEYMAP_RP__10__010_PNG = 0x000016B9,
        KEYMAP_RP__11__001_PNG = 0x000016C0,
        KEYMAP_RP__11__002_PNG = 0x000016C1,
        KEYMAP_RP__11__003_PNG = 0x000016C2,
        KEYMAP_RP__11__004_PNG = 0x000016C3,
        KEYMAP_RP__11__005_PNG = 0x000016C4,
        KEYMAP_RP__11__006_PNG = 0x000016C5,
        KEYMAP_RP__11__007_PNG = 0x000016C6,
        KEYMAP_RP__11__008_PNG = 0x000016C7,
        KEYMAP_RP__11__009_PNG = 0x000016C8,
        KEYMAP_RP__11__010_PNG = 0x000016C9,
        KEYMAP_RP__12__001_PNG = 0x000016D0,
        KEYMAP_RP__12__002_PNG = 0x000016D1,
        KEYMAP_RP__12__003_PNG = 0x000016D2,
        KEYMAP_RP__12__004_PNG = 0x000016D3,
        KEYMAP_RP__12__005_PNG = 0x000016D4,
        KEYMAP_RP__12__006_PNG = 0x000016D5,
        KEYMAP_RP__12__007_PNG = 0x000016D6,
        KEYMAP_RP__12__008_PNG = 0x000016D7,
        KEYMAP_RP__12__009_PNG = 0x000016D8,
        KEYMAP_RP__12__010_PNG = 0x000016D9,
        KEYMAP_RP__13__001_PNG = 0x000016E0,
        KEYMAP_RP__13__002_PNG = 0x000016E1,
        KEYMAP_RP__13__003_PNG = 0x000016E2,
        KEYMAP_RP__13__004_PNG = 0x000016E3,
        KEYMAP_RP__13__005_PNG = 0x000016E4,
        KEYMAP_RP__13__006_PNG = 0x000016E5,
        KEYMAP_RP__13__007_PNG = 0x000016E6,
        KEYMAP_RP__13__008_PNG = 0x000016E7,
        KEYMAP_RP__13__009_PNG = 0x000016E8,
        KEYMAP_RP__13__010_PNG = 0x000016E9,
        KEYMAP_RP__14__001_PNG = 0x000016F0,
        KEYMAP_RP__14__002_PNG = 0x000016F1,
        KEYMAP_RP__14__003_PNG = 0x000016F2,
        KEYMAP_RP__14__004_PNG = 0x000016F3,
        KEYMAP_RP__14__005_PNG = 0x000016F4,
        KEYMAP_RP__14__006_PNG = 0x000016F5,
        KEYMAP_RP__14__007_PNG = 0x000016F6,
        KEYMAP_RP__14__008_PNG = 0x000016F7,
        KEYMAP_RP__14__009_PNG = 0x000016F8,
        KEYMAP_RP__14__010_PNG = 0x000016F9,
        KEYMAP_RP__15__001_PNG = 0x00001700,
        KEYMAP_RP__15__002_PNG = 0x00001701,
        KEYMAP_RP__15__003_PNG = 0x00001702,
        KEYMAP_RP__15__004_PNG = 0x00001703,
        KEYMAP_RP__15__005_PNG = 0x00001704,
        KEYMAP_RP__15__006_PNG = 0x00001705,
        KEYMAP_RP__15__007_PNG = 0x00001706,
        KEYMAP_RP__15__008_PNG = 0x00001707,
        KEYMAP_RP__15__009_PNG = 0x00001708,
        KEYMAP_RP__15__010_PNG = 0x00001709,
        KEYMAP_RP__16__001_PNG = 0x00001710,
        KEYMAP_RP__16__002_PNG = 0x00001711,
        KEYMAP_RP__16__003_PNG = 0x00001712,
        KEYMAP_RP__16__004_PNG = 0x00001713,
        KEYMAP_RP__16__005_PNG = 0x00001714,
        KEYMAP_RP__16__006_PNG = 0x00001715,
        KEYMAP_RP__16__007_PNG = 0x00001716,
        KEYMAP_RP__16__008_PNG = 0x00001717,
        KEYMAP_RP__16__009_PNG = 0x00001718,
        KEYMAP_RP__16__010_PNG = 0x00001719,
        KEYMAP_RP__17__001_PNG = 0x00001720,
        KEYMAP_RP__17__002_PNG = 0x00001721,
        KEYMAP_RP__17__003_PNG = 0x00001722,
        KEYMAP_RP__17__004_PNG = 0x00001723,
        KEYMAP_RP__17__005_PNG = 0x00001724,
        KEYMAP_RP__17__006_PNG = 0x00001725,
        KEYMAP_RP__17__007_PNG = 0x00001726,
        KEYMAP_RP__17__008_PNG = 0x00001727,
        KEYMAP_RP__17__009_PNG = 0x00001728,
        KEYMAP_RP__17__010_PNG = 0x00001729,
        KEYMAP_RP__18__001_PNG = 0x00001730,
        KEYMAP_RP__18__002_PNG = 0x00001731,
        KEYMAP_RP__18__003_PNG = 0x00001732,
        KEYMAP_RP__18__004_PNG = 0x00001733,
        KEYMAP_RP__18__005_PNG = 0x00001734,
        KEYMAP_RP__18__006_PNG = 0x00001735,
        KEYMAP_RP__18__007_PNG = 0x00001736,
        KEYMAP_RP__18__008_PNG = 0x00001737,
        KEYMAP_RP__18__009_PNG = 0x00001738,
        KEYMAP_RP__18__010_PNG = 0x00001739,
        KEYMAP_RP__19__001_PNG = 0x00001740,
        KEYMAP_RP__19__002_PNG = 0x00001741,
        KEYMAP_RP__19__003_PNG = 0x00001742,
        KEYMAP_RP__19__004_PNG = 0x00001743,
        KEYMAP_RP__19__005_PNG = 0x00001744,
        KEYMAP_RP__19__006_PNG = 0x00001745,
        KEYMAP_RP__19__007_PNG = 0x00001746,
        KEYMAP_RP__19__008_PNG = 0x00001747,
        KEYMAP_RP__19__009_PNG = 0x00001748,
        KEYMAP_RP__19__010_PNG = 0x00001749,
        KEYMAP_RP__20__001_PNG = 0x00001750,
        KEYMAP_RP__20__002_PNG = 0x00001751,
        KEYMAP_RP__20__003_PNG = 0x00001752,
        KEYMAP_RP__20__004_PNG = 0x00001753,
        KEYMAP_RP__20__005_PNG = 0x00001754,
        KEYMAP_RP__20__006_PNG = 0x00001755,
        KEYMAP_RP__20__007_PNG = 0x00001756,
        KEYMAP_RP__20__008_PNG = 0x00001757,
        KEYMAP_RP__20__009_PNG = 0x00001758,
        KEYMAP_RP__20__010_PNG = 0x00001759,
        KEYMAP_RP__21__001_PNG = 0x00001760,
        KEYMAP_RP__21__002_PNG = 0x00001761,
        KEYMAP_RP__21__003_PNG = 0x00001762,
        KEYMAP_RP__21__004_PNG = 0x00001763,
        KEYMAP_RP__21__005_PNG = 0x00001764,
        KEYMAP_RP__21__006_PNG = 0x00001765,
        KEYMAP_RP__21__007_PNG = 0x00001766,
        KEYMAP_RP__21__008_PNG = 0x00001767,
        KEYMAP_RP__21__009_PNG = 0x00001768,
        KEYMAP_RP__21__010_PNG = 0x00001769,
        KEYMAP_RP__22__001_PNG = 0x00001770,
        KEYMAP_RP__22__002_PNG = 0x00001771,
        KEYMAP_RP__22__003_PNG = 0x00001772,
        KEYMAP_RP__22__004_PNG = 0x00001773,
        KEYMAP_RP__22__005_PNG = 0x00001774,
        KEYMAP_RP__22__006_PNG = 0x00001775,
        KEYMAP_RP__22__007_PNG = 0x00001776,
        KEYMAP_RP__22__008_PNG = 0x00001777,
        KEYMAP_RP__22__009_PNG = 0x00001778,
        KEYMAP_RP__22__010_PNG = 0x00001779,
        KEYMAP_RP__23__001_PNG = 0x00001780,
        KEYMAP_RP__23__002_PNG = 0x00001781,
        KEYMAP_RP__23__003_PNG = 0x00001782,
        KEYMAP_RP__23__004_PNG = 0x00001783,
        KEYMAP_RP__23__005_PNG = 0x00001784,
        KEYMAP_RP__23__006_PNG = 0x00001785,
        KEYMAP_RP__23__007_PNG = 0x00001786,
        KEYMAP_RP__23__008_PNG = 0x00001787,
        KEYMAP_RP__23__009_PNG = 0x00001788,
        KEYMAP_RP__23__010_PNG = 0x00001789,
        KEYMAP_RP__24__001_PNG = 0x00001790,
        KEYMAP_RP__24__002_PNG = 0x00001791,
        KEYMAP_RP__24__003_PNG = 0x00001792,
        KEYMAP_RP__24__004_PNG = 0x00001793,
        KEYMAP_RP__24__005_PNG = 0x00001794,
        KEYMAP_RP__24__006_PNG = 0x00001795,
        KEYMAP_RP__24__007_PNG = 0x00001796,
        KEYMAP_RP__24__008_PNG = 0x00001797,
        KEYMAP_RP__24__009_PNG = 0x00001798,
        KEYMAP_RP__24__010_PNG = 0x00001799,
        KEYMAP_RP__25__001_PNG = 0x000017A0,
        KEYMAP_RP__25__002_PNG = 0x000017A1,
        KEYMAP_RP__25__003_PNG = 0x000017A2,
        KEYMAP_RP__25__004_PNG = 0x000017A3,
        KEYMAP_RP__25__005_PNG = 0x000017A4,
        KEYMAP_RP__25__006_PNG = 0x000017A5,
        KEYMAP_RP__25__007_PNG = 0x000017A6,
        KEYMAP_RP__25__008_PNG = 0x000017A7,
        KEYMAP_RP__25__009_PNG = 0x000017A8,
        KEYMAP_RP__25__010_PNG = 0x000017A9,
        KEYMAP_RP__26__001_PNG = 0x000017B0,
        KEYMAP_RP__26__002_PNG = 0x000017B1,
        KEYMAP_RP__26__003_PNG = 0x000017B2,
        KEYMAP_RP__26__004_PNG = 0x000017B3,
        KEYMAP_RP__26__005_PNG = 0x000017B4,
        KEYMAP_RP__26__006_PNG = 0x000017B5,
        KEYMAP_RP__26__007_PNG = 0x000017B6,
        KEYMAP_RP__26__008_PNG = 0x000017B7,
        KEYMAP_RP__26__009_PNG = 0x000017B8,
        KEYMAP_RP__26__010_PNG = 0x000017B9,
        KEYMAP_RP__27__001_PNG = 0x000017C0,
        KEYMAP_RP__27__002_PNG = 0x000017C1,
        KEYMAP_RP__27__003_PNG = 0x000017C2,
        KEYMAP_RP__27__004_PNG = 0x000017C3,
        KEYMAP_RP__27__005_PNG = 0x000017C4,
        KEYMAP_RP__27__006_PNG = 0x000017C5,
        KEYMAP_RP__27__007_PNG = 0x000017C6,
        KEYMAP_RP__27__008_PNG = 0x000017C7,
        KEYMAP_RP__27__009_PNG = 0x000017C8,
        KEYMAP_RP__27__010_PNG = 0x000017C9,
        KEYMAP_RP__28__001_PNG = 0x000017D0,
        KEYMAP_RP__28__002_PNG = 0x000017D1,
        KEYMAP_RP__28__003_PNG = 0x000017D2,
        KEYMAP_RP__28__004_PNG = 0x000017D3,
        KEYMAP_RP__28__005_PNG = 0x000017D4,
        KEYMAP_RP__28__006_PNG = 0x000017D5,
        KEYMAP_RP__28__007_PNG = 0x000017D6,
        KEYMAP_RP__28__008_PNG = 0x000017D7,
        KEYMAP_RP__28__009_PNG = 0x000017D8,
        KEYMAP_RP__28__010_PNG = 0x000017D9,
        KEYMAP_RP__29__001_PNG = 0x000017E0,
        KEYMAP_RP__29__002_PNG = 0x000017E1,
        KEYMAP_RP__29__003_PNG = 0x000017E2,
        KEYMAP_RP__29__004_PNG = 0x000017E3,
        KEYMAP_RP__29__005_PNG = 0x000017E4,
        KEYMAP_RP__29__006_PNG = 0x000017E5,
        KEYMAP_RP__29__007_PNG = 0x000017E6,
        KEYMAP_RP__29__008_PNG = 0x000017E7,
        KEYMAP_RP__29__009_PNG = 0x000017E8,
        KEYMAP_RP__29__010_PNG = 0x000017E9,
        KEYMAP_RP__30__001_PNG = 0x000017F0,
        KEYMAP_RP__30__002_PNG = 0x000017F1,
        KEYMAP_RP__30__003_PNG = 0x000017F2,
        KEYMAP_RP__30__004_PNG = 0x000017F3,
        KEYMAP_RP__30__005_PNG = 0x000017F4,
        KEYMAP_RP__30__006_PNG = 0x000017F5,
        KEYMAP_RP__30__007_PNG = 0x000017F6,
        KEYMAP_RP__30__008_PNG = 0x000017F7,
        KEYMAP_RP__30__009_PNG = 0x000017F8,
        KEYMAP_RP__30__010_PNG = 0x000017F9,
    };
    public static class EntryNames
    {
        static EntryNames()
        {
            NameToId = new Dictionary<string, EntryId>();
            IdToName = new Dictionary<EntryId, string>
      {
        { EntryId.DIGESTS, ".digests" },
        { EntryId.ENTRY_KEYS, ".entry_keys" },
        { EntryId.IMAGE_KEY, ".image_key" },
        { EntryId.GENERAL_DIGESTS, ".general_digests" },
        { EntryId.METAS, ".metas" },
        { EntryId.ENTRY_NAMES, ".entry_names" },
        { EntryId.LICENSE_DAT, "license.dat" },
        { EntryId.LICENSE_INFO, "license.info" },
        { EntryId.NPTITLE_DAT, "nptitle.dat" },
        { EntryId.NPBIND_DAT, "npbind.dat" },
        { EntryId.SELFINFO_DAT, "selfinfo.dat" },
        { EntryId.IMAGEINFO_DAT, "imageinfo.dat" },
        { EntryId.TARGET_DELTAINFO_DAT, "target-deltainfo.dat" },
        { EntryId.ORIGIN_DELTAINFO_DAT, "origin-deltainfo.dat" },
        { EntryId.PSRESERVED_DAT, "psreserved.dat" },
        { EntryId.PARAM_SFO, "param.sfo" },
        { EntryId.PLAYGO_CHUNK_DAT, "playgo-chunk.dat" },
        { EntryId.PLAYGO_CHUNK_SHA, "playgo-chunk.sha" },
        { EntryId.PLAYGO_MANIFEST_XML, "playgo-manifest.xml" },
        { EntryId.PRONUNCIATION_SIG, "pronunciation.sig" },
        { EntryId.PRONUNCIATION_XML, "pronunciation.xml" },
        { EntryId.PIC1_PNG, "pic1.png" },
        { EntryId.PUBTOOLINFO_DAT, "pubtoolinfo.dat" },
        { EntryId.APP__PLAYGO_CHUNK_DAT, "app/playgo-chunk.dat" },
        { EntryId.APP__PLAYGO_CHUNK_SHA, "app/playgo-chunk.sha" },
        { EntryId.APP__PLAYGO_MANIFEST_XML, "app/playgo-manifest.xml" },
        { EntryId.SHAREPARAM_JSON, "shareparam.json" },
        { EntryId.SHAREOVERLAYIMAGE_PNG, "shareoverlayimage.png" },
        { EntryId.SAVE_DATA_PNG, "save_data.png" },
        { EntryId.SHAREPRIVACYGUARDIMAGE_PNG, "shareprivacyguardimage.png" },
        { EntryId.ICON0_PNG, "icon0.png" },
        { EntryId.PIC0_PNG, "pic0.png" },
        { EntryId.SND0_AT9, "snd0.at9" },
        { EntryId.CHANGEINFO__CHANGEINFO_XML, "changeinfo/changeinfo.xml" },
        { EntryId.ICON0_DDS, "icon0.dds" },
        { EntryId.PIC0_DDS, "pic0.dds" },
        { EntryId.PIC1_DDS, "pic1.dds" },
      };
            for (var i = 0; i < 31; i++)
            {
                IdToName.Add((EntryId)((int)EntryId.ICON0_00_PNG + i), $"icon0_{i:d2}.png");
                IdToName.Add((EntryId)((int)EntryId.ICON0_00_DDS + i), $"icon0_{i:d2}.dds");
                IdToName.Add((EntryId)((int)EntryId.PIC1_00_PNG + i), $"pic1_{i:d2}.png");
                IdToName.Add((EntryId)((int)EntryId.PIC1_00_DDS + i), $"pic1_{i:d2}.dds");
                IdToName.Add((EntryId)((int)EntryId.CHANGEINFO__CHANGEINFO_00_XML + i), $"changeinfo/changeinfo_{i:d2}.xml");
                if (i < 10)
                {
                    IdToName.Add((EntryId)((int)EntryId.KEYMAP_RP__001_PNG + i), $"keymap_rp/0{i + 1:d2}.png");
                }
                for (var j = 0; j < 10; j++)
                {
                    IdToName.Add((EntryId)((int)EntryId.KEYMAP_RP__00__001_PNG + (16 * i) + j), $"keymap_rp/{i:d2}/0{j + 1:d2}.png");
                }
            }
            for (var i = 0; i < 100; i++)
            {
                IdToName.Add((EntryId)((int)EntryId.TROPHY__TROPHY00_TRP + i), $"trophy/trophy{i:d2}.trp");
            }
            foreach (var kv in IdToName)
            {
                NameToId.Add(kv.Value, kv.Key);
            }
        }
        public static Dictionary<string, EntryId> NameToId;
        public static Dictionary<EntryId, string> IdToName;
    }
}
