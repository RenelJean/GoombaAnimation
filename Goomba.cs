using System;

public class Goomba
{
    private string[] goombaSprite;

    public void Goomba()
    {
        goombaSprite = new string[10];
        goombaSprite[0] = "     __________     ";
        goombaSprite[1] = "    /         \\    ";
        goombaSprite[2] = "   /  \\   /   \\   ";
        goombaSprite[3] = "  /    |    |   \\  ";
        goombaSprite[4] = " /   _^______^_  \\ ";
        goombaSprite[5] = "|__________________|";
        goombaSprite[6] = "      /     \\      ";
        goombaSprite[7] = " ____|       |_____";
        goombaSprite[8] = "/_____\\    /_____\\ ";
        goombaSprite[9] = "                       ";
    }

    public void DrawSprite(int offset)
    {
        for (int i = 0; i <= 9; i++)
        {
            Console.WriteLine(" ".PadLeft(offset) + goombaSprite[i]);
            Console.Clear();

        }
    }
}
