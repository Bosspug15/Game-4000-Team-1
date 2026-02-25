using Unity.VisualScripting;
using UnityEngine;

public class ButtonCall : MonoBehaviour
{
    //The only reason that I'm doing this is because unity buttons for some reason can't trigger custom events on script graphs, this was the only way i found how to do it

    public void TriggerCustomEvent(string name)
    {
        CustomEvent.Trigger(gameObject, name);
    }

}
