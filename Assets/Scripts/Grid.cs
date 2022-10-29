using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField] private int _countWight;
    [SerializeField] private int _countHight;

    [SerializeField] private int _sizeWight;
    [SerializeField] private int _sizeHight;

    [SerializeField] private Vector2 _offset = new Vector2(9, 31);

    private Vector2[,] _grid;

    public Vector2[,] GridCell { get => _grid; private set => _grid = value; }
    public Vector2 OffSet { get => _offset; private set => _offset = value; }
    public Vector2 Size { get => new Vector2(_sizeWight, _sizeHight); }

    private void OnValidate()
    {
        CreagtGrid();
    }

    private void Start()
    {
        CreagtGrid();
    }

    private void CreagtGrid()
    {
        _grid = new Vector2[_countWight, _countHight];

        for (int i = 0; i < _countWight; i++)
        {
            for (int j = 0; j < _countHight; j++)
            {
                _grid[i, j] = _offset + new Vector2(_sizeWight * i, _sizeHight * j);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        for (int i = 0; i < _countWight; i++)
            for (int j = 0; j < _countHight; j++)
                Gizmos.DrawCube(_grid[i, j], new Vector3(_sizeWight, _sizeHight, 1));
    }
}