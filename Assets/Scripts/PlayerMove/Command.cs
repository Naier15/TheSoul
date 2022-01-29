using UnityEngine;

namespace PlayerMove
{
    public abstract class PlayerCommand
    {
        public abstract void Move(Mover movableObject);
    }

    public abstract class MazeCommand
    {
        public abstract void Execute(Maze maze, Hider hider, LightController lightController);
    }

    public class MoveLeft : PlayerCommand
    {
        public override void Move(Mover movableObject)
        {
            movableObject.Rotate(270);
            movableObject.Move();
        }
    }
    
    public class MoveRight : PlayerCommand
    {
        public override void Move(Mover movableObject)
        {
            movableObject.Rotate(90);
            movableObject.Move();
        }
    }
    
    public class MoveDown : PlayerCommand
    {
        public override void Move(Mover movableObject)
        {
            movableObject.Rotate(180);
            movableObject.Move();
        }
    }
    
    public class MoveUp : PlayerCommand
    {
        public override void Move(Mover movableObject)
        {
            movableObject.Rotate(360);
            movableObject.Move();
        }
    }

    public class FlipMaze : MazeCommand
    {
        public override void Execute(Maze maze, Hider hider, LightController lightController)
        {
            maze.Flip();
            if (maze.IsWhiteSide == true)
            {
                hider.HideObjects();
                lightController.ShowObjects();
            }
            else
            {
                hider.ShowObjects();
                lightController.HideObjects();
            }
        }
    }
}