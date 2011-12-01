using System;

namespace DoceMesesDoceKatas.Diciembre.PomodoroKata.Bussines
{
	public class Pomodoro
	{
		public Tiempo TiempoTotal;
		
		public Pomodoro ()
		{
			this.TiempoTotal = new Tiempo();
			this.TiempoTotal.Minutos = 25;
		}
	}
}

