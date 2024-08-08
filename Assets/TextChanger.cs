using DG.Tweening;
using UnityEngine.UI;
using UnityEngine;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("Текст изменяющейся надписи", 3f));
        sequence.Append(_text.DOText("Текст изменяющейся надписи", 3f).SetRelative());
        sequence.Append(_text.DOText("Текст изменяющейся надписи", 3f, true, ScrambleMode.All));
        sequence.SetLoops(-1, LoopType.Yoyo);
    }
}
