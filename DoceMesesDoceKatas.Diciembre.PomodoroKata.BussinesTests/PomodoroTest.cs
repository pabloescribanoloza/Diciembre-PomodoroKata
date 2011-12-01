using System;
using NUnit.Framework;
using DoceMesesDoceKatas.Diciembre.PomodoroKata.Bussines;

namespace DoceMesesDoceKatas.Diciembre.PomodoroKata.BussinesTests
{
	[TestFixture()]
	public class PomodoroTest
	{
		[Test()]
		public void UnPomodoroDura25MinutosPorDefectoTest()
		{
			var pomodoro = new Pomodoro();
			
			Assert.AreEqual(25,pomodoro.TiempoTotal.Minutos);
		}
		
		[Test()]
		public void UnPomodoroSePuedeCrearDeCualquierDuracion()
		{
			var pomodoro30Minutos = new Pomodoro(new Tiempo(30));
			var pomodoro10Minutos = new Pomodoro(new Tiempo(10));
			
			Assert.AreEqual(30,pomodoro30Minutos.TiempoTotal.Minutos);
			Assert.AreEqual(10,pomodoro10Minutos.TiempoTotal.Minutos);	
		}
		
		[Test()]
		public void UnPomodoroRecienCreadoEstaParado()
		{
			var pomodoro = new Pomodoro();
			
			Assert.IsTrue(pomodoro.Estados.estaParado);
		}
		
		[Test()]
		public void UnPomodoroAlArrancarComienzaLaCuentaAtras()
		{
			var pomodoro = new Pomodoro();
			
			pomodoro.Arrancar();
			
			Assert.IsTrue(pomodoro.Estados.cuentaAtras);
		}
		
		[Test()]
		public void UnPomodoroNoTerminaSiNoHaSidoArrancadoPreviamente()
		{
			var pomodoro = new Pomodoro();
			
			pomodoro.Finalizar();
			
			Assert.IsTrue(!pomodoro.Estados.estaFinalizado);
		}
	}
}

