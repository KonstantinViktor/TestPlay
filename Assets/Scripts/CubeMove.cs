using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _radius = 0.2f;

    private Transform cube;

    private bool isMove = true;

    public bool IsPause { get; set; }

    private Vector2 MousePos => Camera.main.ScreenToWorldPoint(Input.mousePosition);

    private void Start()
    {
        cube = GetComponent<Transform>();
        IsPause = false;
    }

    private void Update()
    {
        if (IsPause)
            return;

        if (Input.GetMouseButton(0) && isMove)
        {
            cube.position = MousePos;
            isMove = false;
        }
        else if (!isMove)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, -transform.up, out hit, _radius))
                cube.Translate(hit.transform.right * _speed * Time.deltaTime);
            else
                cube.Translate(-cube.up * _speed * Time.deltaTime);
        }
    }
}