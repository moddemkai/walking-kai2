using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking_Kai_AI : MonoBehaviour
{
    // Start is called before the first frame update
    Animator kai;
    bool is_Idle;
    bool is_Walk_In_Place;
    bool is_Run_In_Place;
    bool is_Eat;
    bool is_Turn_Head;
    int Time_Delay;
    int actioncode;
    int Time_Random;

    void Start()
    {
        kai = this.gameObject.GetComponent<Animator>();
        Time_Delay = 0;
        actioncode = Random.Range(1, 6);
        Time_Random = Random.Range(500, 1500);

    }

 
    void Update()
    {
        is_Idle = false;
        is_Walk_In_Place = false;
        is_Run_In_Place = false;
        is_Eat = false;
        is_Turn_Head = false;


        Time_Delay++;

            if (Time_Delay >= Time_Random)
            {
                actioncode = Random.Range(1, 6);
                Time_Delay = 0;
                Time_Random = Random.Range(500, 1500);

            }


        if (actioncode == 1)
        {
            is_Idle = true;

        }
        else if(actioncode == 2)
        {
            is_Walk_In_Place = true;
        }
        else if(actioncode == 3)
        {
            is_Run_In_Place = true;
        }
        else if(actioncode == 4)
        {
            is_Eat = true;
        }
        else if(actioncode ==5)
        {
            is_Turn_Head = true;
        }




        if(is_Idle == true)
        {
            kai.Play("Idle");
        }
        else if(is_Walk_In_Place == true)
        {
            kai.Play("Walk In Place");
            transform.Translate(0, 0, 0.001f);
        }
        else if(is_Run_In_Place == true)
        {
            kai.Play("Run In Place");
            transform.Translate(0, 0, 0.005f);
        }
        else if (is_Eat == true)
        {
            kai.Play("Eat");
        }
        else if (is_Turn_Head == true)
        {
            kai.Play("Turn Head");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Fance")
        {
            transform.Rotate(0, 100, 0);
        }
        else if(collision.collider.tag == "Kai")
        {
            transform.Rotate(0, 100, 0);
        }
    }

}
