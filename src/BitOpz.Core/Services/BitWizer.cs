#region

using System.Collections.Generic;
using System.Linq;
using BitOpz.Core.Bases;
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

        public void SaveHistory() => _history.Add(new BitWizerHistory<ulong>(AsULong(), AsULong()));


        private void SaveHistory(ulong rawValue, ulong returnValue) => _history.Add(new BitWizerHistory<ulong>(rawValue, returnValue));


        private void SaveHistory(ulong rawValue, uint returnValue) => _history.Add(new BitWizerHistory<uint>(rawValue, returnValue));


        private void SaveHistory(ulong rawValue, ushort returnValue) => _history.Add(new BitWizerHistory<ushort>(rawValue, returnValue));


        private void SaveHistory(ulong rawValue, byte returnValue) => _history.Add(new BitWizerHistory<byte>(rawValue, returnValue));


        public List<(ulong RawValue, object ReturnValue)> GetFullHistory() => _history.Select(x => x.GetSave()).ToList();


        public List<ulong> GetRawHistory() => _history.Select(x => x.GetSave().RawValue).ToList();


        public List<object> GetReturnHistory() => _history.Select(x => x.GetSave().ReturnValue).ToList();


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
        }

        public void AndStore(uint a, uint b)
        {
            var result = a & b;
            SetValue(result);
        }

        public void AndStore(ushort a, ushort b)
        {
            var result = (ushort)(a & b);
            SetValue(result);
        }

        public void AndStore(byte a, byte b)
        {
            var result = (byte)(a & b);
            SetValue(result);
        }

        public ulong AndReturn(ulong value)
        {
            var result = value & AsULong();
            SaveHistory(_value, result);
            return result;
        }

        public uint AndReturn(uint value)
        {
            var result = value & AsUInt();
            SaveHistory(_value, result);
            return result;
        }

        public ushort AndReturn(ushort value)
        {
            var result = (ushort)(value & AsUShort());
            SaveHistory(_value, result);
            return result;
        }

        public byte AndReturn(byte value)
        {
            var result = (byte)(value & AsUByte());
            SaveHistory(_value, result);
            return result;
        }

        #endregion Logical And

        #region Logical Or

        public void OrStore(ulong a, ulong b)
        {
            var result = a | b;
            SetValue(result);
        }

        public void OrStore(uint a, uint b)
        {
            var result = a | b;
            SetValue(result);
        }

        public void OrStore(ushort a, ushort b)
        {
            var result = (ushort)(a | b);
            SetValue(result);
        }

        public void OrStore(byte a, byte b)
        {
            var result = (byte)(a | b);
            SetValue(result);
        }

        public ulong OrReturn(ulong value)
        {
            var result = value | AsULong();
            SaveHistory(_value, result);
            return result;
        }

        public uint OrReturn(uint value)
        {
            var result = value | AsUInt();
            SaveHistory(_value, result);
            return result;
        }

        public ushort OrReturn(ushort value)
        {
            var result = (ushort)(value | AsUShort());
            SaveHistory(_value, result);
            return result;
        }

        public byte OrReturn(byte value)
        {
            var result = (byte)(value | AsUByte());
            SaveHistory(_value, result);
            return result;
        }

        #endregion Logical Or
    }
}
