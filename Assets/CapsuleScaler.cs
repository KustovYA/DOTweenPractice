using DG.Tweening;
using UnityEngine;

public class CapsuleScaler : ObjectChanger
{
    [SerializeField] protected float _scale = 1.5f;

    protected override void Start()
    {
        _gameObject.transform.DOScale(_scale, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
