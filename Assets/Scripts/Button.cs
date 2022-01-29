using System;
using PlayerMove;
using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject _activeItem;
    [SerializeField] private GameObject _hiddenItem;
    private float speed = 0.25f;
    private bool showItem;
    private bool portalAppearing;
    private bool backflipCamera;
    private bool wasPushed;
    private Vector3 lastPosition;
    Coroutine coroutine;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Player player) && !wasPushed)
        {
            MusicController.instance.stove.Play();
            ShowItem();
        }
    }

    void Start() {
        showItem = false;
        portalAppearing = false;
        backflipCamera = false;
        wasPushed = false;
    }

	private void FixedUpdate() {
        if (showItem && coroutine == null)
            coroutine = StartCoroutine(TranslateCamera());
        if (portalAppearing && coroutine == null)
            coroutine = StartCoroutine(ItemAppearing());
        if (backflipCamera && coroutine == null) {
            coroutine = StartCoroutine(TranslateCamera(true));
            wasPushed = true;
        }
	}

	//private void SwapItems()
 //   {
 //       //(_activeItem, _hiddenItem) = (_hiddenItem, _activeItem);
 //       if (_activeItem != null)
	//		ShowItem();
	//	//if (_hiddenItem != null)
	//	//	HideItem();
 //   }

    private void ShowItem()
    {
        GeneralSettings.instance.gameMode = GameMode.LOCKED;
        showItem = true;
    }

    //private void HideItem()
    //{
    //    _hiddenItem.SetActive(false);
    //}

    IEnumerator TranslateCamera(bool backflip = false) {
        if (!backflip) {
            Vector3 itemPos = _activeItem.transform.position;
            Vector3 newPos = new Vector3(itemPos.x, Camera.instance.transform.position.y, itemPos.z - 2f);

            // «апоминаем точку куда вернуть потом камеру
            lastPosition = Camera.instance.transform.position;

            for (int i = 0; i <= 100; ++i) {
                Camera.instance.transform.position = Vector3.Lerp(Camera.instance.transform.position, newPos, (float)i / 100 * speed);
                yield return null;
		    }
            portalAppearing = true;
            showItem = false;
        } else {
            for (int i = 0; i <= 100; ++i) {
                Camera.instance.transform.position = Vector3.Lerp(Camera.instance.transform.position, lastPosition, (float)i / 100 * speed);
                yield return null;
            }
            GeneralSettings.instance.gameMode = GameMode.UNLOCKED;
        }
        backflipCamera = false;
        coroutine = null;
        yield return null;
    }

    IEnumerator ItemAppearing() {

        _activeItem.SetActive(true);
        _activeItem.transform.localScale = Vector3.one;
        yield return new WaitForSeconds(1f);

		for (int i = 0; i <= 100; ++i) {
			_activeItem.transform.localScale = Vector3.Lerp(Vector3.one, new Vector3(70f, 70f, 70f), (float)i / 100 * speed * 8f);
			yield return null;
		}
        backflipCamera = true;
        portalAppearing = false;
        coroutine = null;
        yield return null;
    }
}
