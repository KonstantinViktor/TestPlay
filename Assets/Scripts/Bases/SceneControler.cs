using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneControler : MonoBehaviour
{
    [SerializeField] private Record record;

    [SerializeField] private Text[] _textRecordCube;

    private void Start()
    {
        ChangeRecord(record.Count1 != null ? record.Count1 : 0, 1);
        ChangeRecord(record.Count2 != null ? record.Count2 : 0, 2);
    }

    public void Pauses(int time)
    {
        Time.timeScale = time;

        if (TryGetComponent<FinishPlay>(out FinishPlay finish))
            finish.IsPause = !finish.IsPause;
    }

    public void SetScene(int id)
    {
        SceneManager.LoadScene(id);
    }

    public void ChangeRecord(int record, int idCube)
    {
        _textRecordCube[idCube - 1].text = "Record" + idCube + ": " + record.ToString();
    }
}