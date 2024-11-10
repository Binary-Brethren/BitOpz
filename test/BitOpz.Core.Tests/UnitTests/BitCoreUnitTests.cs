using BitOpz.Core.Bases;
using Xunit;

namespace BitOpz.Core.Tests.UnitTests;

public class BitCoreUnitTests
{
    private BitCore _bitCore;

    #region 64-bit

    [Theory]
    [InlineData(ulong.MaxValue)]
    [InlineData(ulong.MinValue)]
    public void TestBitCoreAsULongSimple(ulong value)
    {
        _bitCore = new BitCore(value);
        Assert.NotNull(_bitCore);
        Assert.Equal((ulong)value, _bitCore.AsULong());
        Assert.Equal(value, _bitCore.AsULong());
    }

    [Theory]
    [InlineData(long.MaxValue)]
    [InlineData(long.MinValue)]
    public void TestBitCoreAsLongSimple(long value)
    {
        _bitCore = new BitCore(value);
        Assert.NotNull(_bitCore);
        Assert.Equal((ulong)value, _bitCore.AsULong());
        Assert.Equal(value, _bitCore.AsLong());
    }

    #endregion

    #region 32-bit

    [Theory]
    [InlineData(int.MaxValue)]
    [InlineData(int.MinValue)]
    public void TestBitCoreAsUIntSimple(uint value)
    {
        _bitCore = new BitCore(value);
        Assert.NotNull(_bitCore);
        Assert.Equal((ulong)value, _bitCore.AsULong());
        Assert.Equal(value, _bitCore.AsUInt());
    }

    [Theory]
    [InlineData(0x1111_2222_3333_4444, 0, 0x1111_2222)]
    [InlineData(0x1111_2222_3333_4444, 1, 0x3333_4444)]
    public void TestBitCoreAsUIntSplit(ulong src, int split, uint expect)
    {
        _bitCore = new BitCore(src);
        Assert.NotNull(_bitCore);
        Assert.Equal((ulong)src, _bitCore.AsULong());
        Assert.Equal(expect, _bitCore.AsUInt(split));
    }

    [Theory]
    [InlineData(int.MaxValue)]
    [InlineData(int.MinValue)]
    public void TestBitCoreAsIntSimple(int value)
    {
        _bitCore = new BitCore(value);
        Assert.NotNull(_bitCore);
        Assert.Equal((ulong)value, _bitCore.AsULong());
        Assert.Equal(value, _bitCore.AsInt());
    }

    [Theory]
    [InlineData(0x1111_2222_3333_4444, 0, 0x1111_2222)]
    [InlineData(0x1111_2222_3333_4444, 1, 0x3333_4444)]
    public void TestBitCoreAsIntSplit(ulong src, int split, int expect)
    {
        _bitCore = new BitCore(src);
        Assert.NotNull(_bitCore);
        Assert.Equal((ulong)src, _bitCore.AsULong());
        Assert.Equal(expect, _bitCore.AsInt(split));
    }

    #endregion

    #region 16-bit

    [Theory]
    [InlineData(short.MaxValue)]
    [InlineData(short.MinValue)]
    public void TestBitCoreAsUShortSimple(ushort value)
    {
        _bitCore = new BitCore(value);
        Assert.NotNull(_bitCore);
        Assert.Equal((ulong)value, _bitCore.AsULong());
        Assert.Equal(value, _bitCore.AsUShort());
    }

    [Theory]
    [InlineData(0x1111_2222_3333_4444, 0, 0x1111)]
    [InlineData(0x1111_2222_3333_4444, 1, 0x2222)]
    [InlineData(0x1111_2222_3333_4444, 2, 0x3333)]
    [InlineData(0x1111_2222_3333_4444, 3, 0x4444)]
    public void TestBitCoreAsUShortSplit(ulong src, int split, ushort expect)
    {
        _bitCore = new BitCore(src);
        Assert.NotNull(_bitCore);
        Assert.Equal((ulong)src, _bitCore.AsULong());
        Assert.Equal(expect, _bitCore.AsUShort(split));
    }

    [Theory]
    [InlineData(short.MaxValue)]
    [InlineData(short.MinValue)]
    public void TestBitCoreAsShortSimple(short value)
    {
        _bitCore = new BitCore(value);
        Assert.NotNull(_bitCore);
        Assert.Equal((ulong)value, _bitCore.AsULong());
        Assert.Equal(value, _bitCore.AsShort());
    }

    [Theory]
    [InlineData(0x1111_2222_3333_4444, 0, 0x1111)]
    [InlineData(0x1111_2222_3333_4444, 1, 0x2222)]
    [InlineData(0x1111_2222_3333_4444, 2, 0x3333)]
    [InlineData(0x1111_2222_3333_4444, 3, 0x4444)]
    public void TestBitCoreAsShortSplit(ulong src, int split, short expect)
    {
        _bitCore = new BitCore(src);
        Assert.NotNull(_bitCore);
        Assert.Equal((ulong)src, _bitCore.AsULong());
        Assert.Equal(expect, _bitCore.AsShort(split));
    }

    #endregion

    #region 8-bit

    [Theory]
    [InlineData(sbyte.MaxValue)]
    [InlineData(sbyte.MinValue)]
    public void TestBitCoreAsUByteSimple(byte value)
    {
        _bitCore = new BitCore(value);
        Assert.NotNull(_bitCore);
        Assert.Equal((ulong)value, _bitCore.AsULong());
        Assert.Equal(value, _bitCore.AsUByte());
    }

    [Theory]
    [InlineData(0x1122_3344_5566_7788, 0, 0x11)]
    [InlineData(0x1122_3344_5566_7788, 1, 0x22)]
    [InlineData(0x1122_3344_5566_7788, 2, 0x33)]
    [InlineData(0x1122_3344_5566_7788, 3, 0x44)]
    [InlineData(0x1122_3344_5566_7788, 4, 0x55)]
    [InlineData(0x1122_3344_5566_7788, 5, 0x66)]
    [InlineData(0x1122_3344_5566_7788, 6, 0x77)]
    [InlineData(0x1122_3344_5566_7788, 7, 0x88)]
    public void TestBitCoreAsUByteSplit(ulong src, int split, byte expect)
    {
        _bitCore = new BitCore(src);
        Assert.NotNull(_bitCore);
        Assert.Equal((ulong)src, _bitCore.AsULong());
        Assert.Equal(expect, _bitCore.AsUByte(split));
    }

    [Theory]
    [InlineData(sbyte.MaxValue)]
    [InlineData(sbyte.MinValue)]
    public void TestBitCoreAsSByteSimple(sbyte value)
    {
        _bitCore = new BitCore(value);
        Assert.NotNull(_bitCore);
        Assert.Equal((ulong)value, _bitCore.AsULong());
        Assert.Equal(value, _bitCore.AsSByte());
    }

    [Theory]
    [InlineData(0x1122_3344_5566_7788, 0, 0x11)]
    [InlineData(0x1122_3344_5566_7788, 1, 0x22)]
    [InlineData(0x1122_3344_5566_7788, 2, 0x33)]
    [InlineData(0x1122_3344_5566_7788, 3, 0x44)]
    [InlineData(0x1122_3344_5566_7788, 4, 0x55)]
    [InlineData(0x1122_3344_5566_7788, 5, 0x66)]
    [InlineData(0x1122_3344_5566_7788, 6, 0x77)]
    [InlineData(0x1122_3344_5566_7788, 7, 0x88)]
    public void TestBitCoreAsSByteSplit(ulong src, int split, sbyte expect)
    {
        _bitCore = new BitCore(src);
        Assert.NotNull(_bitCore);
        Assert.Equal((ulong)src, _bitCore.AsULong());
        Assert.Equal(expect, _bitCore.AsSByte(split));
    }

    #endregion
}
