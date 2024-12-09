using System.Net.Mime;
using Services.Input;
using UnityEngine;

namespace Infrastructure
{
    public class Game
    {
        public static IInputService InputService;

        public Game()
        {
            if (Application.isEditor) 
                InputService = new StandaloneInputService();
        }
    }
}
