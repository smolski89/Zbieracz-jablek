using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BTNStartScript : MonoBehaviour
{
    public void DetectClickButton()
    {
        SceneManager.LoadScene("_Scene_0");
    }
}
