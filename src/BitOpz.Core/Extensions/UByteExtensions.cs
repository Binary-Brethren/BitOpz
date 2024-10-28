namespace BitOpz.Core.Extensions
{
    public static class UByteExtensions
    {
        #region Shift

        public static byte ShiftLeft(this byte value, int shift) => (byte)(value << shift);

        public static byte ShiftRight(this byte value, int shift) => (byte)(value >> shift);

        public static byte SignShiftLeft(this byte value, int shift) => (byte)(((value << shift) & BitOpzConsts.BYTE_MASK_BITS) | (value & BitOpzConsts.BYTE_SIGN_BIT));

        public static byte SignShiftRight(this byte value, int shift) => (byte)(((value & BitOpzConsts.BYTE_MASK_BITS) >> shift) | (value & BitOpzConsts.BYTE_SIGN_BIT));

        #endregion Shift

        #region Roll

        public static byte RollLeft(this byte value, int shift) => (byte)((value << shift) | (value >> (BitOpzConsts.BYTE_BITS - shift)));

        public static byte RollRight(this byte value, int shift) => (byte)((value >> shift) | (value << (BitOpzConsts.BYTE_BITS - shift)));

        public static byte SignRollLeft(this byte value, int shift) => (byte)((((value << shift) | (value >> (BitOpzConsts.BYTE_BITS - shift - 1))) & BitOpzConsts.BYTE_MASK_BITS) | (value & BitOpzConsts.BYTE_SIGN_BIT));

        public static byte SignRollRight(this byte value, int shift) => (byte)(((((value & BitOpzConsts.BYTE_MASK_BITS) >> shift) | (value << (BitOpzConsts.BYTE_BITS - shift - 1))) & BitOpzConsts.BYTE_MASK_BITS) | (value & BitOpzConsts.BYTE_SIGN_BIT));

        #endregion Roll

        #region Flip

        /*
         * Functions marked "BitFlip" are hidden from the public API, as
         * these are non-standard endianess flips that should be hidden
         * until further validation can be done for their usecases.
         */

        internal static byte BitFlipEndian(this byte value) => (byte)((value << 4) | (value >> 4));

        internal static byte SignBitFlipEndian(this byte value) => (byte)(((value << 4) & BitOpzConsts.BYTE_MASK_BITS) | ((value & BitOpzConsts.BYTE_MASK_BITS) >> 4) | (value & BitOpzConsts.BYTE_SIGN_BIT));

        #endregion Flip
    }
}