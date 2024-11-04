namespace BitOpz.Core.Models
{
    internal interface IBitWizerSave
    {
        (ulong RawValue, object ReturnValue) GetSave();
    }

    internal readonly struct BitWizerHistory<T> : IBitWizerSave where T : unmanaged
    {
        public readonly ulong RawValue;
        public readonly T ReturnValue;

        public BitWizerHistory(ulong rawValue, T returnValue)
        {
            RawValue = rawValue;
            ReturnValue = returnValue;
        }

        public (ulong RawValue, object ReturnValue) GetSave() => (RawValue, ReturnValue);
    }
}