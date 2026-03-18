using UnityEngine;

public class myscript : MonoBehaviour
{
    public int my_int = 15;
    public float my_float = 3.0788f;
    public char my_char = 'c';
    public string my_string = "Hello World";
    private Vector2 my_vec2 = new Vector2(12,8);
    public Vector3 my_vec3 = new Vector3(4.6f, 10.2f, 13.5f);
    public int[] my_array = { 1, 3, 7, 6, 65, 77, 112 };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        //Start
        Debug.Log(Add(my_int, 11));
        //Stop
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public int Add(int num1, int num2)
    {
       return num1 + num2;
    }
}
