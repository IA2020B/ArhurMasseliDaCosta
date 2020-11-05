using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Actions/StopAction")]
public class StopAction : Action {
	public override void Act(StateMachine controller) {
		Stop(controller);
	}

	private void Stop(StateMachine controller) {
		controller.transform.Translate(0f, 0f, 0f);
	}
}
