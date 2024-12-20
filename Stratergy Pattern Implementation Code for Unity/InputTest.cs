using UnityEngine;

public class InputTest : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Key 1 Pressed");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Key 2 Pressed");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Spacebar Pressed");
        }
    }
}
