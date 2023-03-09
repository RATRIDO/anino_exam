using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Slot Item Data")]
public class SlotItemData : ScriptableObject
{
    public int slotID;
    public string slotName;
    public int[] slotPayout;
}
