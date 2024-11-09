#region

using System.Collections.Generic;
using System.Linq;
using BitOpz.Core.Bases;
using BitOpz.Core.Enums;
using BitOpz.Core.Models;

#endregion

namespace BitOpz.Core.Services
{
    public class BitWizer : BitCore, IBitWizer
    {
        private readonly IList<IBitWizerSave> _history;

        #region constructors

        public BitWizer()
        {
            _history = new List<IBitWizerSave>();
        }

        #endregion constructors

        #region Control Functions

        public List<BitWizerHistory> GetHistory() => _history.Select(x => x.GetSave()).ToList();

        public void ClearHistory() => _history.Clear();

        #endregion Control Functions

        /*
         * Likely that many of these could be converted into generic
         * functions, only after we handle the signed cases of returns
         * This is because our history forces unmanaged types, not
         * specifically unsigned-unmanaged types.
         *
         * CAREFUL HERE!
         * Ensure that generic types are limited to unmanaged types
         * if this is to be implemented.
         *
         * Generic is the way to go, but we need a base-line first.
         */

        #region Logical And

        public void AndStore(ulong a, ulong b)
        {
            var result = a & b;
            SetValue(result);
            _history.Add(new BitWizerSave<ulong>(a, BitWizerHistoryEnums.BitWizerAction.AND, b, (ulong)result, BitWizerHistoryEnums.BitWizerResult.STORE, result));
        }

        public void AndStore(uint a, uint b)
        {
            var result = a & b;
            SetValue(result);
            _history.Add(new BitWizerSave<uint>(a, BitWizerHistoryEnums.BitWizerAction.AND, b, (ulong)result, BitWizerHistoryEnums.BitWizerResult.STORE, result));
        }

        public void AndStore(ushort a, ushort b)
        {
            var result = (ushort)(a & b);
            SetValue(result);
            _history.Add(new BitWizerSave<ushort>(a, BitWizerHistoryEnums.BitWizerAction.AND, b, (ulong)result, BitWizerHistoryEnums.BitWizerResult.STORE, result));
        }

        public void AndStore(byte a, byte b)
        {
            var result = (byte)(a & b);
            SetValue(result);
            _history.Add(new BitWizerSave<byte>(a, BitWizerHistoryEnums.BitWizerAction.AND, b, (ulong)result, BitWizerHistoryEnums.BitWizerResult.STORE, result));
        }

        public ulong AndReturn(ulong value)
        {
            var stored = AsULong();
            var result = value & stored;
            _history.Add(new BitWizerSave<ulong>(value, BitWizerHistoryEnums.BitWizerAction.AND, stored, (ulong)result, BitWizerHistoryEnums.BitWizerResult.RETURN, result));
            return result;
        }

        public uint AndReturn(uint value)
        {
            var stored = AsUInt();
            var result = value & stored;
            _history.Add(new BitWizerSave<uint>(value, BitWizerHistoryEnums.BitWizerAction.AND, stored, (ulong)result, BitWizerHistoryEnums.BitWizerResult.RETURN, result));
            return result;
        }

        public ushort AndReturn(ushort value)
        {
            var stored = AsUShort();
            var result = (ushort)(value & stored);
            _history.Add(new BitWizerSave<ushort>(value, BitWizerHistoryEnums.BitWizerAction.AND, stored, (ulong)result, BitWizerHistoryEnums.BitWizerResult.RETURN, result));
            return result;
        }

        public byte AndReturn(byte value)
        {
            var stored = AsUByte();
            var result = (byte)(value & stored);
            _history.Add(new BitWizerSave<byte>(value, BitWizerHistoryEnums.BitWizerAction.AND, AsUByte(), (ulong)result, BitWizerHistoryEnums.BitWizerResult.RETURN, result));
            return result;
        }

        #endregion Logical And

        #region Logical Or

        public void OrStore(ulong a, ulong b)
        {
            var result = a | b;
            SetValue(result);
            _history.Add(new BitWizerSave<ulong>(a, BitWizerHistoryEnums.BitWizerAction.OR, b, (ulong)result, BitWizerHistoryEnums.BitWizerResult.STORE, result));
        }

        public void OrStore(uint a, uint b)
        {
            var result = a | b;
            SetValue(result);
            _history.Add(new BitWizerSave<uint>(a, BitWizerHistoryEnums.BitWizerAction.OR, b, (ulong)result, BitWizerHistoryEnums.BitWizerResult.STORE, result));
        }

        public void OrStore(ushort a, ushort b)
        {
            var result = (ushort)(a | b);
            SetValue(result);
            _history.Add(new BitWizerSave<ushort>(a, BitWizerHistoryEnums.BitWizerAction.OR, b, (ulong)result, BitWizerHistoryEnums.BitWizerResult.STORE, result));
        }

        public void OrStore(byte a, byte b)
        {
            var result = (byte)(a | b);
            SetValue(result);
            _history.Add(new BitWizerSave<byte>(a, BitWizerHistoryEnums.BitWizerAction.OR, b, (ulong)result, BitWizerHistoryEnums.BitWizerResult.STORE, result));
        }

        public ulong OrReturn(ulong value)
        {
            var stored = AsULong();
            var result = value | stored;
            _history.Add(new BitWizerSave<ulong>(value, BitWizerHistoryEnums.BitWizerAction.OR, stored, (ulong)result, BitWizerHistoryEnums.BitWizerResult.RETURN, result));
            return result;
        }

        public uint OrReturn(uint value)
        {
            var stored = AsUInt();
            var result = value | stored;
            _history.Add(new BitWizerSave<uint>(value, BitWizerHistoryEnums.BitWizerAction.OR, stored, (ulong)result, BitWizerHistoryEnums.BitWizerResult.RETURN, result));
            return result;
        }

        public ushort OrReturn(ushort value)
        {
            var stored = AsUShort();
            var result = (ushort)(value | stored);
            _history.Add(new BitWizerSave<ushort>(value, BitWizerHistoryEnums.BitWizerAction.OR, stored, (ulong)result, BitWizerHistoryEnums.BitWizerResult.RETURN, result));
            return result;
        }

        public byte OrReturn(byte value)
        {
            var stored = AsUByte();
            var result = (byte)(value | stored);
            _history.Add(new BitWizerSave<byte>(value, BitWizerHistoryEnums.BitWizerAction.OR, AsUByte(), (ulong)result, BitWizerHistoryEnums.BitWizerResult.RETURN, result));
            return result;
        }

        #endregion Logical Or

        #region Logical Xor

        public void XorStore(ulong a, ulong b)
        {
            var result = a ^ b;
            SetValue(result);
            _history.Add(new BitWizerSave<ulong>(a, BitWizerHistoryEnums.BitWizerAction.XOR, b, (ulong)result, BitWizerHistoryEnums.BitWizerResult.STORE, result));
        }

        public void XorStore(uint a, uint b)
        {
            var result = a ^ b;
            SetValue(result);
            _history.Add(new BitWizerSave<uint>(a, BitWizerHistoryEnums.BitWizerAction.XOR, b, (ulong)result, BitWizerHistoryEnums.BitWizerResult.STORE, result));
        }

        public void XorStore(ushort a, ushort b)
        {
            var result = (ushort)(a ^ b);
            SetValue(result);
            _history.Add(new BitWizerSave<ushort>(a, BitWizerHistoryEnums.BitWizerAction.XOR, b, (ulong)result, BitWizerHistoryEnums.BitWizerResult.STORE, result));
        }

        public void XorStore(byte a, byte b)
        {
            var result = (byte)(a ^ b);
            SetValue(result);
            _history.Add(new BitWizerSave<byte>(a, BitWizerHistoryEnums.BitWizerAction.XOR, b, (ulong)result, BitWizerHistoryEnums.BitWizerResult.STORE, result));
        }

        public ulong XorReturn(ulong value)
        {
            var stored = AsULong();
            var result = value ^ stored;
            _history.Add(new BitWizerSave<ulong>(value, BitWizerHistoryEnums.BitWizerAction.XOR, stored, (ulong)result, BitWizerHistoryEnums.BitWizerResult.RETURN, result));
            return result;
        }

        public uint XorReturn(uint value)
        {
            var stored = AsUInt();
            var result = value ^ stored;
            _history.Add(new BitWizerSave<uint>(value, BitWizerHistoryEnums.BitWizerAction.XOR, stored, (ulong)result, BitWizerHistoryEnums.BitWizerResult.RETURN, result));
            return result;
        }

        public ushort XorReturn(ushort value)
        {
            var stored = AsUShort();
            var result = (ushort)(value ^ stored);
            _history.Add(new BitWizerSave<ushort>(value, BitWizerHistoryEnums.BitWizerAction.XOR, stored, (ulong)result, BitWizerHistoryEnums.BitWizerResult.RETURN, result));
            return result;
        }

        public byte XorReturn(byte value)
        {
            var stored = AsUByte();
            var result = (byte)(value ^ stored);
            _history.Add(new BitWizerSave<byte>(value, BitWizerHistoryEnums.BitWizerAction.XOR, AsUByte(), (ulong)result, BitWizerHistoryEnums.BitWizerResult.RETURN, result));
            return result;
        }

        #endregion
    }
}
