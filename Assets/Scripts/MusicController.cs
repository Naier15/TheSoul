using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] public AudioSource backgroundIntro;
    [SerializeField] public AudioSource background;
    [SerializeField] public AudioSource torches;
    [SerializeField] public AudioSource wind;
    [SerializeField] public AudioSource stove;
    [SerializeField] public AudioSource portals;
    [SerializeField] public AudioSource passPortal;

    public static MusicController instance;
    void Awake()
    {
        instance = this;       
    }

    
    void Update()
    {
        
    }
}
