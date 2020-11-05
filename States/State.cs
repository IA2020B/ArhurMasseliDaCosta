using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/State")]
public class State : ScriptableObject {

	public Action[] actions;
	public Transition[] transitions;

	public void UpdateState(StateMachine controller) {
		DoActions(controller);
		CheckTransitions(controller);
	}

	private void DoActions(StateMachine controller) {
		for (int i = 0; i < actions.Length; i++) {
			actions[i].Act(controller);
		}
	}

	private void CheckTransitions(StateMachine controller) {
		for (int i = 0; i < transitions.Length; i++) {
			bool isDecide = transitions[i].decision.Decide(controller);

			if (isDecide) {
				controller.TransitionToState(transitions[i].trueState);
			} else {
				controller.TransitionToState(transitions[i].falseState);
			}
		}
	}
}
