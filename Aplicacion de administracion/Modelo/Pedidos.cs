using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

public class Pedidos
{

	public bool Entregado
	{
		get { return Entregado; }
		set { Entregado = value; }
	}
	public bool EstadoEntrega
	{
		get { return EstadoEntrega; }
		set { EstadoEntrega = value; }
	}
	public bool FechaPagado
	{
		get { return FechaPagado; }
		set { FechaPagado = value; }
	}
	public DateTime FechaPedido
	{
		get { return FechaPedido; }
		set { FechaPedido = value; }
	}
	public DateTime FechaSalida
	{
		get { return FechaSalida; }
		set { FechaSalida = value; }
	}
	public int IdCliente
	{
		get { return IdCliente; }
		set { IdCliente = value; }
	}
	public int IdPago
	{
		get { return IdPago; }
		set { IdPago = value; }
	}
	public int IdPedido
	{
		get { return IdPedido; }
		set { IdPedido = value; }
	}
	public int IdTransportista
	{
		get { return IdTransportista; }
		set { IdTransportista = value; }
	}
	public int NumPedido
	{
		get { return NumPedido; }
		set { NumPedido = value; }
	}
	public bool Pagado
	{
		get { return Pagado; }
		set { Pagado = value; }
	}

	public Pedidos(){ }

}
