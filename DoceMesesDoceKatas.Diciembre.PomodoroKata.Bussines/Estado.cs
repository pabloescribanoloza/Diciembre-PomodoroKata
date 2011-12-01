using System;

namespace DoceMesesDoceKatas.Diciembre.PomodoroKata.Bussines
{
	public class Estado
	{
		public Boolean estaParado;
		public Boolean cuentaAtras;
		
		public Estado ()
		{
			this.estaParado = true;
		}
		
		public void comienzaCuentaAtras()
		{
			this.estaParado = false;
			this.cuentaAtras = true;
		}
	}
}

