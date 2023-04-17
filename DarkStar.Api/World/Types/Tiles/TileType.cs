﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable All

namespace DarkStar.Api.World.Types.Tiles;

public enum TileType : short
{
    Null,
    White,
    Black,

    Terrain_Water_1 = 3097,
    Terrain_Water_2 = 3098,
    Terrain_Water_3 = 3099,
    Terrain_Water_4 = 6912,
    Terrain_Water_5 = 6913,

    Terrain_Grass_1 = 6272,
    Terrain_Grass_2 = 6273,
    Terrain_Grass_3 = 6400,
    Terrain_Grass_4 = 6401,
    Terrain_Grass_5 = 6402,
    Terrain_Grass_6 = 6403,
    Terrain_Grass_7 = 6404,
    Terrain_Grass_8 = 6405,
    Terrain_Grass_9 = 6406,
    Terrain_Grass_10 = 6407,
    Terrain_Grass_11 = 6408,
    Terrain_Grass_12 = 6409,
    Terrain_Grass_Rocks_1 = 6410,
    Terrain_Grass_Rocks_2 = 6411,
    Terrain_Grass_Rocks_3 = 6412,
    Terrain_Grass_Rocks_4 = 6413,
    Terrain_Grass_Rocks_5 = 6414,
    Terrain_Grass_Rocks_6 = 6415,
    Terrain_Grass_Rocks_7 = 6416,
    Terrain_Grass_Rocks_8 = 6417,
    Terrain_Grass_Rocks_9 = 6418,
    Terrain_Grass_Rocks_10 = 6419,


    Terrain_Lava_1 = 6914,
    Terrain_Lava_2 = 6915,

    Wall_Stone_1 = 2965,
    Wall_Stone_2 = 2966,
    Wall_Stone_3 = 2967,
    Wall_Stone_4 = 2968,
    Wall_Stone_5 = 2969,
    Wall_Stone_6 = 2970,
    Wall_Stone_7 = 7296,

    Terrain_Bush_1 = 4608,
    Terrain_Bush_2 = 4609,
    Terrain_Bush_3 = 4610,
    Terrain_Bush_4 = 4611,
    Terrain_Bush_5 = 4612,
    Terrain_Bush_6 = 4613,
    Terrain_Bush_7 = 4614,
    Terrain_Bush_8 = 4615,
    Terrain_Bush_9 = 4616,
    Terrain_Bush_10 = 4617,
    Terrain_Bush_11 = 4618,
    Terrain_Bush_12 = 4619,
    Terrain_Bush_13 = 4620,
    Terrain_Bush_14 = 4621,
    Terrain_Bush_15 = 4622,
    Terrain_Bush_16 = 4623,
    Terrain_Bush_17 = 4624,
    Terrain_Bush_18 = 4625,
    Terrain_Bush_19 = 4626,
    Terrain_Bush_20 = 4627,
    Terrain_Bush_21 = 4628,
    Terrain_Bush_22 = 4629,
    Terrain_Bush_23 = 4630,
    Terrain_Bush_24 = 4631,
    Terrain_Bush_25 = 4632,
    Terrain_Bush_26 = 4633,
    Terrain_Bush_27 = 4634,
    Terrain_Bush_28 = 4635,
    Terrain_Bush_29 = 4636,
    Terrain_Bush_30 = 4637,
    Terrain_Bush_31 = 4638,
    Terrain_Bush_32 = 4639,
    Terrain_Flowers_1 = 4736,
    Terrain_Flowers_2 = 4737,
    Terrain_Flowers_3 = 4738,
    Terrain_Flowers_4 = 4739,
    Terrain_Flowers_5 = 4740,
    Terrain_Flowers_6 = 4741,
    Terrain_Flowers_7 = 4742,
    Terrain_Flowers_8 = 4743,
    Terrain_Flowers_9 = 4744,
    Terrain_Flowers_10 = 4745,

    Terrain_Campfire_1 = 4868,

    Terrain_Tree_1 = 4224,
    Terrain_Tree_2 = 4225,
    Terrain_Tree_3 = 4226,
    Terrain_Tree_4 = 4227,
    Terrain_Tree_5 = 4228,
    Terrain_Tree_6 = 4229,
    Terrain_Tree_7 = 4230,
    Terrain_Tree_8 = 4231,
    Terrain_Tree_9 = 4232,
    Terrain_Tree_10 = 4233,
    Terrain_Tree_11 = 4234,
    Terrain_Tree_12 = 4235,
    Terrain_Tree_13 = 4236,
    Terrain_Tree_14 = 4237,
    Terrain_Tree_15 = 4238,
    Terrain_Tree_16 = 4239,
    Terrain_Tree_17 = 4240,
    Terrain_Tree_18 = 4241,
    Terrain_Tree_19 = 4242,
    Terrain_Tree_20 = 4243,
    Terrain_Tree_21 = 4244,
    Terrain_Tree_22 = 4245,
    Terrain_Tree_23 = 4246,
    Terrain_Tree_24 = 4247,
    Terrain_Tree_25 = 4248,
    Terrain_Tree_26 = 4249,
    Terrain_Tree_27 = 4250,
    Terrain_Tree_28 = 4251,
    Terrain_Tree_29 = 4252,
    Terrain_Tree_30 = 4253,
    Terrain_Tree_31 = 4254,
    Terrain_Tree_32 = 4255,
    Terrain_Tree_33 = 4352,
    Terrain_Tree_34 = 4353,
    Terrain_Tree_35 = 4354,
    Terrain_Tree_36 = 4355,
    Terrain_Tree_37 = 4356,
    Terrain_Tree_38 = 4357,
    Terrain_Tree_39 = 4358,
    Terrain_Tree_40 = 4359,
    Terrain_Tree_41 = 4360,
    Terrain_Tree_42 = 4361,
    Terrain_Tree_43 = 4362,
    Terrain_Tree_44 = 4363,
    Terrain_Tree_45 = 4364,
    Terrain_Tree_46 = 4365,
    Terrain_Tree_47 = 4366,
    Terrain_Tree_48 = 4367,
    Terrain_Tree_49 = 4368,
    Terrain_Tree_50 = 4369,
    Terrain_Tree_51 = 4370,
    Terrain_Tree_52 = 4371,
    Terrain_Tree_53 = 4372,
    Terrain_Tree_54 = 4373,
    Terrain_Tree_55 = 4374,
    Terrain_Tree_56 = 4375,
    Terrain_Tree_57 = 4376,
    Terrain_Tree_58 = 4377,
    Terrain_Tree_59 = 4378,
    Terrain_Tree_60 = 4379,
    Terrain_Tree_61 = 4380,
    Terrain_Tree_62 = 4381,
    Terrain_Tree_63 = 4382,
    Terrain_Tree_64 = 4383,

    Terrain_Floor_House_1 = 6784,
    Terrain_Floor_House_2 = 6785,
    Terrain_Floor_House_3 = 6786,
    Terrain_Floor_House_4 = 6787,
    Terrain_Floor_House_5 = 6788,
    Terrain_Floor_House_6 = 6789,
    Terrain_Floor_House_7 = 6790,
    Terrain_Floor_House_8 = 6791,
    Terrain_Floor_House_9 = 6792,
    Terrain_Floor_House_10 = 6793,
    Terrain_Floor_House_11 = 6794,
    Terrain_Floor_House_12 = 6795,
    Terrain_Floor_House_13 = 6796,
    Terrain_Floor_House_14 = 6797,
    Terrain_Floor_House_15 = 6798,
    Terrain_Floor_House_16 = 6799,
    Terrain_Floor_House_17 = 6800,
    Terrain_Floor_House_18 = 6801,
    Terrain_Floor_House_19 = 6802,
    Terrain_Floor_House_20 = 6803,
    Terrain_Floor_House_21 = 6804,
    Terrain_Floor_House_22 = 6805,
    Terrain_Floor_House_23 = 6806,
    Terrain_Floor_House_24 = 6807,
    Terrain_Floor_House_25 = 6808,
    Terrain_Floor_House_26 = 6809,
    Terrain_Floor_House_27 = 6810,
    Terrain_Floor_House_28 = 6811,
    Terrain_Floor_House_29 = 6812,
    Terrain_Floor_House_30 = 6813,
    Terrain_Floor_House_31 = 6814,
    Terrain_Floor_House_32 = 6815,

    House_Wood_Wall_1 = 7040,
    House_Wood_Column_1 = 7041,
    House_Wood_Window_1 = 7042,
    House_Wood_Window_2 = 7043,
    House_Wood_Window_3 = 7044,
    House_Wood_Door_1 = 7045,
    House_Wood_Door_2 = 7046,
    House_Wood_Decoration_1 = 7047,
    House_Wood_Decoration_2 = 7048,
    House_Wood_Window_4 = 7049,
    House_Wood_Window_5 = 7050,
    House_Wood_Window_6 = 7051,

    House_Wood_Window_7 = 7052,
    House_Wood_Window_8 = 7053,
    House_Wood_Window_9 = 7054,
    House_Wood_Window_10 = 7055,
    House_Wood_Window_11 = 7056,
    House_Wood_Window_12 = 7057,
    House_Wood_Window_13 = 7058,
    House_Wood_Window_14 = 7059,
    House_Wood_Window_15 = 7060,
    House_Wood_Window_16 = 7061,
    House_Wood_Window_17 = 7062,
    House_Wood_Window_18 = 7063,
    House_Wood_Window_19 = 7064,
    House_Wood_Window_20 = 7065,
    House_Wood_Window_21 = 7066,
    House_Wood_Window_22 = 7067,
    House_Wood_Window_23 = 7068,
    House_Wood_Window_24 = 7069,
    House_Wood_Window_25 = 7070,
    House_Wood_Window_26 = 7071,


    Human_Mage_1 = 384,
    Human_Mage_2 = 385,
    Human_Mage_3 = 386,
    Human_Mage_4 = 392,
    Human_Mage_5 = 393,
    Human_Mage_6 = 394,
    Human_Mage_7 = 400,
    Human_Mage_8 = 401,
    Human_Mage_9 = 402,
    Human_Warrior_1 = 387,
    Human_Warrior_2 = 391,
    Human_Warrior_3 = 395,
    Human_Warrior_4 = 403,
    Human_Warrior_5 = 407,
    Human_Priest_1 = 388,
    Human_Priest_2 = 396,
    Human_Priest_3 = 404,
    Human_Rogue_1 = 389,
    Human_Rogue_2 = 390,
    Human_Rogue_3 = 397,
    Human_Rogue_4 = 398,
    Human_Rogue_5 = 405,
    Human_Rogue_6 = 406,

    Elf_Rogue_1 = 1450,
    Elf_Rogue_2 = 1451,
    Elf_Rogue_3 = 1452,
    Elf_Rogue_4 = 1453,
    Elf_Rogue_5 = 1454,
    Elf_Rogue_6 = 1455,

    Human_Kid_1 = 1408,
    Human_Farmer_1 = 1409,
    Human_Farmer_2 = 1428,
    Human_Farmer_3 = 1430,
    Human_Farmer_4 = 1431,
    Human_Farmer_5 = 1432,
    Human_Scout_1 = 1410,
    Human_Scout_2 = 1411,
    Human_Jester_1 = 1412,

    Monster_Rat_1 = 1688,
    Monster_Rat_2 = 1689,
    Monster_Rat_3 = 1690,
    Monster_Rat_4 = 1691,

    Monster_Snake_1 = 2061,
    Monster_Snake_2 = 2062,
    Monster_Snake_3 = 2063,
    Monster_Snake_4 = 2064,
    Monster_Snake_5 = 2065,
    Monster_Snake_6 = 2066,
    Monster_Snake_7 = 2067,
    Monster_Snake_8 = 2068,
    Monster_Snake_9 = 2069,
    Monster_Snake_10 = 2070,
    Monster_Snake_11 = 2071,
    Monster_Snake_12 = 2072,
    Monster_Snake_13 = 2073,
    Monster_Snake_14 = 2074,
    Monster_Snake_15 = 2075,
    Monster_Snake_16 = 2076,
    Monster_Snake_17 = 2077,
    Monster_Snake_18 = 2078,
    Monster_Snake_19 = 2079,
    Monster_Snake_20 = 2080,
    Monster_TriHead_1 = 2081,
    Monster_TriHead_2 = 2082,
    Monster_TriHead_3 = 2083,
    Monster_TriHead_4 = 2084,
    Monster_TriHead_5 = 2085,
    Monster_TriHead_6 = 2086,
    Monster_TriHead_7 = 2087,
    Monster_TriHead_8 = 2088,
    Monster_TriHead_9 = 2089,

    Monster_Medusa_1 = 1926,
    Monster_Medusa_2 = 1927,
    Monster_Medusa_3 = 1928,
    Monster_Medusa_4 = 1929,
    Monster_Medusa_5 = 1930,
    Monster_Medusa_6 = 1931,
    Monster_Medusa_7 = 1932,
    Monster_Medusa_8 = 1933,
    Monster_Medusa_9 = 1934,
    Monster_Medusa_10 = 1935,
    Monster_Medusa_11 = 1936,
    Monster_Medusa_12 = 1937,
    Monster_Medusa_13 = 1938,
    Monster_Medusa_14 = 1939,
    Monster_Medusa_15 = 1940,

    Monster_Thing_1 = 1941,
    Monster_Thing_2 = 1942,
    Monster_Thing_3 = 1943,
    Monster_Thing_4 = 1944,
    Monster_Thing_5 = 1945,
    Monster_Ghost_1 = 1946,
    Monster_Ghost_2 = 1947,
    Monster_Ghost_3 = 1948,
    Monster_Ghost_4 = 1949,
    Monster_Ghost_5 = 1950,
    Monster_Ghost_6 = 1951,
    Monster_Ghost_7 = 1952,
    Monster_Ghost_8 = 1953,
    Monster_Ghost_9 = 1954,
    Monster_Ghost_10 = 1955,
    Monster_Ghost_11 = 1956,
    Monster_Ghost_12 = 1957,
    Monster_Ghost_13 = 1958,
    Monster_Ghost_14 = 1959,
    Monster_Ghost_15 = 1960,

    Monster_Bug_1 = 1961,
    Monster_Bug_2 = 1962,
    Monster_Bug_3 = 1963,
    Monster_Bug_4 = 1964,
    Monster_Bug_5 = 1965,
    Monster_Bug_6 = 1966,
    Monster_Bug_7 = 1967,
    Monster_Bug_8 = 1968,
    Monster_Bug_9 = 1969,

    Monster_Spider_1 = 1970,
    Monster_Spider_2 = 1971,
    Monster_Spider_3 = 1972,
    Monster_Spider_4 = 1973,
    Monster_Spider_5 = 1974,
    Monster_Spider_6 = 1975,
    Monster_Spider_7 = 1976,

    Monster_Ant_1 = 2176,
    Monster_Ant_2 = 2177,
    Monster_Ant_3 = 2178,
    Monster_Ant_4 = 2179,
    Monster_Ant_5 = 2180,
    Monster_Ant_6 = 2181,
    Monster_Ant_7 = 2182,
    Monster_Ant_8 = 2183,

    Monster_Mummy_1 = 2224,
    Monster_Mummy_2 = 2225,
    Monster_Mummy_3 = 2226,
    Monster_Mummy_4 = 2227,
    Monster_Mummy_5 = 2228,
    Monster_Mummy_6 = 2229,
    Monster_Mummy_7 = 2230,
    Monster_Mummy_8 = 2231,

    Item_Ring_1 = 640,
    Item_Ring_2 = 641,
    Item_Ring_3 = 642,
    Item_Ring_4 = 643,
    Item_Ring_5 = 644,
    Item_Ring_6 = 645,
    Item_Ring_7 = 646,
    Item_Ring_8 = 647,
    Item_Ring_9 = 648,
    Item_Ring_10 = 649,
    Item_Ring_11 = 650,
    Item_Ring_12 = 651,
    Item_Ring_13 = 652,
    Item_Ring_14 = 653,
    Item_Ring_15 = 654,
    Item_Ring_16 = 655,
    Item_Ring_17 = 656,
    Item_Ring_18 = 657,
    Item_Ring_19 = 658,
    Item_Ring_20 = 697,
    Item_Ring_21 = 698,
    Item_Ring_22 = 699,
    Item_Ring_23 = 700,
    Item_Ring_24 = 701,
    Item_Ring_25 = 702,
    Item_Ring_26 = 703,
    Item_Ring_27 = 704,
    Item_Ring_28 = 705,
    Item_Ring_29 = 706,
    Item_Ring_30 = 707,
    Item_Ring_31 = 708,
    Item_Ring_32 = 709,
    Item_Ring_33 = 710,
    Item_Ring_34 = 711,
    Item_Ring_35 = 712,
    Item_Ring_36 = 713,
    Item_Ring_37 = 714,
    Item_Ring_38 = 715,
    Item_Ring_39 = 716,
    Item_Ring_40 = 717,
    Item_Ring_41 = 718,
    Item_Ring_42 = 719,
    Item_Ring_43 = 720,
    Item_Ring_44 = 721,
    Item_Ring_45 = 722,
    Item_Ring_46 = 723,
    Item_Ring_47 = 724,
    Item_Ring_48 = 725,
    Item_Ring_49 = 726,

    Item_Ring_Magic_1 = 659,
    Item_Ring_Magic_2 = 660,
    Item_Ring_Magic_3 = 661,
    Item_Ring_Magic_4 = 662,
    Item_Ring_Magic_5 = 663,

    Item_Necklace_1 = 664,
    Item_Necklace_2 = 665,
    Item_Necklace_3 = 666,
    Item_Necklace_4 = 667,
    Item_Necklace_5 = 668,
    Item_Necklace_6 = 669,
    Item_Necklace_7 = 670,
    Item_Necklace_8 = 671,
    Item_Necklace_9 = 672,
    Item_Necklace_10 = 673,
    Item_Necklace_11 = 674,
    Item_Necklace_12 = 675,
    Item_Necklace_13 = 676,
    Item_Necklace_14 = 677,
    Item_Necklace_15 = 678,
    Item_Necklace_16 = 679,
    Item_Necklace_17 = 683,
    Item_Necklace_18 = 684,
    Item_Necklace_19 = 685,
    Item_Necklace_20 = 686,
    Item_Necklace_21 = 687,
    Item_Necklace_22 = 688,
    Item_Necklace_23 = 689,
    Item_Necklace_24 = 690,
    Item_Necklace_25 = 691,
    Item_Necklace_26 = 692,
    Item_Necklace_27 = 693,
    Item_Necklace_28 = 694,
    Item_Necklace_29 = 695,
    Item_Necklace_30 = 696,

    Item_Diamon_1 = 680,
    Item_Diamon_2 = 727,

    Item_Perl_Green_1 = 681,
    Item_Perl_Blue_1 = 682,

    Item_Chest_1 = 896,
    Item_Chest_2 = 897,
    Item_Chest_3 = 898,
    Item_Chest_4 = 899,
    Item_Chest_5 = 900,
    Item_Chest_6 = 901,

    Item_Weapon_Sword_Broken_1 = 1280,
    Item_Weapon_Sword_Broken_2 = 1281,
    Item_Weapon_Sword_Broken_3 = 1282,
    Item_Weapon_Sword_Broken_4 = 1283,
    Item_Weapon_Sword_Broken_5 = 1284,

    Item_Weapon_Sword_1 = 1285,
    Item_Weapon_Sword_2 = 1286,
    Item_Weapon_Sword_3 = 1287,
    Item_Weapon_Sword_4 = 1288,
    Item_Weapon_Sword_5 = 1289,
    Item_Weapon_Sword_6 = 1290,
    Item_Weapon_Sword_7 = 1291,
    Item_Weapon_Sword_8 = 1292,
    Item_Weapon_Sword_9 = 1293,
    Item_Weapon_Sword_10 = 1294,
    Item_Weapon_Sword_11 = 1295,
    Item_Weapon_Sword_12 = 1296,
    Item_Weapon_Sword_Epic_13 = 1297,


    Item_Copper_1 = 903,
    Item_Silver_1 = 904,
    Item_Gold_1 = 905,
    Item_Obsidian_1 = 906,
    Item_Crystal_1 = 907,

    Food_Beer_1 = 256,
    Food_Wine_1 = 257,
    Food_Bread_1 = 258,
    Food_Bread_2 = 262,
    Food_Meat_1 = 259,
    Food_Meat_2 = 260,

    Foot_Potion_1 = 1025,
    Foot_Potion_2 = 1026,
    Foot_Potion_Poison_1 = 1027,
    Foot_Potion_3 = 1028,
    Foot_Potion_4 = 1029,
    Foot_Potion_5 = 1030,
    Foot_Potion_6 = 1031,
    Foot_Potion_7 = 1032,
    Foot_Potion_8 = 1033,
    Foot_Potion_9 = 1034,
    Foot_Potion_10 = 1035,
    Foot_Potion_Empty_1 = 1036,
    Foot_Potion_11 = 1037,
    Foot_Potion_12 = 1038,
    Foot_Potion_13 = 1039,
    Foot_Potion_14 = 1040,
    Foot_Potion_15 = 1041,
    Foot_Potion_16 = 1042,
    Foot_Potion_17 = 1043,
    Foot_Potion_18 = 1044,
    Foot_Potion_19 = 1045,
    Foot_Potion_Empty_2 = 1046,
    Foot_Potion_Empty_3 = 1047,
    Foot_Potion_Empty_4 = 1048,
    Foot_Potion_20 = 1049,
    Foot_Potion_21 = 1050,
    Foot_Potion_22 = 1051,
    Foot_Potion_23 = 1052,
    Foot_Potion_24 = 1053,
    Foot_Potion_25 = 1054,
    Foot_Potion_26 = 1055,
    Foot_Potion_27 = 1056,
    Foot_Potion_Empty_5 = 1057,
    Foot_Potion_28 = 1058,
    Foot_Potion_29 = 1059,
    Foot_Potion_30 = 1060,
    Foot_Potion_31 = 1061,
    Foot_Potion_32 = 1062,
    Foot_Potion_33 = 1063,
    Foot_Potion_34 = 1064,
    Foot_Potion_35 = 1065,
    Foot_Potion_36 = 1066,
    Foot_Potion_Empty_6 = 1067,

    Food_Mushroom_1 = 263,
    Food_Mushroom_2 = 264,
    Food_Mushroom_3 = 265,
    Food_Mushroom_4 = 266,
    Food_Mushroom_5 = 267,
    Food_Mushroom_6 = 268,
    Food_Mushroom_7 = 269,
    Food_Mushroom_8 = 270,
    Food_Mushroom_9 = 271,
    Food_Mushroom_10 = 272,
    Food_Mushroom_11 = 273,
    Food_Mushroom_12 = 274,
    Food_Mushroom_13 = 276,
    Food_Mushroom_14 = 277,
    Food_Mushroom_15 = 278,
    Food_Mushroom_16 = 279,
    Food_Mushroom_17 = 280,
    Food_Mushroom_18 = 281,
    Food_Mushroom_19 = 282,
    Food_Mushroom_20 = 283,
    Food_Mushroom_21 = 284,
    Food_Mushroom_22 = 285,
    Food_Mushroom_23 = 286,
    Food_Mushroom_24 = 287,
    Food_Mushroom_25 = 288,


    Prop_Door_Dungeon_Closed_1 = 2819,
    Prop_Door_Dungeon_Closed_2 = 2820,
    Prop_Door_Dungeon_Closed_3 = 2821,
    Prop_Door_Dungeon_Open_1 = 2822,
    Prop_Door_Dungeon_Open_2 = 2823,
    Prop_Door_Dungeon_Open_3 = 2824,
    Prop_Door_Dungeon_Broken_1 = 2825,
    Prop_Door_Dungeon_Broken_2 = 2826,
    Prop_Door_Dungeon_Broken_3 = 2827,
    Prop_Door_Shop_1 = 3977,
    Prop_Door_Tavern_1 = 3978,
    Prop_Stairs_Dungeon_Up_1 = 2828,
    Prop_Stairs_Dungeon_Up_2 = 2829,
    Prop_Stairs_Dungeon_Up_3 = 2830,
    Prop_Stairs_Dungeon_Down_1 = 2831,
    Prop_Stairs_Dungeon_Down_2 = 2832,
    Prop_Stairs_Dungeon_Down_3 = 2833,

    Human_Corpse_1 = 940,
    Human_Corpse_2 = 941,
    Human_Corpse_3 = 942,
    Human_Corpse_4 = 943,
    Human_Corpse_5 = 944,
    Human_Corpse_6 = 945,
    Human_Corpse_7 = 946,
    Human_Corpse_8 = 947,

    Animal_Bee_1 = 3456,
    Animal_Horse_1 = 3457,
    Animal_Horse_2 = 3458,
    Animal_Horse_3 = 3459,
    Animal_Deer_1 = 3460,
    Animal_Chicken_1 = 3461,
    Animal_Cow_1 = 3462,
    Animal_Donkey_1 = 3463,
    Animal_Bird_1 = 3464,
    Animal_Bird_2 = 3465,
    Animal_Bird_3 = 3466,
    Animal_Bird_4 = 3467,
    Animal_Bird_5 = 3468,
    Animal_Bird_6 = 3469,
    Animal_Bird_7 = 3470,
    Animal_Bird_8 = 3471,
    Animal_Bird_9 = 3472,
    Animal_Cat_1 = 3473,
    Animal_Cat_2 = 3474,
    Animal_Dog_1 = 3475,
    Animal_Dog_2 = 1992,
    Animal_Dog_3 = 1993,
    Animal_Dog_4 = 1994,
    Animal_Dog_5 = 1995,
    Animal_Dog_6 = 1996,
    Animal_Dog_7 = 1997,
    Animal_Dog_8 = 1998,
    Animal_Dog_9 = 1999,
    Animal_Dog_10 = 2000,
    Animal_Dog_11 = 2001,
    Animal_Dog_12 = 2002,
    Animal_Cat_3 = 3476,
    Animal_Snake_1 = 3477,
    Animal_Snake_2 = 3478,
    Animal_Cat_4 = 3479,
    Animal_Cat_5 = 3480,
    Animal_Cat_6 = 3481,
    Animal_Cat_7 = 3482,
    Animal_Cat_8 = 3483,
    Animal_Squirrel_1 = 3484,
    Animal_Turtle_1 = 3485,
    Animal_Deer_2 = 3486,
    Animal_Mouse_1 = 3487,
    Animal_Frog_1 = 3488,
    Animal_Cockroach_1 = 3489,
    Animal_Sheep_1 = 3490,
    Animal_Pig_1 = 3491,
    Animal_Fox_1 = 3492,
    Animal_Bee_2 = 3493,
    Animal_Porcupine = 3494,
}
