using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private Transform[] _spawnPoint;
    [SerializeField] private float _delay = 2f;
    [SerializeField] private Prey _prey;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        WaitForSeconds delay = new WaitForSeconds(_delay);

        while (true)
        {
            int minLenght = 0;
            int maxLenght = _spawnPoint.Length;
            Transform moveDirection = _prey.transform;

            Transform randomSpawnPoit = _spawnPoint[UnityEngine.Random.Range(minLenght, maxLenght)];
            Enemy enemy = Instantiate(_prefab, randomSpawnPoit.position, Quaternion.identity);

            if (enemy != null)
            {
                enemy.SetDirection(moveDirection);
                yield return delay;
            }
        }
    }

}
