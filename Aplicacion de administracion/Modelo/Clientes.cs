using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

public class Clientes
{
	public enum TipoTarjeta
	{
		Visa,
		MasterCard
	}
	public string Apellidos
	{
		get { return Apellidos; }
		set { Apellidos = value; }
	}
	public string Ciudad
	{
		get { return Ciudad; }
		set { Ciudad = value; }
	}
	public string CiudadFacturacion
	{
		get { return CiudadFacturacion; }
		set { CiudadFacturacion = value; }
	}
	public int CodPostal
	{
		get { return CodPostal; }
		set { CodPostal = value; }
	}
	public int CodPostalFacturacion
	{
		get { return CodPostalFacturacion; }
		set { CodPostalFacturacion = value; }
	}
	public string Contraseña
	{
		get { return Contraseña; }
		set { Contraseña = value; }
	}
	public string Direccion1
	{
		get { return Direccion1; }
		set { Direccion1 = value; }
	}
	public string Direccion2
	{
		get { return Direccion2; }
		set { Direccion2 = value; }
	}
	public string Email
	{
		get { return Email; }
		set { Email = value; }
	}
	public int IdCliente
	{
		get { return IdCliente; }
		set { IdCliente = value; }
	}
	public int MesCadTarjetaCredito
	{
		get { return MesCadTarjetaCredito; }
		set { MesCadTarjetaCredito = value; }
	}
	public string Nombre
	{
		get { return Nombre; }
		set { Nombre = value; }
	}
	public int NumTarjetaCredito
	{
		get { return NumTarjetaCredito; }
		set { NumTarjetaCredito = value; }
	}
	public string Pais
	{
		get { return Pais; }
		set { Pais = value; }
	}
	public string PaisFacturacion
	{
		get { return PaisFacturacion; }
		set { PaisFacturacion = value; }
	}
	public string Provincia
	{
		get { return Provincia; }
		set { Provincia = value; }
	}
	public string ProvinciaFacturacion
	{
		get { return ProvinciaFacturacion; }
		set { ProvinciaFacturacion = value; }
	}
	public string Telefono
	{
		get { return Telefono; }
		set { Telefono = value; }
	}
	public TipoTarjeta TipoTarjetaCredito
	{
		get { return TipoTarjetaCredito; }
		set { TipoTarjetaCredito = value; }
	}
	public string Usuario
	{
		get { return Usuario; }
		set { Usuario = value; }
	}
	public int YearCadTarjetaCredito
	{
		get { return YearCadTarjetaCredito; }
		set { YearCadTarjetaCredito = value; }
	}

	public Clientes(){ }

}
