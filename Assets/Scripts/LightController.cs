using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField] private List<Light> _lightPoints;
    
    public void ShowObjects()
    {
        foreach (var t in _lightPoints)
        {
            t.enabled = true;
        }
    }

    public void HideObjects()
    {
        foreach (var t in _lightPoints)
        {
            t.enabled = false;
        }
    }
}
