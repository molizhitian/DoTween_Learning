using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class TextColorTween : MonoBehaviour {

    public Text text;


	// Use this for initialization
	void Start () {
        //text.DOColor(Color.red,3);//改变颜色
        text.DOFade(1, 3);//从无到有
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
