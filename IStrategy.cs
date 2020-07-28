using System;
namespace avengers
{
    public interface AttackStrategy
    {
        public void Attack();
    }
    public interface MovingStrategy
    {
        public void Move();
    }
}