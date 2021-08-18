using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    
    Renderer rend = null;
    Color cCurrentColor;
    float XRotation = 0;
    float YRotation = 0;
    float ZRotation = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region Colors
    public void ChangeToRed()
    {
        cCurrentColor = rend.material.color;

        rend.material.color = Color.Lerp(cCurrentColor, Color.red, Mathf.PingPong(Time.time, 1));

    }
    public void ChangeToBlue()
    {
        cCurrentColor = rend.material.color;

        rend.material.color = Color.Lerp(cCurrentColor, Color.blue, Mathf.PingPong(Time.time, 1));

    }
    public void ChangeToGreen()
    {
        cCurrentColor = rend.material.color;

        rend.material.color = Color.Lerp(cCurrentColor, Color.green, Mathf.PingPong(Time.time, 1));

    }
    #endregion

    #region Scaling
    public void IncreaseScale()
    {
        transform.localScale *= 2.0f;
    }
    public void DecreaseScale()
    {
        transform.localScale *= 0.5f;
    }
    #endregion

    #region Movement
    public void MoveForward()
    {
        transform.localPosition += new Vector3(0, 0, 0.05f);
    }
    public void MoveBackward()
    {
        transform.localPosition -= new Vector3(0, 0, 0.05f);
    }
    public void MoveLeft()
    {
        transform.localPosition -= new Vector3(0.05f, 0, 0);
    }
    public void MoveRight()
    {
        transform.localPosition += new Vector3(0.05f, 0, 0f);
    }
    public void MoveUp()
    {
        transform.localPosition += new Vector3(0, 0.05f, 0);
    }
    public void MoveDown()
    {
        transform.localPosition -= new Vector3(0, 0.05f, 0);
    }
    #endregion

    #region Rotation
    //Tumble forward(Pitch)
    public void RotateXPos()
    {
        XRotation += 15;
        transform.localRotation = Quaternion.Euler(XRotation, 0, 0);
    }
    public void RotateXNeg()
    {
        XRotation -= 15;
        transform.localRotation = Quaternion.Euler(XRotation, 0, 0);
    }
    //Spin in place(Yaw)
    public void RotateYPos()
    {
        YRotation += 15;
        transform.localRotation = Quaternion.Euler(0, YRotation, 0);
    }
    public void RotateYNeg()
    {
        YRotation -= 15;
        transform.localRotation = Quaternion.Euler(0, YRotation, 0);
    }
    //Barrel Roll(Roll)
    public void RotateZPos()
    {
        ZRotation += 15;
        transform.localRotation = Quaternion.Euler(0, 0, ZRotation);
    }
    public void RotateZNeg()
    {
        ZRotation -= 15;
        transform.localRotation = Quaternion.Euler(0, 0, ZRotation);
    }
    #endregion
}
