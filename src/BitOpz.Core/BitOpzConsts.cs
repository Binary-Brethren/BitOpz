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

        internal const byte BYTE_MASK_BITS = 0b01111111;
        internal const ushort WORD_MASK_BITS = 0b01111111_11111111;
        internal const uint DWORD_MASK_BITS = 0b01111111_11111111_11111111_11111111;
        internal const ulong QWORD_MASK_BITS = 0b01111111_11111111_11111111_11111111_11111111_11111111_11111111_11111111;

        internal const ushort WORD_L_MASK = 0x00FF;
        internal const ushort WORD_H_MASK = 0xFF00;
        internal const uint DWORD_LL_MASK = 0x0000_00FF;
        internal const uint DWORD_LH_MASK = 0x0000_FF00;
        internal const uint DWORD_HL_MASK = 0x00FF_0000;
        internal const uint DWORD_HH_MASK = 0xFF00_0000;
        internal const ulong QWORD_LLL_MASK = 0x0000_0000_0000_00FF;
        internal const ulong QWORD_LLH_MASK = 0x0000_0000_0000_FF00;
        internal const ulong QWORD_LHL_MASK = 0x0000_0000_00FF_0000;
        internal const ulong QWORD_LHH_MASK = 0x0000_0000_FF00_0000;
        internal const ulong QWORD_HLL_MASK = 0x0000_00FF_0000_0000;
        internal const ulong QWORD_HLH_MASK = 0x0000_FF00_0000_0000;
        internal const ulong QWORD_HHL_MASK = 0x00FF_0000_0000_0000;
        internal const ulong QWORD_HHH_MASK = 0xFF00_0000_0000_0000;

        internal const int WORD_MOV = 8;
        internal const int DWORD_L_MOV = 8;
        internal const int DWORD_H_MOV = 24;
        internal const int QWORD_LL_MOV = 8;
        internal const int QWORD_LH_MOV = 24;
        internal const int QWORD_HL_MOV = 40;
        internal const int QWORD_HH_MOV = 56;
    }
}