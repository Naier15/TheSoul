using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameMode {
    LOCKED, UNLOCKED
}

public class GeneralSettings : MonoBehaviour
{
    [SerializeField] public GameObject canvas;

    public static GeneralSettings instance;
    public GameMode gameMode;

    void Awake()
    {
        instance = this;
        gameMode = GameMode.LOCKED;
        canvas.SetActive(true);
    }

    void Update()
    {
        
    }

    public void Go() {
        canvas.SetActive(false);
        gameMode = GameMode.UNLOCKED;
        StartCoroutine(PlayerMove.Player.instance.MagicEffect());
        MusicController.instance.backgroundIntro.Stop();
        MusicController.instance.background.Play();
        MusicController.instance.portals.Play();
        MusicController.instance.wind.Play();
    }

    public void StartNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
