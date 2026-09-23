using UnityEngine;
using UnityEngine.Events;

public class EventCore : MonoBehaviour
{

    /// <summary>
    /// When the player used a med kit the number returned is the amout
    /// they have left
    /// </summary>
    public UnityEvent<int> UE_UpdateMedKitUi;

    public UnityEvent<string> UE_PickUpMedkit;

    public UnityEvent UE_UsedMedKit;
}
