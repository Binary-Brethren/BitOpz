#region

using System.Collections.Generic;
using BitOpz.Core.Models;

#endregion

namespace BitOpz.Core.Services
{
    public interface IBitWizer
    {
        #region Control Functions

        public List<BitWizerHistory> GetHistory();
        public void ClearHistory();

        #endregion

        #region Logical And

        public void AndStore(ulong a, ulong b);
        public void AndStore(uint a, uint b);
        public void AndStore(ushort a, ushort b);
        public void AndStore(byte a, byte b);
        public ulong AndReturn(ulong value);
        public uint AndReturn(uint value);
        public ushort AndReturn(ushort value);
        public byte AndReturn(byte value);

        #endregion


        #region Logical Or

        public void OrStore(ulong a, ulong b);
        public void OrStore(uint a, uint b);
        public void OrStore(ushort a, ushort b);
        public void OrStore(byte a, byte b);
        public ulong OrReturn(ulong value);
        public uint OrReturn(uint value);
        public ushort OrReturn(ushort value);
        public byte OrReturn(byte value);

        #endregion

        #region Logical Xor

        public void XorStore(ulong a, ulong b);
        public void XorStore(uint a, uint b);
        public void XorStore(ushort a, ushort b);
        public void XorStore(byte a, byte b);
        public ulong XorReturn(ulong value);
        public uint XorReturn(uint value);
        public ushort XorReturn(ushort value);
        public byte XorReturn(byte value);

        #endregion

        #region BitCore Inheritted Returns

        public ulong AsULong();
        public long AsLong();
        public uint AsUInt();
        public uint AsUInt(int bitSplit);
        public int AsInt();
        public int AsInt(int bitSplit);
        public ushort AsUShort();
        public ushort AsUShort(int bitSplit);
        public short AsShort();
        public short AsShort(int bitSplit);
        public byte AsUByte();
        public byte AsUByte(int bitSplit);
        public sbyte AsSByte();
        public sbyte AsSByte(int bitSplit);

        #endregion
    }
}
