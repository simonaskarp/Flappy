using UnityEngine;

public class Player : MonoBehaviour
{
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            print("Jump");
        }
    }
}
