using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenScale : MonoBehaviour
{
    // Start is called before the first frame update
    public float targetScale;
    public float timeToReachTarget;
    private float startScale;
    private float precentScaled;
    void Start()
    {
        startScale = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (precentScaled < 1f)
        {
            precentScaled += Time.deltaTime / timeToReachTarget;
            float scale = Mathf.Lerp(startScale, targetScale, precentScaled);
            transform.localScale = new Vector3(scale, scale, scale);
        }
    }
}
