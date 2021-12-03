using UnityEngine;

public class LineMaker : MonoBehaviour
{
    public Transform Coin , FireBall;
    Vector3[] _positions = new Vector3[2];
    LineRenderer _lineRenderer;


    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        _positions[0] = Coin.position;
        _positions[1] = FireBall.position;
        _lineRenderer.SetPositions(_positions);
    }
}
