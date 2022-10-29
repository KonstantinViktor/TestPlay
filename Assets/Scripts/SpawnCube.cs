using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    private Vector2 MousePos => Camera.main.ScreenToWorldPoint(Input.mousePosition);


    public void CreatCube(GameObject cube)
    {
        Instantiate(cube, MousePos, Quaternion.identity);
    }
}