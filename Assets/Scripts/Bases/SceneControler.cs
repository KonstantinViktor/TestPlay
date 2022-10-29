using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneControler : MonoBehaviour
{
    private MovePlances _movePlances;
    private CubeMove _cubeMove;

    [SerializeField] private Record record;

    [SerializeField] private Text _textRecordCube1;
    [SerializeField] private Text _textRecordCube2;

    private void Start()
    {
        ChangeRecord(record., 1);
        ChangeRecord(0, 2);
    }

    public void Pauses(int time)
    {
        Time.timeScale = time;

        if (TryGetComponent<CubeMove>(out _cubeMove))
            _cubeMove.IsPause = !_cubeMove.IsPause;
        if (TryGetComponent<MovePlances>(out _movePlances))
            _movePlances.IsPause = !_movePlances.IsPause;
    }

    public void SetScene(int id)
    {
        SceneManager.LoadScene(id);
    }

    public void ChangeRecord(int record, int idCube)
    {
        if (idCube == 1)
        {
            _textRecordCube1.text = "Record 1: " + record.ToString();
            return;
        }
        _textRecordCube2.text = "Record 2: " + record.ToString();
    }
}