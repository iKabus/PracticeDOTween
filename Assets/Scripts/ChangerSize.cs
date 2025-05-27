using UnityEngine;
using DG.Tweening;


public class ChangerSize : MonoBehaviour
{
    [SerializeField] private float _value = 2f;
    [SerializeField] private float _duraction = 1.2f;
    
    private void Start()
    {
        transform.DOScale(new Vector3(_value, _value, _value), _duraction)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
