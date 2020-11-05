using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Decisions/Idle")]
public class Idle : Decision {
	public override bool Decide(StateMachine controller) {
		return controller.CheckCooldown(2f);
	}
}
