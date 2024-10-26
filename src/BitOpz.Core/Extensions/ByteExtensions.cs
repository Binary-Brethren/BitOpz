namespace BitOpz.Core.Extensions
{
    public static class ByteExtensions
    {
        public static byte ShiftLeft(this byte value, int shift) => (byte)(value << shift);

        public static byte ShiftRight(this byte value, int shift) => (byte)(value >> shift);

        public static byte RollLeft(this byte value, int shift) => (byte)((value << shift) | (value >> (BitOpzConsts.BYTE_BITS - shift)));

        public static byte RollRight(this byte value, int shift) => (byte)((value >> shift) | (value << (BitOpzConsts.BYTE_BITS - shift)));
    }
}