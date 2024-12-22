public class GameStateManager {
    private IState currentState;

    public void ChangeState(IState newState) {
        currentState?.Exit();
        currentState = newState;
        currentState.Enter();
    }

    public void Update() {
        currentState?.Execute();
    }
}
