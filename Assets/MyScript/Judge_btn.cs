using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge_btn : MonoBehaviour
{
    public GameObject p1_1;
    public GameObject p1_5;
    public GameObject p1_10;
    public GameObject p2_1;
    public GameObject p2_5;
    public GameObject p2_10;

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
        Renderer ren_p1_1 = p1_1.GetComponent<Renderer>();
        Renderer ren_p1_5 = p1_5.GetComponent<Renderer>();
        Renderer ren_p1_10 = p1_10.GetComponent<Renderer>();
        Renderer ren_p2_1 = p2_1.GetComponent<Renderer>();
        Renderer ren_p2_5 = p2_5.GetComponent<Renderer>();
        Renderer ren_p2_10 = p2_10.GetComponent<Renderer>();

        string p1_card = "";
        string p2_card = "";

        if (ren_p1_1.enabled == true)
        {
            p1_card = "1";
        }
        if (ren_p1_5.enabled == true)
        {
            p1_card = "5";
        }
        if (ren_p1_10.enabled == true)
        {
            p1_card = "10";
        }

        if (ren_p2_1.enabled == true)
        {
            p1_card = "1";
        }
        if (ren_p2_5.enabled == true)
        {
            p1_card = "5";
        }
        if (ren_p2_10.enabled == true)
        {
            p1_card = "10";
        }

        switch (p1_card)
        {
            case "1":
                if (p2_card == "1")
                {

                }
                else if (p2_card == "10")
                {

                }
                else if (p2_card == "5")
                {

                }
                break;
            case "5":
                if (p2_card == "5")
                {

                }
                else if (p2_card == "1")
                {

                }
                else if (p2_card == "10")
                {

                }
                break;
            case "10":
                if (p2_card == "10")
                {

                }
                else if (p2_card =="5")
                {

                }
                else if (p2_card == "1")
                {

                }
                break;
        }

    }
}
