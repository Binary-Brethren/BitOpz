namespace BitOpz.Core.Extensions
{
    public static class UShortExtensions
    {
        #region Shift

        public static ushort ShiftLeft(this ushort value, int shift) => (ushort)(value << shift);

        public static ushort ShiftRight(this ushort value, int shift) => (ushort)(value >> shift);

        public static ushort SignShiftLeft(this ushort value, int shift) => (ushort)(((value << shift) & BitOpzConsts.WORD_MAP_BITS) | (value & BitOpzConsts.WORD_SIGN_BIT));

        public static ushort SignShiftRight(this ushort value, int shift) => (ushort)(((value & BitOpzConsts.WORD_MAP_BITS) >> shift) | (value & BitOpzConsts.WORD_SIGN_BIT));

        #endregion Shift

        #region Roll

        public static ushort RollLeft(this ushort value, int shift) => (ushort)((value << shift) | (value >> (BitOpzConsts.WORD_BITS - shift)));

        public static ushort RollRight(this ushort value, int shift) => (ushort)((value >> shift) | (value << (BitOpzConsts.WORD_BITS - shift)));

        public static ushort SignRollLeft(this ushort value, int shift) => (ushort)((((value << shift) | (value >> (BitOpzConsts.WORD_BITS - shift - 1))) & BitOpzConsts.WORD_MAP_BITS) | (value & BitOpzConsts.WORD_SIGN_BIT));

        public static ushort SignRollRight(this ushort value, int shift) => (ushort)(((((value & BitOpzConsts.WORD_MAP_BITS) >> shift) | (value << (BitOpzConsts.WORD_BITS - shift - 1))) & BitOpzConsts.WORD_MAP_BITS) | (value & BitOpzConsts.WORD_SIGN_BIT));

        #endregion Roll

        #region Flip

        // TODO: Implement

        #endregion Flip
    }
}