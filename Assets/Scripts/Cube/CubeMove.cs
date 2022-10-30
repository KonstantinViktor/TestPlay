using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public delegate void Finish(int cubeId);
    public event Finish Finaliti;

    [SerializeField] private float _speed = 8;
    [SerializeField] private float _maxPosX = 0;
    [SerializeField] private float _radius = 0.2f;

    [SerializeField] private int _id;

    private Transform _cube;
    private FinishPlay _finish;

    private bool isSetStartPosision = false;

    private Vector2 MousePos => Camera.main.ScreenToWorldPoint(Input.mousePosition);

    public void Start()
    {
        _cube = GetComponent<Transform>();
        _finish = FindObjectOfType<FinishPlay>();

        Finaliti += _finish.Finish;
    }

    private void Update()
    {
        if (!_finish.IsPause)
        {
            if (!isSetStartPosision)
                SetStartPosision();
            if (isSetStartPosision)
                Move();
        }
    }

    private void SetStartPosision()
    {
        if (Input.GetMouseButton(0))
        {
            _cube.position = MousePos;
            isSetStartPosision = true;
        }
    }

    private void Move()
    {
        RaycastHit hit;

        if (Physics.Raycast(_cube.position, -_cube.up, out hit, _radius))
            _cube.Translate(hit.transform.right * _speed * Time.deltaTime);
        else
            _cube.Translate(-_cube.up * _speed * Time.deltaTime);


        DetectionPos();
    }

    private void DetectionPos()
    {
        if (_cube.position.x >= _maxPosX)
        {
            Finaliti?.Invoke(_id);
        }
    }
}