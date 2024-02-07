using System;

public class ASCIIANI
{
	void startAni(Goomba g){
		int frame = 1;
		int speed = 1;

		while (frame < 10)
		{
			thread.sleep(50)
				g.drawSprite(frame)
				frame = frame + speed;
		}
		while(frame < 10);
		thread.sleep(50)
			g.draw(frame)
			frame=frame - speed;
		}

	}
}
