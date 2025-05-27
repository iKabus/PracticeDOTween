using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private int _degrees = 360;
    [SerializeField] private float _time = 2f;
    
    private void Start()
    {
        transform.DORotate(new Vector3(0, 0, _degrees), _time, RotateMode.FastBeyond360)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Restart);
    }
}
