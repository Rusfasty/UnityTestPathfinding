using Code.Tester.World.Tilemap;
using System;

namespace Code.Architecture.World.Tilemap {
    public interface IGrid {
        public void Create(int X, int Y, Tile tile);
    }
}