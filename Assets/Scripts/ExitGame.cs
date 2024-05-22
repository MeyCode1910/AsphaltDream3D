using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Quit()
    {
        // Unity Editor'de çalışırken bu satır bir mesaj gösterecektir
        // Derlenmiş oyunda ise oyun kapanacaktır
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
