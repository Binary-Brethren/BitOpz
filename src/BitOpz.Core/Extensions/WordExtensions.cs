using System;

namespace BitOpz.Core.Extensions
{
    public static class WordExtensions
    {
        #region Unsigned

        public static UInt16 ShiftLeft(this UInt16 value, int shift) => (UInt16)(value << shift);

        public static UInt16 ShiftRight(this UInt16 value, int shift) => (UInt16)(value >> shift);

        public static UInt16 RollLeft(this UInt16 value, int shift) => (UInt16)((value << shift) | (value >> (BitOpzConsts.WORD_BITS - shift)));

        public static UInt16 RollRight(this UInt16 value, int shift) => (UInt16)((value >> shift) | (value << (BitOpzConsts.WORD_BITS - shift)));

        #endregion Unsigned

        #region Signed

        public static Int16 ShiftLeft(this Int16 value, int shift) => (Int16)(value << shift);

        public static Int16 ShiftRight(this Int16 value, int shift) => (Int16)(value >> shift);

        public static Int16 RollLeft(this Int16 value, int shift) => (Int16)((value << shift) | (value >> (BitOpzConsts.WORD_BITS - shift)));

        public static Int16 RollRight(this Int16 value, int shift) => (Int16)((value >> shift) | (value << (BitOpzConsts.WORD_BITS - shift)));

        #endregion Signed
    }
}