using UnityEngine;

public class PlayerMoves : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    float MaxSpeed = 3.5f;

    void Start()
    {
        
    }

    // Update is called once per frame GOGO
    void Update()
    {
        // Returns a float from -1.0 to +1.0
       
        Vector3 pos = transform.position ;
        // Input.GetAxis("Vertical")
        pos.y += MaxSpeed * Time.deltaTime ;
        transform.position = pos ;
    }
}
