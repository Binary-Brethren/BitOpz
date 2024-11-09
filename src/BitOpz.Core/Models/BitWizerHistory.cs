#region

using BitOpz.Core.Enums;

#endregion

namespace BitOpz.Core.Models
{
    internal interface IBitWizerSave
    {
        public BitWizerHistory GetSave();
    }

    internal readonly struct BitWizerSave<T> : IBitWizerSave where T : unmanaged
    {
        private readonly T _aActionValue;
        private readonly T _bActionValue;
        private readonly ulong _rawResultValue;
        private readonly T _typedResultValue;
        private readonly BitWizerHistoryEnums.BitWizerAction _actionKind;
        private readonly BitWizerHistoryEnums.BitWizerResult _resultKind;

        public BitWizerSave(T aActionValue, T bActionValue, ulong rawResultValue, T typedResultValue, BitWizerHistoryEnums.BitWizerAction actionKind, BitWizerHistoryEnums.BitWizerResult resultKind)
        { // Simple construction: e.g. new( a, b, AsUlong, AsUShort, AND, STORE )
            _aActionValue = aActionValue;
            _bActionValue = bActionValue;
            _rawResultValue = rawResultValue;
            _typedResultValue = typedResultValue;
            _actionKind = actionKind;
            _resultKind = resultKind;
        }

        public BitWizerSave(T aActionValue, BitWizerHistoryEnums.BitWizerAction actionKind, T bActionValue, ulong rawResultValue, BitWizerHistoryEnums.BitWizerResult resultKind, T typedResultValue)
        { // Logical construction: e.g. new( a, AND, b, AsUlong, STORE, AsUShort )
            _aActionValue = aActionValue;
            _actionKind = actionKind;
            _bActionValue = bActionValue;
            _rawResultValue = rawResultValue;
            _resultKind = resultKind;
            _typedResultValue = typedResultValue;
        }

        public BitWizerHistory GetSave() => new BitWizerHistory() { AActionValue = _aActionValue, BActionValue = _bActionValue, RawResultValue = _rawResultValue, TypedResultValue = _typedResultValue, ActionKind = _actionKind, ResultKind = _resultKind };
    };

    public class BitWizerHistory
    {
        public object AActionValue { get; set; }
        public object BActionValue { get; set; }
        public ulong RawResultValue { get; set; }
        public object TypedResultValue { get; set; }
        public BitWizerHistoryEnums.BitWizerAction ActionKind { get; set; }
        public BitWizerHistoryEnums.BitWizerResult ResultKind { get; set; }
    }
}
