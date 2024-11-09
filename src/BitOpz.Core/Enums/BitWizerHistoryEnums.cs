namespace BitOpz.Core.Enums
{
    public static class BitWizerHistoryEnums
    {
        public enum BitWizerAction
        {
            AND,
            OR,
            XOR
        }

        public enum BitWizerResult : uint
        {
            STORE = 0,
            RETURN = 1
        }
    }
}
