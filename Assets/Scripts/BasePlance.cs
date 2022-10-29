using UnityEngine;
using System;
using System.Collections.Generic;

[CreateAssetMenu()]
public class BasePlance : ScriptableObject
{
    [SerializeField] private List<StatusPlance> _basePlances;

    [SerializeField] private Dictionary<int, GameObject> _dictionary;

    public Dictionary<int, GameObject> Diction => _dictionary;

    public void CreatDictionaty()
    {
        _dictionary = new Dictionary<int, GameObject>();

        for (int i = 0; i < _basePlances.Count; i++)
        {
            _dictionary.Add(_basePlances[i].Key, _basePlances[i].Plance);
        }
    }
}