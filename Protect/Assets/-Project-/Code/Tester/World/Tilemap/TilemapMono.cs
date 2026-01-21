using Code.Architecture.World.Tilemap;
using UnityEngine;

namespace Code.Tester.World.Tilemap {
    public class TilemapMono : MonoBehaviour {
        [field: SerializeField] public Tile tile { get; private set; }
        [field: SerializeField] public Vector2 Size { get; private set; }
        [field: SerializeField] public GridTiles grid { get; private set; }

        public void Init() {
            grid.Init(Size);
        }
        public void SetSize(Vector2 size) {
            Size = size;
        }

        public void CreateGirdTile(Vector2 Size) {
            for (int y = 0; y < Size.y; y++) { 
                for (int x = 0; x < Size.x; x++) {
                    grid.Create(x, y, tile);
                }
            }
        }
    }
}