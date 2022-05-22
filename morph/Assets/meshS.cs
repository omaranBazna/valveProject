using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class meshS : MonoBehaviour {
    public Slider s,ss,s2,s3,s4;
   public int n = 0;
    public GameObject[] lat;
    public GameObject[] lat2;
    public GameObject[] lat3;

    // Use this for initialization
    Vector3[] v0;
    int t = 0;
    Vector3[] vdst;
    public GameObject refMesh,v2,v3;
    Vector3 _temp;
    float f;
    void Start () {
        v0 = gameObject.GetComponent<MeshFilter>().sharedMesh.vertices;
        

       
        
    }

    // Update is called once per frame
    void Update () {
    
        t -= 1;
        if (t > 10)
        {
             if(n< gameObject.GetComponent<MeshFilter>().sharedMesh.vertexCount)
            {
                n += 1;
            }
            if (n == gameObject.GetComponent<MeshFilter>().sharedMesh.vertexCount)
            {
                n=0;
            }
            t = 0;
        }
        Mor();
    }
    public void Mor()
    {
        v0 = refMesh.GetComponent<MeshFilter>().sharedMesh.vertices;
        for (int l = 0; l < lat.Length; l++)
        {
            for (int o = 0; o < gameObject.GetComponent<MeshFilter>().sharedMesh.vertexCount; o++)
            {
                if (((v0[o] - gameObject.transform.worldToLocalMatrix.MultiplyPoint3x4(lat[l].transform.position)).magnitude) < 0.01f)
                {
                    // v0[o] = gameObject.transform.worldToLocalMatrix.MultiplyPoint3x4(lat.transform.position);

                }
                _temp = gameObject.transform.worldToLocalMatrix.MultiplyPoint3x4(lat[l].transform.position) - v0[o];
                if (_temp.magnitude < s2.value)
                {
                    f = 1f / (_temp.magnitude * s.value * _temp.magnitude * s.value);
                    v0[o] = v0[o] + _temp * f;
                }
            }
        }
        for (int l = 0; l < lat2.Length; l++)
        {
            for (int o = 0; o < gameObject.GetComponent<MeshFilter>().sharedMesh.vertexCount; o++)
            {
                if (((v0[o] - gameObject.transform.worldToLocalMatrix.MultiplyPoint3x4(lat2[l].transform.position)).magnitude) < 0.01f)
                {
                    // v0[o] = gameObject.transform.worldToLocalMatrix.MultiplyPoint3x4(lat2.transform.position);

                }
                _temp = gameObject.transform.worldToLocalMatrix.MultiplyPoint3x4(lat2[l].transform.position) - v0[o];
                if (_temp.magnitude < s3.value)
                {
                    f = -1f / (_temp.magnitude *( s.value*0.45f+ss.value * 0.45f) * _temp.magnitude * (s.value * 0.45f + ss.value * 0.45f));
                    v0[o] = v0[o] + _temp * f;
                }
            }
        }

        for (int l = 0; l < lat3.Length; l++)
        {
            for (int o = 0; o < gameObject.GetComponent<MeshFilter>().sharedMesh.vertexCount; o++)
            {
                if (((v0[o] - gameObject.transform.worldToLocalMatrix.MultiplyPoint3x4(lat3[l].transform.position)).magnitude) < 0.01f)
                {
                    // v0[o] = gameObject.transform.worldToLocalMatrix.MultiplyPoint3x4(lat.transform.position);

                }
                _temp = gameObject.transform.worldToLocalMatrix.MultiplyPoint3x4(lat3[l].transform.position) - v0[o];
                if (_temp.magnitude < s2.value)
                {
                    f = 1f / (_temp.magnitude * ss.value*0.9f * _temp.magnitude*0.9f * ss.value);
                    v0[o] = v0[o] + _temp * f;
                }
            }
        }


        gameObject.GetComponent<MeshFilter>().mesh.vertices = v0;
        gameObject.GetComponent<MeshFilter>().mesh.RecalculateBounds();
        v2.GetComponent<MeshFilter>().mesh = gameObject.GetComponent<MeshFilter>().mesh;
        v3.GetComponent<MeshFilter>().mesh = gameObject.GetComponent<MeshFilter>().mesh;
    }
    public void GotoS()
    {
        SceneManager.LoadScene(0);
    }
}
