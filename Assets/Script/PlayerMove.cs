using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //�ִϸ��̼� �κ�
    public string idel_ani = "Frontplayer";
    public string right_ani = "Frontplayer";
    public string left_ani= "Frontplayer";


    string now_ani = "";
    //�̵��κ�
    public float speed = 3f;
    public float JumpPower = 8f;

    float vx = 0;

    //���� �κ�
    bool pushFlag = false;
    bool jumpFlag = false;
    bool groundFlag = false;


    Rigidbody2D player_rigi;
    // Start is called before the first frame update
    void Start()
    {
        player_rigi = GetComponent<Rigidbody2D>();
        player_rigi.constraints = RigidbodyConstraints2D.FreezeRotation; //�浹�� ȸ������

    }

    // Update is called once per frame
    void Update()
    {
        vx  =0;
        now_ani = idel_ani;
        if(Input.GetKey("right"))
        {
            vx = speed;
            now_ani = right_ani;

        }
        if(Input.GetKey("left"))
        {
            vx =-speed;
            now_ani = left_ani;
        }

        if (Input.GetKey("space")&& groundFlag) //����
        {
            if(pushFlag == false)
            {
                jumpFlag = true;
                pushFlag = true;
            }
        }
        else
        {
            pushFlag = false;
        }
    }

    private void FixedUpdate()
    {
        player_rigi.velocity = new Vector2(vx, player_rigi.velocity.y);//�̵�
        this.GetComponent<Animator>().Play(now_ani);//�ִϿ��̼�

        if (jumpFlag) //����Ű ������
        {
            jumpFlag = false;
            player_rigi.AddForce(new Vector2(0, JumpPower), ForceMode2D.Impulse);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        groundFlag = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        groundFlag = false;
    }
}
