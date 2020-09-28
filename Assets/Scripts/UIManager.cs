using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

   [SerializeField] Image fill;
   [SerializeField] Image fade;
   [SerializeField] TMP_Text start;
   [SerializeField] TMP_Text end;
    void Awake()
    {
       if(instance==null)
       {
           instance = this;
       } 
    }
    void Start()
    {
       fill.fillAmount = 0; 
       fadeatstart();
    }
    void fadeatstart()
    {
            fade.DOFade(0f,0.6f).From(1f);
    }

    public void UpdateLevelProgress()
    {
        float val = 1f - ((float)Level.instance.objectInScene/Level.instance.totalObjects);
        fill.DOFillAmount(val,0.3f);
    }

    

}
