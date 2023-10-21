using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeElapsed = 0f;
    public TMP_Text timerText;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        int minutes = Mathf.FloorToInt(timeElapsed / 60f);
        int seconds = Mathf.FloorToInt(timeElapsed % 60f);
        int milliseconds = Mathf.FloorToInt((timeElapsed * 1000f) % 1000f);
        timerText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }

    //private int sec = 0;
    //private float min = 0;
    //private TMP_Text _TimerText;
    //[SerializeField] private int delta = 1;

    //// Start is called before the first frame update
    //void Awake()
    //{
    //    _TimerText = GameObject.Find("TimerText").GetComponent<TMP_Text>();
    //    StartCoroutine(ITimer());
    //}
    //IEnumerator ITimer()
    //{
    //    Debug.Log("Huy");
    //    while (true)
    //    {
    //        if (sec == 59)
    //        {
    //            min++;
    //            sec = -1;
    //        }
    //        sec += delta;
    //        _TimerText.text = min.ToString("D2") + " : " + sec.ToString("D2");
    //        yield return new WaitForSeconds(1);
    //    }
    //}
}
