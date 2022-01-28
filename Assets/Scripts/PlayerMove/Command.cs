using UnityEngine;

namespace PlayerMove
{
    public abstract class Command
    {
        public abstract void Move(Mover movableObject);
    }

    public class MoveLeft : Command
    {
        public override void Move(Mover movableObject)
        {
            movableObject.Move();
            movableObject.Rotate(270);
        }
    }
    
    public class MoveRight : Command
    {
        public override void Move(Mover movableObject)
        {
            movableObject.Move();
            movableObject.Rotate(90);
        }
    }
    
    public class MoveDown : Command
    {
        public override void Move(Mover movableObject)
        {
            movableObject.Move();
            movableObject.Rotate(180);
        }
    }
    
    public class MoveUp : Command
    {
        public override void Move(Mover movableObject)
        {
            movableObject.Move();
            movableObject.Rotate(360);
        }
    }
}