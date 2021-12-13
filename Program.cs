using System;

namespace Learning
{
    class Program
    {
        struct Union
        {
            public double m_variable;

            public void GetVariable<T>(ref T _variable)
            {
                switch (Type.GetTypeCode(typeof(T)))
                {
                    case TypeCode.Boolean:
                        _variable = (T)(object)(((int)m_variable == 0) ? false : true);
                        break;
                    case TypeCode.Char:
                        _variable = (T)(object)(char)m_variable;
                        break;
                    case TypeCode.SByte:
                        _variable = (T)(object)Convert.ToSByte(m_variable);
                        break;
                    case TypeCode.Byte:
                        _variable = (T)(object)Convert.ToByte(m_variable);
                        break;
                    case TypeCode.Int16:
                        _variable = (T)(object)Convert.ToInt16(m_variable);
                        break;
                    case TypeCode.UInt16:
                        _variable = (T)(object)Convert.ToUInt16(m_variable);
                        break;
                    case TypeCode.Int32:
                        _variable = (T)(object)Convert.ToInt32(m_variable);
                        break;
                    case TypeCode.UInt32:
                        _variable = (T)(object)Convert.ToUInt32(m_variable);
                        break;
                    case TypeCode.Int64:
                        _variable = (T)(object)Convert.ToInt64(m_variable);
                        break;
                    case TypeCode.UInt64:
                        _variable = (T)(object)Convert.ToUInt64(m_variable);
                        break;
                    case TypeCode.Single:
                        _variable = (T)(object)Convert.ToSingle(m_variable);
                        break;
                    case TypeCode.Double:
                        _variable = (T)(object)m_variable;
                        break;
                }
            }
            public void SetVariable<T>(T _variable)
            {
                switch (Type.GetTypeCode(typeof(T)))
                {
                    case TypeCode.Boolean:
                        m_variable = (Convert.ToBoolean(_variable)) ? 1 : 0;
                        break;
                    case TypeCode.Char:
                        m_variable = Convert.ToChar(_variable);
                        break;
                    case TypeCode.SByte:
                        m_variable = Convert.ToSByte(_variable);
                        break;
                    case TypeCode.Byte:
                        m_variable = Convert.ToByte(_variable);
                        break;
                    case TypeCode.Int16:
                        m_variable = Convert.ToInt16(_variable);
                        break;
                    case TypeCode.UInt16:
                        m_variable = Convert.ToUInt16(_variable);
                        break;
                    case TypeCode.Int32:
                        m_variable = Convert.ToInt32(_variable);
                        break;
                    case TypeCode.UInt32:
                        m_variable = Convert.ToUInt32(_variable);
                        break;
                    case TypeCode.Int64:
                        m_variable = Convert.ToInt64(_variable);
                        break;
                    case TypeCode.UInt64:
                        m_variable = Convert.ToUInt64(_variable);
                        break;
                    case TypeCode.Single:
                        m_variable = Convert.ToSingle(_variable);
                        break;
                    case TypeCode.Double:
                        m_variable = Convert.ToDouble(_variable);
                        break;
                }
            }
        };

        static Union union;

        static void Main(string[] args)
        {
            int i = 2000000; // int.MaxValue;
            float f = i;
            Console.WriteLine(f);
            union.SetVariable('l');
            bool test = false;
            byte testByte = 10;
            char test2 = 'a';
            sbyte testSbyte = -20;
            union.GetVariable(ref test2);

            test = false;

            Console.WriteLine("Hello World!");
            Console.WriteLine("New Branch!");
            Console.WriteLine("Second commit!");
            Console.WriteLine("Branch 3!");
            // New node? Nope

            Console.ReadKey();
        }
    }
}
