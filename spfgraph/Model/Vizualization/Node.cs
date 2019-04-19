﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Model {
    public class Node : Element {
        public int Value { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Node(int x, int y, int value) {
            Value = value;
            X = x;
            Y = y;
        }

        public Node(Node n) : this(n.X, n.Y, n.Value) { }
    }
}