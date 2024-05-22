using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    // Spawnlanacak araba prefab'larýnýn dizisi
    public GameObject[] carPrefabs;

    // Spawn noktasýnýn pozisyonu ve spawnlanacak arabalar arasýndaki mesafe
    public Transform spawnPoint;
    public float spawnDistance = 35f;

    // Oyuncu ve araba spawn'lanacak yolda ilerleme takibi
    public Transform playerTransform;
    private float nextSpawnZ;

    // Araba spawnlama aralýðý (saniye cinsinden)
    public float spawnInterval = 0f;
    private float spawnTimer = 0.7f;

    void Start()
    {
        // Ýlk spawnlanacak nokta oyuncunun baþlangýç pozisyonu + spawnDistance
        nextSpawnZ = playerTransform.position.z + spawnDistance;
    }

    void Update()
    {
        // Spawn timer'ý güncelle
        spawnTimer -= Time.deltaTime;

        // Eðer spawn timer sýfýra veya daha küçükse, bir araba spawnla
        if (spawnTimer <= 0f)
        {
            // Oyuncu spawnlanacak noktayý geçtiðinde yeni bir araba spawnla
            if (playerTransform.position.z >= nextSpawnZ - spawnDistance)
            {
                SpawnCar();
                nextSpawnZ += spawnDistance; // Bir sonraki spawn noktasý
            }

            // Zamanlayýcýyý yeniden baþlat
            spawnTimer = spawnInterval;
        }
    }
    
    void SpawnCar()
    {
        // Rastgele bir pozisyon seç (x ekseninde) ve z ekseni sabit
        Vector3 spawnPos = new Vector3(
            spawnPoint.position.x + Random.Range(-4.10f, 4.2f),
            spawnPoint.position.y,
            nextSpawnZ
        );

        // Rastgele bir araba prefab'ý seç
        GameObject carPrefab = carPrefabs[Random.Range(0, carPrefabs.Length)];

        // Arabayý spawnla
        Instantiate(carPrefab, spawnPos, Quaternion.identity);
    }
}


