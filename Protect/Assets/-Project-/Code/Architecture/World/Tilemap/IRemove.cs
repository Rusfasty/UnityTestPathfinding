using Code.Architecture.World.Tilemap.Tile;
using UnityEngine;

namespace Code.Architecture.World.Tilemap {
    public interface IRemove {
        public void RemoveAllTiles();
        public void RemoveTile(TileMono tile);
    }
}