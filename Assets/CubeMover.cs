using DG.Tweening;
using UnityEngine;


public class CubeMover : ObjectChanger
{
    [SerializeField] protected float _distanceX = 60f;
    [SerializeField] protected float _distanceY = 15f;
    [SerializeField] protected float _distanceZ = 0f;
    [SerializeField] protected float _scale = 1.5f;
    [SerializeField] protected float _endValue = 3f;

    protected override void Start()
    {
        _gameObject.transform.DOMoveY(_endValue, _duration).SetLoops(-1, LoopType.Yoyo);
        _gameObject.transform.DORotate(new Vector3(_distanceX, _distanceY, _distanceZ), _duration).SetLoops(-1, LoopType.Yoyo);
        _gameObject.transform.DOScale(_scale, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
