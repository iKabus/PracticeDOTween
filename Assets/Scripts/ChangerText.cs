using System.Collections;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ChangerText : MonoBehaviour
{
    [SerializeField]  private Text _text;
    private void Start()
    {
        StartCoroutine(PlayTextSequence());
    }

    private IEnumerator PlayTextSequence()
    {
        float value = 1f;
        float duration = 3f;
        
        var wait = new WaitForSeconds(value);
        
        yield return _text.DOText("Привет, мир!", duration).WaitForCompletion();
        yield return wait;
        
        yield return _text.DOText("Привет, мир! Как дела?", duration).WaitForCompletion();
        yield return wait;

        yield return _text.DOText("Секретное сообщение", duration, true, ScrambleMode.All).WaitForCompletion();
        yield return wait;
        
        yield return _text.DOText("СЮРПРИЗ!", duration, true, ScrambleMode.Uppercase).WaitForCompletion();
        yield return wait;
        
        yield return _text.DOText("", duration, true, ScrambleMode.All).WaitForCompletion();

    }
}
