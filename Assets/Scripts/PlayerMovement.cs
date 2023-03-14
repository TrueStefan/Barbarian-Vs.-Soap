using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float jumpforce = 10f;
    private bool canJump;
    private Rigidbody selfRigidbody;

    // Start is called before the first frame update
    void Start()
    {
     selfRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //read values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //move the player
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput *5);
        transform.Translate(-Vector3.left * Time.deltaTime * horizontalInput *5);

        if(canJump){
         canJump = false;
         selfRigidbody.AddForce(0, jumpforce, 0, ForceMode.Impulse);
        }

        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }

     if(Input.GetKeyUp(KeyCode.Space)){
         canJump = true;
     }
    }
}
         