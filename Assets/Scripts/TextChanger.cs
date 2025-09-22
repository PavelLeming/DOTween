using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text1;

    private float _duration = 2f;
    private float _firstDelay = 4f;
    private float _secondDelay = 8f;

    private void Start()
    {
        _text1.DOText("Hello ", _duration).SetLoops(-1, LoopType.Yoyo);
        _text1.DOText("world", _duration).SetRelative().SetDelay(_firstDelay).SetLoops(-1, LoopType.Yoyo);
        _text1.DOText("Bye-bye world ", _duration, true, ScrambleMode.All).SetDelay(_secondDelay).SetLoops(-1, LoopType.Yoyo);
    }
}
