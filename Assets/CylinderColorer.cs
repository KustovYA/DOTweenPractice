using DG.Tweening;
using UnityEngine;


public class CylinderColorer : MonoBehaviour
{
    [SerializeField] private Renderer _cylinderRenderer;

    private float _duration = 5f;

    private void Start()
    {
        _cylinderRenderer.material.DOColor(Color.green, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
