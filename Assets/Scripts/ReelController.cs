using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReelController : MonoBehaviour
{
    [SerializeField] private float lastPosY, spinSpeed;
    public SlotObject[] symbols;

    public bool reelStoped, finishedSpinning;

    public string stoppedSlot;

    void Start()
    {
        reelStoped = true;
        finishedSpinning = false;

        //origYVal = transform.localPosition.y + spinSpeed;
    }

    public void CanSpin()
    {
        StartCoroutine(Spin());
    }

    private IEnumerator Spin()
    {
        reelStoped = false;
        stoppedSlot = "";

        //Initial Spin
        for (int i = 0; i < 30; i++)
        {
            if (transform.localPosition.y <= lastPosY + spinSpeed)
                transform.localPosition = new Vector2(transform.localPosition.x, 1.45f);

            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - spinSpeed);

            yield return new WaitForSeconds(0.25f);
        }

        //Stopping
        int rand = Random.Range(15, 45);

        for (int i = 0; i < rand; i++)
        {
            if (transform.localPosition.y <= lastPosY + spinSpeed)
                transform.localPosition = new Vector2(transform.localPosition.x, 1.45f);

            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - spinSpeed);

            yield return new WaitForSeconds(0.25f);
        }

        float checkY = transform.localPosition.y;

        if(checkY <= 1.45f && checkY > 1.10f)
            stoppedSlot = "BCD";
        else if (checkY <= 1.10f && checkY > 0.75f)
            stoppedSlot = "CDE";
        else if (checkY <= 0.75f && checkY > 0.4f)
            stoppedSlot = "DEF";
        else if (checkY <= 0.4f && checkY > 0.05f)
            stoppedSlot = "EFG";
        else if (checkY <= 0.05f && checkY > -0.3f)
            stoppedSlot = "FGH";
        else if (checkY <= -0.3f && checkY > -0.65f)
            stoppedSlot = "GHI";
        else if (checkY <= -0.65f && checkY > -1f)
            stoppedSlot = "HIJ";
        else if (checkY <= -1f)
            stoppedSlot = "ABC";

        reelStoped = true;
        finishedSpinning = true;

    }
}
