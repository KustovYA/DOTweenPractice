using DG.Tweening;
using UnityEngine;

public class CubeRotator : ObjectChanger
{
    [SerializeField] protected float _angle = 45f;

    protected override void Start()
    {
        _gameObject.transform.DORotate(new Vector3(0f, _angle, 0f), _duration).SetLoops(-1, LoopType.Incremental);
    }
}
