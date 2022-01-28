using PlayerMove;
using UnityEngine;

public class InputHandler
{
    private Command _buttonA;
    private Command _buttonD;
    private Command _buttonW;
    private Command _buttonS;

    public void SetCommandA(Command command)
    {
        _buttonA = command;
    }

    public void SetCommandD(Command command)
    {
        _buttonD = command;
    }

    public void SetCommandW(Command command)
    {
        _buttonW = command;
    }

    public void SetCommandS(Command command)
    {
        _buttonS = command;
    }

    public Command handleInput()
    {
        if (Input.GetKey(KeyCode.A)) return _buttonA;
        if (Input.GetKey(KeyCode.D)) return _buttonD;
        if (Input.GetKey(KeyCode.S)) return _buttonS;
        if (Input.GetKey(KeyCode.W)) return _buttonW;
        return null;
    }
}