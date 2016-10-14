using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CustomContainers
{
    public class OAA<TKeyType, TDataType, TPredicateType> // <Key, Data, Predicate = LessThan>
    {
        #region private members

        private enum Flags : byte
        {
            ZERO = 0x00,
            DEAD = 0x01,
            RED  = 0x02,
            DEFAULT = RED
        };

        private ConsoleColor ColorMap(byte flags) // it should return a static const char*
        {
            Queue<int> q = new Queue<int>();
            
            switch (flags)
            {
                case 0x00: 
                    return ConsoleColor.Blue;
                case 0x01:
                    return ConsoleColor.DarkBlue;
                case 0x02:
                    return ConsoleColor.Red;
                case 0x03:
                    return ConsoleColor.DarkRed;
                default:
                    return ConsoleColor.Yellow;  // unknown color
            }
        }
        
        private class Node 
        {
            private TKeyType key_ { get; set; }
            private TDataType data_;
            private Node lchildNode, rchildNode;
            private byte flags_ { get; set; } // unsigned char

            Node(TKeyType k, TDataType d, byte flags = (byte)Flags.DEFAULT) 
            {
                key_ = k;
                data_ = d;
                flags_ = flags;
            }
        }
        #endregion


    }


}
