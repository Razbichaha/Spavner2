using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _nps;
    [SerializeField] private GameObject[] _pointSpawn = new GameObject[2];

    private int _pauseTime = 2;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        StartCoroutine(SpawnNps());
    }

    IEnumerator SpawnNps()
    {
        for (int i = 0; i < _pointSpawn.Length; i++)
        {
            Instantiate(_nps, _pointSpawn[i].transform);
            yield return new WaitForSeconds(_pauseTime);
        }

        Spawn();
    }
}
