using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModbusSlaveDemostrator
{
    [Serializable()]
    public class RegValue
    {
        public int Register
        {
            get;
            set;
        }

        public int Value
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public RegValue()
        {
            Register = 0;
            Value = 0;
            Description = "";
        }

        public RegValue(int reg, int val)
        {
            Register = reg;
            Value = val;
            Description = "";
        }

        public RegValue(int reg, int val, string desc)
        {
            Register = reg;
            Value = val;
            Description = desc;
        }
    }
}
