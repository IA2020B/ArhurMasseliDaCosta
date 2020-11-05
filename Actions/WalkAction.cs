using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Actions/WalkAction")]
public class WalkAction : Action {
	public override void Act(StateMachine controller) {
		Walk(controller);
	}

	private void Walk(StateMachine controller) {
		controller.transform.Translate(0.05f, 0f, 0f);
	}
}
