using Code.Architecture.World.Tilemap.Tile;
using Code.Architecture.World.Tilemap;
using UnityEngine;

namespace Code.Tester.World.Tilemap {
    public sealed class TilemapMono : MonoBehaviour, ICreate , IRemove {
        [SerializeField] private Vector2 _sizeWorld;
        [SerializeField] private TileMono _tileProfab;
        [SerializeField] private Transform _pointSpawn;

        [SerializeField] private TileMono[,] _tiles;

        public void Init() {
            DoCreateTile(_sizeWorld, _tileProfab);
        }

        //Test
        public void Start() => Init();

        public void DoCreateTile(Vector2 vector2, TileMono tile) {
            _tiles = new TileMono[(int)_sizeWorld.y, (int)_sizeWorld.x];
            for (int y = 0;y < vector2.y; y++) {
                for (int x = 0;x < vector2.x;x++ ) {
                    Debug.Log($"X:{x},Y:{y},");
                    var Tile = Instantiate(tile,new Vector3(x,y,0),Quaternion.Euler(0,0,0), _pointSpawn);
                    _tiles[(int)_sizeWorld.y-1, (int)_sizeWorld.x -1] = Tile;
                }
            }
        }

        public void RemoveAllTiles() { }
        public void RemoveTile(TileMono tile) { }
    }
}