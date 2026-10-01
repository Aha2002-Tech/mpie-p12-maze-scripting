using UnityEngine;

public class PlayerMovement: MonoBehaviour
{


// speed 
public float speed = 1.0f;
// rotation
//public float rotationSpeed = 10.0f;
 
void Start()
{


}

    // Update is called once per frame
    void Update()
    {
     float translation = Input.GetAxis("Vertical") * speed;
    float rotation = Input.GetAxis("Horizontal") * speed;

        //translation *= Time.deltaTime;
        //rotation *= Time.deltaTime;
        transform.rotation = Quaternion.Euler(translation, 0, -rotation);
        


    }
}
