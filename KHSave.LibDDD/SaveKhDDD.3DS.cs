using KHSave.LibDDD.Types;
using System;
using System.IO;
using Xe.BinaryMapper;
using KHSave.LibDDD.Model;

// A thank you to Hollow_Dragonite, darkmanwe4ever, Bweep, delebile  and all the other people who found parts of the values
// https://gbatemp.net/threads/kingdom-hearts-3d-dream-drop-distance-save-hack.398408/

namespace KHSave.LibDDD
{
    public partial class SaveKhDDD
    {
        public class SaveKhDDD3DS : ISaveKhDDD
        {
            [Data(0, 0x163FF)] public byte[] Data { get; set; }
            [Data(0x10)] public uint GameTimeLoading { get; set; }
            [Data(0x20)] public DifficultyType DifficultyLoading { get; set; }
            [Data(0x28)] public uint SoraXpLoading { get; set; }
            [Data(0x92)] public DifficultyType Difficulty { get; set; }
            [Data(0x94)] public WorldType WorldId { get; set; }
            [Data] public byte RoomId { get; set; }
            [Data] public byte SpawnId { get; set; }
            [Data(0x98)] public uint GameTime { get; set; }
            //3 in party and 99 on the bank
            [Data(0x53a0, Count = 102)] public DreamEater[] DreamEaters { get; set; }

            [Data(0xBFE0, Count = 511)] public CommandEntry[] CommandInventory { get; set; }

            //SoraXp max value 786680?
            [Data(0xd1cc)] public uint SoraXp { get; set; }
            [Data(0xd1e0)] public ushort SoraDroplets { get; set; }
            [Data(0xd1f0)] public byte SoraLv { get; set; }

            //RikuXp max value 786680?
            [Data(0xd248)] public uint RikuXp { get; set; }
            [Data(0xd25c)] public ushort RikuDroplets { get; set; }
            [Data(0xd26c)] public byte RikuLv { get; set; }
            [Data(0xd2c4)] public EquipmentType SoraKeyblade { get; set; }
            [Data(0xd2c6)] public EquipmentType RikuKeyblade { get; set; }
            //Munny max value 999999?
            [Data(0xd2c8)] public uint Munny { get; set; }
            [Data(0xd2f0, Count = 3)] public Deck[] SoraDecks { get; set; }
            [Data(0xd5fc, Count = 3)] public Deck[] RikuDecks { get; set; }

            IDeck[] ISaveKhDDD.SoraDecks => Array.ConvertAll(SoraDecks, x => (IDeck)x);
            IDeck[] ISaveKhDDD.RikuDecks => Array.ConvertAll(SoraDecks, x => (IDeck)x);

            public void Write(Stream stream) =>
                BinaryMapping.WriteObject(stream.FromBegin(), this);
        }
    }
}
