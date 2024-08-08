using DG.Tweening;
using UnityEngine;

public class ObjectChanger : MonoBehaviour
{
    [SerializeField] private GameObject _sphere;
    [SerializeField] private GameObject _rotatingCube;
    [SerializeField] private GameObject _capsule;
    [SerializeField] private GameObject _movingCube;
    [SerializeField] private Renderer _cylinder;
    
    private float _duration = 5f;
    private float _directionZ = 30f;
    private float _angle = 45f;
    private float _scale = 1.5f;

    private void Start()
    {
        _sphere.transform.DOMove(new Vector3(0f, 0f, _directionZ), _duration).SetLoops(-1, LoopType.Incremental);
        _rotatingCube.transform.DORotate(new Vector3(0f, _angle, 0f), _duration).SetLoops(-1, LoopType.Incremental);
        _capsule.transform.DOScale(_scale, _duration).SetLoops(-1, LoopType.Yoyo);
        _movingCube.transform.DOMoveY(3f, 4f).SetLoops(-1, LoopType.Yoyo);
        _movingCube.transform.DORotate(new Vector3(60f, 15f, 0f), 2f).SetLoops(-1, LoopType.Yoyo);
        _movingCube.transform.DOScale(_scale, _duration).SetLoops(-1, LoopType.Yoyo);
        _cylinder.material.DOColor(Color.green, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
