using UnityEngine;
using DG.Tweening;

public class ChangerColor : MonoBehaviour
{ 
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Color _color;
    [SerializeField] private float _duration = 2f;
    
    private void Start()
    {
        _spriteRenderer.DOColor(_color, _duration);
    }
}
