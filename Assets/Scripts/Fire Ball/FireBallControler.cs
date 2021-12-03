using UnityEngine;

public class FireBallControler : MonoBehaviour
{
    public Transform Coin;
    Rigidbody2D _fireBallRigidbody;
    bool _canJumping;



    void Start()
    {
        _fireBallRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!_canJumping)
        {
            _fireBallRigidbody.AddForce((Coin.position - transform.position) * 250f * Time.deltaTime);
        }     
    }


    private void OnTriggerEnter2D(Collider2D waterMelon) 
    {
        if (waterMelon.CompareTag("Watermelon"))
        {
            Destroy(waterMelon.gameObject);
            _canJumping = true;

            _fireBallRigidbody.velocity = Vector2.zero;
            
            _fireBallRigidbody.AddForce((transform.position) * 10000f * Time.deltaTime);
            Invoke("Gravity",1);
        }

        if (waterMelon.CompareTag("Coin"))
        {
            Time.timeScale = 0;
        }    
    }

    void Gravity()
    {
        _canJumping = false;
    }
    
}
