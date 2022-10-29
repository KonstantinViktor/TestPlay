using UnityEngine;

public class SpawnPlance : MonoBehaviour
{
    [SerializeField, Range(2, 16)] private int _countPlance = 3;
    [SerializeField] private int _maxKey1 = 3, _maxKey2 = 3;

    [SerializeField] private Vector2 startPos;
    [SerializeField] private Vector2 endPos;

    [SerializeField] private BasePlance _basePlance;

    private int _key;

    private void Start()
    {
        CreatPlances();
    }

    private void CreatPlances()
    {
        for (int i = 0; i < _countPlance; i++)
        {
            if (_basePlance.D.ContainsKey(_key))
            {
                Vector2 pos = new Vector2(Random.Range(startPos.x, endPos.x), Random.Range(startPos.y, endPos.y));
                Instantiate(_basePlance.D[_key], pos, Quaternion.identity);
            }
        }
    }
}