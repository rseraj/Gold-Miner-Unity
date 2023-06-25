using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookMovement : MonoBehaviour{
    public float min_Z = -55f, max_Z = 55f;
    private float rotate_Speed = 55f;

    private float rotate_Angle;
    private bool rotate_Right;
    private bool canRotate;

    public float move_Speed = 3f;
    private float initial_Move_Speed;

    public float min_Y = -2.5f;
    private float initial_Y;

    private bool moveDown;


  
    void Awake()
    {
       
    }
  
    void Start(){
        initial_Y = transform.position.y;
        initial_Move_Speed = move_Speed;

        canRotate = true;
        
    }

    // Update is called once per frame
    void Update(){
        Rotate();
        GetInput();
        MoveRope();
        
    }
    void Rotate()
    {
        if (!canRotate)
            return;

        if (rotate_Right)
        {
            rotate_Angle += rotate_Speed * Time.deltaTime;

        }
        else
        {
            rotate_Angle -= rotate_Speed * Time.deltaTime;

        }
        transform.rotation = Quaternion.AngleAxis(rotate_Angle, Vector3.forward);
        if(rotate_Angle >= max_Z)
        {
            rotate_Right = false;

        }else if (rotate_Angle <= min_Z)
        {
            rotate_Right = true;
        }
    } //can rotate
    void GetInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (canRotate)
            {
                canRotate = false;
                moveDown = true;
            }
        }
    } // get input
    void MoveRope(){
        if (canRotate)
            return;
        if (!canRotate)
        {
            SoundManager.instance.RopeStretch(true);
            Vector3 temp = transform.position;
            if (moveDown)
            {
                temp -= transform.up * Time.deltaTime * move_Speed;

            }
            else
            {
                temp += transform.up * Time.deltaTime * move_Speed;
            }
            transform.position = temp;
            if(temp.y<= min_Y)
            {
                moveDown = false;
            }
            if(temp.y>= initial_Y)
            {
                canRotate = true;
               
               
                // reset move speed
                move_Speed = initial_Move_Speed;
                SoundManager.instance.RopeStretch(false);
            }
           
        }//cannot rtate



    }// move rope
    public void HookAttachedItem()
    {
        moveDown = false;

    }

}
