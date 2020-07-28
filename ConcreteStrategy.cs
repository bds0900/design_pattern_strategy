using System;
namespace avengers
{
    # region Attack strategy
    
    public class MissileStrategy : AttackStrategy
    {
        public MissileStrategy()
        {
            Console.WriteLine("Set the missile strategy");
        }
        public void Attack()
        {
            Console.WriteLine("Fire the missile.");
        }
    }
    public class PunchStrategy : AttackStrategy
    {
        public PunchStrategy()
        {
            Console.WriteLine("Set the punch strategy");
        }
        public void Attack()
        {
            Console.WriteLine("Punching");
        }
    }
    public class WhipStrategy : AttackStrategy
    {
        public WhipStrategy()
        {
            Console.WriteLine("Set the whip strategy");
        }
        public void Attack()
        { 
            Console.WriteLine("flip flip");
        }
    }
    #endregion
    
    
    #region Move strategy
    
    public class FlyingStrategy : MovingStrategy
    {
        public FlyingStrategy(){Console.WriteLine("Set the flying strategy");}
        public void Move(){Console.WriteLine("I can fly");}
    }
    public class WalkingStrategy : MovingStrategy
    {
        public WalkingStrategy(){Console.WriteLine("Set the walking strategy");}
        public void Move(){Console.WriteLine("walking is boring... I want to jump");}
    }
    public class TeleportStrategy : MovingStrategy
    {
        public TeleportStrategy(){Console.WriteLine("Set the teleport strategy");}
        public void Move(){Console.WriteLine("I can go anywhere");}
    }
    #endregion
}