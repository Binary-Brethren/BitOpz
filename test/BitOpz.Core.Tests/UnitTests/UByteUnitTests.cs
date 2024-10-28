using BitOpz.Core.Extensions;
using Xunit;

namespace BitOpz.Core.Tests.UnitTests
{
    public class UByteUnitTests
    {
        #region Shift

        [Theory]
        [InlineData(0b00010001, 2, 0b01000100)]
        [InlineData(0b10010001, 2, 0b01000100)]
        public void TestUByteShiftLeft(byte src, int shiftCnt, byte expect)
        {
            byte result = src.ShiftLeft(shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00010001, 2, 0b00000100)]
        [InlineData(0b10010001, 2, 0b00100100)]
        public void TestUByteShiftRight(byte src, int shiftCnt, byte expect)
        {
            byte result = src.ShiftRight(shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00010001, 2, 0b01000100)]
        [InlineData(0b10010001, 2, 0b11000100)]
        public void TestSByteShiftLeft(byte src, int shiftCnt, byte expect)
        {
            byte result = src.SignShiftLeft(shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00010001, 2, 0b00000100)]
        [InlineData(0b10010001, 2, 0b10000100)]
        public void TestSByteShiftRight(byte src, int shiftCnt, byte expect)
        {
            byte result = src.SignShiftRight(shiftCnt);
            Assert.Equal(expect, result);
        }

        #endregion Shift

        #region Roll

        [Theory]
        [InlineData(0b00010001, 2, 0b01000100)]
        [InlineData(0b10010001, 2, 0b01000110)]
        public void TestUByteRollLeft(byte src, int shiftCnt, byte expect)
        {
            byte result = src.RollLeft(shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00010001, 2, 0b01000100)]
        [InlineData(0b10010001, 2, 0b01100100)]
        public void TestUByteRollRight(byte src, int shiftCnt, byte expect)
        {
            byte result = src.RollRight(shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00010001, 2, 0b01000100)]
        [InlineData(0b10010001, 2, 0b11000100)]
        public void TestSByteRollLeft(byte src, int shiftCnt, byte expect)
        {
            byte result = src.SignRollLeft(shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00010001, 2, 0b00100100)]
        [InlineData(0b10010001, 2, 0b10100100)]
        public void TestSByteRollRight(byte src, int shiftCnt, byte expect)
        {
            byte result = src.SignRollRight(shiftCnt);
            Assert.Equal(expect, result);
        }

        #endregion Roll
    }
}