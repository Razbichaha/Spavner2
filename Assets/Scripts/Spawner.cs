using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   private Nps _nps = new Nps();
    [SerializeField] private GameObject _nps;
    [SerializeField] private Transform[] _pointSpawn = new Transform[2];

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
            Instantiate(_nps, _pointSpawn[i]);
            yield return new WaitForSeconds(_pauseTime);
        }

        Spawn();
    }
}
