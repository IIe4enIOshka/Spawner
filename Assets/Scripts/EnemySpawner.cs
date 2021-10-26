using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _templateEnemy;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _waitForSeconds;
    [SerializeField] private int _numberEnemies;

    private int _currentPoint = 0;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var waitForSeconds = new WaitForSeconds(_waitForSeconds);

        for (int i = 0; i < _numberEnemies; i++)
        {
            Instantiate(_templateEnemy, _spawnPoints[_currentPoint]);

            _currentPoint++;

            if (_currentPoint >= _spawnPoints.Length)
            {
                _currentPoint = 0;
            }

            yield return waitForSeconds;
        }
    }
}
