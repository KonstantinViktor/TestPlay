using UnityEngine;
using System;
using System.Collections.Generic;

[CreateAssetMenu()]
public class BasePlance : ScriptableObject
{
    [SerializeField] private List<MyClass> ss;

    [SerializeField] private Dictionary<int, GameObject> s;

    public Dictionary<int, GameObject> D => s;
    private void OnEnable()
    {
        for (int i = 0; i < ss.Count; i++)
        {
            s.Add(ss[i].Key, ss[i].Plance);
        }
    }

    [Serializable]
    class MyClass
    {
        [SerializeField] private int _key;
        [SerializeField] private GameObject _plance;

        public int Key => _key;
        public GameObject Plance => _plance;
    }
}