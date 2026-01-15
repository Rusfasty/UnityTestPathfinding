using UnityEngine;

namespace Code.Architecture.MapPoints {
    public sealed class PointMono : MonoBehaviour {
        [field:SerializeField] public PointMono[] PointsNeighbours { get; private set; }
         
        public void Init() {
            gameObject.SetActive(false);
        }
    }
}