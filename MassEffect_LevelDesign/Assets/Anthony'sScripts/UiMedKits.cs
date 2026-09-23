using UnityEngine;
using UnityEngine.UI;

public class UiMedKits : MonoBehaviour
{
    EventCore _eventCore;
    Text _displayText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _eventCore = GameObject.Find("EventCoreManager").GetComponent<EventCore>();
        _eventCore.UE_UpdateMedKitUi.AddListener(UpdateUIText);
        _displayText = GetComponent<Text>();
    }

    private void UpdateUIText(int medkitsAvalible)
    {
        if (medkitsAvalible == 0)
        {
            _displayText.text = $"No medkits";
            return;
        }
        print("updating");
        _displayText.text = $"Medkits: {medkitsAvalible}";
    }
}
