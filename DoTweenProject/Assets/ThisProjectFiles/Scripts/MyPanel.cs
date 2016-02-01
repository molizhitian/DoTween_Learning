using UnityEngine;
using System.Collections;
using DG.Tweening;
public class MyPanel : MonoBehaviour {

    
    void Start()
    {
        Tweener tweener = transform.DOLocalMoveX(0, 2);
        tweener.SetEase(Ease.OutBounce);//动画曲线
        tweener.SetLoops(2);//动画循环次数，-1为无限次

        tweener.OnComplete(OnTweenComplete);//动画结束时间

        //动画的事件，有个OnStart()，这个应该只会执行一次
    }

    private void OnTweenComplete()
    {
        Debug.Log("我是你大爷");
    }
}
