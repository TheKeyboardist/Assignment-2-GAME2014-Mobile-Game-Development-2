/***;
*Project            : Traffic Jumper 
*
*Program name       : "StartScript.cs"
*
* Author            : Ivan Kravchenko
* 
* Student Number    : 101183016
*
*Date created       : 20/11/20
*
*Description        : Loads main menu screen.
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

public class StartScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("MainMenuScreen");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
