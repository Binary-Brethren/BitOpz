namespace BitOpz.Core.Extensions
{
    public static class UIntExtensions
    {
        #region Unsigned

        public static uint ShiftLeft(this uint value, int shift) => (uint)(value << shift);

        public static uint ShiftRight(this uint value, int shift) => (uint)(value >> shift);

        public static uint RollLeft(this uint value, int shift) => (uint)((value << shift) | (value >> (BitOpzConsts.DWORD_BITS - shift)));

        public static uint RollRight(this uint value, int shift) => (uint)((value >> shift) | (value << (BitOpzConsts.DWORD_BITS - shift)));

        #endregion Unsigned

        #region Signed

        public static uint SignShiftLeft(this uint value, int shift) => (uint)(((value << shift) & BitOpzConsts.DWORD_MAP_BITS) | (value & BitOpzConsts.DWORD_SIGN_BIT));

        public static uint SignShiftRight(this uint value, int shift) => (uint)(((value & BitOpzConsts.DWORD_MAP_BITS) >> shift) | (value & BitOpzConsts.DWORD_SIGN_BIT));

        public static uint SignRollLeft(this uint value, int shift) => (uint)((((value << shift) | (value >> (BitOpzConsts.DWORD_BITS - shift - 1))) & BitOpzConsts.DWORD_MAP_BITS) | (value & BitOpzConsts.DWORD_SIGN_BIT));

        public static uint SignRollRight(this uint value, int shift) => (uint)(((((value & BitOpzConsts.DWORD_MAP_BITS) >> shift) | (value << (BitOpzConsts.DWORD_BITS - shift - 1))) & BitOpzConsts.DWORD_MAP_BITS) | (value & BitOpzConsts.DWORD_SIGN_BIT));

        #endregion Signed
    }
}