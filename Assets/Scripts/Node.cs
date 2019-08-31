using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public GameObject geometry;
    public float scaleTime = 0.3f;
    public iTween.EaseType easeType = iTween.EaseType.easeInExpo;
    public float delay = 1f;
    public bool autoRun = false;
    // Start is called before the first frame update
    void Start()
    {
        if (geometry != null)
        {
            geometry.transform.localScale = Vector3.zero;
            if (autoRun)
            {
                ShowGeometry();
            }
        }
    }
    public void ShowGeometry()
    {
        if (geometry != null)
        {
            iTween.ScaleTo(geometry, iTween.Hash(
                "time", scaleTime,
                "scale", Vector3.one,
                "easetype", easeType,
                "delay", delay));
        }
    }
}
