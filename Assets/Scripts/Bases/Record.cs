using UnityEngine;

[CreateAssetMenu()]
class Record : ScriptableObject
{
    [SerializeField] private int countFinishCube1 = 0;
    [SerializeField] private int countFinishCube2 = 0;

    

    public int AddRecord(int idCube)
    {
        if (idCube == 1)
            return ++countFinishCube1;
        else
            return ++countFinishCube2;
    }
}