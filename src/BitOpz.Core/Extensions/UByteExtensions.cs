namespace BitOpz.Core.Extensions
{
    public static class UByteExtensions
    {
        #region Unsigned

        public static byte ShiftLeft(this byte value, int shift) => (byte)(value << shift);

        public static byte ShiftRight(this byte value, int shift) => (byte)(value >> shift);

        public static byte RollLeft(this byte value, int shift) => (byte)((value << shift) | (value >> (BitOpzConsts.BYTE_BITS - shift)));

        public static byte RollRight(this byte value, int shift) => (byte)((value >> shift) | (value << (BitOpzConsts.BYTE_BITS - shift)));

        #endregion Unsigned

        #region Signed

        public static byte SignShiftLeft(this byte value, int shift) => (byte)(((value << shift) & BitOpzConsts.BYTE_MAP_BITS) | (value & BitOpzConsts.BYTE_SIGN_BIT));

        public static byte SignShiftRight(this byte value, int shift) => (byte)(((value & BitOpzConsts.BYTE_MAP_BITS) >> shift) | (value & BitOpzConsts.BYTE_SIGN_BIT));

        public static byte SignRollLeft(this byte value, int shift) => (byte)((((value << shift) | (value >> (BitOpzConsts.BYTE_BITS - shift - 1))) & BitOpzConsts.BYTE_MAP_BITS) | (value & BitOpzConsts.BYTE_SIGN_BIT));

        public static byte SignRollRight(this byte value, int shift) => (byte)(((((value & BitOpzConsts.BYTE_MAP_BITS) >> shift) | (value << (BitOpzConsts.BYTE_BITS - shift - 1))) & BitOpzConsts.BYTE_MAP_BITS) | (value & BitOpzConsts.BYTE_SIGN_BIT));

        #endregion Signed
    }
}