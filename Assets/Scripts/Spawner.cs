using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _npsSpawn;
    [SerializeField] private GameObject _pointSpavn1;
    [SerializeField] private GameObject _pointSpavn2;
    private bool _switch = true;

    void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        if (_switch)
        {
            StartCoroutine(SpawnNps(_npsSpawn,_pointSpavn1.transform));
            _switch = false;
        }else
        {
            StartCoroutine(SpawnNps(_npsSpawn, _pointSpavn2.transform));
            _switch = true;
        }
    }

    IEnumerator SpawnNps(GameObject gameObject, Transform transform)
    {
        GameObject nps = Instantiate(gameObject, transform);
        yield return new WaitForSeconds(2);
        Spawn();
    }
}
