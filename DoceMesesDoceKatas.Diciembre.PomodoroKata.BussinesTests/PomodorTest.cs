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
	}
}

