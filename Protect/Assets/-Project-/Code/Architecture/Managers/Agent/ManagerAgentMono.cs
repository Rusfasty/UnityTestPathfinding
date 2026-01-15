using UnityEngine;
using Code.Agents;

namespace Code.Architecture.Managers.Agents {
    public class ManagerAgentMono : MonoBehaviour {
        [field: SerializeField] public AgentBehavior Agent { get; private set; }


        public void Init() {
        }
    } 
}
