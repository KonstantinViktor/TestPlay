using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _radius = 0.2f;

    private Transform cube;

    private void Start()
    {
        cube = GetComponent<Transform>();
    }

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit, _radius))
            cube.Translate(hit.transform.right * _speed * Time.deltaTime);
        else
            cube.Translate(-cube.up * _speed * Time.deltaTime);
    }
}