using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Quit()
    {
        // Unity Editor'de �al���rken bu sat�r bir mesaj g�sterecektir
        // Derlenmi� oyunda ise oyun kapanacakt�r
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
