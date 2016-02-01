using UnityEngine;
using System.Collections;
using DG.Tweening;
public class PanelTweenAnimation : MonoBehaviour {

    public DOTweenAnimation ta;

    private bool isIn = false;

	

    public void OnClick()
    {
        if (!isIn)
        {
            ta.DOPlayForward();
            isIn = true;
        }
        else
        {
            ta.DOPlayBackwards();
            isIn = false;
        }
    }
}
