using BitOpz.Core.Extensions;
using Xunit;

namespace BitOpz.Core.Tests.UnitTests
{
    public class UShortUnitTests
    {
        #region Shift

        [Theory]
        [InlineData(0b00100001_00000001, 2, 0b10000100_00000100)]
        [InlineData(0b10100001_00000001, 2, 0b10000100_00000100)]
        public void TestUShortShiftLeft(ushort src, int shiftCnt, ushort expect)
        {
            ushort result = UShortExtensions.ShiftLeft(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00100001_00000001, 2, 0b00001000_01000000)]
        [InlineData(0b10100001_00000001, 2, 0b00101000_01000000)]
        public void TestUShortShiftRight(ushort src, int shiftCnt, ushort expect)
        {
            ushort result = UShortExtensions.ShiftRight(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00100001_00000001, 2, 0b00000100_00000100)]
        [InlineData(0b10100001_00000001, 2, 0b10000100_00000100)]
        public void TestSShortShiftLeft(ushort src, int shiftCnt, ushort expect)
        {
            ushort result = UShortExtensions.SignShiftLeft(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00100001_00000001, 2, 0b00001000_01000000)]
        [InlineData(0b10100001_00000001, 2, 0b10001000_01000000)]
        public void TestSShortShiftRight(ushort src, int shiftCnt, ushort expect)
        {
            ushort result = UShortExtensions.SignShiftRight(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        #endregion Shift

        #region Roll

        [Theory]
        [InlineData(0b00100001_00000001, 2, 0b10000100_00000100)]
        [InlineData(0b10100001_00000001, 2, 0b10000100_00000110)]
        public void TestUShortRollLeft(ushort src, int shiftCnt, ushort expect)
        {
            ushort result = UShortExtensions.RollLeft(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00100001_00000001, 2, 0b01001000_01000000)]
        [InlineData(0b10100001_00000001, 2, 0b01101000_01000000)]
        public void TestUShortRollRight(ushort src, int shiftCnt, ushort expect)
        {
            ushort result = UShortExtensions.RollRight(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00100001_00000001, 2, 0b00000100_00000101)]
        [InlineData(0b10100001_00000001, 2, 0b10000100_00000101)]
        public void TestSShortRollLeft(ushort src, int shiftCnt, ushort expect)
        {
            ushort result = UShortExtensions.SignRollLeft(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00100001_00000001, 2, 0b00101000_01000000)]
        [InlineData(0b10100001_00000001, 2, 0b10101000_01000000)]
        public void TestSShortRollRight(ushort src, int shiftCnt, ushort expect)
        {
            ushort result = UShortExtensions.SignRollRight(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        #endregion Roll

        #region Flip

        // TODO: Implement

        #endregion Flip
    }
}