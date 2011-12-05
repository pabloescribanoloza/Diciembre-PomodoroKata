using System;
using NUnit.Framework;
using DoceMesesDoceKatas.Diciembre.PomodoroKata.Bussines;

namespace DoceMesesDoceKatas.Diciembre.PomodoroKata.BussinesTests
{
	[TestFixture()]
	public class PomodoroTest
	{
		/// <summary>
		/// Un pomodoro dura 25 minutos por defecto test.
		/// </summary>
		/// 
		[Test()]
		public void UnPomodoroDura25MinutosPorDefectoTest()
		{
			var pomodoro = new Pomodoro();
			
			Assert.AreEqual(25,pomodoro.TiempoTotal.Minutos);
		}
		
		/// <summary>
		/// Un pomodoro se puede crear de cualquier duracion.
		/// </summary>
		[Test()]
		public void UnPomodoroSePuedeCrearDeCualquierDuracion()
		{
			var pomodoro30Minutos = new Pomodoro(new Tiempo(30));
			var pomodoro10Minutos = new Pomodoro(new Tiempo(10));
			
			Assert.AreEqual(30,pomodoro30Minutos.TiempoTotal.Minutos);
			Assert.AreEqual(10,pomodoro10Minutos.TiempoTotal.Minutos);	
		}
		
		/// <summary>
		/// Un pomodoro recien creado esta parado.
		/// </summary>
		[Test()]
		public void UnPomodoroRecienCreadoEstaParado()
		{
			var pomodoro = new Pomodoro();
			
			Assert.IsTrue(pomodoro.Estados.estaParado);
		}
		
		/// <summary>
		/// Un pomodoro al arrancar comienza la cuenta atras.
		/// </summary>
		[Test()]
		public void UnPomodoroAlArrancarComienzaLaCuentaAtras()
		{
			var pomodoro = new Pomodoro();
			
			pomodoro.Arrancar();
			
			Assert.IsTrue(pomodoro.Estados.cuentaAtras);
		}
		
		/// <summary>
		/// Un pomodoro no termina si no ha sido arrancado previamente.
		/// </summary>
		[Test()]
		public void UnPomodoroNoTerminaSiNoHaSidoArrancadoPreviamente()
		{
			var pomodoro = new Pomodoro();
			
			pomodoro.Finalizar();
			
			Assert.IsTrue(!pomodoro.Estados.estaFinalizado);
		}
		/// <summary>
		/// Un pomodoro finaliza cuando se acaba su tiempo.
		/// </summary>
		[Test()]
		public void UnPomodoroFinalizaCuandoSeAcabaSuTiempo()
		{
			var pomodoro = new Pomodoro();
			
			pomodoro.Arrancar();
			pomodoro.Finalizar();
			
			Assert.AreEqual(0,pomodoro.TiempoRestante);
		}
		
		/// <summary>
		/// Un pomodoro se inicia sin interrupciones.
		/// </summary>
		[Test()]
		public void UnPomodoroSeIniciaSinInterrupciones ()
		{
			var pomodoro = new Pomodoro();
			
			
			Assert.AreEqual(0,pomodoro.ObtenerInterrupciones().Count);
		}
		
		[Test()]
		public void UnPomodoroSiNoEstaArrancadoNoSePuedeInterrumpir()
		{
			var pomodoro = new Pomodoro();
			
			pomodoro.Interrumpir();
			
			Assert.IsFalse(pomodoro.Estados.estaInterrumpido);
		}
	}
}

