namespace Int128
{
    public class UInt128:Object, IComparable
    {
        /// <summary>
        /// byte-8 11111111
        /// short-16 11111111 11111111
        /// int 32 111111111 111111111 1111111111 111111111
        /// long-64 11111111 111111111 1111111111 111111111 111111111 11111111  111111111 11111111
        /// uint128-128 (16) 11111111 111111111 1111111111 111111111 111111111 11111111  111111111 11111111 11111111 111111111 1111111111 111111111 111111111 11111111  111111111 11111111
        /// </summary>


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
        public static UInt128 operator &(UInt128 a, UInt128 b) => new UInt128(a._hi & b._hi, a._lo & b._lo);
        public static UInt128 operator >>(UInt128 value, int count)
        {
            if (count >= 128) return 0;
            if (count >= 64) return value._hi >> count;
            return new UInt128(value._hi >> count, value._hi << (64 - count) | value._lo >> count);
         }
        public static UInt128 operator <<(UInt128 value, int count)
        {
            if (count >= 128) return 0;
            if (count >= 64) return new UInt128(value._lo << count, 0);
            return new UInt128(value._hi << count | value._lo >> (64 - count), value._lo << count);

        }
        public static UInt128 operator *(UInt128 a, UInt128 b)
        {
            UInt128 result = 0;
            for (int i = 0; i < 128; i++)
            {
                if ((b & 1) > 0) result += a;
                a <<= 1;
                b >>= 1;
            }
            return result;
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}