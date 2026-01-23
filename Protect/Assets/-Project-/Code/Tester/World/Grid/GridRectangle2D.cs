using Code.Architecture.World.TIlemap;
using Code.Tester.Grid.Tiles;
using UnityEngine;

namespace Code.Tester.Grid {
    public class GridRectangle2D : MonoBehaviour, IGrid<Tile> {
        [field: SerializeField] public Tile[,] Tiles { get; private set; }

        public const int MAXHEIGHT = 12;
        public const int MAXWIDTH = 12;

        public void Init() {
            Tiles = new Tile[MAXHEIGHT, MAXWIDTH];
        }

        public void CreateTile(int x, int y, Tile Tile) {

        }
        public void Set(int x, int y, Tile Tile) {

        }
    }
}