using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightEdgeCheck : MonoBehaviour
{
    public MoveController script;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Naomi")
        {
            script.rightEdge = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Naomi")
        {
            script.rightEdge = false;
        }
    }
}
