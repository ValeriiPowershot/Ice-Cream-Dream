using Services.Input;
using UnityEngine;

namespace Infrastructure
{
    public class Game
    {
        public static IInputService InputService;

        public Game() =>
            RegisterInput();

        private static void RegisterInput()
        {
            if (Application.isEditor) 
                InputService = new StandaloneInputService();
        }
    }
}
