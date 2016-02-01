using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class TextTween : MonoBehaviour {

    public Text text;


	// Use this for initialization
	void Start () {
        text.DOText("我是你大爷，这句话要很长的，哈哈哈。",2);//如果text里本来有文本，他会替换掉的，很方便的。
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
