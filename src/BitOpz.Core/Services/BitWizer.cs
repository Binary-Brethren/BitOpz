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

        public List<(ulong RawValue, object ReturnValue)> GetFullHistory() => _history.Select(x => x.GetSave()).ToList();

        public List<ulong> GetRawHistory() => _history.Select(x => x.GetSave().RawValue).ToList();

        public List<object> GetReturnHistory() => _history.Select(x => x.GetSave().ReturnValue).ToList();

        #endregion Control Functions

        #region Logical And

        public void AndStore(ulong a, ulong b)
        {
            throw new System.NotImplementedException();
        }

        public void AndStore(uint a, uint b)
        {
            throw new System.NotImplementedException();
        }

        public void AndStore(ushort a, ushort b)
        {
            throw new System.NotImplementedException();
        }

        public void AndStore(byte a, byte b)
        {
            throw new System.NotImplementedException();
        }

        public ulong AndAsULong(ulong value)
        {
            throw new System.NotImplementedException();
        }

        public uint AndAsUInt(uint value)
        {
            throw new System.NotImplementedException();
        }

        public ushort AndAsUShort(ushort value)
        {
            throw new System.NotImplementedException();
        }

        public byte AndAsUByte(byte value)
        {
            throw new System.NotImplementedException();
        }

        #endregion Logical And

        #region Logical Or

        public void OrStore(ulong a, ulong b)
        {
            throw new System.NotImplementedException();
        }

        public void OrStore(uint a, uint b)
        {
            throw new System.NotImplementedException();
        }

        public void OrStore(ushort a, ushort b)
        {
            throw new System.NotImplementedException();
        }

        public void OrStore(byte a, byte b)
        {
            throw new System.NotImplementedException();
        }

        public ulong OrAsULong(ulong value)
        {
            throw new System.NotImplementedException();
        }

        public uint OrAsUInt(uint value)
        {
            throw new System.NotImplementedException();
        }

        public ushort OrAsUShort(ushort value)
        {
            throw new System.NotImplementedException();
        }

        public byte OrAsUByte(byte value)
        {
            throw new System.NotImplementedException();
        }

        #endregion Logical Or
    }
}