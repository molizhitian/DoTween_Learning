using UnityEngine;
using System.Collections;
using DG.Tweening;

public class MyShakeCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //transform.DOShakePosition(1);//屏幕震动效果
        transform.DOShakePosition(1, new Vector3(3,3,0));//前后不震动，因为为0了
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
