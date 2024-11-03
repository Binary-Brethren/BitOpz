namespace BitOpz.Core.Extensions
{
    public static class UIntExtensions
    {
        #region Shift

        public static uint ShiftLeft(this uint value, int shift) => (uint)(value << shift);

        public static uint ShiftRight(this uint value, int shift) => (uint)(value >> shift);

        public static uint SignShiftLeft(this uint value, int shift) => (uint)(((value << shift) & BitOpzConsts.DWORD_MASK_BITS) | (value & BitOpzConsts.DWORD_SIGN_BIT));

        public static uint SignShiftRight(this uint value, int shift) => (uint)(((value & BitOpzConsts.DWORD_MASK_BITS) >> shift) | (value & BitOpzConsts.DWORD_SIGN_BIT));

        #endregion Shift

        #region Roll

        public static uint RollLeft(this uint value, int shift) => (uint)((value << shift) | (value >> (BitOpzConsts.DWORD_BITS - shift)));

        public static uint RollRight(this uint value, int shift) => (uint)((value >> shift) | (value << (BitOpzConsts.DWORD_BITS - shift)));

        public static uint SignRollLeft(this uint value, int shift) => (uint)((((value << shift) | (value >> (BitOpzConsts.DWORD_BITS - shift - 1))) & BitOpzConsts.DWORD_MASK_BITS) | (value & BitOpzConsts.DWORD_SIGN_BIT));

        public static uint SignRollRight(this uint value, int shift) => (uint)(((((value & BitOpzConsts.DWORD_MASK_BITS) >> shift) | (value << (BitOpzConsts.DWORD_BITS - shift - 1))) & BitOpzConsts.DWORD_MASK_BITS) | (value & BitOpzConsts.DWORD_SIGN_BIT));

        #endregion Roll

        #region Flip


        public static uint FlipEndian(this uint value) => (uint)((value & BitOpzConsts.DWORD_LL_MASK) << BitOpzConsts.DWORD_H_MOV) | ((value & BitOpzConsts.DWORD_LH_MASK) << BitOpzConsts.DWORD_L_MOV) | ((value & BitOpzConsts.DWORD_HL_MASK) >> BitOpzConsts.DWORD_L_MOV) | ((value & BitOpzConsts.DWORD_HH_MASK) >> BitOpzConsts.DWORD_H_MOV);


        #endregion Flip
    }
}
