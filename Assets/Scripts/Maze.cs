using System;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class Maze : MonoBehaviour
{
    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    public void Flip()
    {
        _transform.Rotate(0, 0, 180);
    }
}
