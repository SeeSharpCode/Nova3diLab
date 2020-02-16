﻿using System;
using System.IO;

namespace Nova3diLab.Model.Lod
{
    public class Vertex : IModelSerializable
    {
        public short Index { get; }
        public short X { get; }
        public short Y { get; }
        public short Z { get; }

        public Vertex(short index, short x, short y, short z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(X);
            writer.Write(Y);
            writer.Write(Z);
            writer.Write((short)0);
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}