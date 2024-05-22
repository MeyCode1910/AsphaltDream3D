using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    // Spawnlanacak araba prefab'lar�n�n dizisi
    public GameObject[] carPrefabs;

    // Spawn noktas�n�n pozisyonu ve spawnlanacak arabalar aras�ndaki mesafe
    public Transform spawnPoint;
    public float spawnDistance = 35f;

    // Oyuncu ve araba spawn'lanacak yolda ilerleme takibi
    public Transform playerTransform;
    private float nextSpawnZ;

    // Araba spawnlama aral��� (saniye cinsinden)
    public float spawnInterval = 0f;
    private float spawnTimer = 0.7f;

    void Start()
    {
        // �lk spawnlanacak nokta oyuncunun ba�lang�� pozisyonu + spawnDistance
        nextSpawnZ = playerTransform.position.z + spawnDistance;
    }

    void Update()
    {
        // Spawn timer'� g�ncelle
        spawnTimer -= Time.deltaTime;

        // E�er spawn timer s�f�ra veya daha k���kse, bir araba spawnla
        if (spawnTimer <= 0f)
        {
            // Oyuncu spawnlanacak noktay� ge�ti�inde yeni bir araba spawnla
            if (playerTransform.position.z >= nextSpawnZ - spawnDistance)
            {
                SpawnCar();
                nextSpawnZ += spawnDistance; // Bir sonraki spawn noktas�
            }

            // Zamanlay�c�y� yeniden ba�lat
            spawnTimer = spawnInterval;
        }
    }
    
    void SpawnCar()
    {
        // Rastgele bir pozisyon se� (x ekseninde) ve z ekseni sabit
        Vector3 spawnPos = new Vector3(
            spawnPoint.position.x + Random.Range(-4.10f, 4.2f),
            spawnPoint.position.y,
            nextSpawnZ
        );

        // Rastgele bir araba prefab'� se�
        GameObject carPrefab = carPrefabs[Random.Range(0, carPrefabs.Length)];

        // Arabay� spawnla
        Instantiate(carPrefab, spawnPos, Quaternion.identity);
    }
}


