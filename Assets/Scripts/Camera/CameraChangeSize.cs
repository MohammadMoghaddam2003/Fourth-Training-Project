using UnityEngine;

public class CameraChangeSize : MonoBehaviour
{
    public GameObject FireBall , Coin;


    
    void Update()
    {
        float distance = Vector2.Distance(FireBall.transform.position , Coin.transform.position);

        if (distance > 5)
        {
            Camera.main.orthographicSize = distance;
        }
        else
        {
            Camera.main.orthographicSize = 5;
        }
    }
}
