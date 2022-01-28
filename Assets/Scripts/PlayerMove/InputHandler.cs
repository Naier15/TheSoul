using UnityEngine;

namespace PlayerMove
{
    public class InputHandler
    {
        private MoveCommand _buttonA;
        private MoveCommand _buttonS;
        private MoveCommand _buttonD;
        private MoveCommand _buttonW;

        private void Start()
        {
            _buttonA = new Move();
            _buttonS = new Move();
            _buttonD = new Move();
            _buttonW = new Move();
        }

        public MoveCommand handleInput()
        {
            Debug.Log(Input.GetKeyDown(KeyCode.A));
            if (Input.GetKeyDown(KeyCode.A)) return _buttonA;
            if (Input.GetKeyDown(KeyCode.S)) return _buttonS;
            if (Input.GetKeyDown(KeyCode.D)) return _buttonD;
            if (Input.GetKeyDown(KeyCode.W)) return _buttonW;
            return null;
        }
    }
}