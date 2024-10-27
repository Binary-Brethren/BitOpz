namespace BitOpz.Core.Bases
{
    public partial class BitCore
    {
        private bool _isSigned = false;
        private ulong _value = 0;
        public ulong Value => _value;
        public bool IsSigned => _isSigned;

        public void SetSign(bool isSigned) => _isSigned = isSigned;

        public void SetValue(ulong value) => _value = value;

        public BitCore()
        { }

        public BitCore(ulong value) : this()
        { _value = value; }

        public BitCore(byte value) : this((ulong)value)
        { }

        public BitCore(sbyte value) : this((ulong)value)
        { }

        public BitCore(ushort value) : this((ulong)value)
        { }

        public BitCore(short value) : this((ulong)value)
        { }

        public BitCore(uint value) : this((ulong)value)
        { }

        public BitCore(int value) : this((ulong)value)
        { }

        public BitCore(long value) : this((ulong)value)
        { }
    }
}