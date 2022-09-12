using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triger : MonoBehaviour
{
    [SerializeField] private float _speed = 2;
    [SerializeField] private GameObject _nps;
    private int _revers = -1;
    private bool _isMove = false;

    private void Update()
    {
        if (_isMove)
        {

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _isMove = true;
    }



}
