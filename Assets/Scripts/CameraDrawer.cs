using UnityEngine;

public class CameraDrawer : MonoBehaviour
{
       
    [SerializeField] private UnityEngine.Camera _camera;

    public void ChangeColor()
    {
        if (_camera.backgroundColor == Color.white)
        {
            _camera.backgroundColor = Color.black;
        }
        else
        {
            _camera.backgroundColor = Color.white;
        }
    }
}
