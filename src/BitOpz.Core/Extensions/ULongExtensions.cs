namespace BitOpz.Core.Extensions
{
    public static class ULongExtensions
    {
        #region Shift

        public static ulong ShiftLeft(this ulong value, int shift) => (ulong)(value << shift);

        public static ulong ShiftRight(this ulong value, int shift) => (ulong)(value >> shift);

        public static ulong SignShiftLeft(this ulong value, int shift) => (ulong)(((value << shift) & BitOpzConsts.QWORD_MASK_BITS) | (value & BitOpzConsts.QWORD_SIGN_BIT));

        public static ulong SignShiftRight(this ulong value, int shift) => (ulong)(((value & BitOpzConsts.QWORD_MASK_BITS) >> shift) | (value & BitOpzConsts.QWORD_SIGN_BIT));

        #endregion Shift

        #region Roll

        public static ulong RollLeft(this ulong value, int shift) => (ulong)((value << shift) | (value >> (BitOpzConsts.QWORD_BITS - shift)));

        public static ulong RollRight(this ulong value, int shift) => (ulong)((value >> shift) | (value << (BitOpzConsts.QWORD_BITS - shift)));

        public static ulong SignRollLeft(this ulong value, int shift) => (ulong)((((value << shift) | (value >> (BitOpzConsts.QWORD_BITS - shift - 1))) & BitOpzConsts.QWORD_MASK_BITS) | (value & BitOpzConsts.QWORD_SIGN_BIT));

        public static ulong SignRollRight(this ulong value, int shift) => (ulong)(((((value & BitOpzConsts.QWORD_MASK_BITS) >> shift) | (value << (BitOpzConsts.QWORD_BITS - shift - 1))) & BitOpzConsts.QWORD_MASK_BITS) | (value & BitOpzConsts.QWORD_SIGN_BIT));

        #endregion Roll

        #region Flip


        public static ulong FlipEndian(this ulong value) => (ulong)((value & BitOpzConsts.QWORD_LLL_MASK) << BitOpzConsts.QWORD_HH_MOV) | ((value & BitOpzConsts.QWORD_LLH_MASK) << BitOpzConsts.QWORD_HL_MOV) | ((value & BitOpzConsts.QWORD_LHL_MASK) << BitOpzConsts.QWORD_LH_MOV) | ((value & BitOpzConsts.QWORD_LHH_MASK) << BitOpzConsts.QWORD_LL_MOV) | ((value & BitOpzConsts.QWORD_HLL_MASK) >> BitOpzConsts.QWORD_LL_MOV) | ((value & BitOpzConsts.QWORD_HLH_MASK) >> BitOpzConsts.QWORD_LH_MOV) | ((value & BitOpzConsts.QWORD_HHL_MASK) >> BitOpzConsts.QWORD_HL_MOV) | ((value & BitOpzConsts.QWORD_HHH_MASK) >> BitOpzConsts.QWORD_HH_MOV);


        #endregion Flip
    }
}
