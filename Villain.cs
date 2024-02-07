using System;

public interface Villain
{
	public Villain()
	{

	}
	public void move()
	{
        while (true)
        {
            int offset = 0;
            int speed = 1;
            g.DrawSprite(offset);

            // Adjust the sleep duration based on the speed
            System.Threading.Thread.Sleep(100 / speed);

            // Update offset for movement
            offset += speed;

            // Check if the Goomba has reached the right edge
            if (offset >= Console.WindowWidth - 20)
            {
                speed = -1; // Reverse direction
            }
            // Check if the Goomba has reached the left edge
            else if (offset <= 0)
            {
                speed = 1; // Reverse direction
            }
        }
    }
}
