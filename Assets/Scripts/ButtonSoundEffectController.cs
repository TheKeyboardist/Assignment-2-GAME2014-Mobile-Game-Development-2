/***;
*Project            : Traffic Jumper 
*
*Program name       : "ButtonSoundEffectController.cs"
*
* Author            : Ivan Kravchenko
* 
* Student Number    : 101183016
*
*Date created       : 20/11/20
*
*Description        : Plays a sound on button press.
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
using UnityEngine.UI;

public class ButtonSoundEffectController : MonoBehaviour
{
    public AudioSource clickSoound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void PlaySound()
    {
        clickSoound.Play(); 
    }
}
