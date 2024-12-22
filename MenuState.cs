using System;

public class MenuState : IState {
    public void Enter() {
        Console.WriteLine("Entering Menu State.");
    }

    public void Execute() {
        Console.WriteLine("Menu: Press 'P' to Play.");
    }

    public void Exit() {
        Console.WriteLine("Exiting Menu State.");
    }
}
