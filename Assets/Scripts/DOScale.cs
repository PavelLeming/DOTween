using DG.Tweening;
using UnityEngine;

public class DOScale : MonoBehaviour
{
    private Vector3 _scale = new Vector3(2, 2, 2);
    private float _duration = 2f;

    private void Start()
    {
        transform.DOScale(_scale, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}

