using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMove : MonoBehaviour
{
    public int turn = 6;
    public float movespeed = 5;
    public Transform movepoint;
    public LayerMask stopmove;
    public bool isTurn = true;
    public bool moved = false;
    
    void Start()
    {
        movepoint.parent = null;
        isTurn = true;
        turn = 6;
    }

    
    void Update()
    {

        if (turn == 0)
        {
            isTurn = false;
        }
        if(isTurn == true)
        {
            

            transform.position = Vector3.MoveTowards(transform.position, movepoint.position, movespeed * Time.deltaTime);
            

            if (Vector3.Distance(transform.position, movepoint.position) <= .05f)
            {
                if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f && !moved)
                {
                    if (!Physics2D.OverlapCircle(movepoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, stopmove))
                    {
                        movepoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                    }
                    moved = true;
                    turn--;
                }
                else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f && !moved)
                {
                    if (!Physics2D.OverlapCircle(movepoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, stopmove))
                    {
                        movepoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                    }
                    moved = true;
                    turn--;
                }
                else if(Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 0 && Mathf.Abs(Input.GetAxisRaw("Vertical")) == 0)
                {
                    moved = false;
                }
            }
        }
        
    }
     
}
