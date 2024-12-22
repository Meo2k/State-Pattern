using System;

public class PausedState : IState {
    public void Enter() {
        Console.WriteLine("Entering Paused State.");
    }

    public void Execute() {
        Console.WriteLine("Paused: Press 'R' to Resume.");
    }

    public void Exit() {
        Console.WriteLine("Exiting Paused State.");
    }
}
