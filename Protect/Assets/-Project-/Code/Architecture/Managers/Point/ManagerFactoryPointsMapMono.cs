using Code.Architecture.MapPoints.MapBehaviors;
using UnityEngine;

namespace Code.Architecture.Managers.Points {
    public class ManagerFactoryPointsMapMono : MonoBehaviour {
        [field: SerializeField] public MapBehaviorMono MapBehavior { get; private set; }
        [field: SerializeField] public Transform SpawnPoint { get; private set; }

        [field: SerializeField] public Vector2 SizeMap { get; private set; }

        public void Init() {
        }
        public void DoCreateMap() {

        }
        public void DoDestroyMap() { }

        public void SetSizeMap(Vector2 Vector2) { }
    }
}
