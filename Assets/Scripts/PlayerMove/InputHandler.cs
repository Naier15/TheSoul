using PlayerMove;
using UnityEngine;

public class InputHandler
{
    private PlayerCommand _buttonA;
    private PlayerCommand _buttonD;
    private PlayerCommand _buttonW;
    private PlayerCommand _buttonS;
    private MazeCommand _buttonSpace;

    public void SetCommandA(MoveLeft command)
    {
        _buttonA = command;
    }

    public void SetCommandD(PlayerCommand command)
    {
        _buttonD = command;
    }

    public void SetCommandW(PlayerCommand command)
    {
        _buttonW = command;
    }

    public void SetCommandS(PlayerCommand command)
    {
        _buttonS = command;
    }

    public void SetCommandSpace(MazeCommand command)
    {
        _buttonSpace = command;
    }

    public PlayerCommand handlePlayerInput()
    {
        if (Input.GetKey(KeyCode.A)) return _buttonA;
        if (Input.GetKey(KeyCode.D)) return _buttonD;
        if (Input.GetKey(KeyCode.W)) return _buttonW;
        if (Input.GetKey(KeyCode.S)) return _buttonS;
        return null;
    }

    public MazeCommand handleMazeInput()
    {
        if (Input.GetKeyDown(KeyCode.Space)) return _buttonSpace;
        return null;
    }
}