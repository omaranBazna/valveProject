using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class hide : MonoBehaviour {
    public GameObject hideGO;
    public Image img;
    bool active = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void HideUnHide()
    {
        hideGO.SetActive(!active);
        active = !active;
        if (active)
        {
            img.GetComponent<Image>().sprite = Resources.Load<Sprite>("show");
        }
        else
        {
            img.GetComponent<Image>().sprite = Resources.Load<Sprite>("hide");
        }
    }
    public void scenes()
    {
        SceneManager.LoadScene(1);
    }
    public void scenes2()
    {
        SceneManager.LoadScene(0);
    }
}
