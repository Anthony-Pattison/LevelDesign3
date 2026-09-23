using UnityEngine;
using UnityEngine.UI;

public class MedkitVisualCoolDown : MonoBehaviour
{
    EventCore _eventCore;
    Slider _medKitCoolDownVisual;
    public float timer = 5;
    private void Start()
    {
       _medKitCoolDownVisual = GetComponent<Slider>();
       _eventCore = GameObject.Find("EventCoreManager").GetComponent<EventCore>();
       _eventCore.UE_UsedMedKit.AddListener(resetMedkitSlider);

    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        _medKitCoolDownVisual.value = timer;
    }
    void resetMedkitSlider()
    {
        timer = 5;
    }
}
