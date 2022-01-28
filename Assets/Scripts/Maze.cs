using System;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class Maze : MonoBehaviour
{
    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    public void Flip()
    {
        _transform.Rotate(180, 0, 0);
    }
}
