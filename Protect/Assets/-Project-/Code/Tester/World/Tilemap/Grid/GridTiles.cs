using Code.Architecture.World.Tilemap;
using UnityEngine;

namespace Code.Tester.World.Tilemap {
    public sealed class GridTiles : MonoBehaviour, IGrid {
        [field: SerializeField] public Vector2 Size { get; private set; }
        [field: SerializeField] public Tile Tile  { get; private set; }
        [field: SerializeField] public Tile[,] Grid { get; private set; }

        public void Init(Vector2 size) {
            Size = size;
            Debug.Log($"{(int)Size.x},{(int)Size.y}");
            Grid = new Tile[(int)Size.x, (int)Size.y];
        }
        public void Create(int X,int Y,Tile ttile) {
            Tile tile = Instantiate(ttile, new Vector3(X, Y), transform.rotation, transform);
            Grid[X,Y] = tile;
        }
        public void CreateTiles() {
            for (int y = 0; y < Size.y; y++) {
                for (int x = 0; x < Size.x; x++) {
                    Debug.Log($"{x},{y}");
                    Tile tile = Instantiate(Tile, new Vector3(x,y), transform.rotation, transform);
                    Grid[x,y] = tile;
                }
            }
        }
    }
}