using UnityEngine;

public class FireBallRotation : MonoBehaviour
{
    [Range(10f,25f)]
    public float RotateSpeed = 15;




    void Update()
    {
        FireBallRotating();
    }

    void FireBallRotating()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(new Vector3(0,0,-RotateSpeed * Time.deltaTime));
        }
    }
}
