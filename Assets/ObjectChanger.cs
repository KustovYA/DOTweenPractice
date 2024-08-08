using UnityEngine;

public abstract class ObjectChanger : MonoBehaviour 
{
    [SerializeField] protected GameObject _gameObject;  
    [SerializeField] protected float _duration = 5f;        

    protected abstract void Start();    
}
