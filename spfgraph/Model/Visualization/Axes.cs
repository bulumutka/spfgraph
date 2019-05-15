﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace spfgraph.Model.Visualization {
    [DataContract]
    public class Axes : Element {
        [DataMember]
        public int X1 { get; set; }
        [DataMember]
        public int Y1 { get; set; }
        [DataMember]
        public int X2 { get; set; }
        [DataMember]
        public int Y2 { get; set; }

        public Axes(int x1, int y1, int x2, int y2) {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }
    }
}
