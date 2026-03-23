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
        /*or(int i = 0; i < 10; i++)
         {
             Debug.Log(i);
         }*/
        int i = 20;
        while (i < 10)
        {
            Debug.Log(i);
            i++;
        }
        while (i < 10) ;
    }
      
    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Space))
        {/*
            num1++;
            Debug.Log("Num1 is at: " + num1);
            if(num1 == 11)
            {
                Debug.Log("A");
            }
            else if(num1 == 12)
            {
                Debug.Log("B");
            }
            else
            {
                Debug.Log("C");
            }
          switch(num1)
            {
                case 11:
                    Debug.Log("A");
                        break;

                case 12:
                    Debug.Log("B");
                    break;

                case 13:
                case 15:
                    Debug.Log("C");
                    break;

                default:
                    Debug.Log("Default");
                        break;
            }


        }
        
    }
}
           */
      