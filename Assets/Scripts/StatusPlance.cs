using System;
using UnityEngine;

[Serializable]
class StatusPlance
{
    [SerializeField] private int _key;
    [SerializeField] private GameObject _plance;

    public int Key => _key;
    public GameObject Plance => _plance;
}