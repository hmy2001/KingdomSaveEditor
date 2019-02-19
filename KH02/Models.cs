﻿/*
    Kingdom Hearts 0.2 and 3 Save Editor
    Copyright (C) 2019  Luciano Ciccariello

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using KHSave.Attributes;

namespace KHSave
{
	public class PhotoEntry
	{
		[Data] public int Length { get; set; }

		[Data(Count = 0x19000)] public byte[] Data { get; set; }
	}

	public class PlayableCharacter
	{
		[Data] public int Hp { get; set; }
		[Data] public int Mp { get; set; }
		[Data] public int Focus { get; set; }

		public override string ToString()
		{
			return $"HP {Hp} MP {Mp}";
		}
	}

	public class ShortcutGroup
	{
		[Data] public int Circle { get; set; }
		[Data] public int Triangle { get; set; }
		[Data] public int Square { get; set; }
		[Data] public int Cross { get; set; }
	}

	public class Weapon
	{
		[Data] public int Id { get; set; }
		[Data] public int Unknown { get; set; }
	}
}