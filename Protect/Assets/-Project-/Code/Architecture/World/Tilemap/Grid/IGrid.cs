using UnityEngine;

namespace Code.Architecture.World.TIlemap {
    public interface IGrid<T> where T : ITile {
        void CreateTile(int x, int y, T Tile);
        void Set(int x, int y, T Tile) {

        }
    }
}