using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walkimg_KAI : MonoBehaviour
{
    // Start is called before the first frame update
    Animator kai;

    void Start()
    {
        
        kai = this.gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true && Input.GetKey(KeyCode.LeftShift) == false)
        {
            Debug.Log("W");
            transform.Translate(0, 0, 0.001f);
            kai.Play("Walk In Place");

            if (Input.GetKey(KeyCode.A))
            {
                Debug.Log("A");
                transform.Rotate(0, -0.5f, 0);
            }

            else if (Input.GetKey(KeyCode.D))
            {
                Debug.Log("D");
                transform.Rotate(0, 0.5f, 0);
            }

        }
        else if (Input.GetKey(KeyCode.LeftShift) == true && Input.GetKey(KeyCode.W) == true)
        {
            Debug.Log("LeftShift+W");
            transform.Translate(0, 0, 0.005f);
            kai.Play("Run In Place");

            if (Input.GetKey(KeyCode.A))
            {
                Debug.Log("A");
                transform.Rotate(0, -0.5f, 0);
            }

            else if (Input.GetKey(KeyCode.D))
            {
                Debug.Log("D");
                transform.Rotate(0, 0.5f, 0);
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
            transform.Rotate(0, 0.5f, 0);
            kai.Play("Walk In Place");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
            transform.Rotate(0, -0.5f, 0);
            kai.Play("Walk In Place");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S");
            transform.Translate(0, 0, -0.0005f);
            kai.Play("Walk In Place");
        }

        else
        {
            Debug.Log("");
            kai.Play("Idle");
        }

       

    }
    

}
