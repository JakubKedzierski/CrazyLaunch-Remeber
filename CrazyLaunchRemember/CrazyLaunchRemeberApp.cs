using System;

namespace CrazyLaunchRemember
{
    class CrazyLaunchRememberApp
    {
        static void Main(string[] args)
        {
            Launch launch = new Launch();
            launch.location = "Cape Carnavel";
            Console.WriteLine(launch.location);


        }
    }
}
