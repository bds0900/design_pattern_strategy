using System;
namespace avengers
{
    public abstract class Hero {
        private String name;
        private AttackStrategy AttackStrategy;
        private MovingStrategy movingStrategy;


        public Hero(String name) 
        { 
            this.name = name; 
            Console.WriteLine("my name is "+ this.GetName());
        }
        public String GetName() 
        { 
            return name; 
        }
        public void Attack()
        {
            AttackStrategy.Attack();
        }
        public void Move()
        {
            movingStrategy.Move();
        }


        public void SetAttackStrategy(AttackStrategy AttackStrategy)
        {
            this.AttackStrategy=AttackStrategy;
        }
        public void SetMovingStrategy(MovingStrategy movingStrategy)
        {
            this.movingStrategy=movingStrategy;
        }
    }
}