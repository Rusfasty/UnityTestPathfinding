using Code.Tester.World.Tilemap;
using UnityEngine;

public class TestWorldManager : MonoBehaviour {
    [field: SerializeField] public Vector2 Size { get; private set; }
    [field: SerializeField] public TilemapMono TilemapMono { get; private set; }

    public void InitAll() {
        TilemapMono.SetSize(Size);

        TilemapMono.Init();
    }
    public void StartTest1() {
        var gird = TilemapMono.grid;
        gird.CreateTiles();
    }
    public void StartTest2() => TilemapMono.CreateGirdTile(Size);
}