using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEndToNext : MonoBehaviour
{

    public Animator NextAnimation;
    // Start is called before the first frame update
    public void OnAnimationAEnd()
    {
        if (NextAnimation != null)
        {
            NextAnimation.SetTrigger("StartAtk"); // หรือใช้ animatorB.Play("AnimationNameB");
        }
    }
}
