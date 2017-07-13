using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Collider))]
public class EventTrigger : MonoBehaviour 
{
	public PlayMakerFSM fsm;
	public string eventName;
	public string triggerTag;

	private void OnTriggerEnter (Collider other)
	{
		if (other.CompareTag (triggerTag))
			fsm.SendEvent (eventName);
	}
}
