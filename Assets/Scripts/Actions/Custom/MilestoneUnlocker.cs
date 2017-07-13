using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("Custom")]
	public class MilestoneUnlocker : FsmStateAction
	{
		public FsmInt required;
		public FsmInt current;
		public FsmEvent onComplete;
		public bool clearOnExit;

		// Code that runs on entering the state.
		public override void OnEnter()
		{
			TryComplete ();
		}

		// Code that runs every frame.
		public override void OnUpdate()
		{
			TryComplete ();
		}

		private void TryComplete ()
		{
			if (current.Value >= required.Value)
				Fsm.Event (onComplete);
		}

		public override void OnExit ()
		{
			if (clearOnExit)
				current.Value = 0;
		}
	}

}
