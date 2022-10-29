using UnityEngine;
using System;

public class SpawnPlance : MonoBehaviour
{
    [SerializeField, Range(2, 16)] private int _countPlance = 3;
    [SerializeField] private int _maxKey1 = 3, _maxKey2 = 3;

    [SerializeField] private Vector2 startPos;
    [SerializeField] private Vector2 endPos;

    [SerializeField] private BasePlance _basePlance;

    private void Start()
    {
        CreatPlances();
    }

    private void CreatPlances()
    {
        _basePlance.CreatDictionaty();

        int key1 = 0;
        int key2 = 0;
        int key;

        for (int i = 0; i < _countPlance; i++)
        {
            if (i == 0)
                key1 = UnityEngine.Random.Range(1, _maxKey2);
            else
                key1 = key2;

            key2 = UnityEngine.Random.Range(1, _maxKey2);

            key = Convert.ToInt32(key1 + "" + key2);
            print(key);
            if (_basePlance.Diction.ContainsKey(key))
            {
                Vector2 pos = new Vector2(UnityEngine.Random.Range(startPos.x, endPos.x), UnityEngine.Random.Range(startPos.y, endPos.y));
                Instantiate(_basePlance.Diction[key], pos, Quaternion.identity);
            }
        }
    }
}