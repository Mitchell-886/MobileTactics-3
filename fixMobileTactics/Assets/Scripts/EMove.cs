using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMove : MonoBehaviour
{
    public int Emoves = 0;
    public float movespeed = 5;
    public Transform Player;
    public LayerMask stopmove;


    void Start()
    {
        //movepoint.parent = null;
    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Player.position, movespeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, Player.position) <= .05f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                if (!Physics2D.OverlapCircle(Player.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, stopmove))
                {
                    Player.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }
            }
            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                if (!Physics2D.OverlapCircle(Player.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, stopmove))
                {
                    Player.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                }
            }
        }

    }
}
