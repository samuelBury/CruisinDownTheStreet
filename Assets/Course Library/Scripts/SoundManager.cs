using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource m_AudioSource;
    private AudioSource car_AudioSource;
    public AudioClip playMusic;
    public AudioClip menuMusic;
    public AudioClip motorSound;
    public AudioClip explosionSound;
    
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        car_AudioSource = GameObject.Find("Player").GetComponent<AudioSource>();
    }
    public void startGame()
    {
        m_AudioSource.clip = playMusic;
        car_AudioSource.clip = motorSound;
        m_AudioSource.Play();
        car_AudioSource.Play();
        
    }
    public void GameOver()
    {
       
        m_AudioSource.clip = menuMusic;
        m_AudioSource.Play();
        car_AudioSource.Stop();
    }
    public void crash()
    {
        car_AudioSource.PlayOneShot(explosionSound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
