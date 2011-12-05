using System;

namespace DoceMesesDoceKatas.Diciembre.PomodoroKata.Bussines
{
	public class Estado
	{
		public Boolean estaInterrumpido;
		public Boolean estaParado;
		public Boolean cuentaAtras;
		public Boolean estaFinalizado;
		
		public Estado ()
		{
			this.estaParado = true;
			this.estaInterrumpido = false;
			this.cuentaAtras = false;
			this.estaFinalizado = false;
		}
		
		public void comienzaCuentaAtras()
		{
			this.estaParado = false;
			this.cuentaAtras = true;
		}
		
		public void finalizar()
		{
			if(this.cuentaAtras && !this.estaFinalizado)
			{
				this.estaFinalizado = true;
			}
		}
	}
}

