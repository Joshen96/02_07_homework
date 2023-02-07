using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door_clear : MonoBehaviour
{

    public static bool uIclear = false;

    private void Start()
    {
        uIclear = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("문에 닿음");

            if (Keycount.key_count == 0&& Rockhit.mosterdie==true)
            {
                Debug.Log("클리어");
                Time.timeScale = 0;
                uIclear = true;
            }
            else
            {
                
                Debug.Log("남은키수"+ Keycount.key_count +"몬스터 잡음여부"+ Rockhit.mosterdie + "클리어불가");
            }


        }
    }
}
