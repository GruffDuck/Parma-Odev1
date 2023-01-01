using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreButton : MonoBehaviour
{
    [SerializeField] private bool isHit;
    [SerializeField] private Score score;


    public void ClickButton(Transform cube)
    {
        var rot = Mathf.Abs(cube.rotation.eulerAngles.x);
        switch (rot)
        {
            case <= 20:
                StartCoroutine(ResetHit());
                score.Increase(5);
                break;
            case > 20 and <= 40:
                StartCoroutine(ResetHit());
                score.Increase(-5);  
                break;
            case > 40 and <= 65:
                StartCoroutine(ResetHit());
                score.Increase(-15);
                break;
            case > 65 and <= 90:
                StartCoroutine(ResetHit());
                score.Increase(20);
                break;
        }
    }
    
    
    private IEnumerator ResetHit()
    {
        yield return new WaitForSeconds(0.5f);
        isHit = false;
    }
}
