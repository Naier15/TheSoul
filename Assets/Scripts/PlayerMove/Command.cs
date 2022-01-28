using UnityEngine;

namespace PlayerMove
{
    public abstract class PlayerCommand
    {
        public abstract void Move(Mover movableObject);
    }

    public abstract class MazeCommand
    {
        public abstract void Execute(Maze maze);
    }

    public class MoveLeft : PlayerCommand
    {
        public override void Move(Mover movableObject)
        {
            movableObject.Move();
            movableObject.Rotate(270);
        }
    }
    
    public class MoveRight : PlayerCommand
    {
        public override void Move(Mover movableObject)
        {
            movableObject.Move();
            movableObject.Rotate(90);
        }
    }
    
    public class MoveDown : PlayerCommand
    {
        public override void Move(Mover movableObject)
        {
            movableObject.Move();
            movableObject.Rotate(180);
        }
    }
    
    public class MoveUp : PlayerCommand
    {
        public override void Move(Mover movableObject)
        {
            movableObject.Move();
            movableObject.Rotate(360);
        }
    }

    public class FlipMaze : MazeCommand
    {
        public override void Execute(Maze maze)
        {
            maze.Flip();
        }
    }
}