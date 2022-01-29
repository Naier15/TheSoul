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
        MusicController.instance.passPortal.Play();
        _transform.Rotate(0, 0, 180);
        _isWhiteSide = !_isWhiteSide;
        FlipMusic();
    }

    void FlipMusic() {
        if (_isWhiteSide) {
            MusicController.instance.wind.Play();
            MusicController.instance.torches.Stop();
        } else {
            MusicController.instance.wind.Stop();
            MusicController.instance.torches.Play();
        }
	}
}
