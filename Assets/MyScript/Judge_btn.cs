using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Judge_btn : MonoBehaviour
{
    public GameObject p1_gu;
    public GameObject p1_thoki;
    public GameObject p1_pa;
    public GameObject p2_gu;
    public GameObject p2_thoki;
    public GameObject p2_pa;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Renderer ren_p1_gu = p1_gu.GetComponent<Renderer>();
        Renderer ren_p1_thoki = p1_thoki.GetComponent<Renderer>();
        Renderer ren_p1_pa = p1_pa.GetComponent<Renderer>();
        Renderer ren_p2_gu = p2_gu.GetComponent<Renderer>();
        Renderer ren_p2_thoki = p2_thoki.GetComponent<Renderer>();
        Renderer ren_p2_pa = p2_pa.GetComponent<Renderer>();

        string p1_card = "";
        string p2_card = "";

        if (ren_p1_gu.enabled == true)
        {
            p1_card = "gu";
        }
        if (ren_p1_thoki.enabled == true)
        {
            p1_card = "thoki";
        }
        if (ren_p1_pa.enabled == true)
        {
            p1_card = "pa";
        }

        if (ren_p2_gu.enabled == true)
        {
            p1_card = "gu";
        }
        if (ren_p2_thoki.enabled == true)
        {
            p1_card = "thoki";
        }
        if (ren_p2_pa.enabled == true)
        {
            p1_card = "pa";
        }

        switch (p1_card)
        {
            case "gu":
                if (p2_card == "gu")
                {
                    text.text = "あいこ";
                }
                else if (p2_card == "thoki")
                {
                    text.text = "p1の勝ち";
                }
                else if (p2_card == "pa")
                {
                    text.text = "p1の負け";
                }
                break;
            case "thoki":
                if (p2_card == "thoki")
                {
                    text.text = "あいこ";
                }
                else if (p2_card == "pa")
                {
                    text.text = "p1の勝ち";

                }
                else if (p2_card == "gu")
                {
                    text.text = "p1の負け";

                }
                break;
            case "pa":
                if (p2_card == "pa")
                {
                    text.text = "あいこ";
                }
                else if (p2_card == "gu")
                {
                    text.text = "p1の勝ち";
                }
                else if (p2_card == "thoki")
                {
                    text.text = "p1の負け";
                }
                break;
        }

    }
}
