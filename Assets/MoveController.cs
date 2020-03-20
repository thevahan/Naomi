using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveController : MonoBehaviour
{
    public GameObject Naomi;
    public GameObject leftMoveButton, rightMoveButton;
    public Animator NaomiAnim;
    private bool isRight = false, isLeft = false;
    public float speed;
    public bool leftEdge = false, rightEdge = false;

    private void Start()
    {
        Application.targetFrameRate = 300;
        PlayerPrefs.SetInt("turnaround", 0);
    }
    public void rightMove()
    {
        if (rightEdge)
        {
            return;
        }
        leftMoveButton.SetActive(false);
        PlayerPrefs.SetInt("turnaround", 0);
        isRight = true;
    }

    public void stopRightMove()
    {
        leftMoveButton.SetActive(true);
        isRight = false;
    }

    public void leftMove()
    {
        if (leftEdge)
        {
            return;
        }
        rightMoveButton.SetActive(false);
        PlayerPrefs.SetInt("turnaround", 180);
        isLeft = true;
    }

    public void stopLeftMove()
    {
        rightMoveButton.SetActive(true);
        isLeft = false;
    }

    private void Update()
    { 
        if (isRight && !rightEdge)
        {
            NaomiAnim.SetBool("walk", true);
            Naomi.transform.Translate(speed, 0, 0);
        }
        else if (isLeft && !leftEdge)
        {
            Naomi.transform.Translate(-speed, 0, 0);
            NaomiAnim.SetBool("walk", true);
        }
        else
        {
            NaomiAnim.SetBool("walk", false);
        }
        Naomi.transform.eulerAngles = new Vector3(0, PlayerPrefs.GetInt("turnaround"), 0);
    }
}
