using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class valves : MonoBehaviour {
    public GameObject go1,go2,go3,go4,go5;
   Quaternion r1, r2, r3;
    Vector3 s1, s2, s3;
    public bool outline;
   public GameObject OL;
    public GameObject TX;
    public Image cases;
    public Image sel;
    public Image sel1,sel2,sel3,sel4,sel5,sel6,sel7;
    // Use this for initialization
    public void GoTo()
    {
        SceneManager.LoadScene(1);
    }
    void Start () {
        r1 = go1.transform.rotation;
        r2 = go2.transform.rotation;
        r3 = go3.transform.rotation;


        s1 = go1.transform.localScale;
        s2 = go2.transform.localScale;
        s3 = go3.transform.localScale;


    }

    // Update is called once per frame
    void Update () {
        if (outline)
        {
           if(!OL.GetComponent<Outline>().enabled)
            {
                //OL.GetComponent<Outline>().enabled = true;
            }
        }
        if (!outline)
        {
            if (OL.GetComponent<Outline>().enabled)
            {
                // OL.GetComponent<Outline>().enabled = false;
            }
        }
    }
    public void valve1()
    {
        //reSet Transform
        {
            go1.transform.rotation = r1;
            go1.transform.localScale = s1;

            go2.transform.rotation = r2;
            go2.transform.localScale =s2;

            go3.transform.rotation = r3;
            go3.transform.localScale = s3;
        }
        {
            go1.GetComponent<MeshRenderer>().enabled =true;
            go2.GetComponent<MeshRenderer>().enabled =true;
          go3.GetComponent<MeshRenderer>().enabled =true;
            go4.SetActive(true);
            go5.SetActive(false);
           
        }

        go1.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("dys1/ClosedValve-dys1");
        go1.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("dys1/OpenValve-dys1");
        go2.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("dys1/ClosedValve-dys1");
        go2.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("dys1/OpenValve-dys1");
        go3.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("dys1/ClosedValve-dys1");
        go3.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("dys1/OpenValve-dys1");
        TX.GetComponent<ArabicText>().Text = "توسع وصل جيبي انبوبي";
        cases.sprite = Resources.Load<Sprite>("cases/case2");
        sel.rectTransform.position = sel2.rectTransform.position;
    }
    public void valveN()
    {
        //reSet Transform
        {
            go1.transform.rotation = r1;
            go1.transform.localScale = s1;

            go2.transform.rotation = r2;
            go2.transform.localScale = s2;

            go3.transform.rotation = r3;
            go3.transform.localScale = s3;
        }
        {
            go1.GetComponent<MeshRenderer>().enabled = true;
            go2.GetComponent<MeshRenderer>().enabled = true;
            go3.GetComponent<MeshRenderer>().enabled = true;
            go4.SetActive(true);
            go5.SetActive(false);
        }

        go1.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("Normal/ClosedValve-Normal");
        go1.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("Normal/OpenValve-Normal");
        go2.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("Normal/ClosedValve-Normal");
        go2.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("Normal/OpenValve-Normal");
        go3.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("Normal/ClosedValve-Normal");
        go3.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("Normal/OpenValve-Normal");
        TX.GetComponent<ArabicText>().Text = "الصمام الطبيعي";
        cases.sprite = Resources.Load<Sprite>("cases/case0") as Sprite;
        sel.rectTransform.position = sel1.rectTransform.position;
    }




    public void valve2()
    {
        //reSet Transform
        {
            go1.transform.rotation = r1;
            go1.transform.localScale = s1;

            go2.transform.rotation = r2;
            go2.transform.localScale = s2;

            go3.transform.rotation = r3;
            go3.transform.localScale = s3;
        }
        {
            go1.GetComponent<MeshRenderer>().enabled =true;
            go2.GetComponent<MeshRenderer>().enabled =true;
          go3.GetComponent<MeshRenderer>().enabled =true;
            go4.SetActive(true);
            go5.SetActive(false);
        }


        go1.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("dys2/closedvalve_dys2");
        go1.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("dys2/openvalve_dys2");
        go2.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("dys2/closedvalve_dys2");
        go2.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("dys2/openvalve_dys2");
        go3.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("dys2/closedvalve_dys2");
        go3.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("dys2/openvalve_dys2");
        TX.GetComponent<ArabicText>().Text = "توسع وصل ابهري بطيني";
        cases.sprite = Resources.Load<Sprite>("cases/case1");
        sel.rectTransform.position = sel3.rectTransform.position;
    }

    public void valve3()
    {
        //reSet Transform
        {
            go1.transform.rotation = r1;
            go1.transform.localScale = s1;

            go2.transform.rotation = r2;
            go2.transform.localScale = s2;

            go3.transform.rotation = r3;
            go3.transform.localScale = s3;
        }
        {
            go1.GetComponent<MeshRenderer>().enabled =true;
            go2.GetComponent<MeshRenderer>().enabled =true;
          go3.GetComponent<MeshRenderer>().enabled =true;
            go4.SetActive(true);
            go5.SetActive(false);
        }

        go1.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("dys3/closedvalve_dys3");
        go1.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("dys3/openvalve_dys3");
        go2.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("dys3/closedvalve_dys3");
        go2.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("dys3/openvalve_dys3");
        go3.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("dys3/closedvalve_dys3");
        go3.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("dys3/openvalve_dys3");
        TX.GetComponent<ArabicText>().Text = "توسع وصل جيبي انبوبي وابهري بطيني";
        cases.sprite = Resources.Load<Sprite>("cases/case3");
        sel.rectTransform.position = sel4.rectTransform.position;
    }


    public void valve5a()
    {

        //reSet Transform
        {
            go1.transform.rotation = r1;
            go1.transform.localScale = s1;

            go2.transform.rotation = r2;
            go2.transform.localScale = s2;

            go3.transform.rotation = r3;
            go3.transform.localScale = s3;
        }
        {
            go1.GetComponent<MeshRenderer>().enabled =true;
            go2.GetComponent<MeshRenderer>().enabled =true;
          go3.GetComponent<MeshRenderer>().enabled =true;
            go4.SetActive(true);
            go5.SetActive(false);
        }

        go1.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("dys5/ClosedValve-dys5a");
        go1.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("Normal/Openvalve-Normal");
        go2.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("Normal/ClosedValve-Normal");
        go2.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("Normal/Openvalve-Normal");
        go3.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("Normal/ClosedValve-Normal");
        go3.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("Normal/Openvalve-Normal");
        TX.GetComponent<ArabicText>().Text = "انسدال الوريقة";
        cases.sprite = Resources.Load<Sprite>("cases/case5");
        sel.rectTransform.position = sel6.rectTransform.position;
    }


    public void valve5b()
    {

        //reSet Transform
        {
            go1.transform.rotation = r1;
            go1.transform.localScale = s1;

            go2.transform.rotation = r2;
            go2.transform.localScale = s2;

            go3.transform.rotation = r3;
            go3.transform.localScale = s3;
        }
        {
            go1.GetComponent<MeshRenderer>().enabled =true;
            go2.GetComponent<MeshRenderer>().enabled =true;
          go3.GetComponent<MeshRenderer>().enabled =true;
            go4.SetActive(true);
            go5.SetActive(false);
        }

        go1.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("dys5/ClosedValve-dys5b");
        go1.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("dys5/OpenValve-dys5b");
        go2.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("dys5/ClosedValve-dys5b");
        go2.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("dys5/OpenValve-dys5b");
        go1.transform.RotateAround(new Vector3(0, 1f, 0), Mathf.Deg2Rad * 30f);
        go2.transform.localScale = new Vector3(-go2.transform.localScale.x, go2.transform.localScale.y, go2.transform.localScale.z);
        go2.transform.RotateAround(new Vector3(0, 1f, 0),-Mathf.Deg2Rad * 95f);
        go3.GetComponent<MeshRenderer>().enabled = false;

        TX.GetComponent<ArabicText>().Text = "صمام ثنائي الوريقة";

    }

    public void valve4()
    {
        //reSet Transform
        {
            go1.transform.rotation = r1;
            go1.transform.localScale = s1;

            go2.transform.rotation = r2;
            go2.transform.localScale = s2;

            go3.transform.rotation = r3;
            go3.transform.localScale = s3;
        }
        {
            go1.GetComponent<MeshRenderer>().enabled = true;
            go2.GetComponent<MeshRenderer>().enabled = true;
            go3.GetComponent<MeshRenderer>().enabled = true;
            go4.SetActive(false);
            go5.SetActive(true);
           
        }

        TX.GetComponent<ArabicText>().Text = "انثقاب الوريقة";
        cases.sprite = Resources.Load<Sprite>("cases/case4");
        sel.rectTransform.position = sel5.rectTransform.position;
    }

    public void valve6()
    {
        //reSet Transform
        {
            go1.transform.rotation = r1;
            go1.transform.localScale = s1;

            go2.transform.rotation = r2;
            go2.transform.localScale = s2;

            go3.transform.rotation = r3;
            go3.transform.localScale = s3;
        }
        {
            go1.GetComponent<MeshRenderer>().enabled =true;
            go2.GetComponent<MeshRenderer>().enabled =true;
          go3.GetComponent<MeshRenderer>().enabled =true;
            go4.SetActive(true);
            go5.SetActive(false);
        }

        go1.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("dys6/ClosedValve-dys6");
        go1.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("Normal/Openvalve-Normal");
        go2.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("Normal/ClosedValve-Normal");
        go2.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("Normal/Openvalve-Normal");
        go3.GetComponent<morpher2>().m_Meshes[0] = Resources.Load<Mesh>("Normal/ClosedValve-Normal");
        go3.GetComponent<morpher2>().m_Meshes[1] = Resources.Load<Mesh>("Normal/Openvalve-Normal");
        TX.GetComponent<ArabicText>().Text = "تليف الوريقة";
        cases.sprite = Resources.Load<Sprite>("cases/case6");
        sel.rectTransform.position = sel7.rectTransform.position;
    }
}