using UnityEngine;

[CreateAssetMenu()]
class Record : ScriptableObject
{
    [SerializeField] private int _countFinishCube1 = 0;
    [SerializeField] private int _countFinishCube2 = 0;

    public int Count1 => _countFinishCube1;
    public int Count2 => _countFinishCube2;

    public int AddRecord(int idCube)
    {
        if (idCube == 1)
            return ++_countFinishCube1;

        return ++_countFinishCube2;
    }
}