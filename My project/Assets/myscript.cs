using UnityEngine;

public class myscript : MonoBehaviour
{
    int my_int = 15;
    float my_float = 3.0788f;
    char my_char = 'c';
    string my_string = "Hello World";
    Vector2 my_vec2 = new Vector2(12,8);
    Vector3 my_vec3 = new Vector3(4.6f, 10.2f, 13.5f);

    int[] my_array = { 1, 3, 7, 6, 65, 77, 112 };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("My Variables");   
        Debug.Log(my_int);   
        Debug.Log(my_float);   
        Debug.Log(my_char);   
        Debug.Log(my_string);   
        Debug.Log(my_vec2);   
        Debug.Log(my_vec3);
        Debug.Log(my_array[5]);      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
