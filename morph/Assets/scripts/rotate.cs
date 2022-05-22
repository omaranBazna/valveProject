using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotate : MonoBehaviour
{
    public GameObject Cam, x_axis, y_axis, z_axis;
    public Camera main;
    public Slider speedUI;
    float lastx = 0, lasty = 0, xf, yf, Dx, Dy, D, Nx, Ny;
    float rx, ry;
   
    Vector2 LastI;
    float rx0, ry0, rz0;
    public Text txt;
    float speed =0.4f;

    // Update is called once per frame
    public bool IsPointer(Vector2 Point)

    {
        if (Point.y > 0.27 * main.scaledPixelHeight && Point.x >0 * main.scaledPixelWidth && Point.x < 1f * main.scaledPixelWidth)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    void Update()
    {

        if (IsPointer(Input.mousePosition))
        {
            Debug.Log("yes");
        }

            if (Input.touchCount == 1 && IsPointer(Input.mousePosition) )
            {

                Dx = Input.GetTouch(0).deltaPosition.x;
                Dy = Input.GetTouch(0).deltaPosition.y;
                D = Mathf.Sqrt(Dx * Dx + Dy * Dy);
                rx = -Dy / D;
                ry = Dx / D;
               
                Cam.transform.RotateAround(rx * x_axis.transform.position + ry * y_axis.transform.position, D * speed * Time.deltaTime);



            }
            if (Input.touchCount == 2)
            {
                Vector2 I1, I2, I, d1, d2;
                float ratio, a1, a2, alpha, d;
                I1 = Input.GetTouch(0).position;
                I2 = Input.GetTouch(1).position;

                I = I2 - I1;
                if (LastI.magnitude > 0)
                {
                    ratio = I.magnitude / LastI.magnitude;

                    main.GetComponent<Camera>().fieldOfView /= ratio;
                    if (main.GetComponent<Camera>().fieldOfView > 70) { main.GetComponent<Camera>().fieldOfView = 70; }
                    if (main.GetComponent<Camera>().fieldOfView < 30) { main.GetComponent<Camera>().fieldOfView = 30; }
                    a1 = Mathf.Atan2(I.y, I.x);
                    a2 = Mathf.Atan2(LastI.y, LastI.x);
                    alpha = a1 - a2;
                    Cam.transform.RotateAround(z_axis.transform.position - Cam.transform.position, -alpha);

                }

                LastI = I;
            }
        

    }
    public void setSpeed()
    {
        speed = speedUI.value;
    }
}
            
