using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sita : MonoBehaviour
{
    [SerializeField] float moveSpeed = 12f ;
   
    // Start is called before the first frame update
    void Start()
    {
        playerInstruction();
    }

    // Update is called once per frame
    void Update()
    {

        movePlayer();


    }

    void playerInstruction()
    {
        Debug.Log("welcome to game");
        Debug.Log("only say radhe radhe");
        Debug.Log("radha rani ki jai");

    }

    void movePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;


        transform.Translate(xValue, 0, zValue);
    }
}
