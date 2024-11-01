using System;

namespace BitOpz.Core.Bases
{
    public partial class BitCore
    {
        private bool _isSigned = false;
        private ulong _value = 0;
        public bool IsSigned => _isSigned;

        public void SetSign(bool isSigned) => _isSigned = isSigned;

        public void SetValue(ulong value) => _value = value;

        /*
         * Most of these constructors can die after the implementation of BitWiser (or whatever else uses this base class)
         * The primary intention for these was to ensure any extending classes have free use of construction
         * While this may not be utilized, it is worthwhile to have for easier initial implementation of extension classes
         */

        public BitCore()
        { }

        public BitCore(ulong value) : this()
        { _value = value; }

        public BitCore(byte value) : this((ulong)value)
        { }

        public BitCore(sbyte value) : this((ulong)value)
        { }

        public BitCore(ushort value) : this((ulong)value)
        { }

        public BitCore(short value) : this((ulong)value)
        { }

        public BitCore(uint value) : this((ulong)value)
        { }

        public BitCore(int value) : this((ulong)value)
        { }

        public BitCore(long value) : this((ulong)value)
        { }

        #region Value Retrieval

        /*
         * The goal here is to have a sort of .ToString() for anything wishing to get the _value
         * This should be the only interation for retrieving the value --> safety + extensibility
         */

        public ulong AsULong()
        { return _value; }

        public long AsLong()
        { return (long)_value; }

        public uint AsUInt()
        { return AsUInt(0); }

        public uint AsUInt(int bitSplit)
        {
            if ((bitSplit > 1) || // Too large for high split
                (bitSplit < 0)) // Too small for low split
            { throw new ArgumentOutOfRangeException($"{nameof(bitSplit)} must be between 0 (low) and 1 (high) int-set"); }
            return (uint)(_value >> (bitSplit * 32));
        }

        public int AsInt()
        { return (int)AsUInt(0); }

        public int AsInt(int bitSplit)
        {
            if ((bitSplit > 1) || // Too large for high split
                (bitSplit < 0)) // Too small for low split
            { throw new ArgumentOutOfRangeException($"{nameof(bitSplit)} must be between 0 (low) and 1 (high) int-set"); }
            return (int)(_value >> (bitSplit * 32));
        }

        public ushort AsUShort()
        { return AsUShort(0); }

        public ushort AsUShort(int bitSplit)
        {
            if ((bitSplit > 3) || // Too large for high split
                (bitSplit < 0)) // Too small for low split
            { throw new ArgumentOutOfRangeException($"{nameof(bitSplit)} must be between 0 (low) and 3 (high) short-set"); }
            return (ushort)(_value >> (bitSplit * 16));
        }

        public short AsShort()
        { return (short)AsShort(0); }

        public short AsShort(int bitSplit)
        {
            if ((bitSplit > 3) || // Too large for high split
                (bitSplit < 0)) // Too small for low split
            { throw new ArgumentOutOfRangeException($"{nameof(bitSplit)} must be between 0 (low) and 3 (high) short-set"); }
            return (short)(_value >> (bitSplit * 16));
        }

        public byte AsUByte()
        { return AsUByte(0); }

        public byte AsUByte(int bitSplit)
        {
            if ((bitSplit > 7) || // Too large for high split
                (bitSplit < 0)) // Too small for low split
            { throw new ArgumentOutOfRangeException($"{nameof(bitSplit)} must be between 0 (low) and 7 (high) byte-set"); }
            return (byte)(_value >> (bitSplit * 8));
        }

        public sbyte AsSByte()
        { return (sbyte)AsSByte(0); }

        public sbyte AsSByte(int bitSplit)
        {
            if ((bitSplit > 7) || // Too large for high split
                (bitSplit < 0)) // Too small for low split
            { throw new ArgumentOutOfRangeException($"{nameof(bitSplit)} must be between 0 (low) and 7 (high) byte-set"); }
            return (sbyte)(_value >> (bitSplit * 8));
        }

        #endregion Value Retrieval
    }
}