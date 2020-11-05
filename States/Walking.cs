using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Decisions/Walking")]
public class Walking : Decision {

	private bool setInitialPos = true;

	private Vector3 posO = new Vector3(0, 0, 0);
	private Vector3 posF = new Vector3(0, 0, 0);

	public override bool Decide(StateMachine controller) {
		return Walk(controller);
	}

	private bool Walk(StateMachine controller) {
		return controller.CheckCooldown(2f);
	}
}
