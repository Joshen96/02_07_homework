using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
   
    
    private void Start()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision) //이때 ui에 표시해주기
    {
        if(collision.gameObject.tag == "Player")
        {
            
            Destroy(this.gameObject);
            Keycount.key_count--;
            Debug.Log("열쇠확인:"+Keycount.key_count);
            
           
        }
    }
}
