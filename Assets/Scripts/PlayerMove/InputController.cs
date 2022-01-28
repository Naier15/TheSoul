using System;
using UnityEngine;

namespace PlayerMove
{
    public class InputController : MonoBehaviour
    {
        [SerializeField] private Mover _player;
        [SerializeField] private Maze _maze;
        
        private InputHandler _inputHandler;

        private void Start()
        {
            _inputHandler = new InputHandler();
            _inputHandler.SetCommandA(new MoveLeft());
            _inputHandler.SetCommandD(new MoveRight());
            _inputHandler.SetCommandS(new MoveDown());
            _inputHandler.SetCommandW(new MoveUp());
            _inputHandler.SetCommandSpace(new FlipMaze());
        }

        private void FixedUpdate()
        {
            PlayerCommand playerCommand = _inputHandler.handlePlayerInput();
            if (playerCommand != null)
            {
                playerCommand.Move(_player);
            }
        }

        private void Update()
        {
            MazeCommand mazeCommand = _inputHandler.handleMazeInput();
            if (mazeCommand != null)
            {
                mazeCommand.Execute(_maze);
            }
        }
    }
}