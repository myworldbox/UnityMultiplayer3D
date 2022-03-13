using UnityEngine;
using UnityEngine.EventSystems;

public class MoveButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isMoving;

    // Start is called before the first frame update
    public void OnPointerDown(PointerEventData eventData)
    {
        isMoving = true;
    }

    // Update is called once per frame
    public void OnPointerUp(PointerEventData eventData)
    {
        isMoving = false;
    }
}
