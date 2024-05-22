using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Quit()
    {
        // Unity Editor'de çalýþýrken bu satýr bir mesaj gösterecektir
        // Derlenmiþ oyunda ise oyun kapanacaktýr
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
