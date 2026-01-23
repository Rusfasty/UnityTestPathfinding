using System;
namespace Code.Architecture.Player.Healths {
    public interface IHealth {
        float GetHealthCurrent();

        event Action<float> Hit;
        event Action<float> Heal;
        event Action<float,float> HealthChanged;
    }
}