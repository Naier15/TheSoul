using UnityEngine;
using System.Collections.Generic;

public class Hider : MonoBehaviour
{
    [SerializeField] private List<GameObject> _hiddenObjects;
    
    public void ShowObjects()
    {
        foreach (var t in _hiddenObjects)
        {
            t.SetActive(true);
        }
    }

    public void HideObjects()
    {
        foreach (var t in _hiddenObjects)
        {
            t.SetActive(false);
        }
    }
}
