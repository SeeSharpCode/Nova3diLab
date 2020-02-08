﻿using Nova3diLab.Utility;
using System;
using System.IO;

namespace Nova3diLab.Model.Lod
{
    public class SubObject : IModelSerializable
    {
        public int VertexCount { get; set; }
        public int FacesCount { get; set; }
        public int NormalsCount { get; set; }
        public int CollisionVolumesCount { get; set; }
        public double XMinimum { get; set; }
        public double XMaximum { get; set; }
        public double YMinimum { get; set; }
        public double YMaximum { get; set; }
        public double ZMinimum { get; set; }
        public double ZMaximum { get; set; }
        public double XMedian { get; set; }
        public double YMedian { get; set; }
        public double ZMedian { get; set; }
        public double BoundingSphereRadius { get; set; }
        public double ZTotal => ZMaximum - ZMinimum;

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(0);
            writer.Write(VertexCount);
            writer.Write(0);
            writer.Write(FacesCount);
            writer.Write(0);
            writer.Write(NormalsCount);
            writer.Write(0);
            writer.Write(CollisionVolumesCount);
            writer.Write(0);
            writer.Write(new byte[28]);
            writer.WriteFixedPoint(XMinimum);
            writer.WriteFixedPoint(XMaximum);
            writer.WriteFixedPoint(YMinimum);
            writer.WriteFixedPoint(YMaximum);
            writer.WriteFixedPoint(ZMinimum);
            writer.WriteFixedPoint(ZMaximum);
            writer.WriteFixedPoint(XMedian);
            writer.WriteFixedPoint(YMedian);
            writer.WriteFixedPoint(ZMedian);
            writer.WriteFixedPoint(BoundingSphereRadius);
            writer.WriteFixedPoint(BoundingSphereRadius);
            writer.WriteFixedPoint(ZTotal);
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}