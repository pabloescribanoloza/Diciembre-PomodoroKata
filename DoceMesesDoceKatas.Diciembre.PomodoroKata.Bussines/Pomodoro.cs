using System;

namespace DoceMesesDoceKatas.Diciembre.PomodoroKata.Bussines
{
	public class Pomodoro
	{
		public Estado Estados;
		public Tiempo TiempoTotal;
		
		public Pomodoro ()
		{
			this.Estados = new Estado();
			this.TiempoTotal = new Tiempo();
			this.TiempoTotal.Minutos = 25;
		}
		
		public Pomodoro(Tiempo tiempoEnMinutos)
		{
			this.TiempoTotal = tiempoEnMinutos;
		}
		
		public void Arrancar()
		{
			Estados.comienzaCuentaAtras();
		}
	}
}

