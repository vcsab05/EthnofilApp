using UnityEngine;
using System.Collections;

public class Fade : MonoBehaviour {

	public void FadeMe () {
		StartCoroutine (DoFade());
	}

	IEnumerator DoFade () {
		CanvasGroup canvasGrouop = GetComponent<CanvasGroup> ();
		while (canvasGrouop.alpha>0) {
			canvasGrouop.alpha -= Time.deltaTime*4 ;
			yield return null;
			
		}
		canvasGrouop.interactable = false;
		yield return null;
	}
}