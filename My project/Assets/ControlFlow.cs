using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    public float num1 = 10;
    public float num2 = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        Debug.Log(num1 < 5 || num1 > 8 || num1 == 10);
        Debug.Log(num1 < 5 || num1 > 8 && num1 == 10);
        Debug.Log(num1 < 5 || (num1 > 8 && num1 == 10));
        Debug.Log((num1 < 5 || num1 > 8) && num1 == 10);
        Debug.Log(num1 < 5 || num1 > 8 && num1 == 10);
       */
    }
      
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            num1++;
            Debug.Log("Num1 is at: " + num1);
            if(num1 % 2 == 0)
            {
                Debug.Log(num1 + " is even!");
            }
            else
            {
                Debug.Log(num1 + " is odd");
            }
        }
        
    }
}
