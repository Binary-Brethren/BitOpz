using System;

namespace BitOpz.Core.Extensions
{
    public static class DWordExtensions
    {
        #region Unsigned

        public static UInt32 ShiftLeft(this UInt32 value, int shift) => (UInt32)(value << shift);

        public static UInt32 ShiftRight(this UInt32 value, int shift) => (UInt32)(value >> shift);

        public static UInt32 RollLeft(this UInt32 value, int shift) => (UInt32)((value << shift) | (value >> (BitOpzConsts.DWORD_BITS - shift)));

        public static UInt32 RollRight(this UInt32 value, int shift) => (UInt32)((value >> shift) | (value << (BitOpzConsts.DWORD_BITS - shift)));

        #endregion Unsigned

        #region Signed

        public static Int32 ShiftLeft(this Int32 value, int shift) => (Int32)(value << shift);

        public static Int32 ShiftRight(this Int32 value, int shift) => (Int32)(value >> shift);

        public static Int32 RollLeft(this Int32 value, int shift) => (Int32)((value << shift) | (value >> (BitOpzConsts.DWORD_BITS - shift)));

        public static Int32 RollRight(this Int32 value, int shift) => (Int32)((value >> shift) | (value << (BitOpzConsts.DWORD_BITS - shift)));

        #endregion Signed
    }
}