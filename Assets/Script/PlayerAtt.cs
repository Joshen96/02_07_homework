using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtt : MonoBehaviour
{
    public GameObject attprefab;

    //public int maxT = 3;

    public float throwX =4f;
    public float throwY = 4f;
    public float offsetY = 1f;

    //
    bool pushFlag = false;
    bool turnFlag = false;


    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            turnFlag = false;
        }
        if (Input.GetKey("left"))
        {
            turnFlag = true;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            if(pushFlag == false)
            {
               pushFlag = true;
                Vector3 area = this.GetComponent<SpriteRenderer>().bounds.size;
                Vector3 newPos = this.transform.position;
                newPos.y += offsetY;
                GameObject newGameObject = Instantiate(attprefab) as GameObject;
                newPos.z = -5;
                newGameObject.transform.position = newPos; // 새로생성되는 오브젝트 위치 newPos에서 나타나도록
                Rigidbody2D newOBrigi = newGameObject.GetComponent<Rigidbody2D>();

                if (turnFlag)
                {          
                    newOBrigi.AddForce(new Vector2(-throwX, throwY), ForceMode2D.Impulse);
                }
                else
                {
                    newOBrigi.AddForce(new Vector2(throwX, throwY), ForceMode2D.Impulse);
                }


            }
        }
        else
        {
            pushFlag = false;
        }


    }
}
