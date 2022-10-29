using UnityEngine;

public class SceneControler : MonoBehaviour
{
    private MovePlances _movePlances;
    private CubeMove _cubeMove;

    public void Pauses(int time)
    {
       // Time.timeScale = time;

        if (TryGetComponent<MovePlances>(out _movePlances))
            _movePlances.IsPause = !_movePlances.IsPause;
        if (TryGetComponent<CubeMove>(out _cubeMove))
            _cubeMove.IsPause = !_cubeMove.IsPause;
    }
}