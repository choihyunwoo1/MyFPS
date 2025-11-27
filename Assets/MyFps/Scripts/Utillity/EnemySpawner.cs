using UnityEngine;
using System.Collections;

namespace MyFps
{
    public class EnemySpawner : MonoBehaviour
    {
        public GameObject enemyPrefab;
        public Transform spawnPoint;
        public float spawnInterval = 10f;

        public void StartSpawn()
        {
            StartCoroutine(SpawnLoop());
        }

        IEnumerator SpawnLoop()
        {
            while (true)
            {
                Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
                yield return new WaitForSeconds(spawnInterval);
            }
        }
    }
}