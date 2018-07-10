﻿using System.Collections.Generic;
using Skrypt.Execution;

namespace Skrypt.Library.Native
{
    partial class System
    {
        [Constant]
        public class Boolean : SkryptType
        {
            public new List<Operation> Operations = new List<Operation>
            {
                new Operation("and", typeof(Boolean), typeof(Boolean),
                    input =>
                    {
                        var a = TypeConverter.ToBoolean(input, 0);
                        var b = TypeConverter.ToBoolean(input, 1);

                        return new Boolean(a && b);
                    }),
                new Operation("or", typeof(Boolean), typeof(Boolean),
                    input =>
                    {
                        var a = TypeConverter.ToBoolean(input, 0);
                        var b = TypeConverter.ToBoolean(input, 1);

                        return new Boolean(a || b);
                    }),
                new Operation("not", typeof(Boolean),
                    input =>
                    {
                        var a = TypeConverter.ToBoolean(input, 0);

                        return new Boolean(!a);
                    })
            };

            public bool Value;

            public Boolean()
            {
                Name = "boolean";
                CreateCopyOnAssignment = true;
            }

            public Boolean(bool v = false)
            {
                Name = "boolean";
                Value = v;
                CreateCopyOnAssignment = true;
            }

            public static SkryptObject Constructor(SkryptObject self, SkryptObject[] input)
            {
                var a = TypeConverter.ToBoolean(input, 0);

                return new Boolean(a);
            }

            public static implicit operator Boolean(bool d)
            {
                return new Boolean(d);
            }

            public static implicit operator bool(Boolean d)
            {
                return d.Value;
            }

            public override string ToString()
            {
                return Value.ToString();
            }

            public override Boolean ToBoolean()
            {
                return Value;
            }
        }
    }
}