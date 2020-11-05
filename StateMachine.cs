using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour {

	private float timeElapsed = 0f;

	public State remainState;
	public State currentState;

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		currentState.UpdateState(this);
	}

	public void TransitionToState(State nextState) {
		if (nextState != remainState) {
			currentState = nextState;
			OnExitState();
		}
	}

	public bool CheckCooldown(float cooldown) {
		timeElapsed += Time.deltaTime;
		return (timeElapsed >= cooldown);
	}

	private void OnExitState() {
		timeElapsed = 0;
	}
}
