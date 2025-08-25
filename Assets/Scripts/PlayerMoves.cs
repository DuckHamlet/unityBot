using UnityEngine;

public class PlayerMoves : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float MaxSpeed = 5f;
    public float rotSPeed = 180f;

    void Start()
    {
        
    }

    // Update is called once per frame GOGO
    void Update()
    {
        // ROTTION OF THE SHIP

        // Grab our rotation quaternuin
        Quaternion rot = transform.rotation;

        // Grab the Z euler angle
        float z = rot.eulerAngles.z;

        // Change the Z angle based on input
        z += Input.GetAxis("Horizontal") * rotSPeed * Time.deltaTime;

        // Recreate the quaternion
        rot = Quaternion.Euler ( 0, 0 , z);

        // feed quatornion into our rotation
        transform.rotation = rot;


        // MOVE SHIP 
        // Returns a float from -1.0 to +1.0
        Vector3 pos = transform.position;
        /*pos.y += Input.GetAxis("Vertical") * MaxSpeed * Time.deltaTime ;
        transform.position = pos ; */

        Vector3 velocity = new Vector3(0, -Input.GetAxis("Vertical") * MaxSpeed * Time.deltaTime, 0);

        pos += rot * velocity;

        transform.position = pos;

        // Short versiion possble to do as well
        //transform.Translate(new Vector3(0, Input.GetAxis("Vertical") * MaxSpeed * Time.deltaTime, 0) );
    }
}
