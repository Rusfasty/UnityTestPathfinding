using Code.Architecture.Player.Healths;
using System;
namespace Code.Architecture.Player {
    public interface IPlayer {



        IDamage GetDamage();
        IHealth GetHealth();
        IHeal GetHeal();

        event Action Die;
    }
}