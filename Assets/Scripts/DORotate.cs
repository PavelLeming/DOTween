using DG.Tweening;
using UnityEngine;

public class DORotate : MonoBehaviour
{
    private Vector3 _rotation = new Vector3(0, 0, 30);
    private float _duration = 2f;

    private void Start()
    {
        transform.DORotate(_rotation, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
