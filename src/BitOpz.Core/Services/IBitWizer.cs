using System.Collections.Generic;

namespace BitOpz.Core.Services
{
    public interface IBitWizer
    {
        public void SaveHistory();
        public List<(ulong RawValue, object ReturnValue)> GetFullHistory();
        public List<ulong> GetRawHistory();
        public List<object> GetReturnHistory();
        public void ClearHistory();
        public void AndStore(ulong a, ulong b);
        public void AndStore(uint a, uint b);
        public void AndStore(ushort a, ushort b);
        public void AndStore(byte a, byte b);
        public ulong AndReturn(ulong value);
        public uint AndReturn(uint value);
        public ushort AndReturn(ushort value);
        public byte AndReturn(byte value);
        public void OrStore(ulong a, ulong b);
        public void OrStore(uint a, uint b);
        public void OrStore(ushort a, ushort b);
        public void OrStore(byte a, byte b);
        public ulong OrReturn(ulong value);
        public uint OrReturn(uint value);
        public ushort OrReturn(ushort value);
        public byte OrReturn(byte value);
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
    }
}
