﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aurora.Profiles.LeagueOfLegends.GSI.Nodes;
using System.Drawing;

namespace Aurora.Profiles.LeagueOfLegends.Layers
{
    public static class DefaultChampionColors
    {
        /// <summary>
        /// Default colors for the champions. generated with vibrant-js and the icons for the champions
        /// </summary>
        /// <returns></returns>
        public static Dictionary<Champion, Color> Colors => new Dictionary<Champion, Color>()
        {
            [Champion.Unknown] = Color.FromArgb(120, 120, 120),
            [Champion.None] = Color.FromArgb(120, 120, 120),
            [Champion.Aatrox] = Color.FromArgb(237, 83, 79),
            [Champion.Ahri] = Color.FromArgb(61, 76, 178),
            [Champion.Akali] = Color.FromArgb(10, 115, 38),
            [Champion.Alistar] = Color.FromArgb(64, 6, 97),
            [Champion.Amumu] = Color.FromArgb(87, 138, 74),
            [Champion.Anivia] = Color.FromArgb(8, 128, 200),
            [Champion.Annie] = Color.FromArgb(158, 37, 16),
            [Champion.Aphelios] = Color.FromArgb(52, 44, 124),
            [Champion.Ashe] = Color.FromArgb(44, 53, 180),
            [Champion.AurelionSol] = Color.FromArgb(84, 25, 176),
            [Champion.Azir] = Color.FromArgb(234, 157, 58),
            [Champion.Bard] = Color.FromArgb(216, 136, 32),
            [Champion.Blitzcrank] = Color.FromArgb(194, 114, 44),
            [Champion.Brand] = Color.FromArgb(196, 76, 36),
            [Champion.Braum] = Color.FromArgb(42, 180, 208),
            [Champion.Caitlyn] = Color.FromArgb(74, 143, 164),
            [Champion.Camille] = Color.FromArgb(117, 113, 113),
            [Champion.Cassiopeia] = Color.FromArgb(110, 219, 0),
            [Champion.Chogath] = Color.FromArgb(173, 47, 99),
            [Champion.Corki] = Color.FromArgb(222, 150, 72),
            [Champion.Darius] = Color.FromArgb(177, 4, 14),
            [Champion.Diana] = Color.FromArgb(68, 68, 187),
            [Champion.DrMundo] = Color.FromArgb(96, 184, 196),
            [Champion.Draven] = Color.FromArgb(177, 4, 14),
            [Champion.Ekko] = Color.FromArgb(88, 219, 195),
            [Champion.Elise] = Color.FromArgb(137, 57, 82),
            [Champion.Evelynn] = Color.FromArgb(182, 52, 159),
            [Champion.Ezreal] = Color.FromArgb(225, 242, 97),
            [Champion.Fiddlesticks] = Color.FromArgb(44, 116, 72),
            [Champion.Fiora] = Color.FromArgb(204, 41, 98),
            [Champion.Fizz] = Color.FromArgb(114, 178, 194),
            [Champion.Galio] = Color.FromArgb(76, 111, 169),
            [Champion.Gangplank] = Color.FromArgb(228, 60, 12),
            [Champion.Garen] = Color.FromArgb(38, 64, 186),
            [Champion.Gnar] = Color.FromArgb(244, 124, 36),
            [Champion.Gragas] = Color.FromArgb(196, 72, 36),
            [Champion.Graves] = Color.FromArgb(82, 16, 16),
            [Champion.Hecarim] = Color.FromArgb(7, 145, 145),
            [Champion.Heimerdinger] = Color.FromArgb(191, 155, 70),
            [Champion.Illaoi] = Color.FromArgb(79, 186, 69),
            [Champion.Irelia] = Color.FromArgb(188, 60, 76),
            [Champion.Ivern] = Color.FromArgb(98, 156, 45),
            [Champion.Janna] = Color.FromArgb(192, 108, 132),
            [Champion.JarvanIV] = Color.FromArgb(228, 116, 36),
            [Champion.Jax] = Color.FromArgb(126, 83, 186),
            [Champion.Jayce] = Color.FromArgb(163, 128, 11),
            [Champion.Jhin] = Color.FromArgb(164, 38, 94),
            [Champion.Jinx] = Color.FromArgb(255, 94, 234),
            [Champion.Kaisa] = Color.FromArgb(104, 52, 128),
            [Champion.Kalista] = Color.FromArgb(47, 175, 199),
            [Champion.Karma] = Color.FromArgb(52, 201, 162),
            [Champion.Karthus] = Color.FromArgb(64, 149, 191),
            [Champion.Kassadin] = Color.FromArgb(70, 40, 92),
            [Champion.Katarina] = Color.FromArgb(177, 5, 57),
            [Champion.Kayle] = Color.FromArgb(240, 183, 83),
            [Champion.Kayn] = Color.FromArgb(133, 0, 0),
            [Champion.Kennen] = Color.FromArgb(101, 5, 128),
            [Champion.Khazix] = Color.FromArgb(82, 39, 196),
            [Champion.Kindred] = Color.FromArgb(63, 138, 189),
            [Champion.Kled] = Color.FromArgb(161, 99, 10),
            [Champion.KogMaw] = Color.FromArgb(140, 140, 52),
            [Champion.Leblanc] = Color.FromArgb(68, 15, 128),
            [Champion.LeeSin] = Color.FromArgb(214, 39, 80),
            [Champion.Leona] = Color.FromArgb(193, 105, 37),
            [Champion.Lillia] = Color.FromArgb(88, 4, 199),
            [Champion.Lissandra] = Color.FromArgb(52, 86, 125),
            [Champion.Lucian] = Color.FromArgb(6, 40, 82),
            [Champion.Lulu] = Color.FromArgb(77, 58, 199),
            [Champion.Lux] = Color.FromArgb(212, 170, 44),
            [Champion.Malphite] = Color.FromArgb(97, 57, 15),
            [Champion.Malzahar] = Color.FromArgb(106, 10, 187),
            [Champion.Maokai] = Color.FromArgb(40, 132, 160),
            [Champion.MasterYi] = Color.FromArgb(212, 209, 28),
            [Champion.MissFortune] = Color.FromArgb(217, 57, 17),
            [Champion.Mordekaiser] = Color.FromArgb(44, 164, 124),
            [Champion.Morgana] = Color.FromArgb(190, 50, 186),
            [Champion.Nami] = Color.FromArgb(36, 188, 232),
            [Champion.Nasus] = Color.FromArgb(132, 53, 196),
            [Champion.Nautilus] = Color.FromArgb(205, 95, 43),
            [Champion.Neeko] = Color.FromArgb(84, 26, 219),
            [Champion.Nidalee] = Color.FromArgb(137, 237, 90),
            [Champion.Nocturne] = Color.FromArgb(12, 8, 94),
            [Champion.Nunu] = Color.FromArgb(62, 186, 226),
            [Champion.Olaf] = Color.FromArgb(227, 141, 43),
            [Champion.Orianna] = Color.FromArgb(121, 115, 255),
            [Champion.Ornn] = Color.FromArgb(120, 0, 0),
            [Champion.Pantheon] = Color.FromArgb(73, 73, 182),
            [Champion.Poppy] = Color.FromArgb(201, 38, 81),
            [Champion.Pyke] = Color.FromArgb(50, 104, 98),
            [Champion.Qiyana] = Color.FromArgb(228, 128, 83),
            [Champion.Quinn] = Color.FromArgb(172, 84, 76),
            [Champion.Rakan] = Color.FromArgb(196, 132, 148),
            [Champion.Rammus] = Color.FromArgb(212, 120, 35),
            [Champion.RekSai] = Color.FromArgb(49, 0, 133),
            [Champion.Renekton] = Color.FromArgb(30, 74, 12),
            [Champion.Rengar] = Color.FromArgb(212, 150, 6),
            [Champion.Rell] = Color.FromArgb(199, 157, 4),
            [Champion.Riven] = Color.FromArgb(57, 255, 43),
            [Champion.Rumble] = Color.FromArgb(198, 50, 28),
            [Champion.Ryze] = Color.FromArgb(67, 88, 202),
            [Champion.Samira] = Color.FromArgb(166, 2, 2),
            [Champion.Sejuani] = Color.FromArgb(29, 107, 193),
            [Champion.Senna] = Color.FromArgb(40, 161, 215),
            [Champion.Seraphine] = Color.FromArgb(247, 87, 255),
            [Champion.Sett] = Color.FromArgb(172, 76, 92),
            [Champion.Shaco] = Color.FromArgb(84, 68, 164),
            [Champion.Shen] = Color.FromArgb(92, 102, 195),
            [Champion.Shyvana] = Color.FromArgb(140, 20, 7),
            [Champion.Singed] = Color.FromArgb(88, 185, 95),
            [Champion.Sion] = Color.FromArgb(180, 9, 12),
            [Champion.Sivir] = Color.FromArgb(193, 113, 74),
            [Champion.Skarner] = Color.FromArgb(112, 78, 172),
            [Champion.Sona] = Color.FromArgb(88, 147, 184),
            [Champion.Soraka] = Color.FromArgb(184, 97, 255),
            [Champion.Swain] = Color.FromArgb(156, 25, 14),
            [Champion.Sylas] = Color.FromArgb(108, 132, 188),
            [Champion.Syndra] = Color.FromArgb(142, 53, 200),
            [Champion.TahmKench] = Color.FromArgb(132, 100, 60),
            [Champion.Taliyah] = Color.FromArgb(189, 97, 47),
            [Champion.Talon] = Color.FromArgb(54, 62, 118),
            [Champion.Taric] = Color.FromArgb(122, 64, 203),
            [Champion.Teemo] = Color.FromArgb(200, 96, 38),
            [Champion.Thresh] = Color.FromArgb(19, 236, 127),
            [Champion.Tristana] = Color.FromArgb(184, 93, 100),
            [Champion.Trundle] = Color.FromArgb(81, 172, 192),
            [Champion.Tryndamere] = Color.FromArgb(64, 64, 191),
            [Champion.TwistedFate] = Color.FromArgb(20, 75, 130),
            [Champion.Twitch] = Color.FromArgb(44, 153, 60),
            [Champion.Udyr] = Color.FromArgb(156, 60, 28),
            [Champion.Urgot] = Color.FromArgb(92, 196, 76),
            [Champion.Varus] = Color.FromArgb(169, 55, 107),
            [Champion.Vayne] = Color.FromArgb(182, 18, 42),
            [Champion.Veigar] = Color.FromArgb(67, 42, 158),
            [Champion.Velkoz] = Color.FromArgb(202, 57, 201),
            [Champion.Vi] = Color.FromArgb(196, 55, 100),
            [Champion.Viktor] = Color.FromArgb(204, 76, 36),
            [Champion.Vladimir] = Color.FromArgb(190, 63, 57),
            [Champion.Volibear] = Color.FromArgb(74, 134, 175),
            [Champion.Warwick] = Color.FromArgb(62, 153, 50),
            [Champion.Xayah] = Color.FromArgb(165, 28, 87),
            [Champion.Xerath] = Color.FromArgb(58, 76, 164),
            [Champion.XinZhao] = Color.FromArgb(204, 133, 99),
            [Champion.Wukong] = Color.FromArgb(231, 62, 33),
            [Champion.Yasuo] = Color.FromArgb(65, 116, 178),
            [Champion.Yorick] = Color.FromArgb(58, 104, 197),
            [Champion.Yone] = Color.FromArgb(219, 59, 59),
            [Champion.Yuumi] = Color.FromArgb(180, 116, 76),
            [Champion.Zac] = Color.FromArgb(97, 184, 75),
            [Champion.Zed] = Color.FromArgb(148, 0, 0),
            [Champion.Ziggs] = Color.FromArgb(227, 67, 23),
            [Champion.Zilean] = Color.FromArgb(61, 148, 194),
            [Champion.Zoe] = Color.FromArgb(228, 104, 87),
            [Champion.Zyra] = Color.FromArgb(158, 40, 19),
        };
    }
}
