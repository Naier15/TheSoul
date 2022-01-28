using PlayerMove;
using UnityEngine;

public class InputHandler
{
    private MoveCommand _buttonA;
    private MoveCommand _buttonD;
    private MoveCommand _buttonW;
    private MoveCommand _buttonS;

    public void SetCommandA(MoveCommand command)
    {
        _buttonA = command;
    }

    public void SetCommandD(MoveCommand command)
    {
        _buttonD = command;
    }

    public void SetCommandW(MoveCommand command)
    {
        _buttonW = command;
    }

    public void SetCommandS(MoveCommand command)
    {
        _buttonS = command;
    }

    public MoveCommand handleInput()
    {
        if (Input.GetKey(KeyCode.A)) return _buttonA;
        if (Input.GetKey(KeyCode.D)) return _buttonD;
        if (Input.GetKey(KeyCode.S)) return _buttonS;
        if (Input.GetKey(KeyCode.W)) return _buttonW;
        return null;
    }
}