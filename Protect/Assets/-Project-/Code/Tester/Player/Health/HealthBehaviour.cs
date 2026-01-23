using Code.Architecture.Player;
using Code.Architecture.Player.Healths;
using System;
using UnityEngine;

namespace Code.Tester.Player {
    [Serializable]
    public class HealthBehaviour : IHealth, IDamage, IHeal {
        [SerializeField] private float _HealthCurrent;
        [SerializeField] private float _HealthMax;
        private IDie _DieAction;

        public HealthBehaviour(float MaxHealth,IDie DieAction) {
            _HealthMax = MaxHealth;
            _HealthCurrent = _HealthMax;
            _DieAction = DieAction;
        }

        public void TakeDamage(float amount) {
            var HealthOld = _HealthCurrent;
            _HealthCurrent -= amount;
            Hit.Invoke(amount);
            HealthChanged.Invoke(HealthOld, _HealthCurrent);
        }
        public void HHeal(float amount) {
            var HealthOld = _HealthCurrent;
            _HealthCurrent += amount;
            Heal.Invoke(amount);
            HealthChanged.Invoke(HealthOld, _HealthCurrent);
        }
        public void MaxHeal() {
            var HealthOld = _HealthCurrent;
            _HealthCurrent = _HealthMax;
            HealthChanged.Invoke(HealthOld, _HealthCurrent);
        } 

        public float GetHealthCurrent() => _HealthCurrent;
        public void Kill() => _DieAction.DieAction();

        public event Action<float> Hit;
        public event Action<float> Heal;
        public event Action<float, float> HealthChanged;
    }
}