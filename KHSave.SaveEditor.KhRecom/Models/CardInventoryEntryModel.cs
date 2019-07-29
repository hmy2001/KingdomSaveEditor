﻿using KHSave.Attributes;
using KHSave.LibRecom.Types;
using KHSave.SaveEditor.Common.Models;
using KHSave.SaveEditor.KhRecom.Interfaces;

namespace KHSave.SaveEditor.KhRecom.Models
{
    public class CardInventoryEntryModel : EnumIconTypeModel<Card>
    {
        private readonly ICardCountService cardCountService;

        public CardInventoryEntryModel(Card card, ICardCountService cardCountService)
        {
            Name = InfoAttribute.GetInfo(card);
            Value = card;
            this.cardCountService = cardCountService;
        }

        public byte CountValue0 { get => GetCount(0); set => SetCount(0, value); }
        public byte CountValue1 { get => GetCount(1); set => SetCount(1, value); }
        public byte CountValue2 { get => GetCount(2); set => SetCount(2, value); }
        public byte CountValue3 { get => GetCount(3); set => SetCount(3, value); }
        public byte CountValue4 { get => GetCount(4); set => SetCount(4, value); }
        public byte CountValue5 { get => GetCount(5); set => SetCount(5, value); }
        public byte CountValue6 { get => GetCount(6); set => SetCount(6, value); }
        public byte CountValue7 { get => GetCount(7); set => SetCount(7, value); }
        public byte CountValue8 { get => GetCount(8); set => SetCount(8, value); }
        public byte CountValue9 { get => GetCount(9); set => SetCount(9, value); }

        public string CountTotal =>
            $"{CountValue0} {CountValue1} {CountValue2} {CountValue3} {CountValue4} {CountValue5} {CountValue6} {CountValue7} {CountValue8} {CountValue9}";

        private byte GetCount(CardIndex index) => cardCountService.GetCardCount(Value, index, false);
        private void SetCount(CardIndex index, byte value)
        {
            cardCountService.SetCardCount(Value, index, false, value);
            OnPropertyChanged(nameof(CountTotal));
        }
    }
}
