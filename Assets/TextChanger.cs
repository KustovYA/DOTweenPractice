using DG.Tweening;
using UnityEngine.UI;
using UnityEngine;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] protected float _duration = 3f;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("Текст изменяющейся надписи", _duration));
        sequence.Append(_text.DOText("Текст изменяющейся надписи", _duration).SetRelative());
        sequence.Append(_text.DOText("Текст изменяющейся надписи", _duration, true, ScrambleMode.All));
        sequence.SetLoops(-1, LoopType.Yoyo);
    }
}
