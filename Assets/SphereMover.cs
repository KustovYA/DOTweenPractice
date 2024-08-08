using DG.Tweening;
using UnityEngine;

public class SphereMover : ObjectChanger
{
    [SerializeField] protected float _directionZ = 30f;

    protected override void Start()
    {
        _gameObject.transform.DOMove(new Vector3(0f, 0f, _directionZ), _duration).SetLoops(-1, LoopType.Incremental);
    }  
}
