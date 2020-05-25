using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

public class Transportistas
{
	public int IdTransportista
	{
		get;
		set;
	}
	public string NomEmpresa
	{
		get;
		set;
	}
	public string Telefono
	{
		get;
		set;
	}

	public Transportistas(){ }

	public Transportistas(string NomEmpresa,string Telefono)
	{
		this.NomEmpresa = NomEmpresa;
		this.Telefono = Telefono;
	}

}
