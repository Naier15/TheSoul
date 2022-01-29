using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerMove;

public class FinishPortal : MonoBehaviour
{
    float i;

    void Start()
    {
        i = 0f;
        StartCoroutine(Pulsing());
    }

    void OnTriggerEnter(Collider other) {
        if (other.name == "Player") {
            StartCoroutine(other.GetComponent<Player>().MagicEffect(true));
            MusicController.instance.passPortal.Play();
        }
	}

    IEnumerator Pulsing() {
        while (true) {
            while (transform.localScale.x >= 41f) {

                transform.localScale = Vector3.Lerp(new Vector3(80f, 80f, 80f), new Vector3(40f, 40f, 40f), i);
                i += 0.01f;
                yield return new WaitForSeconds(0.01f);
            }
            i = 0f;
            while (transform.localScale.x <= 79f) {

                transform.localScale = Vector3.Lerp(new Vector3(40f, 40f, 40f), new Vector3(80f, 80f, 80f), i);
                i += 0.01f;
                yield return new WaitForSeconds(0.01f);
            }
            i = 0f;
        }
	}
}
