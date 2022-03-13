using UnityEngine;
using UnityEngine.EventSystems;

public class JumpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isPressed;

    // Start is called before the first frame update
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    // Update is called once per frame
    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}
