﻿using System.Collections.Generic;

namespace SysBot.Pokemon
{
    /// <summary>
    /// Pokémon Scarlet/Violet RAM offsets
    /// </summary>
    public class PokeDataOffsetsSV
    {
     public const string SVGameVersion = "2.0.1";
        public const string ScarletID = "0100A3D008C5C000";
        public const string VioletID = "01008F6008C5E000";
        public IReadOnlyList<long> BoxStartPokemonPointer { get; } = new long[] { 0x46445E8, 0xA90, 0x9D0, 0x0 };
        public IReadOnlyList<long> LinkTradePartnerPokemonPointer { get; } = new long[] { 0x461AE58, 0x48, 0x58, 0x40, 0x148 };
        public IReadOnlyList<long> LinkTradePartnerNIDPointer { get; } = new long[] { 0x45DF450, 0x58, 0x70, 0x98 };
        public IReadOnlyList<long> MyStatusPointer { get; } = new long[] { 0x46447C8, 0xA0, 0x40 };
        public IReadOnlyList<long> Trader1MyStatusPointer { get; } = new long[] { 0x461AE58, 0x48, 0xB0, 0x0 }; // The trade partner status uses a compact struct that looks like MyStatus.
        public IReadOnlyList<long> Trader2MyStatusPointer { get; } = new long[] { 0x461AE58, 0x48, 0xE0, 0x0 };
        public IReadOnlyList<long> ConfigPointer { get; } = new long[] { 0x46447D8, 0x20, 0x90 };
        public IReadOnlyList<long> CurrentBoxPointer { get; } = new long[] { 0x46445E8, 0x1490, 0x570 };
        public IReadOnlyList<long> PortalBoxStatusPointer { get; } = new long[] { 0x463AB58, 0x130, 0x568, 0xF0, 0x100, 0xC8 };  // 9-A in portal, 4-6 in box.
        public IReadOnlyList<long> IsConnectedPointer { get; } = new long[] { 0x4644948, 0x10 };
        public IReadOnlyList<long> OverworldPointer { get; } = new long[] { 0x4644870, 0x348, 0x10, 0xD8, 0x28 };

       public const int BoxFormatSlotSize = 0x158;
        public const ulong LibAppletWeID = 0x010000000000100a; // One of the process IDs for the news.

        public IReadOnlyList<long> TeraRaidCodePointer { get; } = new long[] { 0x44DFCA8, 0x10, 0x78, 0x10, 0x1A9 };
        public IReadOnlyList<long> TeraRaidBlockPointer { get; } = new long[] { 0x44C1C18, 0x180, 0x40 };
        public IReadOnlyList<long> CollisionPointer { get; } = new long[] { 0x45069E0, 0x28, 0x48, 0x0, 0x08, 0x80 };
        public IReadOnlyList<long> PlayerOnMountPointer { get; } = new long[] { 0x45069E0, 0x28, 0x48, 0x0, 0x08, 0x70 };
        public IReadOnlyList<long> MobilityPointer { get; } = new long[] { 0x44E4E00, 0x60, 0x0, 0xB8, 0x20 };
        public IReadOnlyList<long> BlockKeyPointer = new long[] { 0x44B71A8, 0xD8, 0x0, 0x0, 0x30, 0x0 };
        public IReadOnlyList<long> TextBoxPointer { get; } = new long[] { 0x44E73B0, 0x10, 0x670, 0x6D8, 0x30 };
        public uint EggData = 0x044C3348;
        public ulong TeraLobbyIsConnected { get; } = 0x04176430;
        public ulong LoadedIntoDesiredState { get; } = 0x04553020;
    }
}
