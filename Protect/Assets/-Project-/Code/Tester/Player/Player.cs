using Code.Architecture.Player;
using Code.Architecture.Player.Healths;
using UnityEngine;
using System;

namespace Code.Tester.Player {
    public class Player : MonoBehaviour, IPlayer, IDie {
        [field: SerializeField] public HealthBehaviour Health { get; private set; }

        public IDamage GetDamage() => Health;
        public IHealth GetHealth() => Health;
        public IHeal GetHeal() => Health;

        public void DieAction() => Die.Invoke();

        public event Action Die;
    }
}