using UnityEngine;
using System.Collections;
using DG.Tweening;//DoTween要引入这个命名空间
public class DoTweenTest : MonoBehaviour {

    public Vector3 myValue = new Vector3(568,0,0);

    public RectTransform task;

    public float myValue2 = 0;

    void Start()
    {
        DOTween.To(() => myValue, x => myValue = x, new Vector3(0,0,0),2);//用到了兰巴达表达式，对第一个值进行修改，把修改后的值再给myValue，前两个值不懂可以照抄，基本上不会变的，第三个是目标值，第四个值是2秒钟
        //         其实是两个委托，两个变量类型的方法
        //在2秒内移动的速度是抛物线的，先快后慢的

        DOTween.To(() => myValue2, x => myValue2 = x, 10, 2);
    }

    void Update()
    {
        //task.position = myValue;
        task.localPosition = myValue;
    }
    	
}

