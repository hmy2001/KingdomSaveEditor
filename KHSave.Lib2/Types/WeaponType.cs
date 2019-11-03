﻿using KHSave.Attributes;

namespace KHSave.Lib2.Types
{
    public enum WeaponType : short
    {
        [Info] Empty = 0,
        [Consumable("Potion")] Potion = 0x01,
        [Consumable("Hi-Potion")] HiPotion = 0x02,
        [Consumable("Ether")] Ether = 0x03,
        [Consumable("Elixir")] Elixir = 0x04,
        [Consumable("Mega-Potion")] MegaPotion = 0x05,
        [Consumable("Mega-Ether")] MegaEther = 0x06,
        [Consumable("Megalixir")] Megalixir = 0x07,
        [Accessory("Ability Ring")] AbilityRing = 0x08,
        Unknown09 = 0x09,
        Unknown0A = 0x0A,
        [Accessory("Expert's Ring")] ExpertsRing = 0x0B,
        Unknown0C = 0x0C,
        Unknown0D = 0x0D,
        Unknown0E = 0x0E,
        Unknown0F = 0x0F,
        [Accessory("Diamond Ring")] DiamondRing = 0x10,
        Unknown11 = 0x11,
        Unknown12 = 0x12,
        Unknown13 = 0x13,
        Unknown14 = 0x14,
        Unknown15 = 0x15,
        Unknown16 = 0x16,
        Unknown17 = 0x17,
        Unknown18 = 0x18,
        Unknown19 = 0x19,
        Unknown1A = 0x1A,
        Unknown1B = 0x1B,
        Unknown1C = 0x1C,
        Unknown1D = 0x1D,
        Unknown1E = 0x1E,
        Unknown1F = 0x1F,
        Unknown20 = 0x20,
        Unknown21 = 0x21,
        Unknown22 = 0x22,
        [Accessory("Moon Amulet")] MoonAmulet = 0x23,
        [Accessory("Star Charm")] StarCharm = 0x24,
        Unknown25 = 0x25,
        Unknown26 = 0x26,
        [Accessory("Skillful Ring")] SkillfulRing = 0x27,
        [Accessory("Solider Earring")] SoliderEarring = 0x28,
        [Keyblade("Kingdom Key")] KingdomKey = 0x29,
        [Keyblade("Oathkeeper")] Oathkeeper = 0x2a,
        [Keyblade("Oblivion")] Oblivion = 0x2b,
        [Keyblade("Detection Saber")] DetectionSaber = 0x2c,
        [Keyblade("Frontier of Ultima")] FrontierOfUltima = 0x2d,
        [Accessory("Fencer Earring")] FencerEarring = 0x2E,
        [Accessory("Mage Earring")] MageEarring = 0x2F,
        [Accessory("Slayer Earring")] SlayerEarring = 0x30,
        Unknown31 = 0x31,
        Unknown32 = 0x32,
        Unknown33 = 0x33,
        [Accessory("Cosmic Ring")] CosmicRing = 0x34,
        Unknown35 = 0x35,
        Unknown36 = 0x36,
        Unknown37 = 0x37,
        [Accessory("Cosmic Arts")] CosmicArts = 0x38,
        [Accessory("Shadow Archive")] ShadowArchive = 0x39,
        [Accessory("Shadow Archive+")] ShadowArchivePlus = 0x3A,
        Unknown3B = 0x3B,
        Unknown3C = 0x3C,
        Unknown3D = 0x3D,
        Unknown3E = 0x3E,
        Unknown3F = 0x3F,
        [Accessory("Full Bloom")] FullBloom = 0x40,
        Unknown41 = 0x41,
        Unknown42 = 0x42,
        Unknown43 = 0x43,
        [Armor("Divine Bandanna")] DivineBandanna = 0x44,
        [Armor("Power Band")] PowerBand = 0x45,
        [Armor("Buster Band")] BusterBand = 0x46,
        [Keyblade("Antiform Dummy")] AntiformDummy = 0x47,
        [Weapon] Scimitar = 0x48,
        [Weapon("Way to the Dawn")] WayToTheDawn = 0x49,
        [Weapon("Identity Disk")] IdentityDisk = 0x4A,
        [Staff("Mage's Staff")] MagesStaff = 0x4b,
        Unknown4C = 0x4C,
        Unknown4D = 0x4D,
        [Armor("Protect Belt")] ProtectBelt = 0x4E,
        [Armor("Gaia Belt")] GaiaBelt = 0x4F,
        MulanSword = 0x50,
        Unknown51 = 0x51,
        [AbilityAction] Guard = 0x52,
        Unknown53 = 0x53,
        Unknown54 = 0x54,
        Unknown55 = 0x55,
        Unknown56 = 0x56,
        Unknown57 = 0x57,
        Unknown58 = 0x58,
        Unknown59 = 0x59,
        Unknown5A = 0x5A,
        Unknown5B = 0x5B,
        Unknown5C = 0x5C,
        Unknown5D = 0x5D,
        Unknown5E = 0x5E,
        Unknown5F = 0x5F,
        Unknown60 = 0x60,
        Unknown61 = 0x61,
        Unknown62 = 0x62,
        Unknown63 = 0x63,
        Unknown64 = 0x64,
        Unknown65 = 0x65,
        Unknown66 = 0x66,
        Unknown67 = 0x67,
        Unknown68 = 0x68,
        Unknown69 = 0x69,
        Unknown6A = 0x6A,
        Unknown6B = 0x6B,
        Unknown6C = 0x6C,
        Unknown6D = 0x6D,
        Unknown6E = 0x6E,
        [Armor("Cosmic Belt")] CosmicBelt = 0x6F,
        Unknown70 = 0x70,
        Unknown71 = 0x71,
        Unknown72 = 0x72,
        Unknown73 = 0x73,
        Unknown74 = 0x74,
        Unknown75 = 0x75,
        Unknown76 = 0x76,
        Unknown77 = 0x77,
        Unknown78 = 0x78,
        Unknown79 = 0x79,
        Unknown7A = 0x7A,
        Unknown7B = 0x7B,
        Unknown7C = 0x7C,
        Unknown7D = 0x7D,
        Unknown7E = 0x7E,
        Unknown7F = 0x7F,
        Unknown80 = 0x80,
        Unknown81 = 0x81,
        Unknown82 = 0x82,
        Unknown83 = 0x83,
        Unknown84 = 0x84,
        Unknown85 = 0x85,
        Unknown86 = 0x86,
        Unknown87 = 0x87,
        Unknown88 = 0x88,
        Unknown89 = 0x89,
        Unknown8A = 0x8A,
        Unknown8B = 0x8B,
        Unknown8C = 0x8C,
        Unknown8D = 0x8D,
        Unknown8E = 0x8E,
        Unknown8F = 0x8F,
        Unknown90 = 0x90,
        Unknown91 = 0x91,
        Unknown92 = 0x92,
        Unknown93 = 0x93,
        Unknown94 = 0x94,
        Unknown95 = 0x95,
        Unknown96 = 0x96,
        Unknown97 = 0x97,
        Unknown98 = 0x98,
        Unknown99 = 0x99,
        Unknown9A = 0x9A,
        Unknown9B = 0x9B,
        Unknown9C = 0x9C,
        [Armor("Grand Ribbon")] GrandRibbon = 0x9D,
        Unknown9E = 0x9E,
        Unknown9F = 0x9F,
        UnknownA0 = 0xA0,
        UnknownA1 = 0xA1,
        UnknownA2 = 0xA2,
        UnknownA3 = 0xA3,
        UnknownA4 = 0xA4,
        UnknownA5 = 0xA5,
        UnknownA6 = 0xA6,
        UnknownA7 = 0xA7,
        UnknownA8 = 0xA8,
        UnknownA9 = 0xA9,
        UnknownAA = 0xAA,
        UnknownAB = 0xAB,
        UnknownAC = 0xAC,
        UnknownAD = 0xAD,
        UnknownAE = 0xAE,
        UnknownAF = 0xAF,
        UnknownB0 = 0xB0,
        UnknownB1 = 0xB1,
        UnknownB2 = 0xB2,
        UnknownB3 = 0xB3,
        UnknownB4 = 0xB4,
        UnknownB5 = 0xB5,
        UnknownB6 = 0xB6,
        UnknownB7 = 0xB7,
        UnknownB8 = 0xB8,
        UnknownB9 = 0xB9,
        UnknownBA = 0xBA,
        UnknownBB = 0xBB,
        UnknownBC = 0xBC,
        UnknownBD = 0xBD,
        UnknownBE = 0xBE,
        UnknownBF = 0xBF,
        UnknownC0 = 0xC0,
        UnknownC1 = 0xC1,
        UnknownC2 = 0xC2,
        UnknownC3 = 0xC3,
        UnknownC4 = 0xC4,
        UnknownC5 = 0xC5,
        UnknownC6 = 0xC6,
        UnknownC7 = 0xC7,
        UnknownC8 = 0xC8,
        UnknownC9 = 0xC9,
        UnknownCA = 0xCA,
        UnknownCB = 0xCB,
        UnknownCC = 0xCC,
        UnknownCD = 0xCD,
        UnknownCE = 0xCE,
        UnknownCF = 0xCF,
        UnknownD0 = 0xD0,
        UnknownD1 = 0xD1,
        UnknownD2 = 0xD2,
        UnknownD3 = 0xD3,
        UnknownD4 = 0xD4,
        UnknownD5 = 0xD5,
        UnknownD6 = 0xD6,
        UnknownD7 = 0xD7,
        UnknownD8 = 0xD8,
        UnknownD9 = 0xD9,
        UnknownDA = 0xDA,
        UnknownDB = 0xDB,
        UnknownDC = 0xDC,
        UnknownDD = 0xDD,
        UnknownDE = 0xDE,
        UnknownDF = 0xDF,
        UnknownE0 = 0xE0,
        UnknownE1 = 0xE1,
        UnknownE2 = 0xE2,
        UnknownE3 = 0xE3,
        UnknownE4 = 0xE4,
        UnknownE5 = 0xE5,
        UnknownE6 = 0xE6,
        UnknownE7 = 0xE7,
        UnknownE8 = 0xE8,
        UnknownE9 = 0xE9,
        UnknownEA = 0xEA,
        UnknownEB = 0xEB,
        UnknownEC = 0xEC,
        UnknownED = 0xED,
        UnknownEE = 0xEE,
        UnknownEF = 0xEF,
        UnknownF0 = 0xF0,
        UnknownF1 = 0xF1,
        UnknownF2 = 0xF2,
        UnknownF3 = 0xF3,
        UnknownF4 = 0xF4,
        UnknownF5 = 0xF5,
        UnknownF6 = 0xF6,
        UnknownF7 = 0xF7,
        UnknownF8 = 0xF8,
        UnknownF9 = 0xF9,
        UnknownFA = 0xFA,
        UnknownFB = 0xFB,
        UnknownFC = 0xFC,
        UnknownFD = 0xFD,
        UnknownFE = 0xFE,
        UnknownFF = 0xFF,
        Unknown100 = 0x100,
        Unknown101 = 0x101,
        Unknown102 = 0x102,
        Unknown103 = 0x103,
        Unknown104 = 0x104,
        Unknown105 = 0x105,
        Unknown106 = 0x106,
        Unknown107 = 0x107,
        Unknown108 = 0x108,
        Unknown109 = 0x109,
        Unknown10A = 0x10A,
        Unknown10B = 0x10B,
        Unknown10C = 0x10C,
        Unknown10D = 0x10D,
        Unknown10E = 0x10E,
        Unknown10F = 0x10F,
        Unknown110 = 0x110,
        Unknown111 = 0x111,
        Unknown112 = 0x112,
        Unknown113 = 0x113,
        Unknown114 = 0x114,
        Unknown115 = 0x115,
        Unknown116 = 0x116,
        Unknown117 = 0x117,
        Unknown118 = 0x118,
        Unknown119 = 0x119,
        Unknown11A = 0x11A,
        Unknown11B = 0x11B,
        Unknown11C = 0x11C,
        Unknown11D = 0x11D,
        Unknown11E = 0x11E,
        Unknown11F = 0x11F,
        Unknown120 = 0x120,
        Unknown121 = 0x121,
        Unknown122 = 0x122,
        Unknown123 = 0x123,
        Unknown124 = 0x124,
        Unknown125 = 0x125,
        Unknown126 = 0x126,
        Unknown127 = 0x127,
        Unknown128 = 0x128,
        Unknown129 = 0x129,
        Unknown12A = 0x12A,
        Unknown12B = 0x12B,
        Unknown12C = 0x12C,
        Unknown12D = 0x12D,
        Unknown12E = 0x12E,
        Unknown12F = 0x12F,
        Unknown130 = 0x130,
        [Armor("Champion Belt")] ChampionBelt = 0x131,
        Unknown132 = 0x132,
        Unknown133 = 0x133,
        Unknown134 = 0x134,
        Unknown135 = 0x135,
        Unknown136 = 0x136,
        Unknown137 = 0x137,
        Unknown138 = 0x138,
        Unknown139 = 0x139,
        Unknown13A = 0x13A,
        Unknown13B = 0x13B,
        Unknown13C = 0x13C,
        Unknown13D = 0x13D,
        Unknown13E = 0x13E,
        Unknown13F = 0x13F,
        Unknown140 = 0x140,
        Unknown141 = 0x141,
        Unknown142 = 0x142,
        Unknown143 = 0x143,
        Unknown144 = 0x144,
        Unknown145 = 0x145,
        Unknown146 = 0x146,
        Unknown147 = 0x147,
        Unknown148 = 0x148,
        Unknown149 = 0x149,
        Unknown14A = 0x14A,
        Unknown14B = 0x14B,
        Unknown14C = 0x14C,
        Unknown14D = 0x14D,
        Unknown14E = 0x14E,
        Unknown14F = 0x14F,
        Unknown150 = 0x150,
        Unknown151 = 0x151,
        Unknown152 = 0x152,
        Unknown153 = 0x153,
        Unknown154 = 0x154,
        Unknown155 = 0x155,
        Unknown156 = 0x156,
        Unknown157 = 0x157,
        Unknown158 = 0x158,
        Unknown159 = 0x159,
        Unknown15A = 0x15A,
        Unknown15B = 0x15B,
        Unknown15C = 0x15C,
        Unknown15D = 0x15D,
        Unknown15E = 0x15E,
        Unknown15F = 0x15F,
        Unknown160 = 0x160,
        Unknown161 = 0x161,
        Unknown162 = 0x162,
        Unknown163 = 0x163,
        Unknown164 = 0x164,
        Unknown165 = 0x165,
        Unknown166 = 0x166,
        Unknown167 = 0x167,
        Unknown168 = 0x168,
        Unknown169 = 0x169,
        Unknown16A = 0x16A,
        Unknown16B = 0x16B,
        Unknown16C = 0x16C,
        Unknown16D = 0x16D,
        Unknown16E = 0x16E,
        Unknown16F = 0x16F,
        Unknown170 = 0x170,
        Unknown171 = 0x171,
        Unknown172 = 0x172,
        Unknown173 = 0x173,
        Unknown174 = 0x174,
        Unknown175 = 0x175,
        Unknown176 = 0x176,
        Unknown177 = 0x177,
        Unknown178 = 0x178,
        Unknown179 = 0x179,
        Unknown17A = 0x17A,
        Unknown17B = 0x17B,
        Unknown17C = 0x17C,
        Unknown17D = 0x17D,
        Unknown17E = 0x17E,
        Unknown17F = 0x17F,
        Unknown180 = 0x180,
        Unknown181 = 0x181,
        Unknown182 = 0x182,
        Unknown183 = 0x183,
        Unknown184 = 0x184,
        Unknown185 = 0x185,
        Unknown186 = 0x186,
        Unknown187 = 0x187,
        Unknown188 = 0x188,
        Unknown189 = 0x189,
        Unknown18A = 0x18A,
        Unknown18B = 0x18B,
        Unknown18C = 0x18C,
        Unknown18D = 0x18D,
        Unknown18E = 0x18E,
        Unknown18F = 0x18F,
        Unknown190 = 0x190,
        Unknown191 = 0x191,
        Unknown192 = 0x192,
        Unknown193 = 0x193,
        Unknown194 = 0x194,
        Unknown195 = 0x195,
        Unknown196 = 0x196,
        Unknown197 = 0x197,
        Unknown198 = 0x198,
        Unknown199 = 0x199,
        Unknown19A = 0x19A,
        Unknown19B = 0x19B,
        Unknown19C = 0x19C,
        Unknown19D = 0x19D,
        Unknown19E = 0x19E,
        Unknown19F = 0x19F,
        Unknown1A0 = 0x1A0,
        Unknown1A1 = 0x1A1,
        Unknown1A2 = 0x1A2,
        Unknown1A3 = 0x1A3,
        Unknown1A4 = 0x1A4,
        Unknown1A5 = 0x1A5,
        Unknown1A6 = 0x1A6,
        Unknown1A7 = 0x1A7,
        Unknown1A8 = 0x1A8,
        Unknown1A9 = 0x1A9,
        Unknown1AA = 0x1AA,
        Unknown1AB = 0x1AB,
        Unknown1AC = 0x1AC,
        Unknown1AD = 0x1AD,
        Unknown1AE = 0x1AE,
        Unknown1AF = 0x1AF,
        Unknown1B0 = 0x1B0,
        Unknown1B1 = 0x1B1,
        Unknown1B2 = 0x1B2,
        Unknown1B3 = 0x1B3,
        Unknown1B4 = 0x1B4,
        Unknown1B5 = 0x1B5,
        Unknown1B6 = 0x1B6,
        Unknown1B7 = 0x1B7,
        Unknown1B8 = 0x1B8,
        Unknown1B9 = 0x1B9,
        Unknown1BA = 0x1BA,
        Unknown1BB = 0x1BB,
        Unknown1BC = 0x1BC,
        Unknown1BD = 0x1BD,
        Unknown1BE = 0x1BE,
        Unknown1BF = 0x1BF,
        Unknown1C0 = 0x1C0,
        Unknown1C1 = 0x1C1,
        Unknown1C2 = 0x1C2,
        Unknown1C3 = 0x1C3,
        Unknown1C4 = 0x1C4,
        Unknown1C5 = 0x1C5,
        Unknown1C6 = 0x1C6,
        Unknown1C7 = 0x1C7,
        Unknown1C8 = 0x1C8,
        Unknown1C9 = 0x1C9,
        Unknown1CA = 0x1CA,
        Unknown1CB = 0x1CB,
        Unknown1CC = 0x1CC,
        Unknown1CD = 0x1CD,
        Unknown1CE = 0x1CE,
        Unknown1CF = 0x1CF,
        Unknown1D0 = 0x1D0,
        Unknown1D1 = 0x1D1,
        Unknown1D2 = 0x1D2,
        Unknown1D3 = 0x1D3,
        Unknown1D4 = 0x1D4,
        Unknown1D5 = 0x1D5,
        Unknown1D6 = 0x1D6,
        Unknown1D7 = 0x1D7,
        Unknown1D8 = 0x1D8,
        Unknown1D9 = 0x1D9,
        Unknown1DA = 0x1DA,
        Unknown1DB = 0x1DB,
        Unknown1DC = 0x1DC,
        Unknown1DD = 0x1DD,
        Unknown1DE = 0x1DE,
        Unknown1DF = 0x1DF,
        [Keyblade("Star Seeker")] StarSeeker = 0x1e0,
        [Keyblade("Hidden Dragon")] HiddenDragon = 0x1e1,
        [Staff("Save the Queen")] SaveTheQueen = 0x1e2,
        [Shield("Save the King")] SaveTheKing = 0x1e3,
        [Keyblade("Hero's Crest")] HeroCrest = 0x1e4,
        [Keyblade("Monochrome")] Monochrome = 0x1e5,
        [Keyblade("Follow the Wind")] FollowTheWind = 0x1e6,
        [Keyblade("Circle of Life")] CircleOfLife = 0x1e7,
        [Keyblade("Photon Debugger")] PhotonDebugger = 0x1e8,
        [Keyblade("Gull Wing")] GullWing = 0x1e9,
        [Keyblade("Rumbling Rose")] RumblingRose = 0x1ea,
        [Keyblade("Guardian Soul")] GuardianSoul = 0x1eb,
        [Keyblade("Wishing Lamp")] WishingLamp = 0x1ec,
        [Keyblade("Decisive Pumpkin")] DecisivePumpkin = 0x1ed,
        [Keyblade("Sleeping Lion")] SleepingLion = 0x1ee,
        [Keyblade("Sweet Memories")] SweetMemories = 0x1ef,
        [Keyblade("Mysterious Abyss")] MysteriousAbyss = 0x1f0,
        [Keyblade("Fatal Crest")] FatalCrest = 0x1f1,
        [Keyblade("Bond of Flame")] BondOfFlame = 0x1f2,
        [Keyblade("Fenrir")] Fenrir = 0x1f3,
        [Keyblade("Ultima Weapon")] UltimaWeapon = 0x1f4,
        [Keyblade("Struggle wand")] StruggleWand = 0x1f5,
        [Keyblade("Struggle hammer")] StruggleHammer = 0x1f6,
        [Staff("Save the Queen+")] SaveTheQueenPlus = 0x1F7,
        [Shield("Save the King+")] SaveTheKingPlus = 0x1F8,
        [KeyItem("The Interceptor Map")] TheInterceptorMap = 0x1F9,
        [KeyItem("The Black Pearl Map")] TheBlackPearlMap = 0x1FA,
        Unknown1FB = 0x1FB,
        Unknown1FC = 0x1FC,
        Unknown1FD = 0x1FD,
        Unknown1FE = 0x1FE,
        Unknown1FF = 0x1FF,
        Unknown200 = 0x200,
        Unknown201 = 0x201,
        Unknown202 = 0x202,
        Unknown203 = 0x203,
        Unknown204 = 0x204,
        Unknown205 = 0x205,
        Unknown206 = 0x206,
        Unknown207 = 0x207,
        Unknown208 = 0x208,
        Unknown209 = 0x209,
        Unknown20A = 0x20A,
        Unknown20B = 0x20B,
        Unknown20C = 0x20C,
        Unknown20D = 0x20D,
        Unknown20E = 0x20E,
        Unknown20F = 0x20F,
        Unknown210 = 0x210,
        Unknown211 = 0x211,
        Unknown212 = 0x212,
        Unknown213 = 0x213,
        Unknown214 = 0x214,
        Unknown215 = 0x215,
        Unknown216 = 0x216,
        Unknown217 = 0x217,
        Unknown218 = 0x218,
        Unknown219 = 0x219,
        Unknown21A = 0x21A,
        Unknown21B = 0x21B,
        Unknown21C = 0x21C,
        Unknown21D = 0x21D,
        Unknown21E = 0x21E,
        [Keyblade("Two Become One")] TwoBecomeOne = 0x21f,
        [Keyblade("Winner's Proof")] WinnersProof = 0x220,
        [Staff("Centurion")] Centurion = 0x221,
        [Staff("Centurion+")] CenturionPlus = 0x222,
        Unknown223 = 0x223,
        Unknown224 = 0x224,
        Unknown225 = 0x225,
        Unknown226 = 0x226,
        Unknown227 = 0x227,
        Unknown228 = 0x228,
        Unknown229 = 0x229,
        Unknown22A = 0x22A,
        Unknown22B = 0x22B,
        Unknown22C = 0x22C,
        Unknown22D = 0x22D,
        [Shield("Ultimate Mushroom")] UltimateMushroom = 0x22E,
        Unknown22F = 0x22F,
        Unknown230 = 0x230,
        Unknown231 = 0x231,
        Unknown232 = 0x232,
        Unknown233 = 0x233,
        Unknown234 = 0x234,
        Unknown235 = 0x235,
        Unknown236 = 0x236,
        Unknown237 = 0x237,
        Unknown238 = 0x238,
        Unknown239 = 0x239,
        Unknown23A = 0x23A,
        Unknown23B = 0x23B,
        Unknown23C = 0x23C,
        Unknown23D = 0x23D,
        Unknown23E = 0x23E,
        Unknown23F = 0x23F,
        [Synthesis("Remembrance Shard")] RemembranceShard = 0x240,
        Unknown241 = 0x241,
        Unknown242 = 0x242,
        Unknown243 = 0x243,
        Unknown244 = 0x244,
        Unknown245 = 0x245,
        Unknown246 = 0x246,
        Unknown247 = 0x247,
        Unknown248 = 0x248,
        Unknown249 = 0x249,
        Unknown24A = 0x24A,
        Unknown24B = 0x24B,
        Unknown24C = 0x24C,
        Unknown24D = 0x24D,
        Unknown24E = 0x24E,
        Unknown24F = 0x24F,
        [KeyItem("Garden of Assemblage Map")] GardenOfAssemblageMap = 0x250,
        Unknown251 = 0x251,
        Unknown252 = 0x252,
        Unknown253 = 0x253,
        Unknown254 = 0x254,
        Unknown255 = 0x255,
        Unknown256 = 0x256,
        Unknown257 = 0x257,
        [Staff("Shaman's Relic+")] ShamansRelicPlus = 0x258,
        [Shield("Akashic Record+")] AkashicRecordPlus = 0x259,
        Unknown25A = 0x25A,
        Unknown25B = 0x25B,
        Unknown25C = 0x25C,
        Unknown25D = 0x25D,
        Unknown25E = 0x25E,
        Unknown25F = 0x25F,
        Unknown260 = 0x260,
        Unknown261 = 0x261,
        Unknown262 = 0x262,
        Unknown263 = 0x263,
        Unknown264 = 0x264,
        Unknown265 = 0x265,
        Unknown266 = 0x266,
        Unknown267 = 0x267,
        Unknown268 = 0x268,
        Unknown269 = 0x269,
        Unknown26A = 0x26A,
        Unknown26B = 0x26B,
        Unknown26C = 0x26C,
        Unknown26D = 0x26D,
        Unknown26E = 0x26E,
        Unknown26F = 0x26F,
        Unknown270 = 0x270,
        Unknown271 = 0x271,
        Unknown272 = 0x272,
        Unknown273 = 0x273,
        Unknown274 = 0x274,
        Unknown275 = 0x275,
        Unknown276 = 0x276,
        Unknown277 = 0x277,
        Unknown278 = 0x278,
        Unknown279 = 0x279,
        Unknown27A = 0x27A,
        Unknown27B = 0x27B,
        Unknown27C = 0x27C,
        Unknown27D = 0x27D,
        Unknown27E = 0x27E,
        Unknown27F = 0x27F,
    }
}
