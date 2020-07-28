using System;

namespace avengers
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero iron=new IronMan("Toni");
            iron.SetAttackStrategy(new MissileStrategy());
            iron.SetMovingStrategy(new FlyingStrategy());
            iron.Move();
            iron.Attack();

            Hero magician=new DoctorStrange("???");
            magician.SetAttackStrategy(new WhipStrategy());
            magician.SetMovingStrategy(new TeleportStrategy());
            magician.Move();
            magician.Attack();

            Hero hulk=new Hulk("Banner");
            hulk.SetAttackStrategy(new PunchStrategy());
            hulk.SetMovingStrategy(new WalkingStrategy());
            hulk.Move();
            hulk.Attack();

        }
    }
}
