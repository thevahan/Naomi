using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftEdgeCheck : MonoBehaviour
{
    public MoveController script;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Naomi")
        {
            script.leftEdge = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Naomi")
        {
            script.leftEdge = false;
        }
    }
}
