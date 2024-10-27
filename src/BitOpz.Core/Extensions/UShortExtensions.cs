namespace BitOpz.Core.Extensions
{
    public static class UShortExtensions
    {
        #region Unsigned

        public static ushort ShiftLeft(this ushort value, int shift) => (ushort)(value << shift);

        public static ushort ShiftRight(this ushort value, int shift) => (ushort)(value >> shift);

        public static ushort RollLeft(this ushort value, int shift) => (ushort)((value << shift) | (value >> (BitOpzConsts.WORD_BITS - shift)));

        public static ushort RollRight(this ushort value, int shift) => (ushort)((value >> shift) | (value << (BitOpzConsts.WORD_BITS - shift)));

        #endregion Unsigned

        #region Signed

        public static ushort SignShiftLeft(this ushort value, int shift) => (ushort)(((value << shift) & BitOpzConsts.WORD_MAP_BITS) | (value & BitOpzConsts.WORD_SIGN_BIT));

        public static ushort SignShiftRight(this ushort value, int shift) => (ushort)(((value & BitOpzConsts.WORD_MAP_BITS) >> shift) | (value & BitOpzConsts.WORD_SIGN_BIT));

        public static ushort SignRollLeft(this ushort value, int shift) => (ushort)((((value << shift) | (value >> (BitOpzConsts.WORD_BITS - shift - 1))) & BitOpzConsts.WORD_MAP_BITS) | (value & BitOpzConsts.WORD_SIGN_BIT));

        public static ushort SignRollRight(this ushort value, int shift) => (ushort)(((((value & BitOpzConsts.WORD_MAP_BITS) >> shift) | (value << (BitOpzConsts.WORD_BITS - shift - 1))) & BitOpzConsts.WORD_MAP_BITS) | (value & BitOpzConsts.WORD_SIGN_BIT));

        #endregion Signed
    }
}