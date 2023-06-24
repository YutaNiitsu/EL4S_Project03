using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


namespace Util
{
    public static class Fade
    {
        public static void FadeoutObject(GameObject gameObject, float fadeoutSec = 2.0f)
        {
            if (gameObject.GetComponent<FadeOut>()) return;

            FadeOut fadeout = gameObject.AddComponent<FadeOut>();
            CanvasGroup cg = gameObject.AddComponent<CanvasGroup>();
            fadeout.obj = gameObject;
            fadeout.cg = cg;
            fadeout.FadeDuration = fadeoutSec;
            fadeout.Start();
        }
    }
}

public class FadeOut : MonoBehaviour
{
    public GameObject obj;
    public CanvasGroup cg;
    public float FadeDuration;

    float elapsedTime;//Œo‰ßŽžŠÔ
    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(fadeoutCoroutine());
    }

    IEnumerator fadeoutCoroutine()
    {
        EventSystem eventSystem = GameObject.FindObjectOfType<EventSystem>();
        eventSystem.enabled = false;
        cg.alpha = 1;
        while (elapsedTime <= FadeDuration)
        {
            elapsedTime += Time.deltaTime;
            cg.alpha = Mathf.Lerp(1, 0, elapsedTime / FadeDuration);
            yield return null;
        }
        Destroy(cg);
        Destroy(this);

        obj.SetActive(false);
        eventSystem.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
