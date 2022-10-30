using UnityEngine;

public class MovePlances
{
    private LayerMask _layerPlance = 4;
    private float _distancy = 100;
    private Vector2 offset = new Vector2(3, 2);

    private Grid _grid;

    private GameObject _objMove;

    private Vector2 MousePos => Camera.main.ScreenToWorldPoint(Input.mousePosition);

    public MovePlances(Grid grid, FinishPlay finish)
    {
        _grid = grid;

        finish.Move += Move;
    }

    private void Move()
    {
        if (Input.GetMouseButton(0))
        {
            MovePlance();
        }
        if (Input.GetMouseButtonUp(0) && _objMove != null)
        {
            Vector2 pos = MousePos - _grid.OffSet;

            _objMove.transform.position = _grid.GridCell[(int)((pos.x / (_grid.Size.x - offset.x))), (int)((pos.y / (_grid.Size.y - offset.y)))];
            _objMove = null;
        }

    }

    private void MovePlance()
    {
        if (_objMove == null)
        {
            var rayMouse = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(rayMouse, out hit, _distancy, _layerPlance))
            {
                if (hit.transform.parent != null)
                    _objMove = hit.transform.parent.gameObject;
                else
                    _objMove = hit.collider.gameObject;
            }
        }

        if (_objMove != null)
            _objMove.transform.position = MousePos;
    }
}