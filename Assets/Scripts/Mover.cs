using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duraction;
    private void Start()
    {
        transform.DOMove(_position, _duraction);
    }

}
