using UnityEngine;
using System.Collections;
using DG.Tweening;

public class ShortWayDoMove : MonoBehaviour {

    public RectTransform panelTrans;

    private bool isIn = false;
    	

    void Start()
    {
        //是DoTween给UGUI做的扩展，所以就能直接用了
        //panelTrans.DOMove(new Vector3(0, 0, 0), 1);//这是修改世界坐标的
        Tweener tweener = panelTrans.DOLocalMove(new Vector3(0, 0, 0), 0.3f);//这是修改局部坐标的,默认动画播放完成，会被销毁
        //Tweener对象保存这个动画的信息，每次调用do类型的方法都会创建一个tweener对象，这个对象是DoTween来管理
        tweener.SetAutoKill(false);//把autoKill自动销毁设置为false
        tweener.Pause();//放在Start方法暂停住，如果放在下面OnClick()方法里会，创建多次，浪费我们的性能，放在这暂停住，可以很好的
    }


    public void OnClick()
    {

        if (!isIn)
        {

            //注意：这个调用方法，会把panelTrans上绑定的所有动画都播放的

            //panelTrans.DOPlay();//此方法只会播放一次动画，所以不好用
            panelTrans.DOPlayForward();//此方法跟下面的方法是成对出现的
            isIn = true;
        }
        else
        {
            panelTrans.DOPlayBackwards();//直接执行会执行不了，因为tweener被删了
            isIn = false;
        }

    }
}
