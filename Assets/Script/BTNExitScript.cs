using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTNExitScript : MonoBehaviour
{
    public void Quitgame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    
}
