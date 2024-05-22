using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score = 0;
    public Text scoreText;
    public Transform playerTransform;

    private float startZPosition;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // Oyuncunun baþlangýç pozisyonunu kaydet
        if (playerTransform != null)
        {
            startZPosition = playerTransform.position.z;
        }
        UpdateScoreText();
    }

    void Update()
    {
        if (playerTransform != null)
        {
            // Oyuncunun baþlangýç pozisyonundan ne kadar ilerlediðini hesapla
            float distanceTravelled = playerTransform.position.z - startZPosition;
            score = Mathf.FloorToInt(distanceTravelled);
            UpdateScoreText();
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(2);
    }


}
