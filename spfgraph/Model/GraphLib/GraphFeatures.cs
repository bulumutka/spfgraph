﻿using System;

namespace spfgraph.Model.GraphLib {

    /// <summary>
    ///  Class, that encapsulates all features
    ///  of the dag graph.
    /// </summary>
    public class GraphFeatures {

        #region Public Properties 

        public int Height { get; set; }
        public int Width { get; set; }
        public double AvrgWidth { get; set; }
        public double Irregular { get; set; }
        public double AvrgDeviation { get; set; }

        #endregion

        #region Overrided Methods

        public override bool Equals(object obj) {
            var feature = (GraphFeatures)obj;
            if (feature.Height == Height && feature.Width == Width && Math.Abs(AvrgWidth - feature.AvrgWidth) <= 0.0001 && Irregular == feature.Irregular)
                return true;
            else
                return false;
        }

        public override string ToString() => $"Height: {Height} \nWidth: {Width} \nAvrgWidth: {AvrgWidth} \nIrregular: {Irregular} \nAvrgDeviation: {AvrgDeviation} ";

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        #endregion

    }
}
