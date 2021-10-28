namespace UInt128S
{
    public readonly struct UInt128
    {
        public readonly int ID;
        public readonly string Name;
        public UInt128(int id,string name)
        {
            ID = id;
            Name = name;
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        public static UInt128 GetUInt()
        {
            var a = 10;
            var b=a.GetType();
            return new UInt128(1,"");
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}