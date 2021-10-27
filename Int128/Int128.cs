namespace Int128
{
    public class UInt128
    {
        private ulong _lo;
        private ulong _hi;
        public string lastError;
        public UInt128(ulong hi,ulong lo)
        {
            _hi = hi;
            _lo = lo;
        }
        // +x,-x,!x,~x,++,--,true,false - 
        // x+y, x-y
        // new


        public ulong this [int index]
        {
            get { return index==0?_lo:_hi; }
            set 
            { 
                if (index ==0)
                    _lo = value; 
                else
                    _hi = value;
            }
        }
        public static bool operator ==(UInt128 a,UInt128 b)
        {
            if (a._lo != b._lo) return false;
            return a._hi == b._hi;
        }
        public static bool operator !=(UInt128 a, UInt128 b)
        {
            if (a._lo != b._lo) return true;
            return a._hi != b._hi;
        }

        public static implicit operator UInt128(ulong a)
        {
            return new UInt128(0,a);
        }

        public static explicit operator ulong(UInt128 value)
        {
            return value._lo;
        }


        public static UInt128 operator ++(UInt128 a)
        {
            return a + 1;
        }

        public static UInt128 operator +(UInt128 a,UInt128 b)
        {
            ulong r = a._lo + b._lo;
            if (r< a._lo && r < b._lo)
            {
                return new UInt128(a._hi + b._hi + 1, r);
            }

            return new UInt128(a._hi + b._hi, r);
        }

    }
}