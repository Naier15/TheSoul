namespace PlayerMove
{
    public abstract class MoveCommand
    {
        public abstract void Execute(Mover movableObject);
    }

    public class Move : MoveCommand
    {
        public override void Execute(Mover movableObject)
        {
            movableObject.Move();
        }
    }
}