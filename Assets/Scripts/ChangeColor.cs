using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{


    //Rotation values to store and set
    float XRotation = 0;
    float YRotation = 0;
    float ZRotation = 0;
    //bools for holding down buttons
    bool LeftButton = false;
    bool RightButton = false;
    bool ForwardButton = false;
    bool BackwardButton = false;
    bool UpButton = false;
    bool DownButton = false;
    bool ScaleUpButton = false;
    bool ScaleDownButton = false;
    bool RotateXPosButton = false;
    bool RotateXNegButton = false;
    bool RotateYPosButton = false;
    bool RotateYNegButton = false;
    bool RotateZPosButton = false;
    bool RotateZNegButton = false;
    //"Speed" for updating values
    public float ModValue = 0;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //If the button is being held - call the action
        if(LeftButton || RightButton)
        {
            MoveLeftRight(LeftButton);
        }
        if(ForwardButton || BackwardButton)
        {
            MoveForwardBackward(ForwardButton);
        }
        if(UpButton || DownButton)
        {
            MoveUpDown(UpButton);
        }
        if(ScaleUpButton || ScaleDownButton)
        {
            AdjustScale(ScaleUpButton);
        }
        if(RotateXPosButton || RotateXNegButton)
        {
            RotateXPosNeg(RotateXPosButton);
        }
        if (RotateYPosButton || RotateYNegButton)
        {
            RotateYPosNeg(RotateYPosButton);
        }
        if (RotateZPosButton || RotateZNegButton)
        {
            RotateZPosNeg(RotateZPosButton);
        }
    }


    #region Scaling
    private void AdjustScale(bool ScalingUp)
    {
        if(ScalingUp)
        {
            transform.localScale = transform.localScale * (ModValue + 1);
        }
        else
        {
            transform.localScale = transform.localScale / (ModValue + 1);
        }
    }

    //Button Tracking
    public void IncreaseScale()
    {
        ScaleUpButton = true; Debug.Log("ScaleUpTrue");
    }
    public void StopIncreaseScale()
    {
        ScaleUpButton = false; Debug.Log("ScaleUpFalse");
    }
    public void DecreaseScale()
    {
        ScaleDownButton = true;
    }
    public void StopDecreseScale()
    {
        ScaleDownButton = false;
    }
    #endregion

    #region Movement
    #region MovementHandlers
    //If Moving Positively - Make the number always positive. If Moving Negatively - make the number always negative
    private void MoveLeftRight(bool MovingLeft)
    {
        //It looks like it's going to the right on screen when adding to the vector, so swapping the math just here
        ModValue = MovingLeft ? Mathf.Abs(ModValue) * -1 : Mathf.Abs(ModValue);
        transform.localPosition += new Vector3(ModValue, 0, 0);
    }
    private void MoveForwardBackward(bool MovingForward)
    {
        ModValue = MovingForward ? Mathf.Abs(ModValue) : Mathf.Abs(ModValue) * -1;
        transform.localPosition += new Vector3(0, 0, ModValue);
    }
    private void MoveUpDown(bool MovingUp)
    {
        ModValue = MovingUp ? Mathf.Abs(ModValue) : Mathf.Abs(ModValue) * -1;
        transform.localPosition += new Vector3(0, ModValue, 0);
    }
    #endregion

    #region MovementButtonTracking
    public void MoveForward()
    {
        ForwardButton = true;
    }
    public void StopMoveForward()
    {
        ForwardButton = false;
    }
    public void MoveBackward()
    {
        BackwardButton = true;
    }
    public void StopMoveBackward()
    {
        BackwardButton = false;
    }
    public void MoveLeft()
    {
        LeftButton = true; Debug.Log("Left = true");
    }
    public void StopMoveLeft()
    {
        LeftButton = false; Debug.Log("Left = false");
    }
    public void MoveRight()
    {
        RightButton = true; Debug.Log("Right = true");
    }
    public void StopMoveRight()
    {
        RightButton = false; Debug.Log("Right = false");
    }
    public void MoveUp()
    {
        UpButton = true;
    }
    public void StopMoveUp()
    {
        UpButton = false;
    }
    public void MoveDown()
    {
        DownButton = true;
    }
    public void StopMoveDown()
    {
        DownButton = false;
    }
    #endregion
    #endregion

    #region Rotation
    //Tumble forward(Pitch)
    private void RotateXPosNeg(bool RotateXPosButton)
    {
        XRotation = RotateXPosButton ? XRotation + 1 : XRotation - 1;
        transform.localRotation = Quaternion.Euler(XRotation, YRotation, ZRotation);
    }
    public void RotateXPos()
    {
        RotateXPosButton = true;
    }
    public void StopRotateXPos()
    {
        RotateXPosButton = false;
    }
    public void RotateXNeg()
    {
        RotateXNegButton = true;
    }
    public void StopRotateXNeg()
    {
        RotateXNegButton = false;
    }
    //Spin in place(Yaw)
    private void RotateYPosNeg(bool RotateYPosButton)
    {
        YRotation = RotateYPosButton ? YRotation + 1 : YRotation - 1;
        transform.localRotation = Quaternion.Euler(XRotation, YRotation, ZRotation);
    }
    public void RotateYPos()
    {
        RotateYPosButton = true;
    }
    public void StopRotateYPos()
    {
        RotateYPosButton = false;
    }
    public void RotateYNeg()
    {
        RotateYNegButton = true;
    }
    public void StopRotateYNeg()
    {
        RotateYNegButton = false;
    }
    //Barrel Roll(Roll)
    private void RotateZPosNeg(bool RotateZPosButton)
    {
        ZRotation = RotateZPosButton ? ZRotation + 1 : ZRotation - 1;
        transform.localRotation = Quaternion.Euler(XRotation, YRotation, ZRotation);
    }
    public void RotateZPos()
    {
        RotateZPosButton = true;
    }
    public void StopRotateZPos()
    {
        RotateZPosButton = false;
    }
    public void RotateZNeg()
    {
        RotateZNegButton = true;
    }
    public void StopRotateZNeg()
    {
        RotateZNegButton = false;
    }
    #endregion
}
