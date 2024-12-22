using System;

public class PlayingState : IState {
    public void Enter() {
        Console.WriteLine("Entering Playing State.");
    }

    public void Execute() {
        Console.WriteLine("Playing: Press 'ESC' to Pause.");
    }

    public void Exit() {
        Console.WriteLine("Exiting Playing State.");
    }
}
