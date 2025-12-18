using DG.Tweening;
using UnityEngine;

public class ObstecleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveZ(100, 5f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }


}
