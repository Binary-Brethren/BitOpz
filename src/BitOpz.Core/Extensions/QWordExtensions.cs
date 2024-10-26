using System;

namespace BitOpz.Core.Extensions
{
    public static class QWordExtensions
    {
        #region Unsigned

        public static UInt64 ShiftLeft(this UInt64 value, int shift) => (UInt64)(value << shift);

        public static UInt64 ShiftRight(this UInt64 value, int shift) => (UInt64)(value >> shift);

        public static UInt64 RollLeft(this UInt64 value, int shift) => (UInt64)((value << shift) | (value >> (BitOpzConsts.QWORD_BITS - shift)));

        public static UInt64 RollRight(this UInt64 value, int shift) => (UInt64)((value >> shift) | (value << (BitOpzConsts.QWORD_BITS - shift)));

        #endregion Unsigned

        #region Signed

        public static Int64 ShiftLeft(this Int64 value, int shift) => (Int64)(value << shift);

        public static Int64 ShiftRight(this Int64 value, int shift) => (Int64)(value >> shift);

        public static Int64 RollLeft(this Int64 value, int shift) => (Int64)((value << shift) | (value >> (BitOpzConsts.QWORD_BITS - shift)));

        public static Int64 RollRight(this Int64 value, int shift) => (Int64)((value >> shift) | (value << (BitOpzConsts.QWORD_BITS - shift)));

        #endregion Signed
    }
}