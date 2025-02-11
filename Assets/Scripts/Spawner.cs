using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private Transform[] _spawnPoint;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {

        while (true)
        {
            int minLenght = 0;
            int maxLenght = _spawnPoint.Length;
            float minValue = -1f;
            float maxValue = 1f;
            Vector3 moveDirection = new Vector3(UnityEngine.Random.Range(minValue,maxValue), UnityEngine.Random.Range(minValue,maxValue), UnityEngine.Random.Range(minValue, maxValue));

            Transform randomSpawnPoit = _spawnPoint[UnityEngine.Random.Range(minLenght, maxLenght)];
            Enemy enemy = Instantiate(_prefab, randomSpawnPoit.position, Quaternion.identity);

            Enemy enemyScript = enemy.GetComponent<Enemy>();

            if (enemyScript != null) 
            {
                enemyScript.SetDirection(moveDirection);
            }

            yield return new WaitForSeconds(2f);
        }
    }

}
