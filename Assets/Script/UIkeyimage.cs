using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIkeyimage : MonoBehaviour
{

    public Image key1;
    public Image key2;
    public Image key3;
    public Image killmonster;
    public Image gameclear;
    public Image replay;


    private void Start()
    {
        key1.GetComponent<Image>().enabled = false;
        key2.GetComponent<Image>().enabled = false;
        key3.GetComponent<Image>().enabled = false;
        killmonster.GetComponent<Image>().enabled = false;
        gameclear.GetComponent<Image>().enabled = false;
        replay.GetComponent<Image>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {


        if (Keycount.key_count == 2)
        {
            key1.GetComponent<Image>().enabled = true;
        }
       
        if (Keycount.key_count == 1)
        {
            key1.GetComponent<Image>().enabled = true;
            key2.GetComponent<Image>().enabled = true;

        }

        if (Keycount.key_count == 0)
        {
            key1.GetComponent<Image>().enabled = true;
            key2.GetComponent<Image>().enabled = true;
            key3.GetComponent<Image>().enabled = true;
        }
        if (Rockhit.mosterdie == true)
        {
            killmonster.GetComponent<Image>().enabled = true;
        }

        if (Door_clear.uIclear == true)
        {
            gameclear.GetComponent<Image>().enabled = true;
            replay.GetComponent<Image>().enabled = true;
        }


  


    }
}
