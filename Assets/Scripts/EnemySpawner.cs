using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _runingTime = 0;
    private int _currentPoint = 0;

    private void Update()
    {
        _runingTime += Time.deltaTime;

        if(_runingTime >= _secondsBetweenSpawn)
        {
            _runingTime = 0;

            Instantiate(_template, _spawnPoints[_currentPoint]);

            _currentPoint++;

            if(_currentPoint >= _spawnPoints.Length)
            {
                _currentPoint = 0;
            }
        }
    }
}
