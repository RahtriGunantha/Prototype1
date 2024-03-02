using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        // transform.Translate(0, 0, 1); (Sama aja artinya sama yang dibawah)
        // make player move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
       // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); (yang ini kaku kesamping kiri kanan)
       // make player turn vichele
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
