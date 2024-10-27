namespace BitOpz.Core.Extensions
{
    public static class ULongExtensions
    {
        #region Shift

        public static ulong ShiftLeft(this ulong value, int shift) => (ulong)(value << shift);

        public static ulong ShiftRight(this ulong value, int shift) => (ulong)(value >> shift);

        public static ulong SignShiftLeft(this ulong value, int shift) => (ulong)(((value << shift) & BitOpzConsts.QWORD_MAP_BITS) | (value & BitOpzConsts.QWORD_SIGN_BIT));

        public static ulong SignShiftRight(this ulong value, int shift) => (ulong)(((value & BitOpzConsts.QWORD_MAP_BITS) >> shift) | (value & BitOpzConsts.QWORD_SIGN_BIT));

        #endregion Shift

        #region Roll

        public static ulong RollLeft(this ulong value, int shift) => (ulong)((value << shift) | (value >> (BitOpzConsts.QWORD_BITS - shift)));

        public static ulong RollRight(this ulong value, int shift) => (ulong)((value >> shift) | (value << (BitOpzConsts.QWORD_BITS - shift)));

        public static ulong SignRollLeft(this ulong value, int shift) => (ulong)((((value << shift) | (value >> (BitOpzConsts.QWORD_BITS - shift - 1))) & BitOpzConsts.QWORD_MAP_BITS) | (value & BitOpzConsts.QWORD_SIGN_BIT));

        public static ulong SignRollRight(this ulong value, int shift) => (ulong)(((((value & BitOpzConsts.QWORD_MAP_BITS) >> shift) | (value << (BitOpzConsts.QWORD_BITS - shift - 1))) & BitOpzConsts.QWORD_MAP_BITS) | (value & BitOpzConsts.QWORD_SIGN_BIT));

        #endregion Roll

        #region Flip

        // TODO: Implement

        #endregion Flip
    }
}