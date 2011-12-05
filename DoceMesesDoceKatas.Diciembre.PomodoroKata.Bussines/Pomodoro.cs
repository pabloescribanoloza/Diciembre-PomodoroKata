using System;
using System.Collections.Generic;

namespace DoceMesesDoceKatas.Diciembre.PomodoroKata.Bussines
{
	public class Pomodoro
	{
		public Estado Estados;
		public Tiempo TiempoTotal;
		public Tiempo TiempoRestante;
		
		private List<Interrupcion> _interrupciones;
		
		public Pomodoro ()
		{
			this.Estados = new Estado();
			this.TiempoTotal = new Tiempo();
			this.TiempoTotal.Minutos = 25;
			this._interrupciones = new List<Interrupcion>();
		}
		
		public Pomodoro(Tiempo tiempoEnMinutos)
		{
			this.TiempoTotal = tiempoEnMinutos;
		}
		
		
		
		public void Arrancar()
		{
			Estados.comienzaCuentaAtras();
		}
		
		public void Interrumpir()
		{
			if(this.Estados.cuentaAtras)
			{
				this.Estados.estaInterrumpido=true;
			}
		}
		
		public List<Interrupcion> ObtenerInterrupciones()
		{
			return this._interrupciones;
		}
		
		public void Finalizar()
		{
			this.Estados.finalizar();
		}
	}
}

