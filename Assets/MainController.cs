using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
	public Animator anim;

	public void OnClick (string obj)
	{
		Debug.Log ("click: " + obj);
		anim.SetTrigger (obj);
	}
}
