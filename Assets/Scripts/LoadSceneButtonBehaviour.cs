/***;
*Project            : Traffic Jumper 
*
*Program name       : "LoadSceneButtonBehaviour.cs"
*
* Author            : Ivan Kravchenko
* 
* Student Number    : 101183016
*
*Date created       : 20/11/20
*
*Description        : Load scenes with button press.
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


public class LoadSceneButtonBehaviour : MonoBehaviour
{
    public AudioSource click;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Delay(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(sceneName);
    }


    // Event Handler for the StartButton_Pressed Event
    public void OnPlayButtonPressed()
    {
        click.Play();
        StartCoroutine("Delay", 0.15f);
        Debug.Log("PlayButton Pressed");

    }

}
