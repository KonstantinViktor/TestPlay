using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public void CreatCube(GameObject cube)
    {
        Instantiate(cube, Vector3.zero, Quaternion.identity);
    }
}