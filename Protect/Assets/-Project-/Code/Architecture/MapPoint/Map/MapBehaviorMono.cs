using UnityEngine;

namespace Code.Architecture.MapPoints.MapBehaviors {
    public sealed class MapBehaviorMono : MonoBehaviour {
        [field:Header("LOl")]
        [field: SerializeField] public Vector2 SpawnPointStarting { get; private set; }
        [field: SerializeField] public Transform SpawnPoint { get; private set; }
        [field:Space]
        [field: SerializeField] public PointMono Point { get; private set; }
        [field: SerializeField] public PointMono[,] Points { get; private set; }

        public void Init() {

        }
        public void DoCreate() {
            Points = new PointMono[(int)SpawnPointStarting.x, (int)SpawnPointStarting.y];
            for (int I = 0; I < SpawnPointStarting.y; I++) {
                for (int L = 0; L < SpawnPointStarting.x; L++) {
                    var Point = DoGetCreatePoint();
                    Points[I,L] = Point;
                    var vector2 = Points[I,L].transform.position;
                    DoCreatePoint(new Vector2(vector2.y + I, vector2.z + L), Point);
                }
            }
        }
        public void DoDestroy() { }

        private void DoCreatePoint(Vector2 vector, PointMono Point) { 
            Point.gameObject.transform.position = new Vector3(vector.x, vector.y,0);
        }
        private PointMono DoGetCreatePoint() {
            PointMono PointMono = Instantiate(Point, SpawnPoint);
            return PointMono;
        }

    }
}
