using UnityEngine;

public class MedKitPickUp : MonoBehaviour
{
    EventCore _eventCore;
    private void Start()
    {
        _eventCore = GameObject.Find("EventCoreManager").GetComponent<EventCore>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _eventCore.UE_PickUpMedkit.Invoke(other.tag);
            this.gameObject.SetActive(false);
        }
    }
}
