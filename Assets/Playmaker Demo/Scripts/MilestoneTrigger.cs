using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Collider))]
public class MilestoneTrigger : MonoBehaviour {

	public PlayMakerFSM fsm;
	public string variableName;
	public string triggerTag;
	private bool wasUsed;

	private void OnTriggerEnter (Collider other)
	{
		if (!wasUsed && other.CompareTag (triggerTag))
		{
			wasUsed = true;
			fsm.FsmVariables.GetFsmInt (variableName).Value ++;
		}
	}
}
