using Code.Architecture.World.Tilemap.Tile;
using UnityEngine;

namespace Code.Architecture.World.Tilemap {
    public interface ICreate {
        public void DoCreateTile(Vector2 vector2, TileMono tile);
    }
}
