using DG.Tweening;
using UnityEngine;

public class DOColor : MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private Color _color;

    private float _duration = 2f;

    private void Start()
    {
        _material.DOColor(_color, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
