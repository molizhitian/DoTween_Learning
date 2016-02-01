using UnityEngine;
using System.Collections;
using DG.Tweening;

public class MyCube : MonoBehaviour {

	void Start () {
        //transform.DOMoveX(6, 3).From();//加上.From()是从目标点5移动回自己的点。
        transform.DOMoveX(5, 3).From(true);//.From()里加上true,是自己的点加上5移动回自己的点。
        //注意区别
        //这是FromTween
    }
	
}
