using UnityEngine;

public class WatermelonMaker : MonoBehaviour
{
    public GameObject Watermelon;
    float xPosition,yPosition;

    void Start()
    {
       InvokeRepeating("Maker",2,2);
    }

    void Update() 
    {
       xPosition = Random.Range(2,-2);
       yPosition = Random.Range(2,-2);

       if (xPosition == 1)
       {
           xPosition = 2;
       }
       else if(xPosition== -1)
       {
           xPosition = -2;
       }

       if (yPosition == 1)
       {
           yPosition = 2;
       }
       else if(yPosition== -1)
       {
           yPosition = -2;
       }
    }

    void Maker()
    {
       Instantiate(Watermelon,new Vector2(xPosition,yPosition),Quaternion.identity);
    }
}
