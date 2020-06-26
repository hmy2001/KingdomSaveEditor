﻿using Xe.BinaryMapper;

namespace KHSave.LibPersona5
{
    internal class Persona5Royal : ISavePersona5
    {
        [Data(Count = 256 * 1024)] public byte[] Data { get; set; }

        [Data(0x357c)] public int Money { get; set; }
    }
}