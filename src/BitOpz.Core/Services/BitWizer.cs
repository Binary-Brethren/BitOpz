using BitOpz.Core.Bases;
using BitOpz.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace BitOpz.Core.Services
{
    public class BitWizer : BitCore
    {
        #region constructors

        public BitWizer() : base()
        {
            _history = new List<IBitWizerSave>();
        }

        #endregion constructors

        private IList<IBitWizerSave> _history;

        #region Control Functions

        public void SaveHistory() => _history.Add(new BitWizerHistory<ulong>(AsULong(), AsULong()));

        private void SaveHistory(ulong rawValue, ulong returnValue) => _history.Add(new BitWizerHistory<ulong>(rawValue, returnValue));

        private void SaveHistory(ulong rawValue, uint returnValue) => _history.Add(new BitWizerHistory<uint>(rawValue, returnValue));

        private void SaveHistory(ulong rawValue, ushort returnValue) => _history.Add(new BitWizerHistory<ushort>(rawValue, returnValue));

        private void SaveHistory(ulong rawValue, byte returnValue) => _history.Add(new BitWizerHistory<byte>(rawValue, returnValue));

        public List<(ulong RawValue, object ReturnValue)> GetFullHistory() => _history.Select(x => x.GetSave()).ToList();

        public List<ulong> GetRawHistory() => _history.Select(x => x.GetSave().RawValue).ToList();

        public List<object> GetReturnHistory() => _history.Select(x => x.GetSave().ReturnValue).ToList();

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
            ulong result = (ulong)(a & b);
            SetValue(result);
        }

        public void AndStore(uint a, uint b)
        {
            uint result = (uint)(a & b);
            SetValue((ulong)result);
        }

        public void AndStore(ushort a, ushort b)
        {
            ushort result = (ushort)(a & b);
            SetValue((ulong)result);
        }

        public void AndStore(byte a, byte b)
        {
            byte result = (byte)(a & b);
            SetValue((ulong)result);
        }

        public ulong AndReturn(ulong value)
        {
            ulong result = (ulong)(value & AsULong());
            SaveHistory(_value, result);
            return result;
        }

        public uint AndReturn(uint value)
        {
            uint result = (uint)(value & AsUInt());
            SaveHistory(_value, result);
            return result;
        }

        public ushort AndReturn(ushort value)
        {
            ushort result = (ushort)(value & AsUShort());
            SaveHistory(_value, result);
            return result;
        }

        public byte AndReturn(byte value)
        {
            byte result = (byte)(value & AsUByte());
            SaveHistory(_value, result);
            return result;
        }

        #endregion Logical And

        #region Logical Or

        public void OrStore(ulong a, ulong b)
        {
            ulong result = (ulong)(a | b);
            SetValue(result);
        }

        public void OrStore(uint a, uint b)
        {
            uint result = (uint)(a | b);
            SetValue((ulong)result);
        }

        public void OrStore(ushort a, ushort b)
        {
            ushort result = (ushort)(a | b);
            SetValue((ulong)result);
        }

        public void OrStore(byte a, byte b)
        {
            byte result = (byte)(a | b);
            SetValue((ulong)result);
        }

        public ulong OrReturn(ulong value)
        {
            ulong result = (ulong)(value | AsULong());
            SaveHistory(_value, result);
            return result;
        }

        public uint OrReturn(uint value)
        {
            uint result = (uint)(value | AsUInt());
            SaveHistory(_value, result);
            return result;
        }

        public ushort OrReturn(ushort value)
        {
            ushort result = (ushort)(value | AsUShort());
            SaveHistory(_value, result);
            return result;
        }

        public byte OrReturn(byte value)
        {
            byte result = (byte)(value | AsUByte());
            SaveHistory(_value, result);
            return result;
        }

        #endregion Logical Or
    }
}