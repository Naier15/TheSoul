using System;
using UnityEngine;
using System.Collections;

namespace PlayerMove
{
    public enum PlayerState
    {
        OnThePortal,
        OnTheFloor
    };

    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerState _state;
        public static Player instance;

        public PlayerState State => _state;

		private void Awake() {
            instance = this;
			//StartCoroutine(MagicEffect());
		}

		private void ChangeState(PlayerState state)
        {
            _state = state;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out Portal portal))
            {
                ChangeState(PlayerState.OnThePortal);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.TryGetComponent(out Portal portal))
            {
                ChangeState(PlayerState.OnTheFloor);
            }
        }

        public IEnumerator MagicEffect(bool theEnd = false) {
            ParticleSystem paticles = transform.GetChild(2).GetComponent<ParticleSystem>();
            paticles.Play();
            yield return new WaitForSeconds(1f);
            paticles.Stop();

            if (theEnd) {
                GeneralSettings.instance.gameMode = GameMode.LOCKED;
                GeneralSettings.instance.canvas.SetActive(true);
                GeneralSettings.instance.canvas.transform.GetChild(4).gameObject.SetActive(false);
                GeneralSettings.instance.canvas.transform.GetChild(3).gameObject.SetActive(true);
                MusicController.instance.backgroundIntro.Play();
                MusicController.instance.background.Stop();
                MusicController.instance.wind.Stop();
                MusicController.instance.torches.Stop();
            }
            yield return null;
        }
    }


}