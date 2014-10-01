using System;

namespace my_first_repo
{
	public class Player
	{
		private String name;
		private int lives;
		private int xpos;
		private int ypos;
		
		public Player ()
		{
			this.name = name;
			this.lives = lives;
			this.xpos = xpos;
			this.ypos = ypos;
		}
		
		public void setName(string newName)
		{
			this.name = newName;	
		}
		
		public String getName()
		{
			return this.name;
		}
		
		public void setLives(int lives)
		{
			this.lives = lives;
		}
		
		public int getLives()
		{
			return this.lives;
		}
		
		public void playerMove()
		{}
		
		public void calculateScore()
		{}
		
		public void checkCollision()
		{}
		
	}
}

