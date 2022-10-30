using UnityEngine;

public class FinishPlay : MonoBehaviour
{
    public delegate void OnMove();
    public event OnMove Move;

    public bool IsPause { get; set; }

    private SceneControler _sceneControler;

    [SerializeField] private Record _record;
    [SerializeField] private Grid _grid;

    private void Start()
    {
        _sceneControler = FindObjectOfType<SceneControler>();
        new MovePlances(_grid, this);

        IsPause = false;
    }

    private void Update()
    {
        if (!IsPause)
            Move?.Invoke();
    }

    public void Finish(int cubeId)
    {
        _sceneControler.ChangeRecord(_record.AddRecord(cubeId), cubeId);
        _sceneControler.SetScene(0);
    }
}