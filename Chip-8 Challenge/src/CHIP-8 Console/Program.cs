﻿using CHIP_8_Virtual_Machine;

namespace CHIP_8_Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            VM vm = new VM();
            vm.Load("pong.rom");
            vm.Run();
        }
    }
}
