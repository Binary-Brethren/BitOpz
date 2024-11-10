#region

using System;
using System.Runtime.InteropServices;

#endregion

namespace BitOpz.Core.Bases
{
    public partial class BitCore
    {
        #region constructors

        /*
         * Most of these constructors can die after the implementation of BitWiser (or whatever else uses this base class)
         * The primary intention for these was to ensure any extending classes have free use of construction
         * While this may not be utilized, it is worthwhile to have for easier initial implementation of extension classes
         */

        public BitCore() { }

        public BitCore(ulong value) : this() { _value.ULong = value; }

        public BitCore(byte value) : this((ulong)value) { }

        public BitCore(sbyte value) : this((ulong)value) { }

        public BitCore(ushort value) : this((ulong)value) { }

        public BitCore(short value) : this((ulong)value) { }

        public BitCore(uint value) : this((ulong)value) { }

        public BitCore(int value) : this((ulong)value) { }

        public BitCore(long value) : this((ulong)value) { }

        #endregion constructors

        // Idk if we need these yet...
        //private bool _isSigned = false;
        //public bool IsSigned => _isSigned;
        //public void SetSign(bool isSigned) => _isSigned = isSigned;

        private SignBitMap64 _value = new SignBitMap64() { ULong = 0 };

        protected void SetValue(ulong value) => _value.ULong = value;
        protected void SetValue(long value) => _value.Long = value;

        #region 64-Bit Sign Map

        [StructLayout(LayoutKind.Explicit)]
        private struct SignBitMap64
        {
            [FieldOffset(0)] private ulong _ulong;

            [FieldOffset(0)] private long _long;

            public long Long
            {
                get { return _long; }
                set { _long = value; }
            }

            public ulong ULong
            {
                get { return _ulong; }
                set { _ulong = value; }
            }
        }

        #endregion

        #region Value Retrieval

        /*
         * The goal here is to have a sort of .ToString() for anything wishing to get the _value
         * This should be the only interation for retrieving the value --> safety + extensibility
         */

        public ulong AsULong() { return _value.ULong; }

        public long AsLong() { return _value.Long; }

        public uint AsUInt() { return AsUInt(1); }

        public uint AsUInt(int bitSplit)
        {
            if ((bitSplit > 1) || // Too large for high split
                (bitSplit < 0)) // Too small for low split
            {
                throw new ArgumentOutOfRangeException($"{nameof(bitSplit)} must be between 0 (low) and 1 (high) int-set");
            }

            return (uint)(_value.ULong >> ((1 - bitSplit) * 32));
        }

        public int AsInt() { return (int)AsInt(1); }

        public int AsInt(int bitSplit)
        {
            if ((bitSplit > 1) || // Too large for high split
                (bitSplit < 0)) // Too small for low split
            {
                throw new ArgumentOutOfRangeException($"{nameof(bitSplit)} must be between 0 (low) and 1 (high) int-set");
            }

            return (int)(_value.ULong >> ((1 - bitSplit) * 32));
        }

        public ushort AsUShort() { return AsUShort(3); }

        public ushort AsUShort(int bitSplit)
        {
            if ((bitSplit > 3) || // Too large for high split
                (bitSplit < 0)) // Too small for low split
            {
                throw new ArgumentOutOfRangeException($"{nameof(bitSplit)} must be between 0 (low) and 3 (high) short-set");
            }

            return (ushort)(_value.ULong >> ((3 - bitSplit) * 16));
        }

        public short AsShort() { return (short)AsShort(3); }

        public short AsShort(int bitSplit)
        {
            if ((bitSplit > 3) || // Too large for high split
                (bitSplit < 0)) // Too small for low split
            {
                throw new ArgumentOutOfRangeException($"{nameof(bitSplit)} must be between 0 (low) and 3 (high) short-set");
            }

            return (short)(_value.ULong >> ((3 - bitSplit) * 16));
        }

        public byte AsUByte() { return AsUByte(7); }

        public byte AsUByte(int bitSplit)
        {
            if ((bitSplit > 7) || // Too large for high split
                (bitSplit < 0)) // Too small for low split
            {
                throw new ArgumentOutOfRangeException($"{nameof(bitSplit)} must be between 0 (low) and 7 (high) byte-set");
            }

            return (byte)(_value.ULong >> ((7 - bitSplit) * 8));
        }

        public sbyte AsSByte() { return (sbyte)AsSByte(7); }

        public sbyte AsSByte(int bitSplit)
        {
            if ((bitSplit > 7) || // Too large for high split
                (bitSplit < 0)) // Too small for low split
            {
                throw new ArgumentOutOfRangeException($"{nameof(bitSplit)} must be between 0 (low) and 7 (high) byte-set");
            }

            return (sbyte)(_value.ULong >> ((7 - bitSplit) * 8));
        }

        #endregion Value Retrieval
    }
}
