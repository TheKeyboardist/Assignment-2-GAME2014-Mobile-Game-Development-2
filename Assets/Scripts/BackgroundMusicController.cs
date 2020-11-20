/***;
*Project            : Traffic Jumper 
*
*Program name       : "BackgoundMusicController.cs"
*
* Author            : Ivan Kravchenko
* 
* Student Number    : 101183016
*
*Date created       : 20/11/20
*
*Description        : Plays music throughout the entire game and gets muted when gameplayscene is loaded.
*
*Last modified      : 20/11/20
*
* Revision History  :
*
*Date        Author Ref    Revision (Date in YYYYMMDD format) 
*201120    Ivan Kravchenko        Created script. 
*
|**/




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusicController : MonoBehaviour
{
    public AudioSource _audioSource;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();

    }


    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();

    }

    public void StopMusic()
    {
        _audioSource.Stop();
        
    }    

    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("music").GetComponent<BackgroundMusicController>().PlayMusic();
        
    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "GameplayScene")
        {
            _audioSource.volume = 0.0f;

        }
        else _audioSource.volume = 1.0f;
  
    }
}
