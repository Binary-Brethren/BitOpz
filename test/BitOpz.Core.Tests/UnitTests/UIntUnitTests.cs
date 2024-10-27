﻿using BitOpz.Core.Extensions;
using Xunit;

namespace BitOpz.Core.Tests.UnitTests
{
    public class UIntUnitTests
    {
        #region Shift

        [Theory]
        [InlineData(0b00100001_00000000_00000000_00000001, 2, 0b10000100_00000000_00000000_00000100)]
        [InlineData(0b10100001_00000000_00000000_00000001, 2, 0b10000100_00000000_00000000_00000100)]
        public void TestUIntShiftLeft(uint src, int shiftCnt, uint expect)
        {
            uint result = UIntExtensions.ShiftLeft(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00100001_00000000_00000000_00000001, 2, 0b00001000_01000000_00000000_00000000)]
        [InlineData(0b10100001_00000000_00000000_00000001, 2, 0b00101000_01000000_00000000_00000000)]
        public void TestUIntShiftRight(uint src, int shiftCnt, uint expect)
        {
            uint result = UIntExtensions.ShiftRight(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00100001_00000000_00000000_00000001, 2, 0b00000100_00000000_00000000_00000100)]
        [InlineData(0b10100001_00000000_00000000_00000001, 2, 0b10000100_00000000_00000000_00000100)]
        public void TestSIntShiftLeft(uint src, int shiftCnt, uint expect)
        {
            uint result = UIntExtensions.SignShiftLeft(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00100001_00000000_00000000_00000001, 2, 0b00001000_01000000_00000000_00000000)]
        [InlineData(0b10100001_00000000_00000000_00000001, 2, 0b10001000_01000000_00000000_00000000)]
        public void TestSIntShiftRight(uint src, int shiftCnt, uint expect)
        {
            uint result = UIntExtensions.SignShiftRight(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        #endregion Shift

        #region Roll

        [Theory]
        [InlineData(0b00100001_00000000_00000000_00000001, 2, 0b10000100_00000000_00000000_00000100)]
        [InlineData(0b10100001_00000000_00000000_00000001, 2, 0b10000100_00000000_00000000_00000110)]
        public void TestUIntRollLeft(uint src, int shiftCnt, uint expect)
        {
            uint result = UIntExtensions.RollLeft(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00100001_00000000_00000000_00000001, 2, 0b01001000_01000000_00000000_00000000)]
        [InlineData(0b10100001_00000000_00000000_00000001, 2, 0b01101000_01000000_00000000_00000000)]
        public void TestUIntRollRight(uint src, int shiftCnt, uint expect)
        {
            uint result = UIntExtensions.RollRight(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00100001_00000000_00000000_00000001, 2, 0b00000100_00000000_00000000_00000101)]
        [InlineData(0b10100001_00000000_00000000_00000001, 2, 0b10000100_00000000_00000000_00000101)]
        public void TestSIntRollLeft(uint src, int shiftCnt, uint expect)
        {
            uint result = UIntExtensions.SignRollLeft(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(0b00100001_00000000_00000000_00000001, 2, 0b00101000_01000000_00000000_00000000)]
        [InlineData(0b10100001_00000000_00000000_00000001, 2, 0b10101000_01000000_00000000_00000000)]
        public void TestSIntRollRight(uint src, int shiftCnt, uint expect)
        {
            uint result = UIntExtensions.SignRollRight(src, shiftCnt);
            Assert.Equal(expect, result);
        }

        #endregion Roll

        #region Flip

        // TODO: Implement

        #endregion Flip
    }
}