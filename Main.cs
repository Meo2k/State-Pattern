using System;

class Program
{
    public static void Main(string[] args)
    {
        GameStateManager gameStateManager = new GameStateManager();

        // Tạo các trạng thái
        IState menuState = new MenuState();
        IState playingState = new PlayingState();
        IState pausedState = new PausedState();

        // Bắt đầu với trạng thái Menu
        gameStateManager.ChangeState(menuState);
        gameStateManager.Update();

        // Giả lập các hành động để chuyển đổi trạng thái
        Console.WriteLine("\nSimulating state transitions...\n");

        // Chuyển sang PlayingState
        gameStateManager.ChangeState(playingState);
        gameStateManager.Update();

        // Chuyển sang PausedState
        gameStateManager.ChangeState(pausedState);
        gameStateManager.Update();

        // Trở về MenuState
        gameStateManager.ChangeState(menuState);
        gameStateManager.Update();
    }
}
