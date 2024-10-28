using BitOpz.Core.Extensions;
using Xunit;

namespace BitOpz.Core.Tests.UnitTests
{
    public class ULongUnitTests
    {
        #region Shift

        [Theory]
        [InlineData(0b00100001_00000000_00000000_00000000_00000000_00000000_00000000_00000001, 2, 0b10000100_00000000_00000000_00000000_00000000_00000000_00000000_00000100)]
        [InlineData(0b10100001_00000000_00000000_00000000_00000000_00000000_00000000_00000001, 2, 0b10000100_00000000_00000000_00000000_00000000_00000000_00000000_00000100)]
        public void TestULongShiftLeft(ulong src, int shiftCnt, ulong expect)
        {
            ulong result = ULongExtensions.ShiftLeft(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00100001_00000000_00000000_00000000_00000000_00000000_00000000_00000001, 2, 0b00001000_01000000_00000000_00000000_00000000_00000000_00000000_00000000)]
        [InlineData(0b10100001_00000000_00000000_00000000_00000000_00000000_00000000_00000001, 2, 0b00101000_01000000_00000000_00000000_00000000_00000000_00000000_00000000)]
        public void TestULongShiftRight(ulong src, int shiftCnt, ulong expect)
        {
            ulong result = ULongExtensions.ShiftRight(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00100001_00000000_00000000_00000000_00000000_00000000_00000000_00000001, 2, 0b00000100_00000000_00000000_00000000_00000000_00000000_00000000_00000100)]
        [InlineData(0b10100001_00000000_00000000_00000000_00000000_00000000_00000000_00000001, 2, 0b10000100_00000000_00000000_00000000_00000000_00000000_00000000_00000100)]
        public void TestSLongShiftLeft(ulong src, int shiftCnt, ulong expect)
        {
            ulong result = ULongExtensions.SignShiftLeft(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00100001_00000000_00000000_00000000_00000000_00000000_00000000_00000001, 2, 0b00001000_01000000_00000000_00000000_00000000_00000000_00000000_00000000)]
        [InlineData(0b10100001_00000000_00000000_00000000_00000000_00000000_00000000_00000001, 2, 0b10001000_01000000_00000000_00000000_00000000_00000000_00000000_00000000)]
        public void TestSLongShiftRight(ulong src, int shiftCnt, ulong expect)
        {
            ulong result = ULongExtensions.SignShiftRight(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        #endregion Shift

        #region Roll

        [Theory]
        [InlineData(0b00100001_00000000_00000000_00000000_00000000_00000000_00000000_00000001, 2, 0b10000100_00000000_00000000_00000000_00000000_00000000_00000000_00000100)]
        [InlineData(0b10100001_00000000_00000000_00000000_00000000_00000000_00000000_00000001, 2, 0b10000100_00000000_00000000_00000000_00000000_00000000_00000000_00000110)]
        public void TestULongRollLeft(ulong src, int shiftCnt, ulong expect)
        {
            ulong result = ULongExtensions.RollLeft(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00100001_00000000_00000000_00000000_00000000_00000000_00000000_00000001, 2, 0b01001000_01000000_00000000_00000000_00000000_00000000_00000000_00000000)]
        [InlineData(0b10100001_00000000_00000000_00000000_00000000_00000000_00000000_00000001, 2, 0b01101000_01000000_00000000_00000000_00000000_00000000_00000000_00000000)]
        public void TestULongRollRight(ulong src, int shiftCnt, ulong expect)
        {
            ulong result = ULongExtensions.RollRight(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00100001_00000000_00000000_00000000_00000000_00000000_00000000_00000001, 2, 0b00000100_00000000_00000000_00000000_00000000_00000000_00000000_00000101)]
        [InlineData(0b10100001_00000000_00000000_00000000_00000000_00000000_00000000_00000001, 2, 0b10000100_00000000_00000000_00000000_00000000_00000000_00000000_00000101)]
        public void TestSLongRollLeft(ulong src, int shiftCnt, ulong expect)
        {
            ulong result = ULongExtensions.SignRollLeft(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00100001_00000000_00000000_00000000_00000000_00000000_00000000_00000001, 2, 0b00101000_01000000_00000000_00000000_00000000_00000000_00000000_00000000)]
        [InlineData(0b10100001_00000000_00000000_00000000_00000000_00000000_00000000_00000001, 2, 0b10101000_01000000_00000000_00000000_00000000_00000000_00000000_00000000)]
        public void TestSLongRollRight(ulong src, int shiftCnt, ulong expect)
        {
            ulong result = ULongExtensions.SignRollRight(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        #endregion Roll

        #region Flip

        [Theory]
        [InlineData(0x123456780000FFFF, 0xFFFF000078563412)]
        [InlineData(0xF00FF00FF00FF00F, 0x0FF00FF00FF00FF0)]
        public void TestFlipEndian(ulong src, ulong expect)
        {
            ulong result = ULongExtensions.FlipEndian(src);
            Assert.Equal(expect, result);
        }

        #endregion Flip
    }
}