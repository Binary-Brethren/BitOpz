namespace BitOpz.Core
{
    public static class BitOpzConsts
    {
        internal const int BYTE_BITS = 8;
        internal const int WORD_BITS = 16;
        internal const int DWORD_BITS = 32;
        internal const int QWORD_BITS = 64;

        internal const byte BYTE_SIGN_BIT = 0b10000000;
        internal const ushort WORD_SIGN_BIT = 0b10000000_00000000;
        internal const uint DWORD_SIGN_BIT = 0b10000000_00000000_00000000_00000000;
        internal const ulong QWORD_SIGN_BIT = 0b10000000_00000000_00000000_00000000_00000000_00000000_00000000_00000000;

        internal const byte BYTE_MAP_BITS = 0b01111111;
        internal const ushort WORD_MAP_BITS = 0b01111111_11111111;
        internal const uint DWORD_MAP_BITS = 0b01111111_11111111_11111111_11111111;
        internal const ulong QWORD_MAP_BITS = 0b01111111_11111111_11111111_11111111_11111111_11111111_11111111_11111111;
    }
}