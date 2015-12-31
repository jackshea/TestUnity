using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.UI;

public class TweenTest : MonoBehaviour
{
    // Use this for initialization
    Text text;
    void Start()
    {
        text = GetComponent<Text>();
        text.DOText("Hello,world.", 5f,true,ScrambleMode.All);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
