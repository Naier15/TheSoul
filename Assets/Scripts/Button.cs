using System;
using PlayerMove;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject _activeItem;
    [SerializeField] private GameObject _hiddenItem;

    private void Start()
    {
        ShowItem();
        HideItem();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Player player))
        {
            SwapItems();
        }
    }

    private void SwapItems()
    {
        (_activeItem, _hiddenItem) = (_hiddenItem, _activeItem);
        ShowItem();
        HideItem();
    }

    private void ShowItem()
    {
        _activeItem.SetActive(true);
    }

    private void HideItem()
    {
        _hiddenItem.SetActive(false);
    }
}
