using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotObject : MonoBehaviour
{
    [SerializeField] private SlotItemData refItem;

    public int CheckID()
    {
        return refItem.slotID;
    }

    public string CheckName()
    {
        return refItem.slotName;
    }

    public int CheckPayout(int result)
    {   
        if(result == 0)
            return refItem.slotPayout[0];
        else if (result == 1)
            return refItem.slotPayout[1];
        else if (result == 2)
            return refItem.slotPayout[2];
        else if (result == 3)
            return refItem.slotPayout[3];
        else
            return refItem.slotPayout[4];
    }
}
