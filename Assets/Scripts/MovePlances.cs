using UnityEngine;

public class MovePlances : MonoBehaviour
{
    [SerializeField] private LayerMask _layerPlance;
    [SerializeField] private float _distancy = 100;

    private GameObject _objMove;
    private Grid _grid;

    private Vector2 MousePos => Camera.main.ScreenToWorldPoint(Input.mousePosition);

    private void Start()
    {
        _grid = GetComponent<Grid>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MovePlance();
        }
        if (Input.GetMouseButtonUp(0) && _objMove != null)
        {
            Vector2 pos = MousePos - _grid.OffSet;

            _objMove.transform.position = _grid.GridCell[(int)((pos.x / _grid.Size.x)), (int)((pos.y / _grid.Size.y))];
            print(_objMove.transform.position);
            _objMove = null;
        }
    }

    private void MovePlance()
    {
        var rayMouse = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(rayMouse, out hit, _distancy, _layerPlance))
            _objMove = hit.collider.gameObject.transform.parent.gameObject;

        if (_objMove != null)
            _objMove.transform.position = MousePos;
    }
}