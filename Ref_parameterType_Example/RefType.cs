using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ref_parameterType_Example
{
    public  class RefType
    {
        public void Swap( ref int x,ref  int y )
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        public void Opetarions( int num1,int num2,ref int addition,out int multiplication)
        {
            addition = num1 + num2;
            multiplication = num1*num2;
        }
    }
}
