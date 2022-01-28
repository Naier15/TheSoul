using System;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class Maze : MonoBehaviour
{
    [SerializeField] private bool _isWhiteSide = true;

    private Transform _transform;

    public bool IsWhiteSide => _isWhiteSide;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    public void Flip()
    {
        _transform.Rotate(0, 0, 180);
        _isWhiteSide = !_isWhiteSide;
    }
}
