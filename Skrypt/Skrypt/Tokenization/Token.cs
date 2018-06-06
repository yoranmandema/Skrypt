﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skrypt.Tokenization {
    /// <summary>
    /// Represents part of a string with a type.
    /// </summary>
    class Token {
        public string Value { get; set; }
        public string Type { get; set; }
        public int Start { get; set; }
        public int End { get; set; }

        // Override to debug tokens properly
        public override string ToString() {
            return "(" + Start + "," + End + ") Type: " + Type + ", Value: " + Value;
        }
    }
}
