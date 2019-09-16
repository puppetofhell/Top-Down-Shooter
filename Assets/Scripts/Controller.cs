using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float rotationSpeed = 450;
    public float walkSPeed = 5;
    public float runSpeed = 4 ;
    private Quaternion targetRotation;
    private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));
        if(input!= Vector3.zero) {
           targetRotation = Quaternion.LookRotation(input);
        }
            transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y,transform.eulerAngles.y,rotationSpeed*Time.deltaTime);
        
    }
}
