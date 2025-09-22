using DG.Tweening;
using UnityEngine;

public class DOMove : MonoBehaviour
{
    private Vector3 _position = new Vector3(0, 3, -7);
    private float _duration = 2f;

    private void Start()
    {
        transform.DOMove(_position, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
