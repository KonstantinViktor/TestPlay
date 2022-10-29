using UnityEngine;

public class FinishPlay : MonoBehaviour
{
    private SceneControler _sceneControler;
    private CubeMove cube;
    [SerializeField] private Record _record;

    public void Finish()
    {
        _sceneControler = FindObjectOfType<SceneControler>();
        cube = FindObjectOfType<CubeMove>();
        _sceneControler.ChangeRecord(_record.AddRecord(cube.Id), cube.Id);
        _sceneControler.SetScene(0);
    }
}